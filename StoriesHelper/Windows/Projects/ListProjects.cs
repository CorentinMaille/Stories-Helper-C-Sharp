using StoriesHelper.Models;
using StoriesHelper.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects
{
    public partial class ListProjects : UserControl
    {
        public ListProjects()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);
            List<Project> Projects = Organization.getListProjects();
            Projects = Projects.OrderBy(p => p.getName()).ToList();
            int positionLabel = 60;
            int positionButton = 55;
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
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(10, positionLabel);
                this.Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Project.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(150, positionButton);
                button.Click += new System.EventHandler(this.goToProject);
                this.Controls.Add(button);

                positionLabel += 40;
                positionButton += 40;
            }
        }
        private void goToProject(object sender, EventArgs e)
        {
            Button button = sender as Button;
            System.Windows.MessageBox.Show(button.Name);
        }
    }
}
