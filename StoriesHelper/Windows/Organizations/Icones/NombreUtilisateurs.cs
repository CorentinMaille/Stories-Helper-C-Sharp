﻿using StoriesHelper.Properties;
using StoriesHelper.Repository;
using StoriesHelper.Services;
using StoriesHelper.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoriesHelper.Windows.Organizations.Icones
{
    public partial class NombreUtilisateurs : UserControl
    {
        public NombreUtilisateurs()
        {
            InitializeComponent();

            UserRepository UserRepository = new UserRepository();

            int NbUser = UserRepository.getAllUserFromOrganization(Session.UserId, pagination: false).Count();

            Label Titre = new Label();
            Titre.Name = "TitreNbUtilisateur";
            Titre.Text = "Nb Utilisateurs";
            Titre.Location = new Point(35, 130);
            Titre.BackColor = Color.Transparent;
            Titre.UseMnemonic = true;
            Titre.AutoSize = true;
            Titre.Font = new Font("Cambria", 13, FontStyle.Bold);
            Controls.Add(Titre);

            Label Nombre = new Label();
            Nombre.Name = "Nombre";
            Nombre.Text = NbUser.ToString();
            Nombre.Location = new Point(65, 155);
            Nombre.BackColor = Color.Transparent;
            Nombre.UseMnemonic = true;
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Cambria", 22, FontStyle.Bold);
            Controls.Add(Nombre);

            IconeUser IconeUser = new IconeUser();
            IconeUser.Size = new Size(150, 175);
            IconeUser.Location = new Point(25, 25);
            Controls.Add(IconeUser);

            for (int i = 0; i <= 25; i++)
            {
                if (i <= 5)
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(150 + 2 * i, 175 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(42 + (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
                else
                {
                    UserControl OmbreUtilisateur = new UserControl();
                    OmbreUtilisateur.Name = "OmbreUtilisateur" + i.ToString();
                    OmbreUtilisateur.Size = new Size(150 + 2 * i, 175 + 2 * i);
                    OmbreUtilisateur.Location = new Point(25 - i, 25 - i);
                    OmbreUtilisateur.BackColor = Color.FromArgb(75 - (3 * i), 0, 0, 0);
                    Controls.Add(OmbreUtilisateur);
                    OmbreUtilisateur.Show();
                }
            }
        }
    }
}
