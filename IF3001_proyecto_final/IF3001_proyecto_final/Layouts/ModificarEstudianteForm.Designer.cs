﻿
namespace IF3001_proyecto_final.Layouts
{
    partial class ModificarEstudianteForm
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_carne = new System.Windows.Forms.TextBox();
            this.lbl_carne = new System.Windows.Forms.Label();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_apeliidos = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_carne);
            this.groupBox1.Controls.Add(this.lbl_carne);
            this.groupBox1.Controls.Add(this.txt_promedio);
            this.groupBox1.Controls.Add(this.lbl_promedio);
            this.groupBox1.Controls.Add(this.txt_edad);
            this.groupBox1.Controls.Add(this.lbl_edad);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.lbl_apeliidos);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Location = new System.Drawing.Point(99, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar datos de estudiante";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(216, 198);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.Text = "Modificar cambios";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(343, 198);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 29);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_carne
            // 
            this.txt_carne.Location = new System.Drawing.Point(106, 198);
            this.txt_carne.Name = "txt_carne";
            this.txt_carne.Size = new System.Drawing.Size(86, 27);
            this.txt_carne.TabIndex = 20;
            // 
            // lbl_carne
            // 
            this.lbl_carne.AutoSize = true;
            this.lbl_carne.Location = new System.Drawing.Point(17, 198);
            this.lbl_carne.Name = "lbl_carne";
            this.lbl_carne.Size = new System.Drawing.Size(50, 20);
            this.lbl_carne.TabIndex = 19;
            this.lbl_carne.Text = "Carné:";
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(312, 115);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(125, 27);
            this.txt_promedio.TabIndex = 18;
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.Location = new System.Drawing.Point(216, 115);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(77, 20);
            this.lbl_promedio.TabIndex = 17;
            this.lbl_promedio.Text = "Promedio:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(106, 115);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(86, 27);
            this.txt_edad.TabIndex = 16;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(21, 115);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 20);
            this.lbl_edad.TabIndex = 15;
            this.lbl_edad.Text = "Edad:";
            this.lbl_edad.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(312, 42);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(125, 27);
            this.txt_apellidos.TabIndex = 14;
            // 
            // lbl_apeliidos
            // 
            this.lbl_apeliidos.AutoSize = true;
            this.lbl_apeliidos.Location = new System.Drawing.Point(216, 42);
            this.lbl_apeliidos.Name = "lbl_apeliidos";
            this.lbl_apeliidos.Size = new System.Drawing.Size(75, 20);
            this.lbl_apeliidos.TabIndex = 13;
            this.lbl_apeliidos.Text = "Apellidos:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(106, 42);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(86, 27);
            this.txt_nombre.TabIndex = 12;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 42);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_nombre.TabIndex = 11;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // ModificarEstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 346);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarEstudianteForm";
            this.Text = "ModificarEstudianteForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_carne;
        private System.Windows.Forms.Label lbl_carne;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_apeliidos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
    }
}