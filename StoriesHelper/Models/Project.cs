using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Project : Model
    {
        protected int rowid;
        protected string name;
        protected string type;
        protected DateTime open;
        protected int fk_organization;
        protected string description;
        protected List<Team> list_team = new List<Team>();
        protected int active;

        public Project(int idProject = -1)
        {
            if(idProject != -1)
            {
                fetch(idProject);
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
        public string getType()
        {
            return type;
        }
        public void setType(string newName)
        {
            type = newName;
        }
        public DateTime getOpen()
        {
            return open;
        }
        public void setOpen(DateTime newOpen)
        {
            open = newOpen;
        }
        public string getDescription()
        {
            return description;
        }
        public void setDescription(string newDescription)
        {
            description = newDescription;
        } 
        public int getActive()
        {
            return active;
        }
        public void setActive(int newActive)
        {
            active = newActive;
        }
        public int getFkOrganization()
        {
            return fk_organization;
        }
        public void setFkOrganization(int newFkOrganization)
        {
            fk_organization = newFkOrganization;
        }
        public List<Team> getListTeams()
        {
            return list_team;
        }
        public void setListTeams(List<Team> newListTeams)
        {
            list_team = newListTeams;
        }

        public void fetch(int idProject)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idProject);
            string sql = "SELECT *";
            sql += " FROM projects ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                type = reader.GetString(2);
                open = reader.GetDateTime(3);
                fk_organization = reader.GetInt32(5);
                description = reader.GetString(6);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idProjet", idProject);
            string sql2 = "SELECT *";
            sql2 += " FROM teams";
            sql2 += " WHERE fk_project = @idProjet";
            command2.CommandText = sql2;
            MySqlDataReader teams = command2.ExecuteReader();
            while (teams.Read())
            {
                Team team = new Team();
                team.initializedTeam(teams.GetInt32(0), teams.GetString(1), teams.GetInt32(2), teams.GetInt32(3));
                list_team.Add(team);
            }
            conn.Close();
        }
    }
}
