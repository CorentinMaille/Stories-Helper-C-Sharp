using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Windows.Organizations.OrganizationListProject;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationMain : UserControl
    {
        protected string projectName = "";
        protected string projectType = "";
        public OrganizationMain(string projectName = "", string projectType = "")
        {
            int idOrganization = Session.UserId;
            InitializeComponent();
            Organization Organization = new Organization(idOrganization);
            OrganizationLabel.Text += Organization.getName();
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

            displayTaskChart(Tasks, TasksOpen, TasksClosed);

            NbProjects.Text += nbProjects;
            NbArchivedProjects.Text += nbArchived;
            NbTeams.Text += nbTeams;
            NbUtilisateurs.Text += nbUsers;

            // Liste Projets
            MainOrganizationListProject MainOrganizationListProject = new MainOrganizationListProject();
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(MainOrganizationListProject);
            MainOrganizationListProject.Show();

            // Liste Teams
            OrganizationListTeams ListTeams = new OrganizationListTeams();
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();
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

        private void displayTeam(object sender, System.EventArgs e)
        {
            if (checkBoxArchivedTeam.Checked && checkBoxOpenTeam.Checked)
            {
                OrganizationListTeams ListTeams = new OrganizationListTeams(true, true);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(ListTeams);
                ListTeams.Show();
            } else if (checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked) {
                OrganizationListTeams ListTeams = new OrganizationListTeams(true, false);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(ListTeams);
                ListTeams.Show();
            } else if (!checkBoxArchivedTeam.Checked && !checkBoxOpenTeam.Checked) {
                OrganizationListTeams ListTeams = new OrganizationListTeams(false, false);
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(ListTeams);
                ListTeams.Show();
            } else {
                OrganizationListTeams ListTeams = new OrganizationListTeams();
                PanelListTeams.Controls.Clear();
                PanelListTeams.Controls.Add(ListTeams);
                ListTeams.Show();
            }
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
    }
}
