using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Windows.Organizations.OrganizationListProject;
using StoriesHelper.Windows.Organizations.OrganizationListTeam;
using StoriesHelper.Windows.Organizations.Icons;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationMain : UserControl
    {
        protected string projectName = "";
        protected string projectType = "";
        protected string teamName = "";
        public OrganizationMain(string projectName = "", string projectType = "")
        {
            int idOrganization = Session.UserId;
            InitializeComponent();
            Organization Organization = new Organization(idOrganization);
            OrganizationLabel.Text += Organization.getName();
            OrganizationLabel.Left = (this.ClientSize.Width - OrganizationLabel.Width) / 2;

            List<Project> Projects = Organization.getListProjects();
            List<Team> Teams = new List<Team>();
            List<Column> Columns = new List<Column>();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            List<Collaborator> Users = Organization.getListUsers();
            int nbArchived = 0;
            int nbProjects = 0;
            foreach (Project project in Projects)
            {
                Teams.AddRange(project.getListTeams());

                if (!project.isActive())
                {
                    nbArchived++;
                } else
                {
                    nbProjects++;
                }
            }
            foreach (Team team in Teams)
            {
                Columns.AddRange(team.getListColumns());
            }
            foreach (Column column in Columns)
            {
                foreach (Task task in column.getListTasks())
                {
                    if(task.isActive() == 1)
                    {

                        if (column.getName() == "Closed")
                        {
                            TasksClosed.Add(task);
                        } else
                        {
                            TasksOpen.Add(task);
                        }
                    }
                }
            }
            int nbTeams = Teams.Count();
            int nbUsers = Users.Count();
/*
            for(int i = 0; i <= 25; i++)
            {
                UserControl OmbreUtilisateur = new UserControl();
                OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                OmbreUtilisateur.Size = new Size(150 + (2 * i), 150 + (2 * i));
                OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                OmbreUtilisateur.BackColor = Color.FromArgb(100 - (4 * i), 0, 0, 0);
                testPanel.Controls.Add(OmbreUtilisateur);
                OmbreUtilisateur.Show();
            }    */  

            displayTaskChart(Tasks, TasksOpen, TasksClosed);

            // icone Utilisateur
            IconUser IconUser = new IconUser();
            panelIconUser.Controls.Clear();
            panelIconUser.Controls.Add(IconUser);
            IconUser.Show();

            // icone Equipe
            IconTeam IconTeam = new IconTeam();
            panelIconTeam.Controls.Clear();
            panelIconTeam.Controls.Add(IconTeam);
            IconTeam.Show();

            // icone Projet
            IconProject IconProject = new IconProject();
            panelIconProject.Controls.Clear();
            panelIconProject.Controls.Add(IconProject);
            IconProject.Show();

            // Liste Projets
            MainOrganizationListProject MainOrganizationListProject = new MainOrganizationListProject();
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(MainOrganizationListProject);
            MainOrganizationListProject.Show();

            // Liste Teams
            MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam();
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(MainOrganizationListTeam);
            MainOrganizationListTeam.Show();
        }

        private void FilterDisplayProject(object sender, System.EventArgs e)
        {
            projectName = FilterNameProject.Text;
            projectType = FilterTypeProject.Text;

            showListProject();
        }

        private void displayProject(object sender, System.EventArgs e)
        {
            showListProject();
        }
        
        private void FilterDisplayTeam(object sender, System.EventArgs e)
        {
            teamName = FilterNameTeam.Text;

            showListTeam();
        }

        private void displayTeam(object sender, System.EventArgs e)
        {
            showListTeam();
        }

        private void displayTaskChart(List<Task> Tasks, List<Task> TasksOpen, List<Task> TasksClosed)
        {

            if (TasksClosed.Count() == 0 && TasksOpen.Count() == 0)
            {
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY("no Data", 1);
            }
            else
            {
                double ratioOpen = Calcul.CalculateRatioTasks(TasksOpen.Count(), Tasks.Count());
                double ratioClosed = Calcul.CalculateRatioTasks(TasksClosed.Count(), Tasks.Count());
                string labelOpen = "Open (" + ratioOpen + "%)";
                string labelClosed = "Closed (" + ratioClosed + "%)";

                GraphiqueRatioTaskOrganization.Series["Task"].IsValueShownAsLabel = true;
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelOpen, TasksOpen.Count());
                GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelClosed, TasksClosed.Count());
            }
        }
        
        public void showListProject()
        {
            if (checkBoxArchivedProject.Checked && checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(true, true, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
            else if (checkBoxArchivedProject.Checked && !checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(true, false, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
            }
            else if (!checkBoxArchivedProject.Checked && !checkBoxOpenProject.Checked)
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(false, false, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
            else
            {
                MainOrganizationListProject ListProjects = new MainOrganizationListProject(false, true, projectName, projectType);
                PanelListProjects.Controls.Clear();
                PanelListProjects.Controls.Add(ListProjects);
                ListProjects.Show();
            }
        }

        public void showListTeam()
        {
            if (checkBoxArchivedTeam.Checked && checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(true, true, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else if (checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(true, false, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else if (!checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked)
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(false, false, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
            else
            {
                MainOrganizationListTeam MainOrganizationListTeam = new MainOrganizationListTeam(false, true, teamName);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(MainOrganizationListTeam);
                MainOrganizationListTeam.Show();
            }
        }
    }
}
