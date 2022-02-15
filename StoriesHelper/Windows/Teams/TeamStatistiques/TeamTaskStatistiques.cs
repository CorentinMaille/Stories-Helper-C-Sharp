using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamTaskStatistiques : UserControl
    {
        protected int idTeam;
        protected string date;
        protected int relativeDate;
        public TeamTaskStatistiques(int idTeam)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            relativeDate = 0;
            date = "mois";

            TeamTaskGraphics TeamTaskGraphics = new TeamTaskGraphics(idTeam, date, relativeDate);
            PanelTeamTaskGraphics.Controls.Clear();
            PanelTeamTaskGraphics.Controls.Add(TeamTaskGraphics);
            TeamTaskGraphics.Show();
        }

        private void btnDateGraphics(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "precedent":
                    relativeDate--;
                    break;
                case "suivant":
                    relativeDate++;
                    break;
                default:
                    relativeDate = 0;
                    date = button.Name;
                    break;
            }

            TeamTaskGraphics TeamTaskGraphics = new TeamTaskGraphics(idTeam, date, relativeDate);
            PanelTeamTaskGraphics.Controls.Clear();
            PanelTeamTaskGraphics.Controls.Add(TeamTaskGraphics);
            TeamTaskGraphics.Show();
        }
    }
}
