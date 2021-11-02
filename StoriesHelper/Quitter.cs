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
    public partial class Quitter : Form
    {
        public Quitter()
        {
            InitializeComponent();
        }

        private void annulerQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmerQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
