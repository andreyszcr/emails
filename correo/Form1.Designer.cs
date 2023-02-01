namespace correo
{
    partial class frmCorreo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtadjunto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.envuarCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjuntarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofarchivo = new System.Windows.Forms.OpenFileDialog();
            this.correosEntrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "contraseña";
            // 
            // txtDE
            // 
            this.txtDE.Location = new System.Drawing.Point(98, 47);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(361, 22);
            this.txtDE.TabIndex = 5;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(98, 82);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(361, 22);
            this.txtPara.TabIndex = 6;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(98, 123);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(360, 22);
            this.txtAsunto.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(576, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Archivo Adjunto";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(141, 172);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(318, 22);
            this.txtArchivo.TabIndex = 10;
            // 
            // txtadjunto
            // 
            this.txtadjunto.Location = new System.Drawing.Point(12, 227);
            this.txtadjunto.Name = "txtadjunto";
            this.txtadjunto.Size = new System.Drawing.Size(558, 96);
            this.txtadjunto.TabIndex = 12;
            this.txtadjunto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envuarCorreoToolStripMenuItem,
            this.adjuntarArchivoToolStripMenuItem,
            this.correosEntrantesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // envuarCorreoToolStripMenuItem
            // 
            this.envuarCorreoToolStripMenuItem.Name = "envuarCorreoToolStripMenuItem";
            this.envuarCorreoToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.envuarCorreoToolStripMenuItem.Text = "Envuar Correo";
            this.envuarCorreoToolStripMenuItem.Click += new System.EventHandler(this.envuarCorreoToolStripMenuItem_Click);
            // 
            // adjuntarArchivoToolStripMenuItem
            // 
            this.adjuntarArchivoToolStripMenuItem.Name = "adjuntarArchivoToolStripMenuItem";
            this.adjuntarArchivoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.adjuntarArchivoToolStripMenuItem.Text = "Adjuntar Archivo";
            this.adjuntarArchivoToolStripMenuItem.Click += new System.EventHandler(this.adjuntarArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ofarchivo
            // 
            this.ofarchivo.FileName = "openFileDialog1";
            // 
            // correosEntrantesToolStripMenuItem
            // 
            this.correosEntrantesToolStripMenuItem.Name = "correosEntrantesToolStripMenuItem";
            this.correosEntrantesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.correosEntrantesToolStripMenuItem.Text = "Correos Entrantes";
            this.correosEntrantesToolStripMenuItem.Click += new System.EventHandler(this.correosEntrantesToolStripMenuItem_Click);
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txtadjunto);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtDE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCorreo";
            this.Text = "Correo Electronico ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.RichTextBox txtadjunto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem envuarCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjuntarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofarchivo;
        private System.Windows.Forms.ToolStripMenuItem correosEntrantesToolStripMenuItem;
    }
}

