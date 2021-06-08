using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IF3001_proyecto_final.Cluster;

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
            // GestionEstudianteForm gestionEstudianteForm = new GestionEstudianteForm();
            //gestionEstudianteForm.Show();
            ConexionSqlServerCluster conexionSqlServer = new ConexionSqlServerCluster();

            MessageBox.Show("hoal" + conexionSqlServer.ConnectToDatabase());

            //ConexionMySqlCluster conexionMySqlCluster = new ConexionMySqlCluster();
            //MessageBox.Show("" + conexionMySqlCluster.ConnectToDatabase());
           // ListenerCluster listenerCluster = new ListenerCluster();
           // MessageBox.Show("" + listenerCluster.ConnectToDatabaseInstance());
        }

        private void gestionCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCarreraForm gestionCarreraForm = new GestionCarreraForm();
            gestionCarreraForm.Show();
        }

        private void gestionCursotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionCursoForm gestionCursoForm = new GestionCursoForm();
            gestionCursoForm.Show();
        }

        private void gestionSedetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionSedeForm gestionSedeForm = new GestionSedeForm();
            gestionSedeForm.Show();
        }

        private void gestionBecaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionBecaForm gestionBecaForm = new GestionBecaForm();
            gestionBecaForm.Show();
        }
    }
}
