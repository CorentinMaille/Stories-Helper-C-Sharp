using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoriesHelper.Modeles
{
    class Model
    {
        protected MySqlConnection conn;

        protected Model()
        {
            MySqlConnection conn = new MySqlConnection("database=projet;server=localhost;user id = root;pwd=");
        }
    }
}
