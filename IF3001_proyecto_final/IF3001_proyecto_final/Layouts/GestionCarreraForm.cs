using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IF3001_proyecto_final.Layouts;

namespace IF3001_proyecto_final.Layouts
{
    public partial class GestionCarreraForm : Form
    {
        public GestionCarreraForm()
        {
            InitializeComponent();
        }

        private void grid_carrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_carrera.Columns["btn_modificar"].Index && e.RowIndex >= 0)
            {
                //MessageBox.Show("Button on row {0} clicked" + e.RowIndex);
                ModificarCarreraForm modificarCarreraForm = new ModificarCarreraForm();
                modificarCarreraForm.Show();
            }
        }
    }
}
