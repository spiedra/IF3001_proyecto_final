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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void gestionEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEstudianteForm gestionEstudianteForm = new GestionEstudianteForm();
            gestionEstudianteForm.Show();
        }

        private void gestionCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCarreraForm gestionCarreraForm = new GestionCarreraForm();
            gestionCarreraForm.Show();
        }
    }
}
