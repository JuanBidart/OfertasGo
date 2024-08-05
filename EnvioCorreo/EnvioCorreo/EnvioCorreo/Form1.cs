using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioCorreo
{
    public partial class Form1 : Form
    {
        private string myEmail = "juandi_b@hotmail.com";
        private string MyPassword = "juan/1458";
        private string MyAlias = "Juan Diego";
        private string[] myAdjuntos;
        private MailMessage mCorreo;

        public Form1()
        {
            InitializeComponent();
        }

        private void CrearCuerpoCorreo()
        {
            try
            {
                mCorreo = new MailMessage();
                mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
                mCorreo.To.Add(txtEmailFrom.Text.Trim());
                mCorreo.Subject = txtSubject.Text.Trim();
                mCorreo.Body = txtMessage.Text.Trim();
                mCorreo.IsBodyHtml = true;
                mCorreo.Priority = MailPriority.Normal;

                // Adjuntos
                if (myAdjuntos != null)
                {
                    for (int i = 0; i < myAdjuntos.Length; i++)
                    {
                        mCorreo.Attachments.Add(new Attachment(myAdjuntos[i]));
                    }
                }
                    
            }
            catch (Exception e)
            {

               
            }
            

        }

        private void Enviar() 
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Credentials = new System.Net.NetworkCredential(myEmail, MyPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
                MessageBox.Show("Enviado");
                lblFiles.Text = "";
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
         
        }

        private void AdjuntarArchivos() 
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar archivos al correo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myAdjuntos = ofd.FileNames;
            }

            for (int i = 0; i < myAdjuntos.Length; i++)
            {
                names += myAdjuntos[i] + "\n";
            }

            lblFiles.Text = names;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            Enviar();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }
    }
}
