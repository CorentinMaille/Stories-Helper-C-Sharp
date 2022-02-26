using FluentDate;
using FluentDateTime;
using System;
using System.Linq;
using System.Windows.Forms;
using StoriesHelper.Models;
using System.Collections.Generic;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TitreStatistique : UserControl
    {
        protected int idTeam;
        public TitreStatistique(int idTeam, string date, int relativeDate)
        {
            InitializeComponent();
            this.idTeam = idTeam;
            bool ret = calculateTime(date, relativeDate, out DateTime DateBegin, out DateTime DateEnd);
            bool previousRet = calculateTime(date, relativeDate, out DateTime PreviousDateBegin, out DateTime PreviousDateEnd);

            AfficherTitre(date, DateBegin, DateEnd);
            AfficherRendement(idTeam, DateBegin, DateEnd);

            Titre.Left = (this.ClientSize.Width - Titre.Width) / 2;
            Rendement.Left = (this.ClientSize.Width - Rendement.Width) / 2;
            Taches.Left = (this.ClientSize.Width - Taches.Width) / 2;
            ValueTache.Left = (this.ClientSize.Width - ValueTache.Width) / 2;
            ValueRendement.Left = (this.ClientSize.Width - ValueRendement.Width) / 2;
        }

        private void AfficherTitre(string date, DateTime DateBegin, DateTime DateEnd)
        {
            switch (date)
            {
                case "jour":
                    Titre.Text = DateBegin.ToString("dd/MM/yyyy");
                    break;
                case "semaine":
                    int week = CalculateWeeks(DateBegin);
                    Titre.Text = DateBegin.ToString("yyyy") + " Semaine " + week;
                    break;
                case "mois":
                    string month = DateBegin.ToString("MMMM").First().ToString().ToUpper() + DateBegin.ToString("MMMM").Substring(1);
                    Titre.Text = month + " " + DateBegin.ToString("yyyy");
                    break;
                case "annee":
                    Titre.Text = "Année " + DateBegin.ToString("yyyy");
                    break;
            }
        }

        private void AfficherRendement(int idTeam, DateTime DateBegin, DateTime DateEnd)
        {
            List<Task> TasksClosed = new List<Task>();
            List<Task> Tasks = new List<Task>();
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            Columns = Columns.OrderBy(c => c.getRank()).ToList();
            foreach (Column Column in Columns)
            {
                if (Column.getName() == "Closed")
                {
                    TasksClosed = Column.fetchTaskBetweenTime(Column.getRowId(), DateBegin, DateEnd, true);
                }
                else
                {
                    Tasks.AddRange(Column.fetchTaskBetweenTime(Column.getRowId(), DateBegin, DateEnd, false));
                }
            }

            double rendement = CalculateRendement(TasksClosed.Count(), Tasks.Count());
            ValueRendement.Text = rendement.ToString();
        }

        private int CalculateWeeks(DateTime DateWeekBegin)
        {
            DateTime beginOfTheYear = DateTime.Now.BeginningOfYear();

            while(DateWeekBegin.BeginningOfYear() != beginOfTheYear)
            {
                if(DateWeekBegin.BeginningOfYear() < beginOfTheYear)
                {
                    DateWeekBegin = DateWeekBegin.NextYear();
                } else
                {
                    DateWeekBegin = DateWeekBegin.PreviousYear();
                }
            }

            int week = 0;
            while (beginOfTheYear < DateWeekBegin)
            {
                beginOfTheYear = beginOfTheYear.WeekAfter();
                week++;
            }
            return week;
        }

        private bool calculateTime(string date, int relativeDate, out DateTime DateBegin, out DateTime DateEnd)
        {
            DateBegin = DateTime.Now;
            DateEnd = DateTime.Now;
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
            if (relativeDate != 0)
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

            return true;
        }

        private double CalculateRendement(double tasksClosed, double tasks)
        {
            double result = tasksClosed;
            if(tasks != 0)
            {
                result = (tasksClosed / tasks) ;
            }
            return result;
        }
    }
}
