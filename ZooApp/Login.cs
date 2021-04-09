using System;
using System.Data;

namespace ZooApp
{
    class Login
    {
        Conexion conn = new Conexion();

        public bool Auth(string User, string Password)
        {
            string query = String.Format("select * from Usrs where Usr='{0}' and Pass='{1}'", User, Password);
            DataRow[] dt = conn.readQuery(query, "Usrs", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(string User, string Password, string Email)
        {
            bool set = conn.setData(String.Format("insert into Usrs (Usr, Pass, Email) values ('{0}', '{1}', '{2}')",User,Password, Email));

            return set;
        }
    }
}
