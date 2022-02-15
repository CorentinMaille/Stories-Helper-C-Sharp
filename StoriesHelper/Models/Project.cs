using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
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
        protected List<Team> list_teams = new List<Team>();
        protected bool active;

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
        public void setRowid(int newRowid)
        {
            rowid = newRowid;
        }
        public string getName()
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
        public bool isActive()
        {
            return active;
        }
        public void setActive(bool newActive)
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
            return list_teams;
        }
        public void setListTeams(List<Team> newListTeams)
        {
            list_teams = newListTeams;
        }

        public void fetch(int idProject)
        {
            // récupère les informations du projet
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idProject);
            string sql = "SELECT *";
            sql += " FROM storieshelper_project ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string projectDescription = "";
                if (!reader.IsDBNull(5))
                {
                    projectDescription = reader.GetString(5);
                }
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                type = reader.GetString(2);
                open = reader.GetDateTime(3);
                fk_organization = reader.GetInt32(4);
                description = projectDescription;
                active = reader.GetBoolean(6);
            }
            conn.Close();
            //initialise les teams du projet
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idProjet", idProject);
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_team";
            sql2 += " WHERE fk_project = @idProjet";
            command2.CommandText = sql2;
            MySqlDataReader teams = command2.ExecuteReader();
            while (teams.Read())
            {
                Team team = new Team();
                team.initializedTeam(teams.GetInt32(0), teams.GetString(1), teams.GetInt32(2), teams.GetBoolean(3));
                list_teams.Add(team);
            }
            conn.Close();
        }

        public void initializedProject(int rowid, string name, string type, DateTime open, int fk_organization, string description, bool active)
        {
            this.rowid = rowid;
            this.name = name;
            this.type = type;
            this.open = open;
            this.fk_organization = fk_organization;
            this.description = description;
            this.active = active;

            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idProjet", rowid);
            string sql2 = "SELECT *";
            sql2 += " FROM storieshelper_team";
            sql2 += " WHERE fk_project = @idProjet";
            command2.CommandText = sql2;
            MySqlDataReader teams = command2.ExecuteReader();
            while (teams.Read())
            {
                Team team = new Team();
                team.initializedTeam(teams.GetInt32(0), teams.GetString(1), teams.GetInt32(2), teams.GetBoolean(3));
                list_teams.Add(team);
            }
            conn.Close();
        }

        public void delete()
        {
            // supprime les liens team/utilisateur
            conn.Open();
            MySqlCommand deleteBelongTo = conn.CreateCommand();
            string sql = "DELETE mc FROM storieshelper_map_column mc ";
            sql += "INNER JOIN storieshelper_team tm ON tm.rowid = mc.fk_team ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteBelongTo.Parameters.AddWithValue("@rowid", rowid);
            deleteBelongTo.CommandText = sql;
            deleteBelongTo.ExecuteNonQuery();
            conn.Close();
            // supprime les liens team/utilisateur
            conn.Open();
            MySqlCommand deleteTaskMember = conn.CreateCommand();
            sql = "DELETE tkm FROM storieshelper_task_member tkm ";
            sql += "INNER JOIN storieshelper_task tk ON tk.rowid = tkm.fk_task ";
            sql += "INNER JOIN storieshelper_map_column mc ON mc.rowid = tk.fk_column ";
            sql += "INNER JOIN storieshelper_team tm ON tm.rowid = mc.fk_team ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteTaskMember.Parameters.AddWithValue("@rowid", rowid);
            deleteTaskMember.CommandText = sql;
            deleteTaskMember.ExecuteNonQuery();
            conn.Close();
            // supprime les commentaires
            conn.Open();
            MySqlCommand deleteComments = conn.CreateCommand();
            sql = "DELETE tc FROM storieshelper_task_comment tc ";
            sql += "INNER JOIN storieshelper_task tk ON tk.rowid = tc.fk_task ";
            sql += "INNER JOIN storieshelper_map_column mc ON mc.rowid = tk.fk_column ";
            sql += "INNER JOIN storieshelper_team tm ON tm.rowid = mc.fk_team ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteComments.Parameters.AddWithValue("@rowid", rowid);
            deleteComments.CommandText = sql;
            deleteComments.ExecuteNonQuery();
            conn.Close();
            // supprime les tâches
            conn.Open();
            MySqlCommand deleteTasks = conn.CreateCommand();
            sql = "DELETE tk FROM storieshelper_task tk ";
            sql += "INNER JOIN storieshelper_map_column mc ON mc.rowid = tk.fk_column ";
            sql += "INNER JOIN storieshelper_team tm ON tm.rowid = mc.fk_team ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteTasks.Parameters.AddWithValue("@rowid", rowid);
            deleteTasks.CommandText = sql;
            deleteTasks.ExecuteNonQuery();
            conn.Close();
            // supprime les colonnes
            conn.Open();
            MySqlCommand deleteColumns = conn.CreateCommand();
            sql = "DELETE mc FROM storieshelper_map_column mc ";
            sql += "INNER JOIN storieshelper_team tm ON tm.rowid = mc.fk_team ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteColumns.Parameters.AddWithValue("@rowid", rowid);
            deleteColumns.CommandText = sql;
            deleteColumns.ExecuteNonQuery();
            conn.Close();
            // supprime les teams
            conn.Open();
            MySqlCommand deleteTeams = conn.CreateCommand();
            sql = "DELETE tm FROM storieshelper_team tm ";
            sql += "INNER JOIN storieshelper_project p ON p.rowid = tm.fk_project ";
            sql += "WHERE p.rowid = @rowid ";
            deleteTeams.Parameters.AddWithValue("@rowid", rowid);
            deleteTeams.CommandText = sql;
            deleteTeams.ExecuteNonQuery();
            conn.Close();
            // supprime le projet
            conn.Open();
            MySqlCommand delete = conn.CreateCommand();
            sql = "DELETE p FROM storieshelper_project p ";
            sql += "WHERE rowid = @rowid";
            delete.Parameters.AddWithValue("@rowid", rowid);
            delete.CommandText = sql;
            delete.ExecuteNonQuery();
            conn.Close();
        }

        public void update()
        {
            conn.Open();
            MySqlCommand update = conn.CreateCommand();
            string sql = "UPDATE storieshelper_project ";
            sql += "SET ";
            sql += "name = @name, ";
            sql += "type = @type, ";
            sql += "open = @open, ";
            sql += "fk_organization = @fk_organization, ";
            sql += "description = @description, ";
            sql += "active = @active ";
            sql += "WHERE rowid = @rowid";
            update.Parameters.AddWithValue("@name", name);
            update.Parameters.AddWithValue("@type", type);
            update.Parameters.AddWithValue("@open", open);
            update.Parameters.AddWithValue("@fk_organization", fk_organization);
            update.Parameters.AddWithValue("@description", description);
            update.Parameters.AddWithValue("@active", active);
            update.Parameters.AddWithValue("@rowid", rowid);
            update.CommandText = sql;
            update.ExecuteNonQuery();
            conn.Close();
        }
    }
}
