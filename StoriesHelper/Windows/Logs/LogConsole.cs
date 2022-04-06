using System;
using System.Windows.Forms;
using StoriesHelper.Services;
using StoriesHelper.Models;
using System.Collections.Generic;
using System.Drawing;
using StoriesHelper.Repository;
using StoriesHelper.Models;
using System.Linq;

namespace StoriesHelper.Windows.Logs
{
    public partial class LogConsole : UserControl
    {
        public LogConsole()
        {
            InitializeComponent();

            // Display 100 logs in the console log
            LogHistoryRepository logHistoryRepository = new LogHistoryRepository();
            List<LogHistory> logs = logHistoryRepository.GetLogsByOrganization(Session.UserId);
            logs = logs.OrderBy(dc => dc.getDate_creation()).ToList();
            RichTextBox Line = new RichTextBox();
            Line.Size = new Size(900, 600);
            Line.Multiline = true;
            Line.MaxLength = 2147483647;
            Line.Location = new Point(10, 5);
            Line.BackColor = Color.Black;
            Line.BorderStyle = BorderStyle.None;
            Line.ReadOnly = true;
            foreach (LogHistory log in logs)
            {
                string date = log.getDate_creation().ToString("yyyy MMM dd HH:mm:ss");
/*                string ip = "[" + log.getIp().ToString() + "]";*/
                User User = new User(log.getFk_author());
                string auteur = User.getRowId().ToString();
                if (User.getLastname() == null && User.getFirstname() == null)
                {
                    auteur = "ADMIN";
                } else
                {
                    auteur = User.getLastname() + " " + User.getFirstname();
                }
                string action = log.getAction();
                string objectName = log.getObject_name();
                string objectType = log.getObject_type();
                string status = "[" + log.getStatus() + "]";
                string exception = log.getException();

                rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, date, Line);
                Line.AppendText(" ");
                switch (status)
                {
                    case "[INFO]":
                        rtb_AppendText(new Font("Cambria", 12), Color.DodgerBlue, Color.Black, status, Line);
                        break;
                    case "[WARNING]":
                        rtb_AppendText(new Font("Cambria", 12), Color.Yellow, Color.Black, status, Line);
                        break;
                    case "[ERROR]":
                        rtb_AppendText(new Font("Cambria", 12), Color.Red, Color.Black, status, Line);
                        break;
                    case "[IMPORTANT]":
                        rtb_AppendText(new Font("Cambria", 12), Color.Orange, Color.Black, status, Line);
                        break;
                }
                this.Controls.Add(Line);
                rtb_AppendText(new Font("Cambria", 12), Color.Green, Color.Black, "[" + User.getRowId().ToString() + "] ", Line);
                rtb_AppendText(new Font("Cambria", 12), Color.Green, Color.Black, auteur, Line);
                Line.AppendText(" "); 
                rtb_AppendText(new Font("Cambria", 12), Color.Orange , Color.Black, action, Line);
                Line.AppendText(" ");
                rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, objectType, Line);
                rtb_AppendText(new Font("Cambria", 12), Color.White, Color.Black, "[id]", Line);
                Line.AppendText(" ");

                if (status == "[ERROR]") {
                    rtb_AppendText(new Font("Cambria", 12), Color.Red, Color.Black, "Create an error : " + exception, Line);
                }

                Line.AppendText("\n");
            }
        }

        private void rtb_AppendText(Font selfont, Color color, Color bcolor, string text, RichTextBox Rtb)

        {
            //append the text to the RichTextBox control
            int start = Rtb.TextLength;
            Rtb.AppendText(text);
            int end = Rtb.TextLength;
            //select the new text
            Rtb.Select(start, end - start);
            //set the attributes of the new text
            Rtb.SelectionColor = color;
            Rtb.SelectionFont = selfont;
            Rtb.SelectionBackColor = bcolor;
            //unselect
            Rtb.Select(end, 0);
            //only required for multi line text to scroll to the end
            Rtb.ScrollToCaret();
        }
        
    }
}