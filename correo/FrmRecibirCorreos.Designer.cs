namespace correo
{
    partial class FrmRecibirCorreos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recibirCorreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvcorreo = new System.Windows.Forms.DataGridView();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.lblserver = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibirCorreosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recibirCorreosToolStripMenuItem
            // 
            this.recibirCorreosToolStripMenuItem.Name = "recibirCorreosToolStripMenuItem";
            this.recibirCorreosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.recibirCorreosToolStripMenuItem.Text = "Recibir Correos";
            this.recibirCorreosToolStripMenuItem.Click += new System.EventHandler(this.recibirCorreosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvcorreo
            // 
            this.dgvcorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcorreo.Location = new System.Drawing.Point(28, 259);
            this.dgvcorreo.Name = "dgvcorreo";
            this.dgvcorreo.RowHeadersWidth = 51;
            this.dgvcorreo.RowTemplate.Height = 24;
            this.dgvcorreo.Size = new System.Drawing.Size(711, 150);
            this.dgvcorreo.TabIndex = 1;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(25, 101);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(49, 17);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "correo";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(25, 157);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(79, 17);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "contraseña";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(25, 212);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(49, 17);
            this.lblport.TabIndex = 4;
            this.lblport.Text = "puerto";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(80, 101);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(408, 22);
            this.txtemail.TabIndex = 5;
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(80, 212);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(408, 22);
            this.txtport.TabIndex = 6;
            this.txtport.Text = "993";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(110, 152);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(378, 22);
            this.txtpassword.TabIndex = 7;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(90, 61);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(398, 22);
            this.txtserver.TabIndex = 9;
            this.txtserver.Text = "imap.gmail.com";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(25, 64);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(59, 17);
            this.lblserver.TabIndex = 8;
            this.lblserver.Text = "servidor";
            // 
            // FrmRecibirCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.dgvcorreo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRecibirCorreos";
            this.Text = "FrmRecibirCorreos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recibirCorreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvcorreo;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label lblserver;
    }
}