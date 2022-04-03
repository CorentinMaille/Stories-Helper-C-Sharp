﻿using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Repository
{
    class UserRepository : Repository
    {
        List<Team> list_teams = new List<Team>();
        List<Project> list_projects = new List<Project>();
        List<Collaborator> list_collaborators = new List<Collaborator>();
        
        public List<Collaborator> getUserFromOrganization(int fkOrganization ,string lastname = null, string firstname = null, string email = null, string team = null, string project = null, string id = null, int page = 0, bool pagination = true)
        {
            int offset = 25 * page;
            int limit = 25;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idOrganization", fkOrganization);
            string sql = "select u.* ";
            sql += " FROM storieshelper_organization o ";
            sql += " INNER JOIN storieshelper_project p on p.fk_organization = o.rowid";
            sql += " INNER JOIN storieshelper_team t on t.fk_project = p.rowid";
            sql += " INNER JOIN storieshelper_belong_to bt on bt.fk_team = t.rowid";
            sql += " INNER JOIN storieshelper_user u on bt.fk_user = u.rowid";
            sql += " WHERE o.rowid = @idOrganization";
            if (lastname != null)
            {
                command.Parameters.AddWithValue("@name", "%" + lastname + "%");
                sql += " AND u.lastname LIKE @name";
            }
            if(firstname != null)
            {
                command.Parameters.AddWithValue("@firstname", "%" + firstname + "%");
                sql += " AND u.firstname LIKE @firstname";
            }
            if(email != null)
            {
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                sql += " AND u.email LIKE @email";
            }
            if(team != null)
            {
                command.Parameters.AddWithValue("@team", "%" + team + "%");
                sql += " AND t.name LIKE @team";
            }
            if(project != null)
            {
                command.Parameters.AddWithValue("@project", "%" + project + "%");
                sql += " AND p.name LIKE @project";
            }
            if(id != null)
            {
                command.Parameters.AddWithValue("@id", "%" + id + "%");
                sql += " AND u.rowid LIKE @id";
            }
            if(pagination)
            {
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                sql += " LIMIT @limit";
                sql += " OFFSET @offset";
            }
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while (users.Read())
            {
                Collaborator user = new Collaborator();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
            return list_collaborators;
        }

        public List<Collaborator> getUserFromTeam(int fkTeam, string lastname = null, string firstname = null, string email = null, int page = 0, bool pagination = true)
        {
            int offset = 10 * page;
            int limit = 10;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idTeam", fkTeam);
            string sql = "select u.* ";
            sql += " FROM storieshelper_team t ";
            sql += " INNER JOIN storieshelper_belong_to bt ON bt.fk_team = t.rowid ";
            sql += " INNER JOIN storieshelper_user u ON bt.fk_user = u.rowid ";
            sql += " WHERE t.rowid = @idTeam";
            if (lastname != null)
            {
                command.Parameters.AddWithValue("@name", "%" + lastname + "%");
                sql += " AND u.lastname LIKE @name";
            }
            if (firstname != null)
            {
                command.Parameters.AddWithValue("@firstname", "%" + firstname + "%");
                sql += " AND u.firstname LIKE @firstname";
            }
            if (email != null)
            {
                command.Parameters.AddWithValue("@email", "%" + email + "%");
                sql += " AND u.email LIKE @email";
            }
            if (pagination)
            {
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@limit", limit);
                sql += " LIMIT @limit";
                sql += " OFFSET @offset";
            }
            command.CommandText = sql;
            MySqlDataReader users = command.ExecuteReader();
            while (users.Read())
            {
                Collaborator user = new Collaborator();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(5), users.GetInt32(6));
                list_collaborators.Add(user);
            }
            conn.Close();
            return list_collaborators;
        }

        public List<Team> getTeams(int fk_user)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUser", fk_user);
            string sql = "SELECT t.*";
            sql += " FROM storieshelper_team AS t";
            sql += " LEFT JOIN storieshelper_belong_to AS b ON t.rowid = b.fk_team";
            sql += " WHERE b.fk_user = @idUser";
            command.CommandText = sql;
            MySqlDataReader teams = command.ExecuteReader();
            while (teams.Read())
            {
                Team team = new Team();
                team.initializedTeam(teams.GetInt32(0), teams.GetString(1), teams.GetInt32(2), teams.GetBoolean(3));
                list_teams.Add(team);
            }
            conn.Close();
            return list_teams;
        }

        public List<Project> getProjects(int fk_user)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@idUser", fk_user);
            string sql = "SELECT p.*";
            sql += " FROM storieshelper_project p";
            sql += " LEFT JOIN storieshelper_team t ON p.rowid = t.fk_project";
            sql += " LEFT JOIN storieshelper_belong_to AS b ON t.rowid = b.fk_team";
            sql += " WHERE b.fk_user = @idUser";
            command.CommandText = sql;
            MySqlDataReader projects = command.ExecuteReader();
            while (projects.Read())
            {
                Project project = new Project();
                project.initializedProject(projects.GetInt32(0), projects.GetString(1), projects.GetString(2), projects.GetDateTime(3), projects.GetInt32(4), projects.GetString(5), projects.GetBoolean(6));
                list_projects.Add(project);
            }
            conn.Close();
            return list_projects;
        }
    }
}
