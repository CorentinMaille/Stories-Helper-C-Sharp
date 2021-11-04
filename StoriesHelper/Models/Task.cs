using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Task : Model
    {
        private int rowid;
        private string name;
        private string description;
        private int fk_column;
        private int rank;
        private int fk_author;
        private bool admin;
        private bool active;

        public Task(int taskId = -1)
        {
            if(taskId != -1)
            {
                conn.Open();

                MySqlCommand command = conn.CreateCommand();

                command.Parameters.AddWithValue("@rowid", taskId);

                string sql = "SELECT t.rowid, t.name, t.description, t.fk_column, t.rank, t.fk_author, t.admin, t.active";
                sql+= " FROM tasks AS t";
                sql+= " WHERE t.rowid = @rowid";

                command.CommandText = sql;

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    this.rowid = reader.GetInt32(0);
                    name = reader.GetString(1);
                    description = reader.GetString(2);
                    fk_column = reader.GetInt32(3);
                    rank = reader.GetInt32(4);
                    fk_author = reader.GetInt32(5);
                    admin = reader.GetBoolean(6);
                    active = reader.GetBoolean(7);
                }

                conn.Close();
            }
        }

        // SETTER
        public void setrowid(int rowid)
        {
            this.rowid = rowid;
        }

        public void setname(string name)
        {
            this.name = name;
        }

        public void setdescription(string description)
        {
            this.description = description;
        }

        public void setfk_column(int fk_column)
        {
            this.fk_column = fk_column;
        }

        public void setActive(bool active)
        {
            this.active = active;
        }


        // GETTER
        public int getRowid()
        {
            return this.rowid;
        }

        public string getName()
        {
            return this.name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public int getFk_column()
        {
            return this.fk_column;
        }

        public int getFk_author()
        {
            return this.fk_author;
        }

        public bool getAdmin()
        {
            return this.admin;
        }

        public bool getActive()
        {
            return this.active;
        }

        // FETCH

        public void fetch(int taskId)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@rowid", taskId);

            string sql = "SELECT t.rowid, t.name, t.description, t.fk_column, t.rank, t.fk_author, t.admin, t.active";
            sql+= " FROM tasks AS t";
            sql+= " WHERE rowid = ?";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
                description = reader.GetString(2);
                fk_column = reader.GetInt32(3);
                rank = reader.GetInt32(4);
                fk_author = reader.GetInt32(5);
                admin = reader.GetBoolean(6);
                active = reader.GetBoolean(7);
            }

            conn.Close();
        }

        public int fetch_last_insert_id()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            string sql = "SELECT MAX(rowid) AS rowid";
            sql+= " FROM tasks";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int lastInsertId = 0;

            while(reader.Read())
            {
                lastInsertId = reader.GetInt32(0);
            }

            conn.Close();

            return lastInsertId;
        }

        public int fetchRank(int rowid)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT rank";
            sql+= " FROM tasks";
            sql+= " WHERE rowid = @rowid";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int rank = 0;

            while(reader.Read())
            {
                rank = reader.GetInt32(0);
            }

            conn.Close();

            return rank;
        }

        public int fetchNextRank(int rowid, int fk_column)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@fk_column", fk_column);
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT t.rank AS nextRank, t.rowid AS rowid";
            sql+= " FROM tasks AS t";
            sql+= " WHERE t.fk_column = @fk_column";
            sql+= " AND t.rank > (SELECT rank FROM tasks WHERE rowid = @rowid)";
            sql+= " ORDER BY t.rank ASC";
            sql+= " LIMIT 1";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int nextRank = 0;

            while(reader.Read())
            {
                nextRank = reader.GetInt32(0);
            }

            conn.Close();

            return nextRank;
        }

        public int fetchPrevRank(int rowid, int fk_column)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@fk_column", fk_column);
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT t.rank AS prevRank, t.rowid AS rowid";
            sql+= " FROM tasks AS t";
            sql+= " WHERE t.fk_column = @fk_column";
            sql+= " AND t.rank < (SELECT rank FROM tasks WHERE rowid = @rowid)";
            sql+= " ORDER BY t.rank DESC";
            sql+= " LIMIT 1";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int prevRank = 0;

            while(reader.Read())
            {
                prevRank = reader.GetInt32(0);
            }

            conn.Close();

            return prevRank;
        }

    }
}
