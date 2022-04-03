using System;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogMain : UserControl
    {
        public LogMain()
        {
            InitializeComponent();
            LogConsole LogConsoleContent = new LogConsole();

            PanelLogConsole.Controls.Clear();
            PanelLogConsole.Controls.Add(LogConsoleContent);

            LogConsoleContent.Show();
        }
    }
}
