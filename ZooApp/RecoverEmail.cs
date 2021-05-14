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
            PasswordCode PCform = new PasswordCode();
            PCform.Show();
        }

        
    }
}
