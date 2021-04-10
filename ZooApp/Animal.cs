using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Animal : Form
    {

        ControlAnimals control = new ControlAnimals();

        public Animal()
        {
            InitializeComponent();
        }

        public Animal(string id, string nombre, string nombreCientifico, string genero, string Especie, string Habitat, string FechaNac)
        {
            InitializeComponent();
        }

        private void btnExitAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            DataSet dsEspecie = control.getEspecie();
            DataSet dsGenero = control.getGenero();
            DataSet dsHabitat = control.getHabitat();

            //ComboBox Genero
            cbSex.DataSource = dsGenero.Tables[0];
            cbSex.ValueMember = "IdGenero";
            cbSex.DisplayMember = "Genero";

            //ComboBox Especie
            cbSpecies.DataSource = dsEspecie.Tables[0];
            cbSpecies.ValueMember = "IdEspecie";
            cbSpecies.DisplayMember = "Especie";

            //ComboBox Habitat
            cbHabitat.DataSource = dsHabitat.Tables[0];
            cbHabitat.ValueMember = "IdHabitat";
            cbHabitat.DisplayMember = "Habitat";
        }

        private void btnSaveAnimal_Click(object sender, EventArgs e)
        {
            string Nombre = txtAnimalName.Text,
                NombreCientifico = txtAnimalNameC.Text,
                FechaNac = txtFecha.Text;

            int IdGenero = int.Parse(cbSex.SelectedValue.ToString()),
                IdEspecie = int.Parse(cbSpecies.SelectedValue.ToString()),
                IdHabitat = int.Parse(cbHabitat.SelectedValue.ToString());

            bool resp = control.newAnimals(Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac);

            if (resp)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar los datos");
            }

        }
    }
}
