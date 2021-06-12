using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IF3001_proyecto_final.Utility;



using IF3001_proyecto_final.Cluster;
using IF3001_proyecto_final.Business;
using IF3001_proyecto_final.Domain;
using System.Threading;

namespace IF3001_proyecto_final.Layouts
{
    public partial class MainForm : Form
    {
        private ListenerCluster listenerCluster;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void gestionEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //ListenerCluster listenerCluster = ListenerCluster.GetListenerCluster();
            //ConexionSqlServerCluster conexionSqlServerCluster = new ConexionSqlServerCluster();

            //listenerCluster.initThread();
            //MessageBox.Show("bool: " + listenerCluster.NodeIsRunnig + "Conexion sqlsever: " + conexionSqlServerCluster.SqlConnection);
            MessageBox.Show("Cargando... Por favor, espere...");
          //  while (this.listenerCluster.NodeIsRunnig != 0 && !Utility.Utility.IsConnect)
            //{
              //  Utility.Utility.IsConnect = true;
                GestionEstudianteForm gestionEstudianteForm = new GestionEstudianteForm();
                gestionEstudianteForm.Show();
            //}


            //ListenerCluster listenerCluster = ListenerCluster.GetListenerCluster();
            //ConexionSqlServerCluster conexionSqlServerCluster = new ConexionSqlServerCluster();

            //listenerCluster.initThread();


            // ListenerBusiness ListenerBusiness = new ListenerBusiness();
            // MessageBox.Show(""+ ListenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodasLasBecas", null));
        }


        private void gestionCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionCursotoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gestionSedetoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void gestionBecaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
