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
    public partial class VerCarreraForm : Form
    {
        private ListenerBusiness ListenerBusiness;
        private int estudianteId;
        private string carneEstudiante;
        public VerCarreraForm(string carne,int estudianteId)
        {
            InitializeComponent();
            this.estudianteId = estudianteId;
            this.carneEstudiante = carne;
            this.ListenerBusiness = new ListenerBusiness();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount>=3)
            {
                MessageBox.Show("Ha alcanzado el máximo de carreras");
            }
            else
            {
                if (this.cb_carrera.SelectedIndex != -1)
                {
                    this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "InsertarCarreraEstudiante",
               new object[] { this.estudianteId, this.cb_carrera.SelectedItem.ToString() });

                    this.VerCarrerasEstudiante();
                }
            }
        }

        private void VerCarreraForm_Load(object sender, EventArgs e)
        {
            VerCarrerasEstudiante();
            this.FillCbxCarreras(this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasCarreras", null));
        }
        private void FillGridListCarrera(object methodReturn)
        {
            List<Carrera> carreras = (List<Carrera>)methodReturn;
            for (int f = 0; f < carreras.Count; f++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[f].Cells[0].Value = carreras[f].Nombre;
            }
        }
        private void FillCbxCarreras(object methodReturn)
        {
            List<Carrera> carreras = (List<Carrera>)methodReturn;
            foreach (Carrera carreraData in carreras)
            {
                this.cb_carrera.Items.Add(carreraData.Nombre);
            }
        }

        private void VerCarrerasEstudiante()
        {
            this.dataGridView1.Rows.Clear();
            this.FillGridListCarrera(this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerCarrerasEstudiante", new object[1]{
                   this.estudianteId
            }));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string carrera = Convert.ToString(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == this.dataGridView1.Columns["btn_accion"].Index && e.RowIndex >= 0)
            {
                this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "EliminarCarreraEstudiante", new object[2]{
                  carrera,  this.carneEstudiante
            });
            }
            VerCarrerasEstudiante();
        }
    }
}
