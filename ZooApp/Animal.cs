using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Animal : Form
    {
        ControlAnimals Control = new ControlAnimals();

        int Id = 0;
        string nombre;
        string nombreC;
        string genero;
        string especie;
        string habitat;
        string fechaNac;
        string Mode = "New";

        public Animal()
        {
            InitializeComponent();
        }

        public Animal(string id, string Nombre, string NombreC, string Genero, string Especie, string Habitat, string FechaNac)
        {
            Id = int.Parse(id);
            Mode = "Update";

            nombre = Nombre;
            nombreC = NombreC;
            genero = Genero;
            especie = Especie;
            habitat = Habitat;
            fechaNac = FechaNac;

            InitializeComponent();
        }

        private void btnExitAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            DataSet dsGenero = Control.getGenero();
            DataSet dsEspecie = Control.getEspecie();
            DataSet dsHabitat = Control.getHabitat();

            //ComboBox Genero
            cbSex.DataSource = dsGenero.Tables[0];
            cbSex.DisplayMember = "Genero";
            cbSex.ValueMember = "IdGenero";

            //ComboBox Especie
            cbSpecies.DataSource = dsEspecie.Tables[0];
            cbSpecies.DisplayMember = "Especie";
            cbSpecies.ValueMember = "IdEspecie";

            //ComboBox Habitat
            cbHabitat.DataSource = dsHabitat.Tables[0];
            cbHabitat.DisplayMember = "Habitat";
            cbHabitat.ValueMember = "IdHabitat";

            if (Mode == "Update")
            {
                txtAnimalName.Text = nombre;
                txtAnimalNameC.Text = nombreC;
                txtAnimalDate.Text = fechaNac;
            }

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

        private void btnSaveAnimal_Click(object sender, EventArgs e)
        {
            string
                Nombre = txtAnimalName.Text,
                NombreCientifico = txtAnimalNameC.Text,
                FechaNac = txtAnimalDate.Text;

            int
                IdGenero = int.Parse(cbSex.SelectedValue.ToString()),
                IdEspecie = int.Parse(cbSpecies.SelectedValue.ToString()),
                IdHabitat = int.Parse(cbHabitat.SelectedValue.ToString());

            bool isSave = Control.newAnimal(Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac);

            if (isSave)
            {
                //Se almaceno el animal
                this.Close();
            }
            else
            {
                //Error al almacenar el animal
                MessageBox.Show("Error al almacenar un nuevo animal");
            }

        }
    }
}
