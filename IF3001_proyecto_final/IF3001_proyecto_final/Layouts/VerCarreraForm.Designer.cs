
namespace IF3001_proyecto_final.Layouts
{
    partial class VerCarreraForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_seleccionar_carrera = new System.Windows.Forms.Label();
            this.btn_agregar_carrera = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_carrera = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(171, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carreras del estudiante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.btn_accion});
            this.dataGridView1.Location = new System.Drawing.Point(108, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(331, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // btn_accion
            // 
            this.btn_accion.HeaderText = "Acción";
            this.btn_accion.MinimumWidth = 6;
            this.btn_accion.Name = "btn_accion";
            this.btn_accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_accion.Text = "Quitar";
            this.btn_accion.Width = 70;
            // 
            // lbl_seleccionar_carrera
            // 
            this.lbl_seleccionar_carrera.AutoSize = true;
            this.lbl_seleccionar_carrera.Location = new System.Drawing.Point(58, 35);
            this.lbl_seleccionar_carrera.Name = "lbl_seleccionar_carrera";
            this.lbl_seleccionar_carrera.Size = new System.Drawing.Size(138, 20);
            this.lbl_seleccionar_carrera.TabIndex = 1;
            this.lbl_seleccionar_carrera.Text = "Seleccionar carrera:";
            // 
            // btn_agregar_carrera
            // 
            this.btn_agregar_carrera.Location = new System.Drawing.Point(379, 33);
            this.btn_agregar_carrera.Name = "btn_agregar_carrera";
            this.btn_agregar_carrera.Size = new System.Drawing.Size(94, 29);
            this.btn_agregar_carrera.TabIndex = 3;
            this.btn_agregar_carrera.Text = "Agregar";
            this.btn_agregar_carrera.UseVisualStyleBackColor = true;
            this.btn_agregar_carrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_carrera);
            this.groupBox2.Controls.Add(this.lbl_seleccionar_carrera);
            this.groupBox2.Controls.Add(this.btn_agregar_carrera);
            this.groupBox2.Location = new System.Drawing.Point(171, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cb_carrera
            // 
            this.cb_carrera.FormattingEnabled = true;
            this.cb_carrera.Location = new System.Drawing.Point(211, 35);
            this.cb_carrera.Name = "cb_carrera";
            this.cb_carrera.Size = new System.Drawing.Size(152, 28);
            this.cb_carrera.TabIndex = 4;
            // 
            // VerCarreraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerCarreraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver carreras";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_seleccionar_carrera;
        private System.Windows.Forms.Button btn_agregar_carrera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn btn_accion;
    }
}