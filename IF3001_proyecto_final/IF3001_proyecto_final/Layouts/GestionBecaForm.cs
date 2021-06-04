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
    public partial class GestionBecaForm : Form
    {
        public GestionBecaForm()
        {
            InitializeComponent();
        }

        private void grid_beca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.grid_beca.Columns["btn_modificar"].Index && e.RowIndex>=0)
            {
                ModificarBecaForm mb = new ModificarBecaForm();
                mb.Show();
            }
            
        }
    }
}
