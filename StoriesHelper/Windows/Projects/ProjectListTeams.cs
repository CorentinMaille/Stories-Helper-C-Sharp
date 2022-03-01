using StoriesHelper.Services;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects
{
    public partial class ProjectListTeams : UserControl
    {
        public ProjectListTeams(int idProject)
        {
            InitializeComponent();
            Project Project = new Project(idProject);
            List<Team> Teams = Project.getListTeams();
            Teams = Teams.OrderBy(t => t.getName()).ToList();
            int positionLabel = 10;
            int positionButton = 5;
            foreach (Team Team in Teams)
            {
                // Créer le label
                string TeamName = Team.getName();
                string newName = "";
                Label Label = new Label();
                if (TeamName.Length > 30)
                {
                    newName = TeamName.Remove(30, (TeamName.Length - 30));
                    newName = newName.Insert(newName.Length, "...");
                    Label.Text = "- " + newName;
                    Label.Name = newName + Team.getRowId();
                }
                else
                {
                    Label.Text = "- " + TeamName;
                    Label.Name = TeamName + Team.getRowId();
                }
                Label.UseMnemonic = true;
                Label.AutoSize = true;
                Label.Font = new Font("Cambria", 13);
                Label.Location = new Point(0, positionLabel);
                this.Controls.Add(Label);

                Label NbCollaborateur = new Label();
                NbCollaborateur.Text = Team.getListCollaborators().Count().ToString();
                NbCollaborateur.Name = "NbCollaborateur" + Team.getRowId();
                NbCollaborateur.UseMnemonic = true;
                NbCollaborateur.AutoSize = true;
                NbCollaborateur.Font = new Font("Cambria", 14);
                NbCollaborateur.Location = new Point(290, positionLabel);
                this.Controls.Add(NbCollaborateur);

                Label NbTask = new Label();
                List<Column> Columns = Team.getListColumns();
                List<Task> Tasks = new List<Task>();
                foreach (Column column in Columns)
                {
                   foreach (Task task in column.getListTasks())
                   {
                       if (task.isActive() == 1)
                       {
                           Tasks.Add(task);
                       }
                   }
                }
                NbTask.Text = Tasks.Count().ToString();
                NbTask.Name = "NbTask" + Team.getRowId();
                NbTask.UseMnemonic = true;
                NbTask.AutoSize = true;
                NbTask.Font = new Font("Cambria", 14);
                NbTask.Location = new Point(420, positionLabel);
                this.Controls.Add(NbTask);


                // Créer Le button
                Button button = new Button();
                button.Name = Team.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(550, positionButton);
                button.Click += new EventHandler(goToTeam);
                this.Controls.Add(button);

                positionLabel += 40;
                positionButton += 40;
            }
        }
        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToTeam(Convert.ToInt32(button.Name), "Project");
        }
    }
}
