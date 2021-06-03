
namespace IF3001_proyecto_final.Layouts
{
    partial class GestionCursoForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_beca = new System.Windows.Forms.DataGridView();
            this.gbx_agregar_carrera = new System.Windows.Forms.GroupBox();
            this.btn_agregar_carrera = new System.Windows.Forms.Button();
            this.tbx_nombre_curso = new System.Windows.Forms.TextBox();
            this.lb_nombre_curso = new System.Windows.Forms.Label();
            this.lb_creditos = new System.Windows.Forms.Label();
            this.tbx_creditos = new System.Windows.Forms.TextBox();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_nombre_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_beca)).BeginInit();
            this.gbx_agregar_carrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_beca);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 319);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar y eliminar curso";
            // 
            // grid_beca
            // 
            this.grid_beca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_beca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_nombre_curso,
            this.column_creditos,
            this.btn_modificar,
            this.btn_eliminar});
            this.grid_beca.Location = new System.Drawing.Point(18, 43);
            this.grid_beca.Name = "grid_beca";
            this.grid_beca.RowHeadersWidth = 51;
            this.grid_beca.RowTemplate.Height = 29;
            this.grid_beca.Size = new System.Drawing.Size(704, 249);
            this.grid_beca.TabIndex = 0;
            // 
            // gbx_agregar_carrera
            // 
            this.gbx_agregar_carrera.Controls.Add(this.tbx_creditos);
            this.gbx_agregar_carrera.Controls.Add(this.lb_creditos);
            this.gbx_agregar_carrera.Controls.Add(this.btn_agregar_carrera);
            this.gbx_agregar_carrera.Controls.Add(this.tbx_nombre_curso);
            this.gbx_agregar_carrera.Controls.Add(this.lb_nombre_curso);
            this.gbx_agregar_carrera.Location = new System.Drawing.Point(12, 12);
            this.gbx_agregar_carrera.Name = "gbx_agregar_carrera";
            this.gbx_agregar_carrera.Size = new System.Drawing.Size(379, 202);
            this.gbx_agregar_carrera.TabIndex = 4;
            this.gbx_agregar_carrera.TabStop = false;
            this.gbx_agregar_carrera.Text = "Agregar beca";
            // 
            // btn_agregar_carrera
            // 
            this.btn_agregar_carrera.Location = new System.Drawing.Point(155, 151);
            this.btn_agregar_carrera.Name = "btn_agregar_carrera";
            this.btn_agregar_carrera.Size = new System.Drawing.Size(134, 29);
            this.btn_agregar_carrera.TabIndex = 2;
            this.btn_agregar_carrera.Text = "Agregar";
            this.btn_agregar_carrera.UseVisualStyleBackColor = true;
            // 
            // tbx_nombre_curso
            // 
            this.tbx_nombre_curso.Location = new System.Drawing.Point(143, 42);
            this.tbx_nombre_curso.Name = "tbx_nombre_curso";
            this.tbx_nombre_curso.Size = new System.Drawing.Size(165, 27);
            this.tbx_nombre_curso.TabIndex = 1;
            // 
            // lb_nombre_curso
            // 
            this.lb_nombre_curso.AutoSize = true;
            this.lb_nombre_curso.Location = new System.Drawing.Point(18, 42);
            this.lb_nombre_curso.Name = "lb_nombre_curso";
            this.lb_nombre_curso.Size = new System.Drawing.Size(106, 20);
            this.lb_nombre_curso.TabIndex = 0;
            this.lb_nombre_curso.Text = "Nombre curso:";
            // 
            // lb_creditos
            // 
            this.lb_creditos.AutoSize = true;
            this.lb_creditos.Location = new System.Drawing.Point(18, 83);
            this.lb_creditos.Name = "lb_creditos";
            this.lb_creditos.Size = new System.Drawing.Size(67, 20);
            this.lb_creditos.TabIndex = 3;
            this.lb_creditos.Text = "Creditos:";
            // 
            // tbx_creditos
            // 
            this.tbx_creditos.Location = new System.Drawing.Point(143, 92);
            this.tbx_creditos.Name = "tbx_creditos";
            this.tbx_creditos.Size = new System.Drawing.Size(165, 27);
            this.tbx_creditos.TabIndex = 4;
            // 
            // column_id
            // 
            this.column_id.HeaderText = "ID";
            this.column_id.MinimumWidth = 6;
            this.column_id.Name = "column_id";
            this.column_id.ReadOnly = true;
            this.column_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column_id.Width = 125;
            // 
            // column_nombre_curso
            // 
            this.column_nombre_curso.HeaderText = "Nombre curso";
            this.column_nombre_curso.MinimumWidth = 6;
            this.column_nombre_curso.Name = "column_nombre_curso";
            this.column_nombre_curso.ReadOnly = true;
            this.column_nombre_curso.Width = 150;
            // 
            // column_creditos
            // 
            this.column_creditos.HeaderText = "Creditos";
            this.column_creditos.MinimumWidth = 6;
            this.column_creditos.Name = "column_creditos";
            this.column_creditos.Width = 125;
            // 
            // btn_modificar
            // 
            this.btn_modificar.HeaderText = "Modificar";
            this.btn_modificar.MinimumWidth = 6;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Width = 125;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "Elminar";
            this.btn_eliminar.MinimumWidth = 6;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Width = 125;
            // 
            // GestionCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_agregar_carrera);
            this.Name = "GestionCursoForm";
            this.Text = "GestionCursoForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_beca)).EndInit();
            this.gbx_agregar_carrera.ResumeLayout(false);
            this.gbx_agregar_carrera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_beca;
        private System.Windows.Forms.GroupBox gbx_agregar_carrera;
        private System.Windows.Forms.Button btn_agregar_carrera;
        private System.Windows.Forms.TextBox tbx_nombre_curso;
        private System.Windows.Forms.Label lb_nombre_curso;
        private System.Windows.Forms.TextBox tbx_creditos;
        private System.Windows.Forms.Label lb_creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nombre_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_creditos;
        private System.Windows.Forms.DataGridViewButtonColumn btn_modificar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
    }
}