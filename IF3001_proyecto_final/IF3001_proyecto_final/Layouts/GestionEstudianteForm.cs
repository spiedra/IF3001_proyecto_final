using System;
using System.Windows.Forms;
using System.Collections.Generic;
using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Layouts
{
    public partial class GestionEstudianteForm : Form
    {
        private ListenerBusiness listenerBusiness;
        public GestionEstudianteForm()
        {
            InitializeComponent();
        }

        private void GestionEstudianteForm_Load(object sender, EventArgs e)
        {
            this.listenerBusiness = new ListenerBusiness();
            this.FillCbxSedes(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasSedes", null));
            this.FillCbxBeca(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasBecas", null));
            this.FillGridListEstudiantes(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodosLosEstudiantes", null));
        }

        private void btn_ver_cursos_Click(object sender, EventArgs e)
        {
            VerCursosEstudianteForm vce = new VerCursosEstudianteForm(Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[0].Value)
                , (string)this.dgrid_estudiantes.Rows[0].Cells[4].Value);
            vce.Show();
        }

        private void btn_ver_carrera_Click(object sender, EventArgs e)
        {
            VerCarreraForm vc = new VerCarreraForm(this.tbx_buscar_carnet.Text, Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[0].Value));
            vc.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int EstudianteId = Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[0].Value);
            string nombre= Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[1].Value);
            string apellidos = Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[2].Value);
            int edad = Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[3].Value);
            string carne = Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[4].Value);
            string promedio = Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[5].Value);
            int beca = Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[6].Value);
            string sede = Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[7].Value);
            string direccion = Convert.ToString(this.dgrid_estudiantes.Rows[0].Cells[8].Value);

            Estudiante estudiante = new Estudiante(EstudianteId, nombre, apellidos,  edad,  carne, promedio, beca,  sede,  direccion);
            ModificarEstudianteForm me = new ModificarEstudianteForm(estudiante);
            me.Show();
        }

        private void btn_contacto_Click(object sender, EventArgs e)
        {
            VerContactoForm vc = new VerContactoForm(Convert.ToInt32(this.dgrid_estudiantes.Rows[0].Cells[0].Value),this.tbx_buscar_carnet.Text);
            vc.Show();
        }

        private void btn_agregar_estudiante_Click(object sender, EventArgs e)
        {
            if (this.txt_nombre.Text != string.Empty && this.txt_apellidos.Text != string.Empty
                && this.txt_edad.Text != string.Empty && this.txt_promedio.Text != string.Empty
                && this.txt_carne.Text != string.Empty && this.txb_direccion.Text != string.Empty
                && this.cbx_sedes.SelectedIndex != -1 && this.cbx_tipos_beca.SelectedIndex != -1)
            {
                if ((bool)this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "AgregarEstudiante", this.CreateEstudiante()))
                {
                    MessageBox.Show("!Estudiante ingresado correctamente!");
                }
                else
                {
                    MessageBox.Show("!El carnet ya ha sido ingresado!");
                }
            }
            else
            {
                MessageBox.Show("Rellenar los espacios en blanco");
            }
        }

        private Estudiante[] CreateEstudiante()
        {
            Estudiante[] estudiante = new Estudiante[1] {
                new Estudiante(-1, this.txt_nombre.Text, this.txt_apellidos.Text, Convert.ToInt32(this.txt_edad.Text)
              , this.txt_carne.Text,  this.txt_promedio.Text, Convert.ToInt32(this.cbx_tipos_beca.SelectedItem.ToString()), (string)this.cbx_sedes.SelectedItem,this.txb_direccion.Text)
            };
            return estudiante;
        }

        private void FillCbxSedes(object methodReturn)
        {
            List<Sede> sedes = (List<Sede>)methodReturn;
            foreach (Sede sede in sedes)
            {
                this.cbx_sedes.Items.Add(sede.Nombre);
            }
        }

        private void FillCbxBeca(object methodReturn)
        {
            List<Beca> becas = (List<Beca>)methodReturn;
            foreach (Beca beca in becas)
            {
                this.cbx_tipos_beca.Items.Add(beca.TipoBeca);
            }
        }

        private void FillGridListEstudiantes(object methodReturn)
        {
            List<Estudiante> estudiantes = (List<Estudiante>)methodReturn;
            for (int f = 0; f < estudiantes.Count; f++)
            {
                this.dgrid_estudiantes.Rows.Add();
                this.dgrid_estudiantes.Rows[f].Cells[0].Value = estudiantes[f].Id;
                this.dgrid_estudiantes.Rows[f].Cells[1].Value = estudiantes[f].Nombre;
                this.dgrid_estudiantes.Rows[f].Cells[2].Value = estudiantes[f].Apellidos;
                this.dgrid_estudiantes.Rows[f].Cells[3].Value = estudiantes[f].Edad;
                this.dgrid_estudiantes.Rows[f].Cells[4].Value = estudiantes[f].Carnet;
                this.dgrid_estudiantes.Rows[f].Cells[5].Value = estudiantes[f].Promedio;
                this.dgrid_estudiantes.Rows[f].Cells[6].Value = estudiantes[f].TipoBeca;
                this.dgrid_estudiantes.Rows[f].Cells[7].Value = estudiantes[f].Sede;
                this.dgrid_estudiantes.Rows[f].Cells[8].Value = estudiantes[f].Direccion;
            }
        }

        private void FillGridEstudiante(object methodReturn)
        {
            this.dgrid_estudiantes.Rows.Clear();
            Estudiante estudiante = (Estudiante)methodReturn;
            int f = this.dgrid_estudiantes.Rows.Add();
            this.dgrid_estudiantes.Rows[f].Cells[0].Value = estudiante.Id;
            this.dgrid_estudiantes.Rows[f].Cells[1].Value = estudiante.Nombre;
            this.dgrid_estudiantes.Rows[f].Cells[2].Value = estudiante.Apellidos;
            this.dgrid_estudiantes.Rows[f].Cells[3].Value = estudiante.Edad;
            this.dgrid_estudiantes.Rows[f].Cells[4].Value = estudiante.Carnet;
            this.dgrid_estudiantes.Rows[f].Cells[5].Value = estudiante.Promedio;
            this.dgrid_estudiantes.Rows[f].Cells[6].Value = estudiante.TipoBeca;
            this.dgrid_estudiantes.Rows[f].Cells[7].Value = estudiante.Sede;
            this.dgrid_estudiantes.Rows[f].Cells[8].Value = estudiante.Direccion;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.dgrid_estudiantes.Rows.Clear();
            this.FillGridListEstudiantes(this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodosLosEstudiantes", null));
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.FillGridEstudiante(this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerEstudiantePorCarnet"
                , new string[1]{
                    this.tbx_buscar_carnet.Text
            }));
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "EliminarEstudiante"
                , new string[1]{
                    this.tbx_buscar_carnet.Text
            })) == true)
            {
                MessageBox.Show("Estudiante eliminado");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar");
            }
        }

        private void gp_registro_estudiantes_Enter(object sender, EventArgs e)
        {

        }

        private void GestionEstudianteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Utility.Utility.IsConnect = false;
        }

        private void cbx_sedes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
