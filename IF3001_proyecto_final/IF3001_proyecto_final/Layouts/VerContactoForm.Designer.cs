
namespace IF3001_proyecto_final.Layouts
{
    partial class VerContactoForm
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
            this.gp_Numeros_contacto = new System.Windows.Forms.GroupBox();
            this.dgv_Ver_Contacto = new System.Windows.Forms.DataGridView();
            this.col_num_contac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txb_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_Numeros_contacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ver_Contacto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_Numeros_contacto
            // 
            this.gp_Numeros_contacto.Controls.Add(this.dgv_Ver_Contacto);
            this.gp_Numeros_contacto.Location = new System.Drawing.Point(210, 30);
            this.gp_Numeros_contacto.Name = "gp_Numeros_contacto";
            this.gp_Numeros_contacto.Size = new System.Drawing.Size(430, 276);
            this.gp_Numeros_contacto.TabIndex = 0;
            this.gp_Numeros_contacto.TabStop = false;
            this.gp_Numeros_contacto.Text = "Numeros de teléfono de";
            // 
            // dgv_Ver_Contacto
            // 
            this.dgv_Ver_Contacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ver_Contacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num_contac,
            this.borrar});
            this.dgv_Ver_Contacto.Location = new System.Drawing.Point(65, 47);
            this.dgv_Ver_Contacto.Name = "dgv_Ver_Contacto";
            this.dgv_Ver_Contacto.RowHeadersWidth = 51;
            this.dgv_Ver_Contacto.RowTemplate.Height = 29;
            this.dgv_Ver_Contacto.Size = new System.Drawing.Size(301, 188);
            this.dgv_Ver_Contacto.TabIndex = 0;
            this.dgv_Ver_Contacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_num_contac
            // 
            this.col_num_contac.HeaderText = "Número de contacto";
            this.col_num_contac.MinimumWidth = 6;
            this.col_num_contac.Name = "col_num_contac";
            this.col_num_contac.Width = 125;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Acción";
            this.borrar.MinimumWidth = 6;
            this.borrar.Name = "borrar";
            this.borrar.Text = "Borrar";
            this.borrar.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.txb_numero);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(210, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar número";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(284, 46);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(82, 29);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // txb_numero
            // 
            this.txb_numero.Location = new System.Drawing.Point(137, 48);
            this.txb_numero.Name = "txb_numero";
            this.txb_numero.Size = new System.Drawing.Size(125, 27);
            this.txb_numero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número:";
            // 
            // VerContactoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gp_Numeros_contacto);
            this.Name = "VerContactoForm";
            this.Text = "VerContactoForm";
            this.gp_Numeros_contacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ver_Contacto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Ver_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num_contac;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txb_numero;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gp_Numeros_contacto;
    }
}