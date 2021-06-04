
namespace IF3001_proyecto_final.Layouts
{
    partial class ModificarCarreraForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbx_modificar_carrera = new System.Windows.Forms.GroupBox();
            this.lb_nombre_carrera = new System.Windows.Forms.Label();
            this.tbx_nombre_carrera = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_modificar_carrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_modificar_carrera
            // 
            this.gbx_modificar_carrera.Controls.Add(this.btn_cancelar);
            this.gbx_modificar_carrera.Controls.Add(this.btn_modificar);
            this.gbx_modificar_carrera.Controls.Add(this.tbx_nombre_carrera);
            this.gbx_modificar_carrera.Controls.Add(this.lb_nombre_carrera);
            this.gbx_modificar_carrera.Location = new System.Drawing.Point(50, 41);
            this.gbx_modificar_carrera.Name = "gbx_modificar_carrera";
            this.gbx_modificar_carrera.Size = new System.Drawing.Size(317, 170);
            this.gbx_modificar_carrera.TabIndex = 0;
            this.gbx_modificar_carrera.TabStop = false;
            this.gbx_modificar_carrera.Text = "Modificar datos de la carrera";
            // 
            // lb_nombre_carrera
            // 
            this.lb_nombre_carrera.AutoSize = true;
            this.lb_nombre_carrera.Location = new System.Drawing.Point(17, 36);
            this.lb_nombre_carrera.Name = "lb_nombre_carrera";
            this.lb_nombre_carrera.Size = new System.Drawing.Size(117, 20);
            this.lb_nombre_carrera.TabIndex = 0;
            this.lb_nombre_carrera.Text = "Nombre carrera:";
            // 
            // tbx_nombre_carrera
            // 
            this.tbx_nombre_carrera.Location = new System.Drawing.Point(151, 36);
            this.tbx_nombre_carrera.Name = "tbx_nombre_carrera";
            this.tbx_nombre_carrera.Size = new System.Drawing.Size(125, 27);
            this.tbx_nombre_carrera.TabIndex = 1;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(40, 98);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(169, 98);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // ModificarCarreraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 252);
            this.Controls.Add(this.gbx_modificar_carrera);
            this.Name = "ModificarCarreraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCarreraForm";
            this.gbx_modificar_carrera.ResumeLayout(false);
            this.gbx_modificar_carrera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbx_modificar_carrera;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox tbx_nombre_carrera;
        private System.Windows.Forms.Label lb_nombre_carrera;
    }
}