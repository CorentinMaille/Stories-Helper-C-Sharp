using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StoriesHelper.Service;

namespace StoriesHelper.Windows
{
    using BCrypt.Net;
    using StoriesHelper.Models;
    using System.Collections.Generic;

    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        public Login()
        {
            InitializeComponent();
            titre.Left = (this.ClientSize.Width - titre.Width) / 2;
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string mdp = passwordInput.Text;
            string email = emailInput.Text;
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT rowid, email, password FROM organizations WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            string mdpHash = "";
            int idOrg = 0;
            if (reader.HasRows)
            {
                erreurEmail.Text = "";
                erreurPassword.Text = "";
                while (reader.Read())
                {
                    mdpHash = reader.GetString(2);
                    idOrg = reader.GetInt32(0);
                }

                if (BCrypt.Verify(mdp, mdpHash))
                {
                    // SECTION TEST !!!
                    // Test Organisation
                    /* Organization organization = new Organization(3);
                       List<Project> listProject = organization.getListProjects();
                       foreach(Project project in listProject)
                       {
                           MessageBox.Show(project.getRowId() + " " + project.getName() + " " + project.getOpen().ToString("d"));
                           List<Team> listTeam = project.getListTeams();
                           foreach (Team team in listTeam)
                           {
                               MessageBox.Show(team.getName());
                               List<User> listUser = team.getListUsers();
                               foreach (User user in listUser)
                               {
                                   MessageBox.Show(user.getFirstname() + " " + user.getLastname() + " " + user.getBirth().ToString("d"));

                               }
                           }
                       }*/

                    // Test la récupération des tâches depuis Team
                    /*
                        Team team = new Team(1);
                        List<MapColumns> listColumns = team.getListColumns();
                        foreach(MapColumns column in listColumns)
                        {
                            MessageBox.Show(column.getName());
                            List<Task> listTask = column.getListTasks();
                            foreach(Task task in listTask)
                            {
                                MessageBox.Show(task.getName() + " " + task.getDescription());
                            }
                        }*/


                    // FIN DE LA SECTION TEST !!!

                    main WelcomeWindow = new main();

                    WelcomeWindow.Show();
                    this.Hide();
                }
                else
                {
                    erreurPassword.Text = "*Le mot de passe est incorrect";
                }
            }
            else
            {
                erreurEmail.Text = "*Email incorrect";
            }
            conn.Close();
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MyDraggableForm mdf = new MyDraggableForm();
            mdf.Drag(sender, e, Handle);
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.connexion_Click(sender, e);
            }
        }
    }
}