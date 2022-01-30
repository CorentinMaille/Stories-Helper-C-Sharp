using StoriesHelper.Service;
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
            int positionLabel = 60;
            int positionButton = 55;
            foreach (Team Team in Teams)
            {
                // Créer le label
                string TeamName = Team.getName();
                string newName = "";
                Label Label = new Label();
                if (TeamName.Length > 15)
                {
                    newName = TeamName.Remove(15, (TeamName.Length - 15));
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
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(0, positionLabel);
                this.Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Team.getName() + " " + Team.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(150, positionButton);
                button.Click += new EventHandler(goToTeam);
                this.Controls.Add(button);

                positionLabel += 40;
                positionButton += 40;
            }
        }
        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            System.Windows.MessageBox.Show(button.Name);
        }
    }
}
