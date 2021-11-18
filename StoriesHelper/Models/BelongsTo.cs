using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class BelongsTo : Model
    {
        List<Int32> userIds;
        List<Int32> teamIds;

        public BelongsTo(int fk_user = 0)
        {
            if(fk_user != 0)
            {
                this.fetch(fk_user);
            }

        }

        // SETTER
        public void setUserIds(List<Int32> userIds)
        {
            this.userIds = userIds;
        }

        public void setTeamIds(List<Int32> teamIds)
        {
            this.teamIds = teamIds;
        }

        // GETTER

        public List<Int32> getUserIds(List<Int32> userIds)
        {
            return this.userIds;
        }

        public List<Int32> getTeamIds(List<Int32> teamIds)
        {
            return this.teamIds;
        }


        public void fetch(int fk_user)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@fk_user", fk_user);

            string sql = "SELECT fk_team";
            sql += " FROM belong_to";
            sql += "  WHERE fk_user = ?";

            command.CommandText = sql;

            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int fk_team = reader.GetInt32(0);
                this.userIds.Add(fk_user);
                this.teamIds.Add(fk_team);
            }
            conn.Close();
        }
    }
}
