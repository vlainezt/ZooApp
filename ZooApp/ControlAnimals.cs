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

        public bool updateAnimal(int IdAnimal, string Nombre, string NombreCientifico, int IdGenero, int IdEspecie, int IdHabitat, string FechaNac)
        {
            string Query = string.Format("UPDATE Animals SET Nombre = '{0}', NombreCientifico = '{1}', IdGenero = {2}, IdEspecie = {3}, IdHabitat = {4}, FechaNac = '{5}' WHERE IdAnimal = {6}", Nombre, NombreCientifico, IdGenero, IdEspecie, IdHabitat, FechaNac, IdAnimal);
            return conn.setData(Query);
        }

        public bool removeAnimal(int IdAnimal)
        {
            string Query = string.Format("DELETE FROM Animals WHERE IdAnimal = {0}", IdAnimal);
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

        public DataSet getRatingHabitat(string asc_or_desc = "ASC")
        {
            string Query = "SELECT COUNT(*) as Cantidad, Habitat FROM Animals, Habitat WHERE Animals.IdHabitat = Habitat.IdHabitat GROUP BY Habitat ORDER BY Cantidad " + asc_or_desc;
            return conn.readQuery(Query, "Habitat");
        }

        public DataSet getRatingEspecie(string asc_or_desc = "DESC")
        {
            string Query = "SELECT TOP 3 COUNT(*) AS Cantidad, Especie FROM Animals, Especie WHERE Animals.IdEspecie = Especie.IdEspecie GROUP BY Especie ORDER BY Cantidad " + asc_or_desc;
            return conn.readQuery(Query, "Especie");
        }

    }
}
