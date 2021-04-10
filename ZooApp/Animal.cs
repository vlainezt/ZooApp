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
    public partial class Animal : Form
    {
        public Animal()
        {
            InitializeComponent();
        }

        private void btnExitAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Animal_Load(object sender, EventArgs e)
        {

        }

        private void lblAnimal_Click(object sender, EventArgs e)
        {

        }

        private void txtAnimalNameC_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cbHabitat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
