using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Models
{
    class Admin : User
    {
        public Admin(int idUser = -1)
        {
            if (idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                string sql = "SELECT u.rowid, u.password. u.email, u.fk_organization";
                sql += " FROM storieshelper_user ";
                sql += "WHERE rowid = @id";
                sql += "AND admin = 1";
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rowid = reader.GetInt32(0);
                    password = reader.GetString(1);
                    email = reader.GetString(2);
                    fk_organization = reader.GetInt32(3);
                }
                conn.Close();
            }
        }
    }
}
