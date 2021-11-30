using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Service;

namespace StoriesHelper.Windows
{
    public partial class PanelOrganization : UserControl
    {
        public PanelOrganization()
        {
            int idOrganization = Session.UserId;
            InitializeComponent();
            Organization organization = new Organization(idOrganization);

            OrganizationLabel.Text += organization.getName();

            List<Project> listProject = organization.getListProjects();
            int nbProjects = listProject.Count();
            NbProjects.Text = "Nombre de projets : " + nbProjects;
            int nbTeams = 0;
            foreach (Project project in listProject)
            {
                List<Team> listTeams = project.getListTeams();
                nbTeams += listTeams.Count();
            }

            NbTeams.Text = "Nombre d'équipes : " + nbTeams;

            List<Task> listTasks = organization.fetchTaskByOrganization(idOrganization);
            List<Task> listTasksOpen = organization.fetchTaskOpenByOrganization(idOrganization);
            List<Task> listTasksClosed = organization.fetchTaskClosedByOrganization(idOrganization);

            NbTasks.Text = "Nombre de tâches : " + listTasks.Count();
            NbTasksOpen.Text = "Nombre de tâches open : " + listTasksOpen.Count();
            NbTasksClosed.Text = "Nombre de tâches closed : " + listTasksClosed.Count();

            int ratio = organization.CalculateRatioTasks(listTasks.Count(), listTasksOpen.Count());

            RatioTasks.Text = "Ratio : " + ratio + "%";
        }
    }
}
