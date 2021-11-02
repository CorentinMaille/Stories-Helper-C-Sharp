using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Modeles
{
    class Users : Model
    {
        private int idUser;
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private DateTime birth;
        private int idOrganization;

        public Users(int idUser)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idUser);
            command.CommandText = "SELECT * FROM users WHERE rowid = @id";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.idUser = reader.GetInt32(0);
                this.firstname = reader.GetString(1);
                this.lastname = reader.GetString(2);
                this.email = reader.GetString(6);
                this.password = reader.GetString(4);
                this.birth = reader.GetDateTime(3);
                this.idOrganization = reader.GetInt32(7);
            }
            conn.Close();
        }
    }
}
