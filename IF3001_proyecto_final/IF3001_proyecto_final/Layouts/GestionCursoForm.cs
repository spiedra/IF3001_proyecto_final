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
    public partial class GestionCursoForm : Form
    {
        public GestionCursoForm()
        {
            InitializeComponent();
        }

        private void grid_beca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_curso.Columns["btn_modificar"].Index && e.RowIndex >= 0)
            {
                //MessageBox.Show("Button on row {0} clicked" + e.RowIndex);
                ModificarCursoForm modificarCursoForm = new ModificarCursoForm();
                modificarCursoForm.Show();
            }
        }
    }
}
