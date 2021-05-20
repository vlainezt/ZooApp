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
    public partial class PasswordCode : Form
    {
        private string emailRecover;
        private int codeSave;

        public PasswordCode( int code, string emailRecover )
        {
            InitializeComponent();

            this.emailRecover = emailRecover;
            this.codeSave = code;
        }

        private void btnCloseRevEmail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPassCode_Click(object sender, EventArgs e)
        {
            string verifiedCode = txtPassCode.Text.Trim();

            if(codeSave.ToString() == verifiedCode)
            {
                frmChangePass changePass = new frmChangePass(emailRecover);
                changePass.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Codigo invalido", "Recuperando contraseña", MessageBoxButtons.OK);
            }
        }
    }
}
