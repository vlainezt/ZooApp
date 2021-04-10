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
    public partial class AllAnimals : Form
    {
        public AllAnimals()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            loadAnimal("Agregar Animal");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            loadAnimal("Modificar Animal");
        }

        private void loadAnimal(string letter)
        {
            if(letter == "Modificar Animal")
            {
                //aca se envian los datos al otro formulario
            }
            Animal animalF = new Animal();
            animalF.lblAnimal.Text = letter;
            animalF.Show();
        }
    }
}
