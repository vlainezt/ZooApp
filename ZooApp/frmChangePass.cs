using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class frmChangePass : Form
    {

        Login login = new Login();
        private string emailRecover;

        public frmChangePass(string emailRecover)
        {
            InitializeComponent();

            this.emailRecover = emailRecover;
        }

        private void btnSendRecoverEmail_Click(object sender, EventArgs e)
        {

            string newPass = txtNewPass.Text.Trim();
            string repeatPass = txtRepeatPass.Text.Trim();

            if(String.IsNullOrEmpty(newPass) && String.IsNullOrEmpty(repeatPass))
            {
                MessageBox.Show("Faltan datos por llenar", "Recuperando contraseña", MessageBoxButtons.OK);
            }
            else
            {
                if(newPass == repeatPass)
                {
                    bool validate_changePass = login.changePassword(newPass, emailRecover);

                    if (validate_changePass)
                    {
                        MessageBox.Show("Contraseña actualizada con exito, vuelva a iniciar sesion", "Cambio de contraseña", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualiza la contraseña, intente de nuevo", "Cambio de contraseña", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Cambio de contraseña", MessageBoxButtons.OK);
                }
            }



        }
    }
}
