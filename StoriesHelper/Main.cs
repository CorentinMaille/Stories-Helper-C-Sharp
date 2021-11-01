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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void collaboratorsButton_Click(object sender, EventArgs e)
        {

        }

        public void buttonHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.White;
        }
        private void buttonLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackColor = Color.HotTrack;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
