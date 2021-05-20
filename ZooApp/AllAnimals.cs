using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class AllAnimals : Form
    {

        ControlAnimals Control = new ControlAnimals();

        public AllAnimals()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            loadAnimal();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            loadAnimal();
        }

        public void Animal_FormClosed(object sender, FormClosedEventArgs e)
        {
            getAnimals();
        }

        private void loadAnimal()
        {
            Animal animalF = new Animal();
            animalF.FormClosed += Animal_FormClosed;
            animalF.Show(); 
        }

        private void loadAnimal(string id, string Nombre, string NombreC, string Genero, string Especie, string Habitat, string FechaNac)
        {
            Animal animalF = new Animal(id, Nombre, NombreC, Genero, Especie, Habitat, FechaNac);
            animalF.FormClosed += Animal_FormClosed;
            animalF.Show();
        }

        private void AllAnimals_Load(object sender, EventArgs e)
        {
            getAnimals();
        }

        private void getAnimals()
        {
            DataSet ds = Control.getAnimals();

            dgvAnimalList.DataSource = ds.Tables[0].DefaultView;
            dgvAnimalList.Columns[0].Visible = false;
            dgvAnimalList.Columns[1].Visible = false;
            dgvAnimalList.Columns[2].Visible = false;
            dgvAnimalList.Columns[3].Visible = false;

        }

        private void dgvAnimalList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string
                id = dgvAnimalList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Genero = dgvAnimalList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Especie = dgvAnimalList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Habitat = dgvAnimalList.Rows[e.RowIndex].Cells[3].Value.ToString(),
                Nombre = dgvAnimalList.Rows[e.RowIndex].Cells[4].Value.ToString(),
                NombreC = dgvAnimalList.Rows[e.RowIndex].Cells[5].Value.ToString(),
                FechaNac = dgvAnimalList.Rows[e.RowIndex].Cells[9].Value.ToString();

            loadAnimal(id, Nombre, NombreC, Genero, Especie, Habitat, FechaNac);
        }
    }
}
