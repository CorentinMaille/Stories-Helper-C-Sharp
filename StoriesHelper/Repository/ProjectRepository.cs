using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoriesHelper.Services;

namespace StoriesHelper.Repository
{
    class ProjectRepository : Repository
    {
        public List<ProjectNameType> GetProjectsByOrganization(bool archived, bool open, int fkOrganization, int page = 0, string name = null, string type = null)
        {
            int offset = 25 * page;
            int limit = 25 * (page + 1);

            List<ProjectNameType> ProjectList = new List<ProjectNameType>();
            if (open || archived)
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@idOrganization", fkOrganization);
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                string sql = "SELECT rowid, name, type, active ";
                sql += "FROM storieshelper_project p ";
                sql += "WHERE fk_organization = @idOrganization ";
                if (name != null)
                {
                    command.Parameters.AddWithValue("@name", "%" + name + "%");
                    sql += "AND p.name LIKE @name ";
                }
                if (type != null)
                {
                    command.Parameters.AddWithValue("@type", "%" + type + "%");
                    sql += "AND p.type LIKE @type ";
                }
                if (open && !archived)
                {
                    sql += "AND p.active = 1 ";
                } else if (archived && !open)
                {
                    sql += "AND p.active = 0 ";
                }
                sql += "LIMIT @limit ";
                sql += "OFFSET @offset ";
                command.CommandText = sql;
                MySqlDataReader Project = command.ExecuteReader();
                while (Project.Read())
                {
                    ProjectNameType ProjectNameType = new ProjectNameType();
                    ProjectNameType.initializeProjectNameType(Project.GetInt32(0), Project.GetString(1), Project.GetString(2), Project.GetBoolean(3));
                    ProjectList.Add(ProjectNameType);
                }
            }

            return ProjectList;
        }
    }
}
