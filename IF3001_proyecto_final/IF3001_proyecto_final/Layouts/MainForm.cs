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

        private async void gestionEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cargando... Por favor, espere...");
            GestionEstudianteForm gestionEstudianteForm = new GestionEstudianteForm();
            gestionEstudianteForm.Show();
        }
    }
}
