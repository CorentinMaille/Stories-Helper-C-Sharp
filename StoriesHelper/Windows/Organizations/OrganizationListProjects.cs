using StoriesHelper.Models;
using StoriesHelper.Service;
using StoriesHelper.Windows.Projects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationListProjects : UserControl
    {
        public OrganizationListProjects(bool archived = false, bool open = true)
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);
            List<Project> ListProjects = Organization.getListProjects();
            List<Project> Projects = new List<Project>();
            if (archived && open) 
            {
                Projects = Organization.getListProjects();
            } else if (archived && !open) {
                foreach (Project Project in ListProjects)
                {
                    if (!Project.isActive())
                    {
                        Projects.Add(Project);
                    }
                }
            } else if (!archived && open) {
                foreach (Project Project in ListProjects)
                {
                    if (Project.isActive())
                    {
                        Projects.Add(Project);
                    }
                }
            }
            Projects = Projects.OrderBy(p => p.getName()).ToList();
            int positionLabel = 25;
            int positionButton = 20;
            foreach (Project Project in Projects)
            {
                // Créer le label
                string projectName = Project.getName();
                string newName = "";
                Label Label = new Label();
                if (projectName.Length > 15)
                {
                    newName = projectName.Remove(15, (projectName.Length - 15));
                    newName = newName.Insert(newName.Length, "...");
                    Label.Text = "- " + newName;
                    Label.Name = newName + Project.getRowId();
                } else
                {
                    Label.Text = "- " + projectName;
                    Label.Name = projectName + Project.getRowId();
                }             
                Label.UseMnemonic = true;
                Label.AutoSize = true;
                if (!Project.isActive())
                {
                    Label.ForeColor = Color.Red;
                }
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(0, positionLabel);
                Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Project.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(150, positionButton);
                button.Click += new EventHandler(goToProject);
                Controls.Add(button);

                positionLabel += 40;
                positionButton += 40;
            }
        }
        private void goToProject(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToProject(Convert.ToInt32(button.Name));
        }
    }
}
