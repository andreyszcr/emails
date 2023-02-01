using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BLL
{
    public class Negocios
    {
         MailMessage email = new MailMessage();
         SmtpClient envios = new SmtpClient();

        #region "Variables"
        string emisor;
        string receptor;
        string asunto;
        string ruta;
        string contraseña;
        string mensaje;
        #endregion
        //***********************
        #region "variables de sql"
        SqlConnection conexion;
        SqlCommand sqlCommand;
        #endregion
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        #region properties
        public string De
            {
                get
                {
                    return emisor;
                }
                set
                {
                    emisor = value;
                }
            }
            //******************************
            public string Para
            {
                get
                {
                   return receptor;
                }
                set
                {
                    receptor = value;
                }
            }
            //******************************
        public string asunt
        {
            get
            {
                return asunto;
            }
            set
            {
                asunto = value;
            }
        }
        //************************************
        public string file
        {
            get
            {
                return ruta;
            }
            set
            {
                ruta= value;
            }
        }
        //************************************
        public string password
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }
        //************************************
        public string message
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }
        //************************************
        #endregion

        //*****************************************************
        public void con()
        {
            conexion = new SqlConnection(@"Data Source=ANDREYSZ\SQLEXPRESS;Initial Catalog=facturacion;User ID=andreysz;Password=andre3093sa;");
            conexion.Open();
        }
        //****************************************************
        public void CorreoGmail()
        {
            try
            {
                email.To.Clear();
                email.Body = "";
                email.Subject = "";
                email.Body = mensaje;
                email.Subject = asunto;
                email.IsBodyHtml = true;
                email.To.Add(receptor.Trim());

                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    email.Attachments.Add(archivo);
                }

                email.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                //Datos importantes no modificables para tener acceso a las cuentas

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(email);
                MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //****************************************************
        public void InsertarBD()
        {
            //validacion de datos 
            //try
            //{
                string instruccion;
                instruccion = "insert into EnvioCorreo";
                instruccion = instruccion + "(Correo,receptor,asunto,archivo,descripcion)";
                instruccion = instruccion + "values (@Correo,@receptor,@asunto,@archivo,@descripcion)";
                con();
            

                sqlCommand = new SqlCommand(instruccion, conexion);
                sqlCommand.Parameters.AddWithValue("@Correo", emisor);
                sqlCommand.Parameters.AddWithValue("@receptor", receptor);
                sqlCommand.Parameters.AddWithValue("@asunto", asunto);
                sqlCommand.Parameters.AddWithValue("@archivo", ruta);
                sqlCommand.Parameters.AddWithValue("@descripcion", mensaje);
                sqlCommand.ExecuteNonQuery();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message,"Error al insertar datos en la base de Datos",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            conexion.Close();
        }

        public void recibirCorreos()
        {

        }
        //****************************************************
    }
}
