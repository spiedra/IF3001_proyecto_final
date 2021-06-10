using System;
using System.Windows.Forms;
using System.Collections.Generic;
using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace IF3001_proyecto_final.Layouts
{
    public partial class GestionEstudianteForm : Form
    {
        private ListenerBusiness listenerBusiness;
        public GestionEstudianteForm()
        {
            InitializeComponent();
        }

        private async void GestionEstudianteForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cargando... Por favor, espere...");
            this.listenerBusiness = new ListenerBusiness();
            this.FillCbxSedes(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasSedes", null));
            this.FillCbxBeca(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasBecas", null));
            this.FillGridListEstudiantes(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodosLosEstudiantes", null));     
        }

        private void btn_ver_cursos_Click(object sender, EventArgs e)
        {
            VerCursosEstudianteForm vce = new VerCursosEstudianteForm();
            vce.Show();
        }

        private void btn_ver_carrera_Click(object sender, EventArgs e)
        {
            VerCarreraForm vc = new VerCarreraForm();
            vc.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarEstudianteForm me = new ModificarEstudianteForm();
            me.Show();
        }

        private void btn_contacto_Click(object sender, EventArgs e)
        {
            VerContactoForm vc = new VerContactoForm();
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
                new Estudiante(-1, this.txt_nombre.Text, this.txt_apellidos.Text, Convert.ToInt32(this.txt_edad.Text),
                this.txt_promedio.Text, this.txt_carne.Text, this.txb_direccion.Text, (string)this.cbx_sedes.SelectedItem, (string)this.cbx_tipos_beca.SelectedItem)
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
    }
}
