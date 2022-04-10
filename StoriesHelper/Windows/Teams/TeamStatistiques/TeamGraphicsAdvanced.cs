using StoriesHelper.Repository;
using StoriesHelper.Models;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using FluentDate;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    public partial class TeamGraphicsAdvanced : UserControl
    {
        protected int idTeam;
        public TeamGraphicsAdvanced(int idTeam)
        {
            InitializeComponent();
            ColumnStateRepository TaskStateRepository = new ColumnStateRepository();
            this.idTeam = idTeam;
            Team Team = new Team(idTeam);
            List<Column> Columns = Team.getListColumns();
            List<Task> Tasks = new List<Task>();

            DateTime DateBegin = DateTime.Now - 1.Months();
            DateTime DateEnd = DateTime.Now;

            string dateBegin = "";
            string dateEnd = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");

            while (DateBegin <= DateEnd)
            {
                dateBegin = DateBegin.ToString("yyyy-MM-dd 00:00:00");
                List<ColumnState> ColumnStates = TaskStateRepository.fetchBackupColumn(idTeam, dateBegin, "jour");
                foreach (ColumnState ColumnState in ColumnStates)
                {
                    string series = ColumnState.getColumnName();
                    if (TeamGraphics.Series[series] != null) { 
                        TeamGraphics.Series.Add(series);
                    }
                    TeamGraphics.Series[series].ChartType = SeriesChartType.StackedArea100;
                    TeamGraphics.Series[series].Points.AddXY(ColumnState.getColumnName(), ColumnState.getNbTask());
                }
                DateBegin = DateBegin + 1.Days();
            }
        }
    }
}
