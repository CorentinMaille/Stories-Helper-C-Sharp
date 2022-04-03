using System.Windows.Forms;
using StoriesHelper.Models;
using System;

namespace StoriesHelper.Windows.Users.UserInterface
{
    public partial class UserInterfaceMain : UserControl
    {
        private int idUser;
        private string from;
        private User User;
        public UserInterfaceMain(int idUser, string from)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.from = from;

            User User = new User(idUser);
            this.User = User;
            textName.Text = User.getLastname();
            textFirstname.Text = User.getFirstname();
            textEmail.Text = User.getEmail();
            dateTimeBirthDay.Value = User.getBirth();
        }

        private void retour_Click(object sender, System.EventArgs e)
        {

            if (from == "ListUser")
            {
                main.goToListUser();
            }
            else if (from == "Organization")
            {
                main.goToOrganization();
            } 
            else
            {
                main.goToTeam(Int32.Parse(from), "Organization");
            }
        }

        private void update_Click(object sender, System.EventArgs e)
        {
            User.setFirstname(textFirstname.Text);
            User.setLastname(textName.Text);
            User.setEmail(textEmail.Text);
            User.setFirstname(textName.Text);
            User.update();
            MessageBox.Show("Les informations ont bien été mise à jour.");
        }
    }
}
