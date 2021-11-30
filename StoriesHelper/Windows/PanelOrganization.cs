using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;

namespace StoriesHelper.Windows
{
    public partial class PanelOrganization : UserControl
    {
        private int id;
        public PanelOrganization(int idOrg)
        {
            this.id = idOrg;
            InitializeComponent();
            Organization organization = new Organization(idOrg);

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

            List<Task> listTasks = organization.fetchTaskByOrganization(idOrg);
            List<Task> listTasksOpen = organization.fetchTaskOpenByOrganization(idOrg);
            List<Task> listTasksClosed = organization.fetchTaskClosedByOrganization(idOrg);

            NbTasks.Text = "Nombre de tâches : " + listTasks.Count();
            NbTasksOpen.Text = "Nombre de tâches open : " + listTasksOpen.Count();
            NbTasksClosed.Text = "Nombre de tâches closed : " + listTasksClosed.Count();

            int ratio = organization.CalculateRatioTasks(listTasks.Count(), listTasksOpen.Count());

            RatioTasks.Text = "Ratio : " + ratio + "%";
        }
    }
}
