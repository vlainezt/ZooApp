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

            bool result = zooConfig.Auth(User, Password);

            if (result)
            {
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
