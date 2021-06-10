using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Layouts
{
    public partial class VerContactoForm : Form
    {
        private ListenerBusiness ListenerBusiness;
        private string carneEstudiante;
        private int estudianteId;
        public VerContactoForm(int estudianteId, string carne)
        {
            InitializeComponent();
            this.carneEstudiante = carne;
            this.estudianteId = estudianteId;
            this.ListenerBusiness = new ListenerBusiness();
        }

        private void VerContactoForm_Load(object sender, EventArgs e)
        {
            verContactosEstudiante();
        }

        private void verContactosEstudiante()
        {
            this.dgv_Ver_Contacto.Rows.Clear();

            this.FillGridListContactos(this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTelefonosEstudiante", new object[1]{
                   this.estudianteId
            })); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string telefono = Convert.ToString(this.dgv_Ver_Contacto.Rows[e.RowIndex].Cells[0].Value);
            this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "EliminarTelefonoEstudiante", new object[2]{
                  this.estudianteId,  telefono
            });

            verContactosEstudiante();

        }
        private void FillGridListContactos(object methodReturn)
        {
            List<Telefono> telefonos = (List<Telefono>)methodReturn;
            for (int f = 0; f < telefonos.Count; f++)
            {
                this.dgv_Ver_Contacto.Rows.Add();
                this.dgv_Ver_Contacto.Rows[f].Cells[0].Value = telefonos[f].Numero;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            this.ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "InsertarTelefonoEstudiante",
                new object[] { this.estudianteId, this.txb_numero.Text });

            this.verContactosEstudiante();
        }


    }
}
