
namespace IF3001_proyecto_final.Layouts
{
    partial class GestionBecaForm
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
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbx_agregar_carrera = new System.Windows.Forms.GroupBox();
            this.btn_agregar_carrera = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_tipo_beca = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_beca)).BeginInit();
            this.gbx_agregar_carrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_beca);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 344);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar y eliminar beca";
            // 
            // grid_beca
            // 
            this.grid_beca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_beca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_nombre,
            this.btn_modificar,
            this.btn_eliminar});
            this.grid_beca.Location = new System.Drawing.Point(18, 43);
            this.grid_beca.Name = "grid_beca";
            this.grid_beca.RowHeadersWidth = 51;
            this.grid_beca.RowTemplate.Height = 29;
            this.grid_beca.Size = new System.Drawing.Size(580, 268);
            this.grid_beca.TabIndex = 0;
            this.grid_beca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_beca_CellContentClick);
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
            // column_nombre
            // 
            this.column_nombre.HeaderText = "Tipo de beca";
            this.column_nombre.MinimumWidth = 6;
            this.column_nombre.Name = "column_nombre";
            this.column_nombre.ReadOnly = true;
            this.column_nombre.Width = 150;
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
            // gbx_agregar_carrera
            // 
            this.gbx_agregar_carrera.Controls.Add(this.btn_agregar_carrera);
            this.gbx_agregar_carrera.Controls.Add(this.textBox1);
            this.gbx_agregar_carrera.Controls.Add(this.lb_tipo_beca);
            this.gbx_agregar_carrera.Location = new System.Drawing.Point(12, 12);
            this.gbx_agregar_carrera.Name = "gbx_agregar_carrera";
            this.gbx_agregar_carrera.Size = new System.Drawing.Size(315, 160);
            this.gbx_agregar_carrera.TabIndex = 2;
            this.gbx_agregar_carrera.TabStop = false;
            this.gbx_agregar_carrera.Text = "Agregar beca";
            // 
            // btn_agregar_carrera
            // 
            this.btn_agregar_carrera.Location = new System.Drawing.Point(143, 100);
            this.btn_agregar_carrera.Name = "btn_agregar_carrera";
            this.btn_agregar_carrera.Size = new System.Drawing.Size(141, 29);
            this.btn_agregar_carrera.TabIndex = 2;
            this.btn_agregar_carrera.Text = "Agregar";
            this.btn_agregar_carrera.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            // 
            // lb_tipo_beca
            // 
            this.lb_tipo_beca.AutoSize = true;
            this.lb_tipo_beca.Location = new System.Drawing.Point(18, 42);
            this.lb_tipo_beca.Name = "lb_tipo_beca";
            this.lb_tipo_beca.Size = new System.Drawing.Size(99, 20);
            this.lb_tipo_beca.TabIndex = 0;
            this.lb_tipo_beca.Text = "Tipo de beca:";
            // 
            // GestionBecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_agregar_carrera);
            this.Name = "GestionBecaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionBecaForm";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_beca)).EndInit();
            this.gbx_agregar_carrera.ResumeLayout(false);
            this.gbx_agregar_carrera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_beca;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btn_modificar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.GroupBox gbx_agregar_carrera;
        private System.Windows.Forms.Button btn_agregar_carrera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_tipo_beca;
    }
}