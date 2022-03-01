using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;

namespace StoriesHelper.Windows.Projects
{
    public partial class ProjectMain : UserControl
    {
        private int idProject;
        public ProjectMain(int idProject)
        {
            InitializeComponent();
            this.idProject = idProject;
            Project Project = new Project(idProject);
            List<Team> Teams = Project.getListTeams();
            List<Column> Columns = new List<Column>();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            List<Collaborator> Collaborator = new List<Collaborator>();
            foreach (Team team in Teams)
            {
                Columns.AddRange(team.getListColumns());
                Collaborator.AddRange(team.getListCollaborators());
            }
            foreach (Column column in Columns)
            {
                foreach (Task task in column.getListTasks())
                {
                    if (task.isActive() == 1)
                    {
                        if (column.getName() == "Closed")
                        {
                            TasksClosed.Add(task);
                        }
                        else
                        {
                            TasksOpen.Add(task);
                        }
                    }
                }
            }
            if (!Project.isActive())
            {
                ArchivedProject.Text = "Projet Achivée";
                buttonArchiverProjet.BackColor = Color.Green;
                buttonArchiverProjet.Text = "Désarchiver le projet";
                buttonArchiverProjet.Name = "buttonDesarchiverProjet";
            }
            LabelTitreProject.Text += Project.getName();
            labelType.Text += Project.getType();
            labelDateCreation.Text += Project.getOpen().ToString("d");
            labelNbCollaborateur.Text += Collaborator.Count(); 
            labelNbTeam.Text += Teams.Count();/*
            textDescription.Text = Project.getDescription();*/

            displayTaskChart(Tasks, TasksOpen, TasksClosed);

            // Liste Teams
            ProjectListTeams ListTeams = new ProjectListTeams(idProject);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();
        }

        /*
         * Permet l'affichage du graphique des tâches en cours
         */
        private void displayTaskChart(List<Task> Tasks, List<Task> TasksOpen, List<Task> TasksClosed)
        {

            if (TasksClosed.Count() == 0 && TasksOpen.Count() == 0)
            {
                GraphiqueRatioTaskProject.Series["Task"].Points.AddXY("no Data", 1);
            } else {
                double ratioOpen = Calcul.CalculateRatioTasks(TasksOpen.Count(), Tasks.Count());
                double ratioClosed = Calcul.CalculateRatioTasks(TasksClosed.Count(), Tasks.Count());
                string labelOpen = "Open (" + ratioOpen + "%)";
                string labelClosed = "Closed (" + ratioClosed + "%)";

                GraphiqueRatioTaskProject.Series["Task"].IsValueShownAsLabel = true;
                GraphiqueRatioTaskProject.Series["Task"].Points.AddXY(labelOpen, TasksOpen.Count());
                GraphiqueRatioTaskProject.Series["Task"].Points.AddXY(labelClosed, TasksClosed.Count());
            }
        }

        private void SupprimerProject_Click(object sender, EventArgs e)
        {
            Project Project = new Project(idProject);
            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer le projet " + Project.getName() + " Cette action est irréversible, êtes-vous sûr de vouloir continuer ?", "Supprimer Projet", (MessageBoxButtons) 1);
            if (result == DialogResult.OK)
            {
                try
                {
                    Project.delete();
                    MessageBox.Show("Le projet " + Project.getName() + " a bien été supprimé.");
                    main.goToOrganization();
                } catch {
                    MessageBox.Show("Une erreur est survenue lors de la suppression.");
                }
            }
        }
        private void buttonArchiverProjet_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Project Project = new Project(idProject);
            if (button.Name == "buttonDesarchiverProjet")
            {
                Project.setActive(true);     
            } else
            {
                Project.setActive(false);
            }
            Project.update();
            main.goToProject(idProject);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            main.goToOrganization();
        }
    }
}
