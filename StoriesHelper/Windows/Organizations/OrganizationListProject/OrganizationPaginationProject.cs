﻿using System;
using System.Windows.Forms;
using StoriesHelper.Models;
using StoriesHelper.Services;
using StoriesHelper.Repository;
using System.Drawing;

namespace StoriesHelper.Windows.Organizations.OrganizationListProject
{
    public partial class OrganizationPaginationProject : UserControl
    {
        protected int page;
        protected bool archived;
        protected bool open;
        protected string name;
        protected string type;
        protected int pagination;
        public OrganizationPaginationProject(bool archived, bool open, int page = 0, string name = null, string type = null)
        {
            InitializeComponent();
            this.page = page;
            this.archived = archived;
            this.open = open;
            this.name = name;
            this.type = type;

            ProjectRepository ProjectRepository = new ProjectRepository();

            int NbTeam = ProjectRepository.GetProjectsByOrganization(archived, open, Session.UserId, page, name, type).Count;

            int pagination = NbTeam / 25;
            this.pagination = pagination;

            Button FastBackward = new Button();
            FastBackward.Name = "FastBackward";
            FastBackward.Text = "<<<";
            FastBackward.FlatStyle = FlatStyle.Flat;
            FastBackward.FlatAppearance.BorderSize = 0;
            FastBackward.BackColor = Color.Transparent;
            FastBackward.Cursor = Cursors.Hand;
            FastBackward.Font = new Font("Cambria", 10);
            FastBackward.AutoSize = true;
            FastBackward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FastBackward.Location = new Point(0, 2);
            FastBackward.Click += new EventHandler(goToPaginate);
            Controls.Add(FastBackward);
            
            Button Backward = new Button();
            Backward.Name = "Backward";
            Backward.Text = "<";
            Backward.FlatStyle = FlatStyle.Flat;
            Backward.FlatAppearance.BorderSize = 0;
            Backward.BackColor = Color.Transparent;
            Backward.Cursor = Cursors.Hand;
            Backward.Font = new Font("Cambria", 10);
            Backward.AutoSize = true;
            Backward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Backward.Location = new Point(50, 2);
            Backward.Click += new EventHandler(goToPaginate);
            Controls.Add(Backward);

            int positionButton = 90;

            for(int i = page - 6; i <= pagination; i++)
            {
                if(i < 0)
                {
                    continue;
                }

                if(i >= page + 6)
                {
                    continue;
                }

                Button button = new Button();
                button.Name = i.ToString();
                button.Text = i.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                if (i == page)
                {
                    button.BackColor = Color.Gray;
                }
                button.Cursor = Cursors.Hand;
                button.Font = new Font("Cambria", 10);
                button.AutoSize = true;
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.Location = new Point(positionButton, 2);
                button.Click += new EventHandler(goToPaginate);
                Controls.Add(button);

                positionButton += 30;
            }

            positionButton += 10;

            Button Forward = new Button();
            Forward.Name = "Forward";
            Forward.Text = ">";
            Forward.FlatStyle = FlatStyle.Flat;
            Forward.FlatAppearance.BorderSize = 0;
            Forward.BackColor = Color.Transparent;
            Forward.Cursor = Cursors.Hand;
            Forward.Font = new Font("Cambria", 10);
            Forward.AutoSize = true;
            Forward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Forward.Location = new Point(positionButton, 2);
            Forward.Click += new EventHandler(goToPaginate);
            Controls.Add(Forward);

            Button FastForward = new Button();
            FastForward.Name = "FastForward";
            FastForward.Text = ">>>";
            FastForward.FlatStyle = FlatStyle.Flat;
            FastForward.FlatAppearance.BorderSize = 0;
            FastForward.BackColor = Color.Transparent;
            FastForward.Cursor = Cursors.Hand;
            FastForward.Font = new Font("Cambria", 10);
            FastForward.AutoSize = true;
            FastForward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FastForward.Location = new Point(positionButton + 30, 2);
            FastForward.Click += new EventHandler(goToPaginate);
            Controls.Add(FastForward);

            Label Label = new Label();
            Label.Text = NbTeam.ToString();
            this.Controls.Add(Label);
        }

        private void goToPaginate(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (Convert.ToString(button.Name) == "FastForward")
            {
                MainOrganizationListProject.goToPaginate(archived, open, pagination, name, type);
            } 
            else if (Convert.ToString(button.Name) == "Forward") 
            {
                if (page < pagination)
                {
                    MainOrganizationListProject.goToPaginate(archived, open, page + 1, name, type); 
                }
            }
            else if (Convert.ToString(button.Name) == "Backward") 
            {
                if (page > 0)
                {
                    MainOrganizationListProject.goToPaginate(archived, open, page - 1, name, type); 
                }
            }
            else if (Convert.ToString(button.Name) == "FastBackward") 
            {
                MainOrganizationListProject.goToPaginate(archived, open, 0, name, type); 
            } 
            else
            {
                MainOrganizationListProject.goToPaginate(archived, open, Convert.ToInt32(button.Name), name, type);
            }
        }
    }
}
