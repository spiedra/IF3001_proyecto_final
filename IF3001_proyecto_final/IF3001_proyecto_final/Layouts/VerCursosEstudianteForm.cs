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
    public partial class VerCursosEstudianteForm : Form
    {
        public VerCursosEstudianteForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==this.dgv_cursos.Columns["btn_quitar"].Index && e.RowIndex >= 0){
                MessageBox.Show("si es");
            }
            else
            {
                MessageBox.Show("no es");
            }
        }

        private void VerCursosEstudianteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
