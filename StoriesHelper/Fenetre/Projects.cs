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
    public partial class Projects : UserControl
    {
        private int idOrg;
        public Projects(int idOrg)
        {
            this.idOrg = idOrg;
            InitializeComponent();
        }
    }
}
