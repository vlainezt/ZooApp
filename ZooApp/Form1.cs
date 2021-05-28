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
    public partial class Form1 : Form
    {
        Login zooConfig = new Login();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMInimizedLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogear_Click(object sender, EventArgs e)
        {
            string User = txtUserNameLogin.Text.Trim(),
                Password = txxPasswordLogin.Text.Trim();

            DataRow[] dt = zooConfig.Auth(User, Password);

            if (dt.Length == 1)
            {

                DataRow dtR = dt[0]; //Esto se convierte como un array

                // Los para sacar sus varoles es:
                // dtR[indice].ToString().Trim()
                // En donde:
                // dtR[0] ===> Id
                // dtR[1] ===> Email
                // dtR[2] ===> Password

                frmDashboard form = new frmDashboard();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }

        }

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverEmail REform = new RecoverEmail();
            REform.Show();

        }
    }
}
