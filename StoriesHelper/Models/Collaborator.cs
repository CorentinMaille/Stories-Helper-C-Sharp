using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Models
{
    class Collaborator : User
    {
        protected string firstname;
        protected string lastname;
        protected DateTime birth;
        public Collaborator(int idUser = -1)
        {
            if (idUser != -1)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", idUser);
                string sql = "SELECT *";
                sql += " FROM storieshelper_user ";
                sql += "WHERE rowid = @id";
                sql += "AND admin = 0";
                command.CommandText = sql;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {   
                    rowid = reader.GetInt32(0);
                    lastname = reader.GetString(1);
                    firstname = reader.GetString(2);
                    birth = reader.GetDateTime(3);
                    password = reader.GetString(4);
                    email = reader.GetString(5);
                    fk_organization = reader.GetInt32(6);
                }
                conn.Close();
            }
        }
        public void initializedCollaborator(int idUser, string lastname, string firstname, DateTime birth, string password, string email, int fk_organization)
        {
            this.rowid = idUser;
            this.lastname = lastname;
            this.firstname = firstname;
            this.birth = birth;
            this.password = password;
            this.email = email;
            this.fk_organization = fk_organization;
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
        public DateTime getBirth()
        {
            return birth;
        }
        public void setBirth(DateTime newBirth)
        {
            birth = newBirth;
        }
    }
}
