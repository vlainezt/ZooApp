using System;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Grafica : Form
    {
        ControlAnimals controls = new ControlAnimals();
        //controls.getRatingHabitat(); Pasale DESC si queres que sea descendiente como string
        //controls.getRatingEspecie(); Pasale ASC si queres que sea ascendente como string

        public Grafica()
        {
            InitializeComponent();
            
        }

        private void Grafica_Load(object sender, EventArgs e)
        {

        }
    }
}
