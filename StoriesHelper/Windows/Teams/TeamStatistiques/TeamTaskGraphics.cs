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
            List<Collaborator> Collaborator = Team.getListCollaborators();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            foreach (Column column in Columns)
            {
                Tasks.AddRange(column.getListTasks());
            }
            foreach (Task task in Tasks)
            {
                if (task.isActive())
                {
                    TasksOpen.Add(task);
                }
                else
                {
                    TasksClosed.Add(task);
                }
            }
            TeamGraphicsStat.Series["Tâches en cours"].IsValueShownAsLabel = true;
            TeamGraphicsStat.Series["Tâches archivées"].IsValueShownAsLabel = true;
            foreach (Column Column in Columns)
            {
                TeamGraphicsStat.Series["Tâches en cours"].Points.AddXY(Column.getName(), 1);
                TeamGraphicsStat.Series["Tâches archivées"].Points.AddXY(Column.getName(), TasksClosed.Count());
            }
        }
    }
}
