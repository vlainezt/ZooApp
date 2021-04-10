using System.Data;

namespace ZooApp
{
    class ControlAnimals
    {

        Conexion conn = new Conexion();

        public bool newAnimal(string Nombre, string NombreCientifico, int IdGenero, int IdEspecie, int IdHabitat, string FechaNac)
        {
            string Query = string.Format("INSERT INTO Animals (Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac) VALUES ('{0}', '{1}', {2}, {3}, {4}, '{5}')", Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac);
            return conn.setData(Query);
        }

        public DataSet getAnimals()
        {
            string Query = "SELECT IdAnimal, Genero.IdGenero, Especie.IdEspecie, Habitat.IdHabitat, Nombre, NombreCientifico, Genero, Especie, Habitat, FechaNac FROM Animals, Especie, Genero, Habitat WHERE Animals.IdGenero = Genero.IdGenero AND Animals.IdEspecie = Especie.IdEspecie AND Animals.IdHabitat = Habitat.IdHabitat";
            return conn.readQuery(Query, "Animal");
        }

        public DataSet getGenero()
        {
            string Query = "SELECT * FROM Genero";
            return conn.readQuery(Query, "Genero");
        }

        public DataSet getEspecie()
        {
            string Query = "SELECT * FROM Especie";
            return conn.readQuery(Query, "Especie");
        }

        public DataSet getHabitat()
        {
            string Query = "SELECT * FROM Habitat";
            return conn.readQuery(Query, "Habitat");
        }

    }
}
