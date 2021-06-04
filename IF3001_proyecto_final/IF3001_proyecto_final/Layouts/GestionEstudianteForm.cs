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
    }
}
