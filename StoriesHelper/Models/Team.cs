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
        protected int fk_project;
        protected List<User> list_users = new List<User>();
        protected List<MapColumns> list_columns = new List<MapColumns>();

        public Team(int idTeam = -1)
        {
            if(idTeam != -1)
            {
                fetch(idTeam);
            }
        }
        public int getRowId()
        {
            return rowid;
        }
        public int setRowId()
        {
            return rowid;
        }
        public string getName()
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
        public int getFkProject()
        {
            return fk_project;
        }
        public void setFkProject(int newFkProject)
        {
            fk_project = newFkProject;
        }        
        public List<User> getListUsers()
        {
            return list_users;
        }
        public void setListUsers(List<User> newListUsers)
        {
            list_users = newListUsers;
        }
        public List<MapColumns> getListColumns()
        {
            return list_columns;
        }
        public void setListColumns(List<MapColumns> newListColumns)
        {
            list_columns = newListColumns;
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
                fk_project = reader.GetInt32(3);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM users AS u";
            sql2 += " LEFT JOIN belong_to AS b ON u.rowid = b.fk_user";
            sql2 += " WHERE b.fk_team = @idTeam";
            command2.CommandText = sql2;
            MySqlDataReader users = command2.ExecuteReader();
            while (users.Read())
            {
                User user = new User();
                user.initializedUser(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(6), users.GetInt32(7));
                list_users.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idTeam", idTeam);
            string sql3 = "SELECT *";
            sql3 += " FROM map_columns";
            sql3 += " WHERE fk_team = @idTeam";
            command3.CommandText = sql3;
            MySqlDataReader columns = command3.ExecuteReader();
            while (columns.Read())
            {
                MapColumns column = new MapColumns();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
        }

        public void initializedTeam(int idTeam, string name, int fk_organization, int fk_project)
        {
            this.rowid = idTeam;
            this.name = name;
            this.fk_organization = fk_organization;
            this.fk_project = fk_project;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", idTeam);
            string sql = "SELECT u.rowid, u.lastname, u.firstname, u.birth, u.password, u.fk_position, u.email, u.fk_organization";
            sql += " FROM users AS u";
            sql += " LEFT JOIN belong_to AS b ON u.rowid = b.fk_user";
            sql += " WHERE b.fk_team = @idTeam";
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while(users.Read())
            {
                User user = new User();
                user.initializedUser(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(6), users.GetInt32(7));
                list_users.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM map_columns";
            sql2 += " WHERE fk_team = @idTeam";
            command2.CommandText = sql2;
            MySqlDataReader columns = command2.ExecuteReader();
            while (columns.Read())
            {
                MapColumns column = new MapColumns();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
        }
    }
}
