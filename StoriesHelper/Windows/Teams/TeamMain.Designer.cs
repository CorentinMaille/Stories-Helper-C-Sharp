
namespace StoriesHelper.Windows.Teams
{
    partial class TeamMain
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientPanelTeam = new StoriesHelper.Services.GradientPageConnexion();
            this.buttonArchiverTeam = new System.Windows.Forms.Button();
            this.buttonSupprimerTeam = new System.Windows.Forms.Button();
            this.ArchivedTeam = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.PanelListUsers = new System.Windows.Forms.Panel();
            this.retour = new System.Windows.Forms.Button();
            this.panelShowStatistiqueTeam = new System.Windows.Forms.Panel();
            this.labelNbCollaborateur = new System.Windows.Forms.Label();
            this.LabelTitreTeam = new System.Windows.Forms.Label();
            this.gradientPanelTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelTeam
            // 
            this.gradientPanelTeam.Angle = 0F;
            this.gradientPanelTeam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradientPanelTeam.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanelTeam.Controls.Add(this.buttonArchiverTeam);
            this.gradientPanelTeam.Controls.Add(this.buttonSupprimerTeam);
            this.gradientPanelTeam.Controls.Add(this.ArchivedTeam);
            this.gradientPanelTeam.Controls.Add(this.Email);
            this.gradientPanelTeam.Controls.Add(this.Prenom);
            this.gradientPanelTeam.Controls.Add(this.Nom);
            this.gradientPanelTeam.Controls.Add(this.PanelListUsers);
            this.gradientPanelTeam.Controls.Add(this.retour);
            this.gradientPanelTeam.Controls.Add(this.panelShowStatistiqueTeam);
            this.gradientPanelTeam.Controls.Add(this.labelNbCollaborateur);
            this.gradientPanelTeam.Controls.Add(this.LabelTitreTeam);
            this.gradientPanelTeam.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelTeam.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanelTeam.Name = "gradientPanelTeam";
            this.gradientPanelTeam.Size = new System.Drawing.Size(1468, 1108);
            this.gradientPanelTeam.TabIndex = 0;
            this.gradientPanelTeam.TopColor = System.Drawing.Color.Empty;
            // 
            // buttonArchiverTeam
            // 
            this.buttonArchiverTeam.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonArchiverTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArchiverTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchiverTeam.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.buttonArchiverTeam.Location = new System.Drawing.Point(280, 999);
            this.buttonArchiverTeam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArchiverTeam.Name = "buttonArchiverTeam";
            this.buttonArchiverTeam.Size = new System.Drawing.Size(167, 68);
            this.buttonArchiverTeam.TabIndex = 36;
            this.buttonArchiverTeam.Text = "Archiver la team";
            this.buttonArchiverTeam.UseVisualStyleBackColor = false;
            this.buttonArchiverTeam.Click += new System.EventHandler(this.buttonArchiverTeam_Click);
            // 
            // buttonSupprimerTeam
            // 
            this.buttonSupprimerTeam.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimerTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerTeam.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSupprimerTeam.Location = new System.Drawing.Point(64, 999);
            this.buttonSupprimerTeam.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimerTeam.Name = "buttonSupprimerTeam";
            this.buttonSupprimerTeam.Size = new System.Drawing.Size(167, 68);
            this.buttonSupprimerTeam.TabIndex = 35;
            this.buttonSupprimerTeam.Text = "Supprimer la team";
            this.buttonSupprimerTeam.UseVisualStyleBackColor = false;
            this.buttonSupprimerTeam.Click += new System.EventHandler(this.buttonSupprimerTeam_Click);
            // 
            // ArchivedTeam
            // 
            this.ArchivedTeam.AutoSize = true;
            this.ArchivedTeam.BackColor = System.Drawing.Color.Transparent;
            this.ArchivedTeam.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivedTeam.ForeColor = System.Drawing.Color.Red;
            this.ArchivedTeam.Location = new System.Drawing.Point(905, 32);
            this.ArchivedTeam.Name = "ArchivedTeam";
            this.ArchivedTeam.Size = new System.Drawing.Size(0, 51);
            this.ArchivedTeam.TabIndex = 27;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(1067, 734);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 28);
            this.Email.TabIndex = 34;
            this.Email.Text = "Email";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Prenom.Location = new System.Drawing.Point(880, 734);
            this.Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 28);
            this.Prenom.TabIndex = 33;
            this.Prenom.Text = "Prénom";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(720, 734);
            this.Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(63, 28);
            this.Nom.TabIndex = 32;
            this.Nom.Text = "Nom";
            // 
            // PanelListUsers
            // 
            this.PanelListUsers.BackColor = System.Drawing.Color.Transparent;
            this.PanelListUsers.Location = new System.Drawing.Point(707, 764);
            this.PanelListUsers.Margin = new System.Windows.Forms.Padding(4);
            this.PanelListUsers.Name = "PanelListUsers";
            this.PanelListUsers.Size = new System.Drawing.Size(733, 320);
            this.PanelListUsers.TabIndex = 31;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(1332, 18);
            this.retour.Margin = new System.Windows.Forms.Padding(4);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(116, 33);
            this.retour.TabIndex = 31;
            this.retour.Text = "<<< Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // panelShowStatistiqueTeam
            // 
            this.panelShowStatistiqueTeam.Location = new System.Drawing.Point(64, 108);
            this.panelShowStatistiqueTeam.Margin = new System.Windows.Forms.Padding(4);
            this.panelShowStatistiqueTeam.Name = "panelShowStatistiqueTeam";
            this.panelShowStatistiqueTeam.Size = new System.Drawing.Size(1333, 554);
            this.panelShowStatistiqueTeam.TabIndex = 30;
            // 
            // labelNbCollaborateur
            // 
            this.labelNbCollaborateur.AutoSize = true;
            this.labelNbCollaborateur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNbCollaborateur.Location = new System.Drawing.Point(696, 687);
            this.labelNbCollaborateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNbCollaborateur.Name = "labelNbCollaborateur";
            this.labelNbCollaborateur.Size = new System.Drawing.Size(317, 28);
            this.labelNbCollaborateur.TabIndex = 29;
            this.labelNbCollaborateur.Text = "Nombre de collaborateurs : ";
            // 
            // LabelTitreTeam
            // 
            this.LabelTitreTeam.AutoSize = true;
            this.LabelTitreTeam.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitreTeam.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitreTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTitreTeam.Location = new System.Drawing.Point(73, 54);
            this.LabelTitreTeam.Name = "LabelTitreTeam";
            this.LabelTitreTeam.Size = new System.Drawing.Size(159, 51);
            this.LabelTitreTeam.TabIndex = 3;
            this.LabelTitreTeam.Text = "Team : ";
            // 
            // TeamMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanelTeam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeamMain";
            this.Size = new System.Drawing.Size(1468, 1108);
            this.gradientPanelTeam.ResumeLayout(false);
            this.gradientPanelTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Services.GradientPageConnexion gradientPanelTeam;
        private System.Windows.Forms.Label LabelTitreTeam;
        private System.Windows.Forms.Label labelNbCollaborateur;
        private System.Windows.Forms.Panel panelShowStatistiqueTeam;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel PanelListUsers;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label ArchivedTeam;
        private System.Windows.Forms.Button buttonSupprimerTeam;
        private System.Windows.Forms.Button buttonArchiverTeam;
    }
}
