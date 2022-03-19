using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Repository
{
    class TeamRepository : Repository
    {
        public int NbTeamByOrganization(bool open, bool closed)
        {
            int count = 0;
            if (open || closed)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string sql = "select COUNT(t.*) ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_project p ON p.rowid = t.fk_project ";
                sql += "INNER JOIN storieshelper_organization o ON o.rowid = p.fk_organization ";
                sql += "WHERE 1 ";
                if (open)
                {
                    sql += "WHERE t.active = 1 ";
                }
                if (closed)
                {
                    sql += "WHERE t.active = 0 ";
                }
                command.CommandText = sql;
                MySqlDataReader CountTeam = command.ExecuteReader();
                while(CountTeam.Read())
                {
                    count = CountTeam.GetInt32(0);
                }
            }

            return count;
        }
    }
}
