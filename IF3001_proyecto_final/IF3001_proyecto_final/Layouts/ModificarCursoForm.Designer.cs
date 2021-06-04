
namespace IF3001_proyecto_final.Layouts
{
    partial class ModificarCursoForm
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
            this.gbx_modificar_curso = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_creditos = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.tbx_nombre_curso = new System.Windows.Forms.TextBox();
            this.lb_nombre_curso = new System.Windows.Forms.Label();
            this.gbx_modificar_curso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_modificar_curso
            // 
            this.gbx_modificar_curso.Controls.Add(this.textBox1);
            this.gbx_modificar_curso.Controls.Add(this.lb_creditos);
            this.gbx_modificar_curso.Controls.Add(this.btn_cancelar);
            this.gbx_modificar_curso.Controls.Add(this.btn_modificar);
            this.gbx_modificar_curso.Controls.Add(this.tbx_nombre_curso);
            this.gbx_modificar_curso.Controls.Add(this.lb_nombre_curso);
            this.gbx_modificar_curso.Location = new System.Drawing.Point(18, 23);
            this.gbx_modificar_curso.Name = "gbx_modificar_curso";
            this.gbx_modificar_curso.Size = new System.Drawing.Size(364, 209);
            this.gbx_modificar_curso.TabIndex = 1;
            this.gbx_modificar_curso.TabStop = false;
            this.gbx_modificar_curso.Text = "Modificar datos de los cursos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 27);
            this.textBox1.TabIndex = 5;
            // 
            // lb_creditos
            // 
            this.lb_creditos.AutoSize = true;
            this.lb_creditos.Location = new System.Drawing.Point(17, 80);
            this.lb_creditos.Name = "lb_creditos";
            this.lb_creditos.Size = new System.Drawing.Size(67, 20);
            this.lb_creditos.TabIndex = 4;
            this.lb_creditos.Text = "Creditos:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(173, 144);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(63, 144);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // tbx_nombre_curso
            // 
            this.tbx_nombre_curso.Location = new System.Drawing.Point(151, 36);
            this.tbx_nombre_curso.Name = "tbx_nombre_curso";
            this.tbx_nombre_curso.Size = new System.Drawing.Size(152, 27);
            this.tbx_nombre_curso.TabIndex = 1;
            // 
            // lb_nombre_curso
            // 
            this.lb_nombre_curso.AutoSize = true;
            this.lb_nombre_curso.Location = new System.Drawing.Point(17, 36);
            this.lb_nombre_curso.Name = "lb_nombre_curso";
            this.lb_nombre_curso.Size = new System.Drawing.Size(106, 20);
            this.lb_nombre_curso.TabIndex = 0;
            this.lb_nombre_curso.Text = "Nombre curso:";
            // 
            // ModificarCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 258);
            this.Controls.Add(this.gbx_modificar_curso);
            this.Name = "ModificarCursoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCursoForm";
            this.gbx_modificar_curso.ResumeLayout(false);
            this.gbx_modificar_curso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_modificar_curso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_creditos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox tbx_nombre_curso;
        private System.Windows.Forms.Label lb_nombre_curso;
    }
}