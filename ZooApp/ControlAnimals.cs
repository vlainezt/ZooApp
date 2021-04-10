using System.Data;

namespace ZooApp
{
    class ControlAnimals
    {

        Conexion conn = new Conexion();

        public bool newAnimals(string Nombre, string NombreCientifico, int IdGenero, int IdEspecie, int IdHabitat, string FechaNac)
        {
            string query = string.Format("INSERT INTO Animals (Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac) VALUES('{0}', '{1}', {2}, {3}, {4}, '{5}') ", Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac);
            return conn.setData(query);
        }

        public DataSet getAnimals() 
        {
            string query = "SELECT IdAnimal, Nombre, NombreCientifico, Genero, Especie, Habitat, FechaNac FROM Animals, Genero, Especie, Habitat WHERE Animals.IdGenero = Genero.IdGenero AND Animals.IdEspecie = Especie.IdEspecie AND Animals.IdHabitat = Habitat.IdHabitat";
            return conn.readQuery(query, "Animals");
        }

        public DataSet getEspecie()
        {
            string query = "SELECT * FROM Especie";
            return conn.readQuery(query, "Especie");
        }

        public DataSet getGenero()
        {
            string query = "SELECT * FROM Genero";
            return conn.readQuery(query, "Genero");
        }

        public DataSet getHabitat()
        {
            string query = "SELECT * FROM Habitat";
            return conn.readQuery(query, "Habitat");
        }

    }
}
