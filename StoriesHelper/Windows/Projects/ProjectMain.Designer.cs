
namespace StoriesHelper.Windows.Projects
{
    partial class ProjectMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gradientPanelProject = new StoriesHelper.Services.Gradient();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.labelNbCollaborateur = new System.Windows.Forms.Label();
            this.labelNbTeam = new System.Windows.Forms.Label();
            this.ArchivedProject = new System.Windows.Forms.Label();
            this.buttonArchiverProjet = new System.Windows.Forms.Button();
            this.buttonSupprimerProjet = new System.Windows.Forms.Button();
            this.labelDateCreation = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.NbTachesEnCours = new System.Windows.Forms.Label();
            this.NombreUtilisateurs = new System.Windows.Forms.Label();
            this.NomTeam = new System.Windows.Forms.Label();
            this.GraphiqueRatioTaskProject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelListTeams = new System.Windows.Forms.Panel();
            this.LabelTitreProject = new System.Windows.Forms.Label();
            this.gradientPanelProject.SuspendLayout();
            this.panelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskProject)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanelProject
            // 
            this.gradientPanelProject.Angle = 90F;
            this.gradientPanelProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gradientPanelProject.BottomColor = System.Drawing.Color.White;
            this.gradientPanelProject.Controls.Add(this.panelDescription);
            this.gradientPanelProject.Controls.Add(this.retour);
            this.gradientPanelProject.Controls.Add(this.labelNbCollaborateur);
            this.gradientPanelProject.Controls.Add(this.labelNbTeam);
            this.gradientPanelProject.Controls.Add(this.ArchivedProject);
            this.gradientPanelProject.Controls.Add(this.buttonArchiverProjet);
            this.gradientPanelProject.Controls.Add(this.buttonSupprimerProjet);
            this.gradientPanelProject.Controls.Add(this.labelDateCreation);
            this.gradientPanelProject.Controls.Add(this.labelType);
            this.gradientPanelProject.Controls.Add(this.NbTachesEnCours);
            this.gradientPanelProject.Controls.Add(this.NombreUtilisateurs);
            this.gradientPanelProject.Controls.Add(this.NomTeam);
            this.gradientPanelProject.Controls.Add(this.GraphiqueRatioTaskProject);
            this.gradientPanelProject.Controls.Add(this.PanelListTeams);
            this.gradientPanelProject.Controls.Add(this.LabelTitreProject);
            this.gradientPanelProject.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelProject.Name = "gradientPanelProject";
            this.gradientPanelProject.Size = new System.Drawing.Size(1101, 900);
            this.gradientPanelProject.TabIndex = 0;
            this.gradientPanelProject.TopColor = System.Drawing.Color.Empty;
            // 
            // panelDescription
            // 
            this.panelDescription.AutoScroll = true;
            this.panelDescription.BackColor = System.Drawing.Color.Transparent;
            this.panelDescription.Controls.Add(this.labelDescription);
            this.panelDescription.Location = new System.Drawing.Point(53, 273);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(982, 214);
            this.panelDescription.TabIndex = 30;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDescription.Location = new System.Drawing.Point(7, 8);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(125, 22);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Description : ";
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.Gray;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retour.Location = new System.Drawing.Point(995, 71);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(87, 27);
            this.retour.TabIndex = 29;
            this.retour.Text = "<<< Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // labelNbCollaborateur
            // 
            this.labelNbCollaborateur.AutoSize = true;
            this.labelNbCollaborateur.BackColor = System.Drawing.Color.Transparent;
            this.labelNbCollaborateur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNbCollaborateur.Location = new System.Drawing.Point(60, 200);
            this.labelNbCollaborateur.Name = "labelNbCollaborateur";
            this.labelNbCollaborateur.Size = new System.Drawing.Size(243, 22);
            this.labelNbCollaborateur.TabIndex = 28;
            this.labelNbCollaborateur.Text = "Nombre de collaborateur : ";
            // 
            // labelNbTeam
            // 
            this.labelNbTeam.AutoSize = true;
            this.labelNbTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelNbTeam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNbTeam.Location = new System.Drawing.Point(60, 240);
            this.labelNbTeam.Name = "labelNbTeam";
            this.labelNbTeam.Size = new System.Drawing.Size(173, 22);
            this.labelNbTeam.TabIndex = 27;
            this.labelNbTeam.Text = "Nombre d\'équipe : ";
            // 
            // ArchivedProject
            // 
            this.ArchivedProject.AutoSize = true;
            this.ArchivedProject.BackColor = System.Drawing.Color.Transparent;
            this.ArchivedProject.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivedProject.ForeColor = System.Drawing.Color.Red;
            this.ArchivedProject.Location = new System.Drawing.Point(679, 44);
            this.ArchivedProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArchivedProject.Name = "ArchivedProject";
            this.ArchivedProject.Size = new System.Drawing.Size(0, 41);
            this.ArchivedProject.TabIndex = 26;
            // 
            // buttonArchiverProjet
            // 
            this.buttonArchiverProjet.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonArchiverProjet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonArchiverProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchiverProjet.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.buttonArchiverProjet.Location = new System.Drawing.Point(210, 812);
            this.buttonArchiverProjet.Name = "buttonArchiverProjet";
            this.buttonArchiverProjet.Size = new System.Drawing.Size(125, 55);
            this.buttonArchiverProjet.TabIndex = 25;
            this.buttonArchiverProjet.Text = "Archiver le projet";
            this.buttonArchiverProjet.UseVisualStyleBackColor = false;
            this.buttonArchiverProjet.Click += new System.EventHandler(this.buttonArchiverProjet_Click);
            // 
            // buttonSupprimerProjet
            // 
            this.buttonSupprimerProjet.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimerProjet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerProjet.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSupprimerProjet.Location = new System.Drawing.Point(48, 812);
            this.buttonSupprimerProjet.Name = "buttonSupprimerProjet";
            this.buttonSupprimerProjet.Size = new System.Drawing.Size(125, 55);
            this.buttonSupprimerProjet.TabIndex = 24;
            this.buttonSupprimerProjet.Text = "Supprimer le projet";
            this.buttonSupprimerProjet.UseVisualStyleBackColor = false;
            this.buttonSupprimerProjet.Click += new System.EventHandler(this.SupprimerProject_Click);
            // 
            // labelDateCreation
            // 
            this.labelDateCreation.AutoSize = true;
            this.labelDateCreation.BackColor = System.Drawing.Color.Transparent;
            this.labelDateCreation.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCreation.Location = new System.Drawing.Point(60, 160);
            this.labelDateCreation.Name = "labelDateCreation";
            this.labelDateCreation.Size = new System.Drawing.Size(142, 22);
            this.labelDateCreation.TabIndex = 21;
            this.labelDateCreation.Text = "Date Création : ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(60, 120);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 22);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Type :  ";
            // 
            // NbTachesEnCours
            // 
            this.NbTachesEnCours.AutoSize = true;
            this.NbTachesEnCours.BackColor = System.Drawing.Color.Transparent;
            this.NbTachesEnCours.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.NbTachesEnCours.Location = new System.Drawing.Point(830, 537);
            this.NbTachesEnCours.Name = "NbTachesEnCours";
            this.NbTachesEnCours.Size = new System.Drawing.Size(60, 19);
            this.NbTachesEnCours.TabIndex = 18;
            this.NbTachesEnCours.Text = "Taches";
            // 
            // NombreUtilisateurs
            // 
            this.NombreUtilisateurs.AutoSize = true;
            this.NombreUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.NombreUtilisateurs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUtilisateurs.Location = new System.Drawing.Point(702, 537);
            this.NombreUtilisateurs.Name = "NombreUtilisateurs";
            this.NombreUtilisateurs.Size = new System.Drawing.Size(95, 19);
            this.NombreUtilisateurs.TabIndex = 17;
            this.NombreUtilisateurs.Text = "Utilisateurs";
            // 
            // NomTeam
            // 
            this.NomTeam.AutoSize = true;
            this.NomTeam.BackColor = System.Drawing.Color.Transparent;
            this.NomTeam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.NomTeam.Location = new System.Drawing.Point(450, 537);
            this.NomTeam.Name = "NomTeam";
            this.NomTeam.Size = new System.Drawing.Size(98, 19);
            this.NomTeam.TabIndex = 16;
            this.NomTeam.Text = "Nom Équipe";
            // 
            // GraphiqueRatioTaskProject
            // 
            this.GraphiqueRatioTaskProject.BackColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskProject.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 45;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskProject.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.GraphiqueRatioTaskProject.Legends.Add(legend1);
            this.GraphiqueRatioTaskProject.Location = new System.Drawing.Point(48, 570);
            this.GraphiqueRatioTaskProject.Margin = new System.Windows.Forms.Padding(2);
            this.GraphiqueRatioTaskProject.Name = "GraphiqueRatioTaskProject";
            this.GraphiqueRatioTaskProject.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Task";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.GraphiqueRatioTaskProject.Series.Add(series1);
            this.GraphiqueRatioTaskProject.Size = new System.Drawing.Size(323, 216);
            this.GraphiqueRatioTaskProject.TabIndex = 14;
            this.GraphiqueRatioTaskProject.Text = "Stats Des Tâches en cours du Projet";
            title1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Stats Des Tâches en cours du Projet";
            this.GraphiqueRatioTaskProject.Titles.Add(title1);
            // 
            // PanelListTeams
            // 
            this.PanelListTeams.BackColor = System.Drawing.Color.Transparent;
            this.PanelListTeams.Location = new System.Drawing.Point(410, 570);
            this.PanelListTeams.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListTeams.Name = "PanelListTeams";
            this.PanelListTeams.Size = new System.Drawing.Size(625, 300);
            this.PanelListTeams.TabIndex = 13;
            // 
            // LabelTitreProject
            // 
            this.LabelTitreProject.AutoSize = true;
            this.LabelTitreProject.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitreProject.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitreProject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTitreProject.Location = new System.Drawing.Point(55, 44);
            this.LabelTitreProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitreProject.Name = "LabelTitreProject";
            this.LabelTitreProject.Size = new System.Drawing.Size(143, 41);
            this.LabelTitreProject.TabIndex = 2;
            this.LabelTitreProject.Text = "Projet : ";
            // 
            // ProjectMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanelProject);
            this.Name = "ProjectMain";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradientPanelProject.ResumeLayout(false);
            this.gradientPanelProject.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Services.Gradient gradientPanelProject;
        private System.Windows.Forms.Label LabelTitreProject;
        private System.Windows.Forms.Panel PanelListTeams;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphiqueRatioTaskProject;
        private System.Windows.Forms.Label NomTeam;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label NbTachesEnCours;
        private System.Windows.Forms.Label NombreUtilisateurs;
        private System.Windows.Forms.Label labelDateCreation;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSupprimerProjet;
        private System.Windows.Forms.Button buttonArchiverProjet;
        private System.Windows.Forms.Label ArchivedProject;
        private System.Windows.Forms.Label labelNbCollaborateur;
        private System.Windows.Forms.Label labelNbTeam;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel panelDescription;
    }
}
