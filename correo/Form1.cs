using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BLL;




namespace correo
{
    public partial class frmCorreo : Form
    {
        Negocios n = new Negocios();
        public frmCorreo()
        {
            InitializeComponent();
        }
        private void envuarCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.De = txtDE.Text;
            n.Para = txtPara.Text;
            n.asunt = txtAsunto.Text;
            n.file = txtArchivo.Text;
            n.password = txtPassword.Text;
            n.message = txtadjunto.Text;
            n.CorreoGmail();
            n.InsertarBD();
            txtDE.Clear();
            txtPara.Clear();
            txtAsunto.Clear();
            txtArchivo.Clear();
            txtPassword.Clear();
            txtadjunto.Clear();
        }
        private void adjuntarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //validacion de datos 
            try
            {
                //se abre el archivo 
                this.ofarchivo.ShowDialog();
                if (this.ofarchivo.FileName.Equals("") == false)
                {
                    txtArchivo.Text = this.ofarchivo.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void correosEntrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecibirCorreos frm = new FrmRecibirCorreos();
            frm.Show();
            this.Hide();
        }
    }
}
