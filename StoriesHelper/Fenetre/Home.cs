using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Fenetre
{
    public partial class Home : UserControl
    {
        private int idOrg;
        public Home(int idOrg)
        {
            this.idOrg = idOrg;
            InitializeComponent();
        }
    }
}
