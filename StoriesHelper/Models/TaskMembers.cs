using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class TaskMembers : Model
    {
        private int rowid;
        private int fk_user;
        private int fk_task;

        public TaskMembers(int rowid = 0)
        {
            if(rowid != 0)
            {
                this.fetch(rowid);
            }
        }

        // SETTER

        public void setRowid(int rowid)
        {
            this.rowid = rowid;
        }

        public void setFk_user(int fk_user)
        {
            this.fk_user = fk_user;
        }

        public void setFk_task(int fk_task)
        {
            this.fk_task = fk_task;
        }

        // GETTER

        public int getRowid(int rowid)
        {
            return this.rowid;
        }

        public int getFk_user(int fk_user)
        {
            return this.fk_user;
        }

        public int getFk_task(int fk_task)
        {
            return fk_task;
        }

        // FETCH
        public void fetch(int rowid)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@rowid", rowid);

            string sql = "SELECT t.rowid, t.fk_user, t.fk_task";
            sql += " FROM tasks_members";
            sql += " WHERE t.rowid = ?";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                this.rowid = reader.GetInt32(0);
                this.fk_user = reader.GetInt32(1);
                this.fk_task = reader.GetInt32(2);
            }
            conn.Close();
        }


    }
}
