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
    public partial class Organization : UserControl
    {
        private int idOrg;
        public Organization(int idOrg)
        {
            this.idOrg = idOrg;
            InitializeComponent();
        }
    }
}
