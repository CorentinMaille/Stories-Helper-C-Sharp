using StoriesHelper.Services;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationListTeams : UserControl
    {
        public OrganizationListTeams(bool archived = false, bool open = true)
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);
            List<Project> Projects = Organization.getListProjects();
            List<Team> ListTeams = new List<Team>();
            List<Team> Teams = new List<Team>();
            foreach (Project project in Projects)
            {
                ListTeams.Clear();
                ListTeams.AddRange(project.getListTeams());
                if (archived && open)
                {
                    Teams.AddRange(project.getListTeams());
                }
                else if (archived && !open)
                {
                    foreach (Team Team in ListTeams)
                    {
                        if (!Team.isActive())
                        {
                            Teams.Add(Team);
                        }
                    }
                }
                else if (!archived && open)
                {
                    foreach (Team Team in ListTeams)
                    {
                        if (Team.isActive())
                        {
                            Teams.Add(Team);
                        }
                    }
                }
            }
            Teams = Teams.OrderBy(t => t.getName()).ToList();
            int positionLabel = 20;
            int positionButton = 15;
            int positionLigne = 47;

            // Créer la ligne du haut
            LigneHorizontale LigneHorizontale = new LigneHorizontale();
            LigneHorizontale.Name = "FirstLine";
            LigneHorizontale.Location = new Point(0, 7);
            LigneHorizontale.Width = 280;
            LigneHorizontale.Height = 2;
            this.Controls.Add(LigneHorizontale);

            foreach (Team Team in Teams)
            {
                // Créer le label
                string TeamName = Team.getName();
                string newName = "";
                Label Label = new Label();
                if (TeamName.Length > 25)
                {
                    newName = TeamName.Remove(25, (TeamName.Length - 25));
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
                if (!Team.isActive())
                {
                    Label.ForeColor = Color.Red;
                }
                Label.Font = new Font("Cambria", 11);
                Label.Location = new Point(1, positionLabel);
                this.Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Team.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(200, positionButton);
                button.Click += new EventHandler(goToTeam);
                this.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Team.getRowId().ToString();
                LigneHorizontale.Location = new Point(0, positionLigne);
                LigneHorizontale.Width = 280;
                LigneHorizontale.Height = 1;
                this.Controls.Add(LigneHorizontale);

                positionLabel += 40;
                positionButton += 40;
                positionLigne += 40;
            }
        }

        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToTeam(Convert.ToInt32(button.Name), "Organization");
        }
    }
}
