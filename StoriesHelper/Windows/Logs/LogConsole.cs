using System;
using System.Windows.Forms;
using StoriesHelper.Services;
using StoriesHelper.Models;
using System.Collections.Generic;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogConsole : UserControl
    {
        public LogConsole()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.idOrganization);
            List<LogHistory> logs = Organization.getLogs();


        }
    }
}
