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
            int positionLabel = 10;
            int positionButton = 7;
            int positionBackColor = 7;
            int rang = 0;

            foreach (Team Team in Teams)
            {
                // créer le fond coloré.
                Gradient BackColor = new Gradient();
                BackColor.Name = "BackColor" + Team.getRowId().ToString();
                BackColor.Location = new Point(0, positionBackColor);
                BackColor.Size = new Size(500, 40);
                if (rang % 2 == 0)
                {
                    BackColor.BackColor = Color.CornflowerBlue;
                }
                else
                {
                    BackColor.BackColor = Color.LightSkyBlue;
                }
                this.Controls.Add(BackColor);

                // Créer le label
                string TeamName = Team.getName();
                string newName = "";
                Label Label = new Label();
                if (TeamName.Length > 50)
                {
                    newName = TeamName.Remove(50, (TeamName.Length - 50));
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
                BackColor.Controls.Add(Label);

                // Créer Le button
                Button button = new Button();
                button.Name = Team.getRowId().ToString();
                button.Text = "Aller à";
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Gray;
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(400, positionButton);
                button.Click += new EventHandler(goToTeam);
                BackColor.Controls.Add(button);

                // Créer la ligne
                LigneHorizontale LigneHorizontale = new LigneHorizontale();
                LigneHorizontale.Name = "Ligne" + Team.getRowId().ToString();
                LigneHorizontale.Location = new Point(0, 0);
                LigneHorizontale.Width = 500;
                LigneHorizontale.Height = 1;
                BackColor.Controls.Add(LigneHorizontale);

                positionBackColor += 40;
                rang += 1;
            }

            // Créer la ligne Verticale Gauche
            LigneVerticale LigneVerticaleGauche = new LigneVerticale();
            LigneVerticaleGauche.Name = "LigneVerticaleGauche";
            LigneVerticaleGauche.Location = new Point(0, 0);
            LigneVerticaleGauche.Width = positionBackColor;
            LigneVerticaleGauche.Height = 1;
            this.Controls.Add(LigneVerticaleGauche);

            // Créer la ligne Verticale Droite
            LigneVerticale LigneVerticaleDroite = new LigneVerticale();
            LigneVerticaleDroite.Name = "LigneVerticaleDroite";
            LigneVerticaleDroite.Location = new Point(500, 0);
            LigneVerticaleDroite.Width = positionBackColor;
            LigneVerticaleDroite.Height = 1;
            this.Controls.Add(LigneVerticaleDroite);

        }

        private void goToTeam(object sender, EventArgs e)
        {
            Button button = sender as Button;
            main.goToTeam(Convert.ToInt32(button.Name), "Organization");
        }
    }
}
