using MySql.Data.MySqlClient;
using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoriesHelper.Repository
{
    class LogHistoryRepository : Repository
    {
        public List<LogHistory> GetLogsByOrganization(int fkOrganization, int page = 0)
        {
            int offset = 100 * page;
            int limit = 100;

            List<LogHistory> LogHistoryList = new List<LogHistory>();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idOrganization", fkOrganization);
            string sql = "SELECT * ";
            sql += "FROM storieshelper_log_history ";
            sql += "WHERE fk_organization = @idOrganization ";

            command.Parameters.AddWithValue("@offset", offset);
            command.Parameters.AddWithValue("@limit", limit);
            sql += "LIMIT @limit ";
            sql += "OFFSET @offset ";
            command.CommandText = sql;
            MySqlDataReader logs = command.ExecuteReader();
            while (logs.Read())
            {
                string value = null;
                if (!logs.IsDBNull(6))
                {
                    value = logs.GetString(6);
                }
                string identification = null;
                if (!logs.IsDBNull(7))
                {
                    identification = logs.GetString(7);
                }
                string exception = null;
                if (!logs.IsDBNull(10))
                {
                    exception = logs.GetString(10);
                }
                string platform = null;
                if (!logs.IsDBNull(11))
                {
                    platform = logs.GetString(11);
                }
                LogHistory LogHistory = new LogHistory();
                LogHistory.initialize(logs.GetInt32(0), logs.GetInt32(1), logs.GetDateTime(2), logs.GetString(3), logs.GetString(4), logs.GetString(5), logs.GetString(9), value, identification, exception, platform);
                LogHistoryList.Add(LogHistory);
            }
            
            conn.Close();
            return LogHistoryList;
        }
    }
}
