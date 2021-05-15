using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class RecoverEmail : Form
    {
        Login login = new Login();
        const string emailSupport = "hiperefe.contact@gmail.com";
        const string passSupport = "hiperEFE2020";

        public RecoverEmail()
        {
            InitializeComponent();
        }

        private void btnCloseRevEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendRecoverEmail_Click(object sender, EventArgs e)
        {

            string emailRecover = txtRecoverEmail.Text.Trim();

            if (String.IsNullOrEmpty(emailRecover))
            {
                MessageBox.Show("Ingrese un email Valido", "Recuperando contraseña", MessageBoxButtons.OK);
            }
            else
            {
                bool validate_email = login.VerifyEmail(emailRecover);

                if (validate_email)
                {

                    Random random = new Random();
                    int code = random.Next(1000, 9999);

                    sendEmailRecover(code, emailRecover);
                }
                else
                {
                    MessageBox.Show("Email no existe, verifique", "Recuperando contraseña", MessageBoxButtons.OK);
                }
            }
        }

        private void sendEmailRecover(int code, string emailRecover)
        {
            

            try
            {

                //Prepara los elementos del Email
                MailAddress emailDe = new MailAddress(emailSupport, "ZooApp El Tukano");
                MailAddress emailPara = new MailAddress(emailRecover);
                string asunto = "Restablecer Contraseña - ZooApp El Tukano";
                string mensaje = "Se ha solicitado restablecer la contraseña de su cuenta El Tukano, Su codigo de verificaciones es: " + code +
                    ". Si usted no ha solicitado restablecer la contraseña, ignore el email o pongase en contacto con nosotros";

                //Configurar servidor SMTP de Gmail
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(emailSupport, passSupport);

                //Configurar el Email
                MailMessage email = new MailMessage(emailDe, emailPara);
                email.Subject = asunto;
                email.Body = mensaje;

                //Enviar el Email
                smtp.Send(email);
                MessageBox.Show("Se le enviando un correo de verificacion, revise su bandeja de entrada", "Recuperando contraseña", MessageBoxButtons.OK);

                //Abrimos el formulario para verificar el codigo
                PasswordCode PCform = new PasswordCode(code, emailRecover);
                PCform.Show();

                this.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show("Error en el envio, Verifique su conexion a internet", "Recupeando contraseña", MessageBoxButtons.OK);
                Console.WriteLine(e);
            }

        }

        
    }
}
