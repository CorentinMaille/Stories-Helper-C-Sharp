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
    }
}
