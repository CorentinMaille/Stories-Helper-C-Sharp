using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace StoriesHelper
{
    public partial class pageConnexion : Form
    {
        MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        public pageConnexion()
        {
            InitializeComponent();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                conn.Open();
                MessageBox.Show("Connexion effectuée !");
            } catch {
                MessageBox.Show("Connexion échouée !");
            }
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();
            string mdp = passwordInput.Text;
            string email = emailInput.Text;
            command.Parameters.AddWithValue("@email", email);
            command.CommandText = "SELECT password FROM organizations WHERE email = @email";
            MySqlDataReader reader = command.ExecuteReader();
            string mdpHash = "";
            MessageBox.Show(mdp);
            while (reader.Read())
            {
                mdpHash = reader.GetString(0);
            }
            MessageBox.Show(mdpHash);
            bool verified = BC.Verify(mdp, mdpHash);
            if (verified)
            {
                MessageBox.Show("Le mot de passe est correct");
            } else
            {
                MessageBox.Show("Le mot de passe est incorrect");
            }
        }
    }
}
