using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Windows.Projects.ProjectListTeam;

namespace StoriesHelper.Windows.Projects
{
    public partial class ProjectMain : UserControl
    {
        private int idProject;
        public ProjectMain(int idProject)
        {
            InitializeComponent();
            Gradient GradientTitre = new Gradient();
            GradientTitre.Name = "GradientTitre";
            GradientTitre.Size = new Size(1100, 60);
            GradientTitre.BackColor = Color.FromArgb(200, 30, 137, 255);
            GradientTitre.Location = new Point(0, 0);
            gradientPanelProject.Controls.Add(GradientTitre);

            LigneHorizontale LigneTitre = new LigneHorizontale();
            LigneTitre.Name = "LigneTitre";
            LigneTitre.Location = new Point(0, 59);
            LigneTitre.Width = 1100;
            LigneTitre.Height = 1;
            GradientTitre.Controls.Add(LigneTitre);

            this.idProject = idProject;
            Project Project = new Project(idProject);

            LabelTitreProject.Text += Project.getName();
            GradientTitre.Controls.Add(LabelTitreProject);
            LabelTitreProject.Left = (1100 - LabelTitreProject.Width) / 2;
            LabelTitreProject.Top = (60 - LabelTitreProject.Height) / 2;

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
            foreach (Column Column in Columns)
            {
                foreach (Task task in Column.getListTasks())
                {
                    if (task.isActive() != 0)
                    {
                        if (Column.getName() == "Closed")
                        {
                            TasksClosed.Add(task);
                        }
                        else
                        {
                            TasksOpen.Add(task);
                        }
                        Tasks.Add(task);
                    }
                }
            }
            if (!Project.isActive())
            {
                ArchivedProject.Text = "Projet Archivé";
                buttonArchiverProjet.BackColor = Color.Green;
                buttonArchiverProjet.Text = "Désarchiver le projet";
                buttonArchiverProjet.Name = "buttonDesarchiverProjet";
            }
            labelType.Text += Project.getType();
            labelDateCreation.Text += Project.getOpen().ToString("d");
            labelNbCollaborateur.Text += Collaborator.Count(); 
            labelNbTeam.Text += Teams.Count();/*
            textDescription.Text = Project.getDescription();*/

            displayTaskChart(Tasks, TasksOpen, TasksClosed);

            // Liste Teams
            MainProjectListTeam ListTeams = new MainProjectListTeam(idProject);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            // description
            ProjectDescription ProjectDescription = new ProjectDescription(Project.getDescription());
            panelDescription.Controls.Clear();
            panelDescription.Controls.Add(ProjectDescription);
            ProjectDescription.Show();
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
