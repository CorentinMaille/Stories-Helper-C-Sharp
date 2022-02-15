﻿using StoriesHelper.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StoriesHelper.Windows.Teams.TeamStatistiques;

namespace StoriesHelper.Windows.Teams
{
    public partial class TeamMain : UserControl
    {
        private int idTeam;
        private string from;
        public TeamMain(int idTeam, string from)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            this.from = from;
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            List<Collaborator> Collaborator = Team.getListCollaborators();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            foreach (Column column in Columns)
            {
                Tasks.AddRange(column.getListTasks());
            }
            foreach (Task task in Tasks)
            {
                if (task.isActive())
                {
                    TasksOpen.Add(task);
                }
                else
                {
                    TasksClosed.Add(task);
                }
            }
            if (!Team.isActive())
            {
                ArchivedTeam.Text = "Equipe Achivée";
                buttonArchiverTeam.BackColor = Color.Green;
                buttonArchiverTeam.Text = "Désarchiver l'équipe";
                buttonArchiverTeam.Name = "buttonDesarchiverTeam";
            }

            // Liste Users
            TeamListUsers ListUsers = new TeamListUsers(idTeam);
            PanelListUsers.Controls.Clear();
            PanelListUsers.Controls.Add(ListUsers);
            ListUsers.Show();

            TeamTaskStatistiques TeamTaskStatistiques = new TeamTaskStatistiques(idTeam);
            panelShowStatistiqueTeam.Controls.Clear();
            panelShowStatistiqueTeam.Controls.Add(TeamTaskStatistiques);
            TeamTaskStatistiques.Show();
        }

        private void retour_Click(object sender, System.EventArgs e)
        {
            Team Team = new Team(idTeam);
            if (from == "Project")
            {
                main.goToProject(Team.getProject());
            } else if (from == "Organization")
            {
                main.goToOrganization();
            }
        }

        private void buttonSupprimerTeam_Click(object sender, System.EventArgs e)
        {
            Team Team = new Team(idTeam);
            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer l'équipe " + Team.getName() + " Cette action est irréversible, êtes-vous sûr de vouloir continuer ?", "Supprimer Team", (MessageBoxButtons)1);
            if (result == DialogResult.OK)
            {
                try
                {
                    Team.delete();
                    MessageBox.Show("L'équipe " + Team.getName() + " a bien été supprimé.");
                    main.goToOrganization();
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression.");
                }
            }
        }

        private void buttonArchiverTeam_Click(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            Team Team = new Team(idTeam);
            if (button.Name == "buttonDesarchiverTeam")
            {
                Team.setActive(true);
            }
            else
            {
                Team.setActive(false);
            }
            Team.update();
            main.goToTeam(idTeam, from);
        }
    }
}
