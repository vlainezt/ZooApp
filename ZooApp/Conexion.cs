using System;
using System.Data;
using System.Data.SqlClient;

namespace ZooApp
{
    class Conexion
    {

        private static SqlConnection conexion()
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\zooapp\\ZooApp\\Zoo.mdf; Integrated Security = True");
            //SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\Zoo.mdf; Integrated Security = True");
            return conn;
        }

        public DataSet readQuery(string query, string table)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conexion()); //Estableciendo puente
            DataSet ds = new DataSet();
            da.Fill(ds, table); //LLenando nuestrp DataSet

            return ds;
        }

        public DataRow[] readQuery(string query, string table, bool datarow)
        {
            DataTable tb = readQuery(query, table).Tables[table];
            DataRow[] rows = tb.Select();

            return rows;
        }

        public bool setData(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion());
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
