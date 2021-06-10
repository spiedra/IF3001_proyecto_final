using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF3001_proyecto_final.Layouts
{
    public partial class ModificarEstudianteForm : Form
    {

        private ListenerBusiness listenerBusiness;
        private Estudiante estudiante;
        public ModificarEstudianteForm(object o)
        {
            InitializeComponent();
            this.estudiante = (Estudiante)o;
            this.listenerBusiness = new ListenerBusiness();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ModificarEstudianteForm_Load(object sender, EventArgs e)
        {

            CargarDatosViejosEstudiante();
            this.FillCbxSedes(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasSedes", null));
            this.FillCbxBeca(listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasBecas", null));
        }


        private void CargarDatosViejosEstudiante()
        {
            this.txt_nombre.Text = this.estudiante.Nombre;
            this.txt_apellidos.Text = this.estudiante.Apellidos;
            this.txt_edad.Text = Convert.ToString(this.estudiante.Edad);
            this.txt_carne.Text = this.estudiante.Carnet;
            this.txt_promedio.Text = this.estudiante.Promedio;
            this.cb_sede.Text = this.estudiante.Sede;
            this.txb_direccion.Text = this.estudiante.Direccion;
            this.cb_beca.Text = this.estudiante.TipoBeca;
        }

        private void FillCbxSedes(object methodReturn)
        {
            List<Sede> sedes = (List<Sede>)methodReturn;
            foreach (Sede sede in sedes)
            {
                this.cb_sede.Items.Add(sede.Nombre);
            }
        }

        private void FillCbxBeca(object methodReturn)
        {
            List<Beca> becas = (List<Beca>)methodReturn;
            foreach (Beca beca in becas)
            {
                this.cb_beca.Items.Add(beca.TipoBeca);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (this.txt_nombre.Text != string.Empty && this.txt_apellidos.Text != string.Empty
               && this.txt_edad.Text != string.Empty && this.txt_promedio.Text != string.Empty
               && this.txt_carne.Text != string.Empty && this.txb_direccion.Text != string.Empty
               && this.cb_sede.SelectedIndex != -1 && this.cb_beca.SelectedIndex != -1)
            {
                if ((bool)this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ActualizarEstudiante", this.CreateEstudiante()))
                {
                    MessageBox.Show("!Estudiante actualizado correctamente!");
                }
                else
                {
                    MessageBox.Show("No se ha podido actualizar");
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
                new Estudiante(this.estudiante.Id, this.txt_nombre.Text, this.txt_apellidos.Text, Convert.ToInt32(this.txt_edad.Text),
                this.txt_promedio.Text, this.txt_carne.Text, this.txb_direccion.Text, (string)this.cb_sede.SelectedItem, (string)this.cb_beca.SelectedItem)
            };
            return estudiante;
        }

    }
}
