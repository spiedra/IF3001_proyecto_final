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

namespace IF3001_proyecto_final.Layouts
{
    public partial class VerContactoForm : Form
    {
        private ListenerBusiness ListenerBusiness;

        public VerContactoForm()
        {
            InitializeComponent();
            this.ListenerBusiness = new ListenerBusiness();
        }

        private void VerContactoForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
