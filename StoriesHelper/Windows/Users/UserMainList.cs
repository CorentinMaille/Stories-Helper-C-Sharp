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
            this.comboProject.DropDownWidth = 200;
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

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string lastname = textName.Text;
            string firstname = textFirstname.Text;
            string email = textEmail.Text;
            string team = comboTeam.Text;
            string project = comboProject.Text;
            string id = textId.Text;

            UserListUsers UserListUsers = new UserListUsers(lastname, firstname, email, team, project, id);

            panelListUsers.Controls.Clear();
            panelListUsers.Controls.Add(UserListUsers);

            UserListUsers.Show();
        }
    }
}
