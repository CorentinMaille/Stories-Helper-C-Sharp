using MySql.Data.MySqlClient;
using System.Collections.Generic;
using StoriesHelper.Services;

namespace StoriesHelper.Repository
{
    class TeamRepository : Repository
    {
        public List<TeamNameType> GetTeamsByOrganization(bool archived, bool open, int fkOrganization, int page = 0, string name = null, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;

            List<TeamNameType> TeamList = new List<TeamNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idOrganization", fkOrganization);
                string sql = "SELECT t.rowid, t.name, t.active ";
                sql += "FROM storieshelper_team t ";
                sql += "INNER JOIN storieshelper_project p ON p.rowid = t.fk_project ";
                sql += "WHERE p.fk_organization = @idOrganization ";
                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND t.name LIKE @name ";
                }
                if (open && !archived)
                {
                    sql += "AND t.active = 1 ";
                }
                else if (archived && !open)
                {
                    sql += "AND t.active = 0 ";
                }
                sql += "ORDER BY t.name ASC ";
                if(pagination)
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    sql += "LIMIT @limit ";
                    sql += "OFFSET @offset ";
                }
                command.CommandText = sql;
                MySqlDataReader Team = command.ExecuteReader();
                while (Team.Read())
                {
                    TeamNameType TeamNameType = new TeamNameType();
                    TeamNameType.initializeTeamNameType(Team.GetInt32(0), Team.GetString(1), Team.GetBoolean(2));
                    TeamList.Add(TeamNameType);
                }
            }

            return TeamList;
        }
    }
}
