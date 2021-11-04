using MySql.Data.MySqlClient;
using System;

namespace StoriesHelper.Modeles
{
    class User : Model
    {
        int idUser { get; set; }
        string firstname { get; set; }
        string lastname { get; set; }
        string email { get; set; }
        string password { get; set; }
        DateTime birth { get; set; }
        int idOrganization { get; set; }

        public User(int idUser = -1)
        {
            if(idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                command.CommandText = "SELECT * FROM users WHERE rowid = @id";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    this.idUser = reader.GetInt32(0);
                    firstname = reader.GetString(1);
                    lastname = reader.GetString(2);
                    email = reader.GetString(6);
                    password = reader.GetString(4);
                    birth = reader.GetDateTime(3);
                    idOrganization = reader.GetInt32(7);
                }
                conn.Close();
            }
        }

        public int getIdUser()
        {
            return idUser;
        }

        public string getFirstname()
        {
            return firstname;
        }
        public void setFirstname(string newFirstname)
        {
            firstname = newFirstname;
        }
        public string getLastname()
        {
            return lastname;
        }
        public void setLastname(string newLastname)
        {
            lastname = newLastname;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string newEmail)
        {
            email = newEmail;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }
        public DateTime getBirth()
        {
            return birth;
        }
        public void setBirth(DateTime newBirth)
        {
            birth = newBirth;
        }
        public int getIdOrganization()
        {
            return idOrganization;
        }
        public void setIdOrganisation(int newIdOrganization)
        {
            idOrganization = newIdOrganization;
        }
    }
}
