using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Team : Model
    {
        protected int rowid;
        protected string name;
        protected int fk_project;
        protected List<User> list_users = new List<User>();
        protected List<Column> list_columns = new List<Column>();
        protected bool active;

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
        public int getProject()
        {
            return fk_project;
        }
        public void setProject(int newProject)
        {
            fk_project = newProject;
        }        
        public List<User> getListUsers()
        {
            return list_users;
        }
        public void setListUsers(List<User> newListUsers)
        {
            list_users = newListUsers;
        }
        public List<Column> getListColumns()
        {
            return list_columns;
        }
        public void setListColumns(List<Column> newListColumns)
        {
            list_columns = newListColumns;
        }
        public bool isActive()
        {
            return active;
        }
        public void setActive(bool newActive)
        {
            this.active = newActive;
        }
        public void fetch(int idTeam)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idTeam);
            string sql = "SELECT *";
            sql += " FROM team ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                fk_project = reader.GetInt32(2);
                active = reader.GetBoolean(3);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM user AS u";
            sql2 += " LEFT JOIN belong_to AS b ON u.rowid = b.fk_user";
            sql2 += " WHERE b.fk_team = @idTeam";
            command2.CommandText = sql2;
            MySqlDataReader users = command2.ExecuteReader();
            while (users.Read())
            {
                User user = new User();
                user.initializedUser(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(6), users.GetInt32(7), users.GetBoolean(10));
                list_users.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idTeam", idTeam);
            string sql3 = "SELECT *";
            sql3 += " FROM map_column";
            sql3 += " WHERE fk_team = @idTeam";
            command3.CommandText = sql3;
            MySqlDataReader columns = command3.ExecuteReader();
            while (columns.Read())
            {
                Column column = new Column();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
        }

        public void initializedTeam(int idTeam, string name, int fk_project, bool active)
        {
            this.rowid = idTeam;
            this.name = name;
            this.fk_project = fk_project;
            this.active = active;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", idTeam);
            string sql = "SELECT *";
            sql += " FROM user AS u";
            sql += " LEFT JOIN belong_to AS b ON u.rowid = b.fk_user";
            sql += " WHERE b.fk_team = @idTeam";
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while(users.Read())
            {
                User user = new User();
                user.initializedUser(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(6), users.GetInt32(7), users.GetBoolean(10));
                list_users.Add(user);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idTeam", idTeam);
            string sql2 = "SELECT *";
            sql2 += " FROM map_column";
            sql2 += " WHERE fk_team = @idTeam";
            command2.CommandText = sql2;
            MySqlDataReader columns = command2.ExecuteReader();
            while (columns.Read())
            {
                Column column = new Column();
                column.initializedColumn(columns.GetInt32(0), columns.GetString(1), columns.GetInt32(2), columns.GetInt32(3));
                list_columns.Add(column);
            }
            conn.Close();
        }
    }
}
