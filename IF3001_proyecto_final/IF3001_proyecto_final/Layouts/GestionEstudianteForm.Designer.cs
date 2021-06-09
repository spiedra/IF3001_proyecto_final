
namespace IF3001_proyecto_final.Layouts
{
    partial class GestionEstudianteForm
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
            this.gp_registro_estudiantes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.btn_agregar_estudiante = new System.Windows.Forms.Button();
            this.txt_carne = new System.Windows.Forms.TextBox();
            this.lbl_carne = new System.Windows.Forms.Label();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.lbl_promedio = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lvl_carne_buscar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gp_lista_estudiantes = new System.Windows.Forms.GroupBox();
            this.btn_contacto = new System.Windows.Forms.Button();
            this.btn_ver_carrera = new System.Windows.Forms.Button();
            this.btn_ver_cursos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carné = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_sedes = new System.Windows.Forms.Label();
            this.lb_tipo_beca = new System.Windows.Forms.Label();
            this.gp_registro_estudiantes.SuspendLayout();
            this.gp_lista_estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_registro_estudiantes
            // 
            this.gp_registro_estudiantes.Controls.Add(this.lb_tipo_beca);
            this.gp_registro_estudiantes.Controls.Add(this.lb_sedes);
            this.gp_registro_estudiantes.Controls.Add(this.comboBox2);
            this.gp_registro_estudiantes.Controls.Add(this.comboBox1);
            this.gp_registro_estudiantes.Controls.Add(this.label1);
            this.gp_registro_estudiantes.Controls.Add(this.txb_direccion);
            this.gp_registro_estudiantes.Controls.Add(this.btn_agregar_estudiante);
            this.gp_registro_estudiantes.Controls.Add(this.txt_carne);
            this.gp_registro_estudiantes.Controls.Add(this.lbl_carne);
            this.gp_registro_estudiantes.Controls.Add(this.txt_promedio);
            this.gp_registro_estudiantes.Controls.Add(this.lbl_promedio);
            this.gp_registro_estudiantes.Controls.Add(this.txt_edad);
            this.gp_registro_estudiantes.Controls.Add(this.lbl_edad);
            this.gp_registro_estudiantes.Controls.Add(this.txt_apellidos);
            this.gp_registro_estudiantes.Controls.Add(this.lbl_apellidos);
            this.gp_registro_estudiantes.Controls.Add(this.txt_nombre);
            this.gp_registro_estudiantes.Controls.Add(this.lbl_nombre);
            this.gp_registro_estudiantes.Location = new System.Drawing.Point(32, 29);
            this.gp_registro_estudiantes.Name = "gp_registro_estudiantes";
            this.gp_registro_estudiantes.Size = new System.Drawing.Size(745, 307);
            this.gp_registro_estudiantes.TabIndex = 0;
            this.gp_registro_estudiantes.TabStop = false;
            this.gp_registro_estudiantes.Text = "Registro de estudiantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dirección:";
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(310, 198);
            this.txb_direccion.Multiline = true;
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(125, 34);
            this.txb_direccion.TabIndex = 11;
            // 
            // btn_agregar_estudiante
            // 
            this.btn_agregar_estudiante.Location = new System.Drawing.Point(163, 262);
            this.btn_agregar_estudiante.Name = "btn_agregar_estudiante";
            this.btn_agregar_estudiante.Size = new System.Drawing.Size(153, 31);
            this.btn_agregar_estudiante.TabIndex = 10;
            this.btn_agregar_estudiante.Text = "Agregar estudiante";
            this.btn_agregar_estudiante.UseVisualStyleBackColor = true;
            this.btn_agregar_estudiante.Click += new System.EventHandler(this.btn_agregar_estudiante_Click);
            // 
            // txt_carne
            // 
            this.txt_carne.Location = new System.Drawing.Point(104, 198);
            this.txt_carne.Name = "txt_carne";
            this.txt_carne.Size = new System.Drawing.Size(86, 27);
            this.txt_carne.TabIndex = 9;
            // 
            // lbl_carne
            // 
            this.lbl_carne.AutoSize = true;
            this.lbl_carne.Location = new System.Drawing.Point(19, 198);
            this.lbl_carne.Name = "lbl_carne";
            this.lbl_carne.Size = new System.Drawing.Size(50, 20);
            this.lbl_carne.TabIndex = 8;
            this.lbl_carne.Text = "Carné:";
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(310, 126);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(125, 27);
            this.txt_promedio.TabIndex = 7;
            // 
            // lbl_promedio
            // 
            this.lbl_promedio.AutoSize = true;
            this.lbl_promedio.Location = new System.Drawing.Point(214, 126);
            this.lbl_promedio.Name = "lbl_promedio";
            this.lbl_promedio.Size = new System.Drawing.Size(77, 20);
            this.lbl_promedio.TabIndex = 6;
            this.lbl_promedio.Text = "Promedio:";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(104, 126);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(86, 27);
            this.txt_edad.TabIndex = 5;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(19, 126);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 20);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "Edad:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(310, 53);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(125, 27);
            this.txt_apellidos.TabIndex = 3;
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(214, 53);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(75, 20);
            this.lbl_apellidos.TabIndex = 2;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 53);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(86, 27);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(19, 53);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(67, 20);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 34);
            this.textBox1.TabIndex = 11;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(245, 36);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 29);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 1;
            // 
            // lvl_carne_buscar
            // 
            this.lvl_carne_buscar.AutoSize = true;
            this.lvl_carne_buscar.Location = new System.Drawing.Point(25, 40);
            this.lvl_carne_buscar.Name = "lvl_carne_buscar";
            this.lvl_carne_buscar.Size = new System.Drawing.Size(50, 20);
            this.lvl_carne_buscar.TabIndex = 0;
            this.lvl_carne_buscar.Text = "Carné:";
            // 
            // gp_lista_estudiantes
            // 
            this.gp_lista_estudiantes.Controls.Add(this.btn_contacto);
            this.gp_lista_estudiantes.Controls.Add(this.btn_ver_carrera);
            this.gp_lista_estudiantes.Controls.Add(this.btn_ver_cursos);
            this.gp_lista_estudiantes.Controls.Add(this.button4);
            this.gp_lista_estudiantes.Controls.Add(this.btn_modificar);
            this.gp_lista_estudiantes.Controls.Add(this.btn_buscar);
            this.gp_lista_estudiantes.Controls.Add(this.dataGridView1);
            this.gp_lista_estudiantes.Controls.Add(this.textBox6);
            this.gp_lista_estudiantes.Controls.Add(this.lvl_carne_buscar);
            this.gp_lista_estudiantes.Location = new System.Drawing.Point(32, 342);
            this.gp_lista_estudiantes.Name = "gp_lista_estudiantes";
            this.gp_lista_estudiantes.Size = new System.Drawing.Size(1006, 318);
            this.gp_lista_estudiantes.TabIndex = 2;
            this.gp_lista_estudiantes.TabStop = false;
            this.gp_lista_estudiantes.Text = "Lista de estudiantes";
            this.gp_lista_estudiantes.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_contacto
            // 
            this.btn_contacto.Location = new System.Drawing.Point(628, 37);
            this.btn_contacto.Name = "btn_contacto";
            this.btn_contacto.Size = new System.Drawing.Size(117, 29);
            this.btn_contacto.TabIndex = 7;
            this.btn_contacto.Text = "Ver contacto";
            this.btn_contacto.UseVisualStyleBackColor = true;
            this.btn_contacto.Click += new System.EventHandler(this.btn_contacto_Click);
            // 
            // btn_ver_carrera
            // 
            this.btn_ver_carrera.Location = new System.Drawing.Point(503, 35);
            this.btn_ver_carrera.Name = "btn_ver_carrera";
            this.btn_ver_carrera.Size = new System.Drawing.Size(94, 31);
            this.btn_ver_carrera.TabIndex = 6;
            this.btn_ver_carrera.Text = "Ver carrera";
            this.btn_ver_carrera.UseVisualStyleBackColor = true;
            this.btn_ver_carrera.Click += new System.EventHandler(this.btn_ver_carrera_Click);
            // 
            // btn_ver_cursos
            // 
            this.btn_ver_cursos.Location = new System.Drawing.Point(375, 35);
            this.btn_ver_cursos.Name = "btn_ver_cursos";
            this.btn_ver_cursos.Size = new System.Drawing.Size(94, 29);
            this.btn_ver_cursos.TabIndex = 5;
            this.btn_ver_cursos.Text = "Ver cursos";
            this.btn_ver_cursos.UseVisualStyleBackColor = true;
            this.btn_ver_cursos.Click += new System.EventHandler(this.btn_ver_cursos_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(889, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(776, 36);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 29);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellidos,
            this.Edad,
            this.Carné,
            this.Promedio,
            this.Beca,
            this.Sede,
            this.Direccion});
            this.dataGridView1.Location = new System.Drawing.Point(19, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(964, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 50;
            // 
            // Carné
            // 
            this.Carné.HeaderText = "Carné";
            this.Carné.MinimumWidth = 6;
            this.Carné.Name = "Carné";
            this.Carné.ReadOnly = true;
            this.Carné.Width = 70;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 80;
            // 
            // Beca
            // 
            this.Beca.HeaderText = "Beca";
            this.Beca.MinimumWidth = 6;
            this.Beca.Name = "Beca";
            this.Beca.ReadOnly = true;
            this.Beca.Width = 50;
            // 
            // Sede
            // 
            this.Sede.HeaderText = "Sede";
            this.Sede.MinimumWidth = 6;
            this.Sede.Name = "Sede";
            this.Sede.ReadOnly = true;
            this.Sede.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(571, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // lb_sedes
            // 
            this.lb_sedes.AutoSize = true;
            this.lb_sedes.Location = new System.Drawing.Point(473, 56);
            this.lb_sedes.Name = "lb_sedes";
            this.lb_sedes.Size = new System.Drawing.Size(51, 20);
            this.lb_sedes.TabIndex = 17;
            this.lb_sedes.Text = "Sedes:";
            // 
            // lb_tipo_beca
            // 
            this.lb_tipo_beca.AutoSize = true;
            this.lb_tipo_beca.Location = new System.Drawing.Point(473, 129);
            this.lb_tipo_beca.Name = "lb_tipo_beca";
            this.lb_tipo_beca.Size = new System.Drawing.Size(78, 20);
            this.lb_tipo_beca.TabIndex = 18;
            this.lb_tipo_beca.Text = "Tipo Beca:";
            // 
            // GestionEstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 672);
            this.Controls.Add(this.gp_lista_estudiantes);
            this.Controls.Add(this.gp_registro_estudiantes);
            this.Name = "GestionEstudianteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionEstudianteForm";
            this.Load += new System.EventHandler(this.GestionEstudianteForm_Load);
            this.gp_registro_estudiantes.ResumeLayout(false);
            this.gp_registro_estudiantes.PerformLayout();
            this.gp_lista_estudiantes.ResumeLayout(false);
            this.gp_lista_estudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_registro_estudiantes;
        private System.Windows.Forms.Button btn_agregar_estudiante;
        private System.Windows.Forms.TextBox txt_carne;
        private System.Windows.Forms.Label lbl_carne;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.Label lbl_promedio;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lvl_carne_buscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gp_lista_estudiantes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ver_cursos;
        private System.Windows.Forms.Button btn_ver_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carné;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_contacto;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;


       
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.Label lb_tipo_beca;
        private System.Windows.Forms.Label lb_sedes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}