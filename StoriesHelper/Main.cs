using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Home HomeContent = new Home();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(HomeContent);

            HomeContent.Show();

           
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.White;
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = SystemColors.HotTrack;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void organisationButton_Click(object sender, EventArgs e)
        {
            Organization OrganizationContent = new Organization();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(OrganizationContent);

            OrganizationContent.Show();
        }
        private void collaboratorsButton_Click(object sender, EventArgs e)
        {
            Collaborators CollaboratorsContent = new Collaborators();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(CollaboratorsContent);

            CollaboratorsContent.Show();
        }
        private void ProjectsButton_Click(object sender, EventArgs e)
        {
            Projects ProjectContent = new Projects();

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(ProjectContent);

            ProjectContent.Show();
        }
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
