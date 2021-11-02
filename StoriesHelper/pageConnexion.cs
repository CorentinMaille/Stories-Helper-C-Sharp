using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StoriesHelper
{
    using BCrypt.Net;

    public partial class pageConnexion : Form
    {


        MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        public pageConnexion()
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
            command.CommandText = "SELECT email, password FROM organizations WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            string mdpHash = "";
            if (reader.HasRows)
            {
                erreurEmail.Text = "";
                erreurPassword.Text = "";
                while (reader.Read())
                {
                    mdpHash = reader.GetString(1);
                }

                if (BCrypt.Verify(mdp, mdpHash))
                {
                    Main WelcomeWindow = new Main();

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
    }
}