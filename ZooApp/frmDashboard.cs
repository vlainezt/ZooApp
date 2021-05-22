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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerFrom form = new registerFrom();
            form.Show();
            this.Hide();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            changeForms(new frmInicio());
        }

        private void btnExitDash_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMInimizedDash_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width == 250)
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 77;
                line.Width = 77;
                pnlSidebarMenu.Width = 97;
                animationMenuMIn.Show(pnlMenu);
            }
            else
            {
                pnlMenu.Visible = false;
                pnlMenu.Width = 250;
                line.Width = 250;
                pnlSidebarMenu.Width = 300;
                animationMenuMax.Show(pnlMenu);

            }
        }

        public void changeForms(Object fh)
        {
            if(pnlForms.Controls.Count > 0)
            {
                pnlForms.Controls.Clear();
            }

            pnlForms.Visible = false;
            Form nfh = fh as Form;
            nfh.TopLevel = false;
            nfh.Dock = DockStyle.Fill;
            pnlForms.Controls.Add(nfh);
            pnlForms.Tag = nfh;
            nfh.Show();
            animationFroms.Show(pnlForms);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            changeForms(new frmInicio());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            changeForms(new registerFrom());
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            changeForms(new AllAnimals());

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            changeForms(new Grafica());

        }
    }
}
