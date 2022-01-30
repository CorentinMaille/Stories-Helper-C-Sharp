using StoriesHelper.Service;
using System;
using System.Collections.Generic;
using StoriesHelper.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations
{
    public partial class OrganizationListUsers : UserControl
    {
        public OrganizationListUsers()
        {
            InitializeComponent();
            Organization Organization = new Organization(Session.UserId);
            List<User> Users = Organization.getListUsers();
            Users = Users.OrderBy(u => u.getLastname()).ToList();
            int positionLabel = 20;
            int positionButton = 15;
            foreach (User User in Users)
            {
                // Créer le label Lastname
                string UserLastname = User.getLastname().ToUpper();
                string newLastname = "";
                Label LabelLastname = new Label();
                if (UserLastname.Length > 10)
                {
                    newLastname = UserLastname.Remove(10, (UserLastname.Length - 10));
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
                if (UserFirstname.Length > 10)
                {
                    newFirstname = UserFirstname.Remove(10, (UserFirstname.Length - 10));
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
                LabelFirstname.Location = new Point(100, positionLabel);
                this.Controls.Add(LabelFirstname);

                // Créer Le button
                Button button = new Button();
                button.Name = User.getLastname() + " " + User.getRowId().ToString();
                button.Text = "Aller à";
                button.Font = new Font("Cambria", 11);
                button.Size = new Size(70, 25);
                button.Location = new Point(200, positionButton);
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
