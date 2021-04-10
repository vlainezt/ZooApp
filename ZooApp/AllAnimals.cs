using System;
using System.Data;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class AllAnimals : Form
    {

        ControlAnimals control = new ControlAnimals();

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

        public void Animal_FormClosed(object sender, FormClosedEventArgs e)
        {
            getAnimals();
        }

        private void loadAnimal(string letter = "Nuevo")
        {
            if(letter == "Modificar")
            {
                Animal animalF = new Animal();
                animalF.lblAnimal.Text = letter;
                animalF.FormClosed += Animal_FormClosed;
                animalF.Show();
            }
            else
            {
                Animal animalF = new Animal();
                animalF.lblAnimal.Text = letter;
                animalF.FormClosed += Animal_FormClosed;
                animalF.Show();
            }
            
        }

        private void AllAnimals_Load(object sender, EventArgs e)
        {
            getAnimals();
        }

        public void getAnimals()
        {
            DataSet ds = control.getAnimals();

            dgvAnimalList.DataSource = ds.Tables[0].DefaultView;
            dgvAnimalList.Columns[0].Visible = false;
        }

        private void dgvAnimalList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Id = dgvAnimalList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Nombre = dgvAnimalList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                NombreCientifico = dgvAnimalList.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Genero = dgvAnimalList.Rows[e.RowIndex].Cells[3].Value.ToString(),
                Especie = dgvAnimalList.Rows[e.RowIndex].Cells[4].Value.ToString(),
                Habitat = dgvAnimalList.Rows[e.RowIndex].Cells[5].Value.ToString(),
                FechaNac = dgvAnimalList.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
