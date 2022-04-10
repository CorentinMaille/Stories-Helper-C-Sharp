using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Windows.Users;

namespace StoriesHelper.Windows.Users.UserInterface
{
    public partial class UserInterface : Form
    {
        private int idUser;
        private User User;
        public UserInterface(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;

            User User = new User(idUser);
            this.User = User;
            textName.Text = User.getLastname();
            textFirstname.Text = User.getFirstname();
            textEmail.Text = User.getEmail();
            dateTimeBirthDay.Value = User.getBirth();
            radioCollaborateur.Checked = true;
            if (User.isAdmin())
            {
                radioAdministrateur.Checked = true;
            }
        }

        private void update_Click(object sender, System.EventArgs e)
        {
            User.setFirstname(textFirstname.Text);
            User.setLastname(textName.Text);
            User.setEmail(textEmail.Text);
            User.setBirth(dateTimeBirthDay.Value);
            User.setAdmin(false);
            if (radioAdministrateur.Checked == true)
            {
                User.setAdmin(true);
            }
            User.update();
            MessageBox.Show("Les informations ont bien été mise à jour.");
            this.Close();

            UserMainList.goToPaginateUser();
        }
    }
}
