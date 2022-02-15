﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Models
{
    class Organization : Model
    {
        protected int rowid;
        protected string name;
        protected string email;
        protected string password;
        protected int consent;
        protected List<Project> list_projects = new List<Project>();
        protected List<Collaborator> list_collaborators = new List<Collaborator>();

        public Organization(int idOrganization = -1)
        {
            if(idOrganization != -1)
            {
                fetch(idOrganization);
            }
        }
        public int getRowId()
        {
            return rowid;
        }
        public void setRowid(int newRowid)
        {
            rowid = newRowid;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string newName)
        {
            name = newName;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string newEmail)
        {
            email = newEmail;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }
        public int getConsent()
        {
            return consent;
        }
        public void setConsent(int newConsent)
        {
            consent = newConsent;
        }
        public List<Project> getListProjects()
        {
            return list_projects;
        }
        public void setListProjects(List<Project> newListProject)
        {
            list_projects = newListProject;
        }
        public List<Collaborator> getListUsers()
        {
            return list_collaborators;
        }
        public void setListUsers(List<Collaborator> newListUser)
        {
            list_collaborators = newListUser;
        }

        public void fetch(int idOrganization)
        {
            // récupère les informations de l'organisation
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", idOrganization);
            string sql = "SELECT *";
            sql += " FROM organization ";
            sql += "WHERE rowid = @id";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowid = reader.GetInt32(0);
                name = reader.GetString(1);
            }
            conn.Close();
            //initialise les projets de l'organisation
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@idOrganization", idOrganization );
            string sql2 = "SELECT *";
            sql2 += " FROM project";
            sql2 += " WHERE fk_organization = @idOrganization";
            command2.CommandText = sql2;
            MySqlDataReader projects = command2.ExecuteReader();
            while (projects.Read())
            {
                Project project = new Project();
                project.initializedProject(projects.GetInt32(0), projects.GetString(1), projects.GetString(2), projects.GetDateTime(3), projects.GetInt32(4), projects.GetString(5), projects.GetBoolean(6));
                list_projects.Add(project);
            }
            conn.Close();
            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@idOrganization", idOrganization);
            string sql3 = "SELECT *";
            sql3 += " FROM user";
            sql3 += " WHERE fk_organization = @idOrganization";
            sql3 += " AND admin = 0";
            command3.CommandText = sql3;
            MySqlDataReader users = command3.ExecuteReader();
            while (users.Read())
            {
                Collaborator user = new Collaborator();
                user.initializedCollaborator(users.GetInt32(0), users.GetString(1), users.GetString(2), users.GetDateTime(3), users.GetString(4), users.GetString(6), users.GetInt32(7));
                list_collaborators.Add(user);
            }
            conn.Close();
        }
    }
}
