
namespace StoriesHelper.Windows.Projects
{
    partial class PanelProject
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gradient = new StoriesHelper.Service.GradientPageConnexion();
            this.labelNbCollaborateur = new System.Windows.Forms.Label();
            this.labelNbTeam = new System.Windows.Forms.Label();
            this.ArchivedProject = new System.Windows.Forms.Label();
            this.buttonArchiverProjet = new System.Windows.Forms.Button();
            this.buttonSupprimerProjet = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDateCreation = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.Rendement = new System.Windows.Forms.Label();
            this.NbTachesEnCours = new System.Windows.Forms.Label();
            this.NombreUtilisateurs = new System.Windows.Forms.Label();
            this.NomTeam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GraphiqueRatioTaskProject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelListTeams = new System.Windows.Forms.Panel();
            this.LabelTitreProject = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.gradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskProject)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gradient
            // 
            this.gradient.Angle = 90F;
            this.gradient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradient.BottomColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradient.Controls.Add(this.retour);
            this.gradient.Controls.Add(this.labelNbCollaborateur);
            this.gradient.Controls.Add(this.labelNbTeam);
            this.gradient.Controls.Add(this.ArchivedProject);
            this.gradient.Controls.Add(this.buttonArchiverProjet);
            this.gradient.Controls.Add(this.buttonSupprimerProjet);
            this.gradient.Controls.Add(this.labelDescription);
            this.gradient.Controls.Add(this.textDescription);
            this.gradient.Controls.Add(this.labelDateCreation);
            this.gradient.Controls.Add(this.labelType);
            this.gradient.Controls.Add(this.Rendement);
            this.gradient.Controls.Add(this.NbTachesEnCours);
            this.gradient.Controls.Add(this.NombreUtilisateurs);
            this.gradient.Controls.Add(this.NomTeam);
            this.gradient.Controls.Add(this.panel1);
            this.gradient.Controls.Add(this.GraphiqueRatioTaskProject);
            this.gradient.Controls.Add(this.PanelListTeams);
            this.gradient.Controls.Add(this.LabelTitreProject);
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(1101, 900);
            this.gradient.TabIndex = 0;
            this.gradient.TopColor = System.Drawing.Color.Empty;
            // 
            // labelNbCollaborateur
            // 
            this.labelNbCollaborateur.AutoSize = true;
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
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDescription.Location = new System.Drawing.Point(60, 280);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(125, 22);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Description : ";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDescription.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(60, 320);
            this.textDescription.MaxLength = 255;
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ReadOnly = true;
            this.textDescription.Size = new System.Drawing.Size(300, 210);
            this.textDescription.TabIndex = 22;
            this.textDescription.Text = "Ici se situe le texte de la description du projet";
            // 
            // labelDateCreation
            // 
            this.labelDateCreation.AutoSize = true;
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
            this.labelType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(60, 120);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 22);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Type :  ";
            // 
            // Rendement
            // 
            this.Rendement.AutoSize = true;
            this.Rendement.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Rendement.Location = new System.Drawing.Point(850, 537);
            this.Rendement.Name = "Rendement";
            this.Rendement.Size = new System.Drawing.Size(94, 19);
            this.Rendement.TabIndex = 19;
            this.Rendement.Text = "Rendement";
            // 
            // NbTachesEnCours
            // 
            this.NbTachesEnCours.AutoSize = true;
            this.NbTachesEnCours.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.NbTachesEnCours.Location = new System.Drawing.Point(770, 537);
            this.NbTachesEnCours.Name = "NbTachesEnCours";
            this.NbTachesEnCours.Size = new System.Drawing.Size(84, 19);
            this.NbTachesEnCours.TabIndex = 18;
            this.NbTachesEnCours.Text = "Nb Taches";
            // 
            // NombreUtilisateurs
            // 
            this.NombreUtilisateurs.AutoSize = true;
            this.NombreUtilisateurs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUtilisateurs.Location = new System.Drawing.Point(650, 537);
            this.NombreUtilisateurs.Name = "NombreUtilisateurs";
            this.NombreUtilisateurs.Size = new System.Drawing.Size(119, 19);
            this.NombreUtilisateurs.TabIndex = 17;
            this.NombreUtilisateurs.Text = "Nb Utilisateurs";
            // 
            // NomTeam
            // 
            this.NomTeam.AutoSize = true;
            this.NomTeam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.NomTeam.Location = new System.Drawing.Point(450, 537);
            this.NomTeam.Name = "NomTeam";
            this.NomTeam.Size = new System.Drawing.Size(87, 19);
            this.NomTeam.TabIndex = 16;
            this.NomTeam.Text = "Nom Team";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(410, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 411);
            this.panel1.TabIndex = 15;
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
            title1.Text = "Stats des Tâches En Cours de l\'Organisation";
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
            this.LabelTitreProject.Size = new System.Drawing.Size(159, 41);
            this.LabelTitreProject.TabIndex = 2;
            this.LabelTitreProject.Text = "Project : ";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(999, 15);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(87, 27);
            this.retour.TabIndex = 29;
            this.retour.Text = "<<< Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // PanelProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradient);
            this.Name = "PanelProject";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradient.ResumeLayout(false);
            this.gradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Service.GradientPageConnexion gradient;
        private System.Windows.Forms.Label LabelTitreProject;
        private System.Windows.Forms.Panel PanelListTeams;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphiqueRatioTaskProject;
        private System.Windows.Forms.Label NomTeam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label Rendement;
        private System.Windows.Forms.Label NbTachesEnCours;
        private System.Windows.Forms.Label NombreUtilisateurs;
        private System.Windows.Forms.Label labelDateCreation;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSupprimerProjet;
        private System.Windows.Forms.Button buttonArchiverProjet;
        private System.Windows.Forms.Label ArchivedProject;
        private System.Windows.Forms.Label labelNbCollaborateur;
        private System.Windows.Forms.Label labelNbTeam;
        private System.Windows.Forms.Button retour;
    }
}
