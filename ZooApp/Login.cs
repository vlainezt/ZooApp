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

        public bool VerifyEmail(string email)
        {
            string query = String.Format("SELECT * FROM Usrs WHERE Usr='{0}'", email);
            DataRow[] dt = conn.readQuery(query, "Usrs", true);

            return dt.Length == 1 ? true : false;

        }

        public bool changePassword (string newPassword, string email)
        {
            string query = String.Format("SELECT * FROM Usrs WHERE Usr='{0}'", email);
            DataRow[] dt = conn.readQuery(query, "Usrs", true);

            if (dt.Length == 1)
            {
                DataRow dtAlone = dt[0];
                int identifier = int.Parse(dtAlone[0].ToString().Trim());

                return updatePassword(newPassword, identifier);
            }
            else
            {
                return false;
            }

        }

        private bool updatePassword(string password, int id)
        {
            string query = String.Format("UPDATE Usrs SET Pass = '{0}' WHERE Id={1}", password, id);
            bool isInsert = conn.setData(query);

            return isInsert;

        }
    }
}
