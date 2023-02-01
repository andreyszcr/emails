using AE.Net.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace correo
{
    public partial class FrmRecibirCorreos : Form
    {
        public FrmRecibirCorreos()
        {
            InitializeComponent();
        }

        private string Servidor
        {
            get
            {
                string result = txtServidor.Text.Trim();
                if (string.IsNullOrEmpty(result))
                    throw new Exception("Especificar servidor");
                return result;
            }
            set
            {
                txtServidor.Text = value.Trim();
            }

        }
        private string Usuario
        {
            get
            {
                string result = txtUsuario.Text.Trim();
                if (string.IsNullOrEmpty(result))
                    throw new Exception("Especificar usuario");
                return result;
            }
            set
            {
                txtUsuario.Text = value.Trim();
            }

        }
        private string Password
        {
            get
            {
                string result = txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(result))
                    throw new Exception("Especificar paswword");
                return result;
            }
            set
            {
                txtPassword.Text = value.Trim();
            }

        }
        private int Puerto
        {
            get
            {
                string puerto = txtPuerto.Text.Trim();
                int result;
                if (string.IsNullOrEmpty(puerto))
                    throw new Exception("Especificar puerto");
                try
                {
                    int.TryParse(puerto, out result);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                    throw;
                }
                return result;
            }
            set
            {
                txtPuerto.Text = value.ToString(CultureInfo.InvariantCulture);
            }

        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recibirCorreosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //creamos variable de lista donde se almacenaran los mensajes
                List<MailMessage> lstMensajes = new List<MailMessage>();
                //Creamos conexion y obtenemos mensajes
                using (var cliente = new ImapClient(Servidor, Usuario, Password, AuthMethods.Login, Puerto, true))
                {
                    //Realizamos busqueda de los mensajes que no han sido leidos
                    var mensajes = cliente.SearchMessages(SearchCondition.Unanswered());
                    //Recorremos los mensajes y obtenemos la informacion agregando cada uno a la lista
                    foreach (string idMensaje in mensajes.Select(s => s.Value.Uid))
                    {
                        lstMensajes.Add(cliente.GetMessage(idMensaje, false, false));
                    }
                    //Mostramos mensajes en data grid
                    dataGridView1.DataSource = lstMensajes.Select(s => new { s.From, s.Subject, s.Date }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error:\n{0}", ex.Message);
                throw;
            }
        }
    }
}
