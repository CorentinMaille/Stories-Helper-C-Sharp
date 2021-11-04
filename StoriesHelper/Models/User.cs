using MySql.Data.MySqlClient;
using System;

namespace StoriesHelper.Models
{
    class User : Model
    {
        protected int rowid;
        protected string firstname;
        protected string lastname;
        protected string email;
        protected string password;
        protected DateTime birth;
        protected int fk_organisation;

        public User(int idUser = -1)
        {
            if(idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                string sql = "SELECT *";
                sql += " FROM users ";
                sql += "WHERE rowid = @id";
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rowid = reader.GetInt32(0);
                    firstname = reader.GetString(1);
                    lastname = reader.GetString(2);
                    birth = reader.GetDateTime(3);
                    password = reader.GetString(4);
                    email = reader.GetString(6);
                    fk_organisation = reader.GetInt32(7);
                }
                conn.Close();
            }
        }

        public int getRowId()
        {
            return rowid;
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
        public int getFkOrganization()
        {
            return fk_organisation;
        }
        public void setFkOrganization(int newIdOrganization)
        {
            fk_organisation = newIdOrganization;
        }

    }
}
