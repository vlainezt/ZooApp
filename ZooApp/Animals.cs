using System.Data;

namespace ZooApp
{
    class Animals
    {
        Conexion conn = new Conexion();

        public bool createAnimal(string Nombre, string NombreCientifico, int Genero, int Especie, int Habitat, string Fecha)
        {

            string query = "insert into Animals (Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac)";

            return false;
        }

        public DataSet getHabitat()
        {
            return conn.readQuery("select * from Habitat", "Habitat");
        }

        public DataSet getEspecie()
        {
            return conn.readQuery("select * from Especie", "Especie");
        }

        public DataSet getGenero()
        {
            return conn.readQuery("select * from Genero", "Genero");
        }

        public DataSet getAnimales()
        {
            return conn.readQuery("select * from Animals", "Animals");
        }

    }
}
