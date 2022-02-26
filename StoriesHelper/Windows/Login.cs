using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StoriesHelper.Services;

namespace StoriesHelper.Windows
{
    using BCrypt.Net;

    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("database=storieshelper;server=localhost;user id = root;pwd=");
        public Login()
        {
            InitializeComponent();

        }

        private void connexion_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string mdp = passwordInput.Text;
            string email = emailInput.Text;
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT rowid, email, password, fk_organization FROM storieshelper_user WHERE email = @email AND admin = 1";
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
                    idOrg = reader.GetInt32(3);
                }

                if (BCrypt.Verify(mdp, mdpHash))
                {

                    Session.UserId = idOrg;
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
            Application.Exit();
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