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
using IF3001_proyecto_final.Domain;

namespace IF3001_proyecto_final.Layouts
{
    public partial class VerCursosEstudianteForm : Form
    {
        private ListenerBusiness listenerBusiness;
        private int estudianteId;
        private string estudianteCarnet;

        public VerCursosEstudianteForm(int estudianteId, string estudianteCarnet)
        {
            InitializeComponent();
            this.estudianteId = estudianteId;
            this.estudianteCarnet = estudianteCarnet;
        }

        private void VerCursosEstudianteForm_Load(object sender, EventArgs e)
        {
            this.listenerBusiness = new ListenerBusiness();
            this.RefreshGridCursos();
            this.FillCbxCursos(this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerTodosLosCursos", null));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==this.dgv_cursos.Columns["btn_quitar"].Index && e.RowIndex >= 0){
                this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "EliminarCursoEstudiante", new object[] {
                    this.estudianteCarnet, this.dgv_cursos.Rows[e.RowIndex].Cells[1].Value
                });
            }
            this.RefreshGridCursos();
        }

        private void FillGridListCursos(object methodReturn)
        {
            List<Curso> cursos = (List<Curso>)methodReturn;
            for (int f = 0; f < cursos.Count; f++)
            {
                this.dgv_cursos.Rows.Add();
                this.dgv_cursos.Rows[f].Cells[0].Value = cursos[f].Id;
                this.dgv_cursos.Rows[f].Cells[1].Value = cursos[f].Nombre;
                this.dgv_cursos.Rows[f].Cells[2].Value = cursos[f].Creditos;
            }
        }

        private void FillCbxCursos(object methodReturn)
        {
            List<Curso> cursos = (List<Curso>)methodReturn;
            foreach (Curso cursoData in cursos)
            {
                this.cb_cursos.Items.Add(cursoData.Nombre);
            }
        }

        private void RefreshGridCursos()
        {
            this.dgv_cursos.Rows.Clear();
            this.FillGridListCursos(this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "ObtenerCursosEstudiante", new object[1] { this.estudianteId }));
        }

        private void btn_agregar_curso_Click_1(object sender, EventArgs e)
        {
            this.listenerBusiness.ConnectToListener("IF3001_proyecto_final.Business.Estudiante", "InsertarCursoEstudiante", new object[] {
                    this.estudianteId, this.cb_cursos.SelectedItem
                });
            this.RefreshGridCursos();
        }
    }
}
