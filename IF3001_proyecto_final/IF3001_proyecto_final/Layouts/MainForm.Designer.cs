
namespace IF3001_proyecto_final.Layouts
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCursotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEstudianteToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.estudianteToolStripMenuItem.Text = "&Estudiantes";
            // 
            // gestionEstudianteToolStripMenuItem
            // 
            this.gestionEstudianteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionEstudianteToolStripMenuItem.Image")));
            this.gestionEstudianteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gestionEstudianteToolStripMenuItem.Name = "gestionEstudianteToolStripMenuItem";
            this.gestionEstudianteToolStripMenuItem.ShowShortcutKeys = false;
            this.gestionEstudianteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.gestionEstudianteToolStripMenuItem.Text = "&Gestionar Estudiante";
            this.gestionEstudianteToolStripMenuItem.Click += new System.EventHandler(this.gestionEstudianteToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCarreraToolStripMenuItem,
            this.gestionCursotoolStripMenuItem1});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administracionToolStripMenuItem.Text = "&Administración";
            // 
            // gestionCarreraToolStripMenuItem
            // 
            this.gestionCarreraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestionCarreraToolStripMenuItem.Image")));
            this.gestionCarreraToolStripMenuItem.Name = "gestionCarreraToolStripMenuItem";
            this.gestionCarreraToolStripMenuItem.ShowShortcutKeys = false;
            this.gestionCarreraToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.gestionCarreraToolStripMenuItem.Text = "&Gestionar Carrera";
            this.gestionCarreraToolStripMenuItem.Click += new System.EventHandler(this.gestionCarreraToolStripMenuItem_Click);
            // 
            // gestionCursotoolStripMenuItem1
            // 
            this.gestionCursotoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("gestionCursotoolStripMenuItem1.Image")));
            this.gestionCursotoolStripMenuItem1.Name = "gestionCursotoolStripMenuItem1";
            this.gestionCursotoolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.gestionCursotoolStripMenuItem1.Text = "Gestión Curso";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindowForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCursotoolStripMenuItem1;
    }
}