
namespace IF3001_proyecto_final.Layouts
{
    partial class VerCursosEstudianteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_cursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cb_cursos = new System.Windows.Forms.ComboBox();
            this.lbl_seleccionar_curso = new System.Windows.Forms.Label();
            this.btn_agregar_curso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_cursos);
            this.groupBox1.Location = new System.Drawing.Point(167, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver cursos de estudiante";
            // 
            // dgv_cursos
            // 
            this.dgv_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Siglas,
            this.btn_quitar});
            this.dgv_cursos.Location = new System.Drawing.Point(50, 45);
            this.dgv_cursos.Name = "dgv_cursos";
            this.dgv_cursos.RowHeadersWidth = 51;
            this.dgv_cursos.RowTemplate.Height = 29;
            this.dgv_cursos.Size = new System.Drawing.Size(388, 149);
            this.dgv_cursos.TabIndex = 0;
            this.dgv_cursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Siglas
            // 
            this.Siglas.HeaderText = "Créditos";
            this.Siglas.MinimumWidth = 6;
            this.Siglas.Name = "Siglas";
            this.Siglas.Width = 70;
            // 
            // btn_quitar
            // 
            this.btn_quitar.HeaderText = "Acción";
            this.btn_quitar.MinimumWidth = 6;
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.Width = 70;
            // 
            // cb_cursos
            // 
            this.cb_cursos.FormattingEnabled = true;
            this.cb_cursos.Location = new System.Drawing.Point(192, 22);
            this.cb_cursos.Name = "cb_cursos";
            this.cb_cursos.Size = new System.Drawing.Size(151, 28);
            this.cb_cursos.TabIndex = 1;
            // 
            // lbl_seleccionar_curso
            // 
            this.lbl_seleccionar_curso.AutoSize = true;
            this.lbl_seleccionar_curso.Location = new System.Drawing.Point(15, 23);
            this.lbl_seleccionar_curso.Name = "lbl_seleccionar_curso";
            this.lbl_seleccionar_curso.Size = new System.Drawing.Size(142, 20);
            this.lbl_seleccionar_curso.TabIndex = 2;
            this.lbl_seleccionar_curso.Text = "Seleccione un curso:";
            // 
            // btn_agregar_curso
            // 
            this.btn_agregar_curso.Location = new System.Drawing.Point(373, 22);
            this.btn_agregar_curso.Name = "btn_agregar_curso";
            this.btn_agregar_curso.Size = new System.Drawing.Size(94, 29);
            this.btn_agregar_curso.TabIndex = 3;
            this.btn_agregar_curso.Text = "Agregar";
            this.btn_agregar_curso.UseVisualStyleBackColor = true;
            this.btn_agregar_curso.Click += new System.EventHandler(this.btn_agregar_curso_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_seleccionar_curso);
            this.groupBox2.Controls.Add(this.btn_agregar_curso);
            this.groupBox2.Controls.Add(this.cb_cursos);
            this.groupBox2.Location = new System.Drawing.Point(167, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // VerCursosEstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerCursosEstudianteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver cursos estudiante";
            this.Load += new System.EventHandler(this.VerCursosEstudianteForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cursos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_cursos;
        private System.Windows.Forms.ComboBox cb_cursos;
        private System.Windows.Forms.Label lbl_seleccionar_curso;
        private System.Windows.Forms.Button btn_agregar_curso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siglas;
        private System.Windows.Forms.DataGridViewButtonColumn btn_quitar;
    }
}