using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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
                command.Parameters.AddWithValue("@rowid", rowid);

                string sql = "SELECT t.rowid, t.name, t.description, t.fk_column, t.rank, t.fk_author, t.admin, t.active";
                sql += " FROM tasks AS t";
                sql += " WHERE t.rowid = ?";

                command.CommandText = sql;

                MySqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        this.rowid = reader.GetInt32(0);
                        this.name = reader.GetString(1);
                        this.description = reader.GetString(2);
                        this.fk_column = reader.GetInt32(3);
                        this.rank = reader.GetInt32(4);
                        this.fk_author = reader.GetInt32(5);
                        this.admin = reader.GetBoolean(6);
                        this.active = reader.GetBoolean(7);
                    }
                }

                conn.Close();
            }
        }

        // SETTER
        public void setRowid(int rowid)
        {
            this.rowid = rowid;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void  setFk_column(int fk_column)
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

        public int getRank()
        {
            return this.rank;
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
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT t.rowid, t.name, t.description, t.fk_column, t.rank, t.fk_author, t.admin, t.active";
            sql += " FROM tasks AS t";
            sql += " WHERE t.rowid = ?";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.rowid = reader.GetInt32(0);
                    this.name = reader.GetString(1);
                    this.description = reader.GetString(2);
                    this.fk_column = reader.GetInt32(3);
                    this.rank = reader.GetInt32(4);
                    this.fk_author = reader.GetInt32(5);
                    this.admin = reader.GetBoolean(6);
                    this.active = reader.GetBoolean(7);
                }
            }

            conn.Close();
        }

        public int fetch_last_insert_id()
        {
            conn.Open();

            sql = "SELECT MAX(rowid) AS rowid";
            sql.= " FROM tasks";

        }
    }
}
