using StoriesHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Teams
{
    public partial class TeamListUsers : UserControl
    {
        public TeamListUsers(int idTeam)
        {
            InitializeComponent();
            Team Team = new Team(idTeam);
            List<Collaborator> Users = Team.getListCollaborators();
            Users = Users.OrderBy(u => u.getLastname()).ToList();
            int positionLabel = 20;
            int positionButton = 15;
            foreach (Collaborator User in Users)
            {
                // Créer le label Lastname
                string UserLastname = User.getLastname().ToUpper();
                string newLastname = "";
                Label LabelLastname = new Label();
                if (UserLastname.Length > 20)
                {
                    newLastname = UserLastname.Remove(20, (UserLastname.Length - 20));
                    newLastname = newLastname.Insert(newLastname.Length, "...");
                    LabelLastname.Text = "- " + newLastname;
                    LabelLastname.Name = newLastname + User.getRowId();
                }
                else
                {
                    LabelLastname.Text = "- " + UserLastname;
                    LabelLastname.Name = UserLastname + User.getRowId();
                }
                LabelLastname.UseMnemonic = true;
                LabelLastname.AutoSize = true;
                LabelLastname.Font = new Font("Cambria", 11);
                LabelLastname.Location = new Point(0, positionLabel);
                this.Controls.Add(LabelLastname);

                // Créer le label Firstname
                string UserFirstname = User.getFirstname();
                string newFirstname = "";
                Label LabelFirstname = new Label();
                if (UserFirstname.Length > 20)
                {
                    newFirstname = UserFirstname.Remove(20, (UserFirstname.Length - 20));
                    newFirstname = newFirstname.Insert(newFirstname.Length, "...");
                    LabelFirstname.Text = newFirstname;
                    LabelFirstname.Name = newFirstname + User.getRowId();
                }
                else
                {
                    LabelFirstname.Text = UserFirstname;
                    LabelFirstname.Name = UserFirstname + User.getRowId();
                }
                LabelFirstname.UseMnemonic = true;
                LabelFirstname.AutoSize = true;
                LabelFirstname.Font = new Font("Cambria", 11);
                LabelFirstname.Location = new Point(130, positionLabel);
                this.Controls.Add(LabelFirstname);

                // Créer le label Email
                string UserEmail = User.getEmail();
                string newLabelEmail = "";
                Label LabelEmail = new Label();
                if (UserEmail.Length > 28)
                {
                    newLabelEmail = UserEmail.Remove(25, (UserEmail.Length - 25));
                    newLabelEmail = newLabelEmail.Insert(newLabelEmail.Length, "...");
                    LabelEmail.Text = newLabelEmail;
                    LabelEmail.Name = newLabelEmail + User.getRowId();
                }
                else
                {
                    LabelEmail.Text = UserEmail;
                    LabelEmail.Name = UserEmail + User.getRowId();
                }
                LabelEmail.UseMnemonic = true;
                LabelEmail.AutoSize = true;
                LabelEmail.Font = new Font("Cambria", 11);
                LabelEmail.Location = new Point(270, positionLabel);
                this.Controls.Add(LabelEmail);

                // Créer Le button
                Button button = new Button();
                button.Name = User.getLastname() + " " + User.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(475, positionButton);
                button.Click += new EventHandler(goToUser);
                this.Controls.Add(button);

                positionLabel += 40;
                positionButton += 40;
            }
        }
        private void goToUser(object sender, EventArgs e)
        {
            Button button = sender as Button;
            System.Windows.MessageBox.Show(button.Name);
        }
    }
}
