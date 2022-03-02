using System.Windows.Forms;
using StoriesHelper.Models;
using System;

namespace StoriesHelper.Windows.Users.UserInterface
{
    public partial class UserInterfaceMain : UserControl
    {
        private int idUser;
        private string from;
        private Collaborator Collaborator;
        public UserInterfaceMain(int idUser, string from)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.from = from;

            Collaborator Collaborator = new Collaborator(idUser);
            this.Collaborator = Collaborator;
            textName.Text = Collaborator.getLastname();
            textFirstname.Text = Collaborator.getFirstname();
            textEmail.Text = Collaborator.getEmail();
            dateTimeBirthDay.Value = Collaborator.getBirth();
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
            Collaborator.setFirstname(textFirstname.Text);
            Collaborator.setLastname(textName.Text);
            Collaborator.setEmail(textEmail.Text);
            Collaborator.setFirstname(textName.Text);
            Collaborator.update();
            MessageBox.Show("Les informations ont bien été mise à jour.");
        }
    }
}
