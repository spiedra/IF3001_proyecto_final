using System;
using System.Windows.Forms;
using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;


namespace IF3001_proyecto_final.Layouts
{
    public partial class GestionEstudianteForm : Form
    {
        public GestionEstudianteForm()
        {
            InitializeComponent();
        }

        private void GestionEstudianteForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
            new ListenerBusiness().ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "AgregarEstudiante", this.CreateEstudiante());
        }

        private Estudiante[] CreateEstudiante()
        {
            Estudiante[] estudiante = new Estudiante[1] {
                new Estudiante(-1, this.txt_nombre.Text, this.txt_apellidos.Text, Convert.ToInt32(this.txt_edad.Text),
                this.txt_promedio.Text, this.txt_carne.Text, this.txb_direccion.Text, null, null)
            };
            return estudiante;
        }
    }
}
