using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;

namespace StoriesHelper.Windows.Users
{
    public partial class UserMainList : UserControl
    {
        public UserMainList()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);

            List<Project> ProjectList = Organization.getListProjects();
            List<Team> TeamList = new List<Team>();
            foreach(Project Project in ProjectList)
            {
                TeamList.AddRange(Project.getListTeams());
            }
            this.comboTeam.DropDownWidth = 200;
            foreach (Project Project in ProjectList)
            {
                this.comboProject.Items.AddRange(new Object[] { Project.getName() });
            }
            foreach (Team Team in TeamList)
            {
                this.comboTeam.Items.AddRange(new Object[] { Team.getName() });
            }

            // Affichage de la liste
            UserListUsers UserListUsers = new UserListUsers();

            panelListUsers.Controls.Clear();
            panelListUsers.Controls.Add(UserListUsers);

            UserListUsers.Show();
        }
    }
}
