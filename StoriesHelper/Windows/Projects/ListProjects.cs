using StoriesHelper.Models;
using StoriesHelper.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Projects
{
    public partial class ListProjects : UserControl
    {
        public ListProjects()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);
            List<Project> Projects = organization.getListProjects();

        }
    }
}
