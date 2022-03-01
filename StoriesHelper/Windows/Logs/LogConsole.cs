using System;
using System.Windows.Forms;
using StoriesHelper.Services;
using StoriesHelper.Models;
using System.Collections.Generic;
using System.Drawing;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogConsole : UserControl
    {
        public LogConsole()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.idOrganization);
            
            // Display all logs in the console log
            List<LogHistory> logs = Organization.getLogs();

            foreach(LogHistory log in logs)
            {
                // creation of the date_creation label
                Label label_date_creation = new Label();

                string date_creation = log.getDate_creation().ToString();
                label_date_creation.Text = date_creation;

                label_date_creation.ForeColor = Color.ForestGreen;
                label_date_creation.Name = "label_date_creation_" + log.getRowid().ToString();

                // creation of the platform label

                Label label_platform = new Label();

                string platform = log.getPlatform().ToString();
                label_platform.Text = platform;

                label_platform.ForeColor = Color.Gray;
                label_platform.Name = "label_platform_" + log.getRowid().ToString();

                // creation of the status label

                Label label_status = new Label();

                string status = log.getStatus();
                label_status.Text = status;

                switch (status)
                {
                    case "INFO":

                        break
                    case "WARNING":

                        break;



                }
                label_status.ForeColor = Color.




                // creation of the action label
            }
        }
    }
}
