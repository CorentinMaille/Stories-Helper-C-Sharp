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

namespace StoriesHelper
{
    public partial class Organization : UserControl
    {
        MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        public Organization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string name = modOrgNomInput.Text;
            command.Parameters.AddWithValue("@name", name);
            command.CommandText = "UPDATE Organizations set name = @name WHERE rowid = 3";
            if (command.ExecuteNonQuery() > 0) 
            { 
                MessageBox.Show("Insertion effectuée!"); 
            } else {
                MessageBox.Show("Erreur lors de l’insertion!"); 
            }
            conn.Close();
        }
    }
}
