using System;
using System.Data;

namespace ZooApp
{
    class Zoologico
    {
        Conexion conn = new Conexion();

        public void Login()
        {
            DataRow[] dt = conn.readQuery("select * from Usrs", "Usrs", true);

            if (dt.Length == 1)
            {
                Console.WriteLine("Users Exist");
            }
            else
            {
                Console.WriteLine("Users No Exist");
            }
        }

        public void Register()
        {
            bool set = conn.setData(String.Format("insert into Usrs (Usr, Pass, Email) values ('{0}', '{1}', '{2}')","Stanley", "stanley123", "johansson.05@hotmail.com"));

            if (set)
            {
                Console.WriteLine("Insert Success");
            }
            else
            {
                Console.WriteLine("Insert Fail");
            }
        }
    }
}
