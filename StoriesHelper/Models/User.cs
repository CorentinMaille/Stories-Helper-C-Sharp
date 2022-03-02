using MySql.Data.MySqlClient;
using System;

namespace StoriesHelper.Models
{
    class User : Model 
    {
        protected int rowid;
        protected string email;
        protected string password;
        protected int fk_organization;
        protected int admin;

        public int getRowId()
        {
            return rowid;
        }
        public void setRowId(int newRowid)
        {
            rowid = newRowid;
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
        public int getOrganization()
        {
            return fk_organization;
        }
        public void setFkOrganization(int newOrganization)
        {
            fk_organization = newOrganization;
        }
    }
}
