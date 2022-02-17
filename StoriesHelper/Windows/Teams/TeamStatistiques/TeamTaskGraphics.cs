using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FluentDateTime;
using FluentDate;



namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamTaskGraphics : UserControl
    {
        protected int idTeam;

        public TeamTaskGraphics(int idTeam, string date, int relativeDate)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            Columns = Columns.OrderBy(c => c.getRank()).ToList();
            List<Collaborator> Collaborator = Team.getListCollaborators();
            List<Task> Tasks = new List<Task>();
            DateTime DateBegin = DateTime.Now;
            DateTime DateEnd = DateTime.Now;
            switch (date)
            {
                case "semaine":
                    DateBegin = DateBegin.BeginningOfWeek();
                    DateEnd = DateEnd.EndOfWeek();
                    break;
                case "mois":
                    DateBegin = DateBegin.BeginningOfMonth();
                    DateEnd = DateEnd.EndOfMonth();
                    break;
                case "annee":
                    DateBegin = DateBegin.BeginningOfYear();
                    DateEnd = DateEnd.EndOfYear();
                    break;
            }
            if(relativeDate != 0)
            {
                switch (date)
                {
                    case "jour":
                        DateBegin = DateBegin + relativeDate.Days();
                        DateEnd = DateEnd + relativeDate.Days();
                        break;
                    case "semaine":
                        DateBegin = DateBegin + relativeDate.Weeks();
                        DateEnd = DateEnd + relativeDate.Weeks();
                        break;
                    case "mois":
                        DateBegin = DateBegin + relativeDate.Months();
                        DateEnd = DateEnd + relativeDate.Months();
                        break;
                    case "annee":
                        DateBegin = DateBegin + relativeDate.Years();
                        DateEnd = DateEnd + relativeDate.Years();
                        break;
                }
            }

            foreach (Column Column in Columns)
            {
                if(Column.getName() == "Closed")
                {
                    Tasks = Column.fetchTaskBetweenTime(Column.getRowId(), DateBegin, DateEnd, true);
                    TeamGraphicsStat.Series["Tâches en cours"].Points.AddXY(Column.getName(), Tasks.Count());
                    TeamGraphicsStat.Series["Tâches en cours"].LabelBackColor = Color.Red;
                } else
                {
                    Tasks = Column.fetchTaskBetweenTime(Column.getRowId(), DateBegin, DateEnd, false);  
                    TeamGraphicsStat.Series["Tâches en cours"].Points.AddXY(Column.getName(), Tasks.Count());
                }
            }

            TitreStatistique TitreStatistique = new TitreStatistique(idTeam, date, relativeDate);
            PanelTitreStatistique.Controls.Clear();
            PanelTitreStatistique.Controls.Add(TitreStatistique);
            TitreStatistique.Show();
        }
    }
}
