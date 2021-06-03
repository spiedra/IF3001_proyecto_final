
namespace IF3001_proyecto_final.Layouts
{
    partial class GestionCarreraForm
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
            this.btn_agregar_carrera = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_carrera = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_carrera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar_carrera);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar carrera";
            // 
            // btn_agregar_carrera
            // 
            this.btn_agregar_carrera.Location = new System.Drawing.Point(175, 102);
            this.btn_agregar_carrera.Name = "btn_agregar_carrera";
            this.btn_agregar_carrera.Size = new System.Drawing.Size(141, 29);
            this.btn_agregar_carrera.TabIndex = 2;
            this.btn_agregar_carrera.Text = "Agregar";
            this.btn_agregar_carrera.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de carrera:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_carrera);
            this.groupBox2.Location = new System.Drawing.Point(23, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar y eliminar carrera";
            // 
            // grid_carrera
            // 
            this.grid_carrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_carrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_nombre,
            this.btn_modificar,
            this.btn_eliminar});
            this.grid_carrera.Location = new System.Drawing.Point(18, 43);
            this.grid_carrera.Name = "grid_carrera";
            this.grid_carrera.RowHeadersWidth = 51;
            this.grid_carrera.RowTemplate.Height = 29;
            this.grid_carrera.Size = new System.Drawing.Size(579, 249);
            this.grid_carrera.TabIndex = 0;
            this.grid_carrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_carrera_CellContentClick);
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
            this.column_nombre.HeaderText = "Nombre Carrera";
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
            // GestionCarreraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionCarreraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCarreraForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_carrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar_carrera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btn_modificar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
    }
}