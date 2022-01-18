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
        protected bool admin;

        public User(int idUser = -1)
        {
            if(idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                string sql = "SELECT *";
                sql += " FROM user ";
                sql += "WHERE rowid = @id";
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rowid = reader.GetInt32(0);
                    lastname = reader.GetString(1);
                    firstname = reader.GetString(2);
                    birth = reader.GetDateTime(3);
                    password = reader.GetString(4);
                    email = reader.GetString(6);
                    fk_organisation = reader.GetInt32(7);
                    admin = reader.GetBoolean(10);
                }
                conn.Close();
            }
        }
        public void initializedUser(int idUser, string firstname, string lastname, DateTime birth, string password, string email, int fk_orgnaization, bool admin)
        {
            this.rowid = idUser;
            this.lastname = lastname;
            this.firstname = firstname;
            this.birth = birth;
            this.password = password;
            this.email = email;
            this.fk_organisation = fk_orgnaization;
            this.admin = admin;
        }
        public int getRowId()
        {
            return rowid;
        }
        public void setRowId(int newRowid)
        {
            rowid = newRowid;
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
        public int getOrganization()
        {
            return fk_organisation;
        }
        public void setFkOrganization(int newOrganization)
        {
            fk_organisation = newOrganization;
        }
        public bool getAdmin()
        {
            return admin;
        }
        public void setAdmin(bool newAdmin)
        {
            admin = newAdmin;
        }
    }
}
