using System;
using System.Drawing;
using System.Windows.Forms;
using StoriesHelper.Service;

namespace StoriesHelper.Windows
{
    public partial class main : MyDraggableForm
    {
        private int id; 
        public main()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1167, 718);

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
            PanelOrganization OrganizationContent = new PanelOrganization();

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
            Quitter quitter = new Quitter();
            quitter.Show();
        }

        protected void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MyDraggableForm mdf = new MyDraggableForm();
            mdf.Drag(sender, e, Handle);
        }

        private void Disconect_button_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Hide();
        }
    }
}
