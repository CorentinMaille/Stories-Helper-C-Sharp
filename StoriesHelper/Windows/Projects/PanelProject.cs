using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Service;

namespace StoriesHelper.Windows.Projects
{
    public partial class PanelProject : UserControl
    {
        public PanelProject(int idProject)
        {
            InitializeComponent();
            Project Project = new Project(idProject);
            List<Team> Teams = Project.getListTeams();
            List<Column> Columns = new List<Column>();
            List<Task> Tasks = new List<Task>();
            List<Task> TasksClosed = new List<Task>();
            List<Task> TasksOpen = new List<Task>();
            foreach (Team team in Teams)
            {
                Columns.AddRange(team.getListColumns());
            }
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

            // Liste Teams
            ProjectListTeams ListTeams = new ProjectListTeams(idProject);
            PanelListTeams.Controls.Clear();
            PanelListTeams.Controls.Add(ListTeams);
            ListTeams.Show();
        }
    }
}
