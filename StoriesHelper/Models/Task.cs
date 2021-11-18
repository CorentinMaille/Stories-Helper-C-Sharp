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
        private List<TaskComment> TaskComments = new List<TaskComment>();

        public Task(int taskId = 0)
        {
            if (taskId != 0)
            {
                this.fetch(taskId);
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
            sql += " FROM tasks AS t";
            sql += " WHERE rowid = @rowid";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string taskName = "";
                if (!reader.IsDBNull(1))
                {
                    taskName = reader.GetString(1);
                }
                string taskDescription = "";
                if (!reader.IsDBNull(2))
                {
                    taskDescription = reader.GetString(2);
                }
                rowid = reader.GetInt32(0); 
                name = taskName;
                description = taskDescription;
                fk_column = reader.GetInt32(3);
                rank = reader.GetInt32(4);
                fk_author = reader.GetInt32(5);
                admin = reader.GetBoolean(6);
                active = reader.GetBoolean(7);
            }
            conn.Close();

            conn.Open();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fk_task", taskId);

            sql = "SELECT t.rowid, t.fk_task, t.note, t.fk_user, t.admin";
            sql += " FROM tasks_comments AS t";
            sql += " WHERE fk_task = @fk_task";

            command.CommandText = sql;

            MySqlDataReader commentReader = command.ExecuteReader();

            while(commentReader.Read())
            {
                TaskComment taskComment = new TaskComment();

                taskComment.initializeTaskComment(commentReader.GetInt32(0), commentReader.GetInt32(1), commentReader.GetString(2), commentReader.GetInt32(3), commentReader.GetBoolean(4));
                this.TaskComments.Add(taskComment);
            }

            conn.Close();
        }

        public void initializedTask(int rowid, string name, string description, int fk_column, int rank, int fk_author, bool admin, bool active)
        {
            this.rowid = rowid;
            this.name = name;
            this.description = description;
            this.fk_column = fk_column;
            this.rank = rank;
            this.fk_author = fk_author;
            this.admin = admin;
            this.active = active;

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@fk_task", rowid);
           
            string sql = "SELECT *";
            sql += " FROM tasks_comments";
            sql += " WHERE fk_task = @fk_task";

            command.CommandText = sql;

            MySqlDataReader commentReader = command.ExecuteReader();

            while (commentReader.Read())
            {
                TaskComment taskComment = new TaskComment();

                taskComment.initializeTaskComment(commentReader.GetInt32(0), commentReader.GetInt32(1), commentReader.GetString(2), commentReader.GetInt32(3), commentReader.GetBoolean(4));
                this.TaskComments.Add(taskComment);
            }

            conn.Close();
        }

        public int fetch_last_insert_id()
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            string sql = "SELECT MAX(rowid) AS rowid";
            sql += " FROM tasks";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int lastInsertId = 0;

            while (reader.Read())
            {
                lastInsertId = reader.GetInt32(0);
            }

            conn.Close();

            return lastInsertId;
        }

        public void fetchRank(int rowid)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT rank";
            sql += " FROM tasks";
            sql += " WHERE rowid = @rowid";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.rank = reader.GetInt32(0);
            }

            conn.Close();
        }

        public int fetchNextRank(int rowid, int fk_column)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@fk_column", fk_column);
            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT t.rank AS nextRank, t.rowid AS rowid";
            sql += " FROM tasks AS t";
            sql += " WHERE t.fk_column = @fk_column";
            sql += " AND t.rank > (SELECT rank FROM tasks WHERE rowid = @rowid)";
            sql += " ORDER BY t.rank ASC";
            sql += " LIMIT 1";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int nextRank = 0;

            while (reader.Read())
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
            sql += " FROM tasks AS t";
            sql += " WHERE t.fk_column = @fk_column";
            sql += " AND t.rank < (SELECT rank FROM tasks WHERE rowid = @rowid)";
            sql += " ORDER BY t.rank DESC";
            sql += " LIMIT 1";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            int prevRank = 0;

            while (reader.Read())
            {
                prevRank = reader.GetInt32(0);
            }

            conn.Close();

            return prevRank;
        }

     
    }
}
