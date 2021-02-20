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
        public Form1()
        {
            InitializeComponent();
            Zoologico zooConfig = new Zoologico();
            zooConfig.Login();
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
            registerFrom formRegister = new registerFrom();
            formRegister.Show();
            this.Hide();
        }
    }
}
