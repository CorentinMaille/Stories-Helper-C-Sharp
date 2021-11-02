using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Fenetre
{
    public partial class Collaborators : UserControl
    {
        MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        public Collaborators()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void inscription(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string firstname = InputFirstname.Text;
            string lastname = InputLastname.Text;
            string email = InputEmail.Text;
            string birth = InputBirth.Value.ToString("yyyy-MM-dd");
            string password = InputPassword.Text;

            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@birth", birth);
            command.Parameters.AddWithValue("@password", password);

            command.CommandText = "INSERT INTO users (lastname, firstname, birth, password, fk_position, email, fk_organization, consent) VALUES (@firstname, @lastname, @birth, @password, 0, @email, 1, 1)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }


            conn.Close();
        }

        private void deleteUser(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string email = emailUser.Text;

            command.Parameters.AddWithValue("@email", email);

            command.CommandText = "DELETE FROM users WHERE email = @email";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression!");
            }


            conn.Close();
        }
    }
}
