
namespace IF3001_proyecto_final.Layouts
{
    partial class GestionSedeForm
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
            this.btn_agregar_sede = new System.Windows.Forms.Button();
            this.txtb_nombre_sede = new System.Windows.Forms.TextBox();
            this.lb_nombre_sede = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_sede = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.column_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sede)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar_sede);
            this.groupBox1.Controls.Add(this.txtb_nombre_sede);
            this.groupBox1.Controls.Add(this.lb_nombre_sede);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar sede";
            // 
            // btn_agregar_sede
            // 
            this.btn_agregar_sede.Location = new System.Drawing.Point(125, 91);
            this.btn_agregar_sede.Name = "btn_agregar_sede";
            this.btn_agregar_sede.Size = new System.Drawing.Size(157, 29);
            this.btn_agregar_sede.TabIndex = 2;
            this.btn_agregar_sede.Text = "Agregar";
            this.btn_agregar_sede.UseVisualStyleBackColor = true;
            // 
            // txtb_nombre_sede
            // 
            this.txtb_nombre_sede.Location = new System.Drawing.Point(125, 39);
            this.txtb_nombre_sede.Name = "txtb_nombre_sede";
            this.txtb_nombre_sede.Size = new System.Drawing.Size(157, 27);
            this.txtb_nombre_sede.TabIndex = 1;
            // 
            // lb_nombre_sede
            // 
            this.lb_nombre_sede.AutoSize = true;
            this.lb_nombre_sede.Location = new System.Drawing.Point(17, 39);
            this.lb_nombre_sede.Name = "lb_nombre_sede";
            this.lb_nombre_sede.Size = new System.Drawing.Size(102, 20);
            this.lb_nombre_sede.TabIndex = 0;
            this.lb_nombre_sede.Text = "Nombre sede:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_sede);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 346);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar y eliminar sede";
            // 
            // grid_sede
            // 
            this.grid_sede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_nombre,
            this.column_modificar,
            this.column_eliminar});
            this.grid_sede.Location = new System.Drawing.Point(16, 26);
            this.grid_sede.Name = "grid_sede";
            this.grid_sede.RowHeadersWidth = 51;
            this.grid_sede.RowTemplate.Height = 29;
            this.grid_sede.Size = new System.Drawing.Size(578, 295);
            this.grid_sede.TabIndex = 2;
            // 
            // column_id
            // 
            this.column_id.HeaderText = "ID";
            this.column_id.MinimumWidth = 6;
            this.column_id.Name = "column_id";
            this.column_id.ReadOnly = true;
            this.column_id.Width = 125;
            // 
            // column_nombre
            // 
            this.column_nombre.HeaderText = "Nombre de sede";
            this.column_nombre.MinimumWidth = 6;
            this.column_nombre.Name = "column_nombre";
            this.column_nombre.ReadOnly = true;
            this.column_nombre.Width = 150;
            // 
            // column_modificar
            // 
            this.column_modificar.HeaderText = "Modificar";
            this.column_modificar.MinimumWidth = 6;
            this.column_modificar.Name = "column_modificar";
            this.column_modificar.ReadOnly = true;
            this.column_modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.column_modificar.Text = "Modificar";
            this.column_modificar.Width = 125;
            // 
            // column_eliminar
            // 
            this.column_eliminar.HeaderText = "Eliminar";
            this.column_eliminar.MinimumWidth = 6;
            this.column_eliminar.Name = "column_eliminar";
            this.column_eliminar.Width = 125;
            // 
            // GestionSedeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionSedeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionSedeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sede)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregar_sede;
        private System.Windows.Forms.TextBox txtb_nombre_sede;
        private System.Windows.Forms.Label lb_nombre_sede;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grid_sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_nombre;
        private System.Windows.Forms.DataGridViewButtonColumn column_modificar;
        private System.Windows.Forms.DataGridViewButtonColumn column_eliminar;
    }
}