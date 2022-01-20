using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Service;
using StoriesHelper.Services;
using StoriesHelper.Windows.Organizations;

namespace StoriesHelper.Windows.Organizations
{
    public partial class PanelOrganization : UserControl
    {
        public PanelOrganization()
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
            List<User> Users = Organization.getListUsers();
            foreach (Project project in Projects)
            {
                Teams.AddRange(project.getListTeams());
            }
            foreach (Team team in Teams)
            {
                Columns.AddRange(team.getListColumns());
            }
            foreach (Column column in Columns)
            {
                Tasks.AddRange(column.getListTasks());
            }
            foreach (Task task in Tasks)
            {
                if (task.isActive())
                {
                    TasksOpen.Add(task);
                } else {
                    TasksClosed.Add(task);
                }
            }
            int nbProjects = Projects.Count();
            int nbTeams = Teams.Count();
            int nbTasks = Tasks.Count();
            int nbUsers = Users.Count();
            NbProjects.Text = "Nombre de projets : " + nbProjects;
            NbTeams.Text = "Nombre de teams : " + nbTeams;
            NbUtilisateurs.Text = "Nombre d'utilisateur : " + nbUsers;
            double ratioOpen = Calcul.CalculateRatioTasks(TasksOpen.Count(), Tasks.Count());
            double ratioClosed = Calcul.CalculateRatioTasks(TasksClosed.Count(), Tasks.Count());
            string labelOpen = "Open (" + ratioOpen + "%)";
            string labelClosed = "Closed (" + ratioClosed + "%)";

            GraphiqueRatioTaskOrganization.Series["Task"].IsValueShownAsLabel = true;
            GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelOpen, TasksOpen.Count());
            GraphiqueRatioTaskOrganization.Series["Task"].Points.AddXY(labelClosed, TasksClosed.Count());

            // Liste Projets
            ListProjects ListProjects = new ListProjects();
            PanelListProjects.Controls.Clear();
            PanelListProjects.Controls.Add(ListProjects);
            ListProjects.Show();

            // Liste Projets
            ListTeams ListTeams = new ListTeams();
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();

            // Liste Projets
            ListUsers ListUsers = new ListUsers();
            PanelListUsers.Controls.Clear();
            PanelListUsers.Controls.Add(ListUsers);
            ListUsers.Show();


        }
    }
}
