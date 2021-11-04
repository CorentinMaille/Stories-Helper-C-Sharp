using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Team : Model
    {
        protected int rowid;
        protected string name;
        protected int fk_organization;
        protected int fk_projet;
        protected List<User> list_users = new List<User>();

        public Team(int idTeam = -1)
        {
            if(idTeam != -1)
            {
                fetch(idTeam);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idTeam", idTeam);
                string sql = "SELECT u.rowid, u.lastname, u.firstname, u.birth, u.password, u.fk_position, u.email, u.fk_organization";
                sql += " FROM users AS u";
                sql += " LEFT JOIN belong_to AS b ON u.rowid = b.fk_user";
                sql += " WHERE b.fk_team = @idTeam";
                command.CommandText = sql;
                MySqlDataReader users = command.ExecuteReader();
                while (users.Read())
                {
                    User user = new User(users.GetInt32(0));
                    list_users.Add(user);
                }
                conn.Close();
            }
        }
        public int getRowId()
        {
            return rowid;
        }
        public string getname()
        {
            return name;
        }
        public void setName(string newName)
        {
            name = newName;
        }
        public int getFkOrganization()
        {
            return fk_organization;
        }
        public void setFkOrganization(int newFkOrganization)
        {
            fk_organization = newFkOrganization;
        }        
        public int getFkProjet()
        {
            return fk_projet;
        }
        public void setFkProjet(int newFkProjet)
        {
            fk_organization = newFkProjet;
        }        
        public List<User> getListUsers()
        {
            return list_users;
        }
        public void setListUsers(List<User> newListUsers)
        {
            list_users = newListUsers;
        }

        public void fetch(int idTeam)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idTeam);
            string sql = "SELECT *";
            sql += " FROM teams ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                fk_organization = reader.GetInt32(2);
                fk_projet = reader.GetInt32(3);
            }
            conn.Close();
        }

        // a déplacer dans models/projects //

        /*       public List<Team> fetchByProjectId(int fk_project)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand command = conn.CreateCommand();
                        command.Parameters.AddWithValue("@id", fk_project);
                        string sql = "SELECT t.rowid, t.name, t.fk_organization, t.fk_project";
                        sql += " FROM teams AS t";
                        sql += " WHERE t.fk_project = ?";
                        command.CommandText = sql;
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            List<Team> list_team = new List<Team>()
                            {
                                Team team = new Team(reader.GetInt32(0));
                                list_team.Add(team);
                            };
                        }
                    }
                    catch (Exception)
                    {
                        List<Team> list_team = new List<Team>();

                        return list_team;
                    }
        return 
                }*/
    }


}
