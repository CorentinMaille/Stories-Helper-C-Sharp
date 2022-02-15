
namespace StoriesHelper.Windows.Organizations
{
    partial class OrganizationMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gradient = new StoriesHelper.Services.GradientPageConnexion();
            this.checkBoxArchivedTeam = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenTeam = new System.Windows.Forms.CheckBox();
            this.labelTitreListeUtilisateur = new System.Windows.Forms.Label();
            this.labelTitreListeTeam = new System.Windows.Forms.Label();
            this.NbArchivedProjects = new System.Windows.Forms.Label();
            this.checkBoxOpenProject = new System.Windows.Forms.CheckBox();
            this.GraphiqueRatioTaskOrganization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxArchivedProject = new System.Windows.Forms.CheckBox();
            this.labelTitreListeProjet = new System.Windows.Forms.Label();
            this.PanelListUsers = new System.Windows.Forms.Panel();
            this.PanelListTeams = new System.Windows.Forms.Panel();
            this.PanelListProjects = new System.Windows.Forms.Panel();
            this.NbUtilisateurs = new System.Windows.Forms.Label();
            this.NbTeams = new System.Windows.Forms.Label();
            this.NbProjects = new System.Windows.Forms.Label();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.gradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.Angle = 90F;
            this.gradient.BackColor = System.Drawing.Color.DodgerBlue;
            this.gradient.BottomColor = System.Drawing.Color.SkyBlue;
            this.gradient.Controls.Add(this.checkBoxArchivedTeam);
            this.gradient.Controls.Add(this.checkBoxOpenTeam);
            this.gradient.Controls.Add(this.labelTitreListeUtilisateur);
            this.gradient.Controls.Add(this.labelTitreListeTeam);
            this.gradient.Controls.Add(this.NbArchivedProjects);
            this.gradient.Controls.Add(this.checkBoxOpenProject);
            this.gradient.Controls.Add(this.GraphiqueRatioTaskOrganization);
            this.gradient.Controls.Add(this.checkBoxArchivedProject);
            this.gradient.Controls.Add(this.labelTitreListeProjet);
            this.gradient.Controls.Add(this.PanelListUsers);
            this.gradient.Controls.Add(this.PanelListTeams);
            this.gradient.Controls.Add(this.PanelListProjects);
            this.gradient.Controls.Add(this.NbUtilisateurs);
            this.gradient.Controls.Add(this.NbTeams);
            this.gradient.Controls.Add(this.NbProjects);
            this.gradient.Controls.Add(this.OrganizationLabel);
            this.gradient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Margin = new System.Windows.Forms.Padding(2);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(1101, 900);
            this.gradient.TabIndex = 1;
            this.gradient.TopColor = System.Drawing.Color.Empty;
            // 
            // checkBoxArchivedTeam
            // 
            this.checkBoxArchivedTeam.AutoSize = true;
            this.checkBoxArchivedTeam.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxArchivedTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxArchivedTeam.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArchivedTeam.ForeColor = System.Drawing.Color.Red;
            this.checkBoxArchivedTeam.Location = new System.Drawing.Point(613, 422);
            this.checkBoxArchivedTeam.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxArchivedTeam.Name = "checkBoxArchivedTeam";
            this.checkBoxArchivedTeam.Size = new System.Drawing.Size(64, 16);
            this.checkBoxArchivedTeam.TabIndex = 21;
            this.checkBoxArchivedTeam.Text = "Archived";
            this.checkBoxArchivedTeam.UseVisualStyleBackColor = false;
            this.checkBoxArchivedTeam.CheckedChanged += new System.EventHandler(this.displayOpenArchivedTeam);
            // 
            // checkBoxOpenTeam
            // 
            this.checkBoxOpenTeam.AutoSize = true;
            this.checkBoxOpenTeam.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpenTeam.Checked = true;
            this.checkBoxOpenTeam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOpenTeam.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic);
            this.checkBoxOpenTeam.Location = new System.Drawing.Point(561, 422);
            this.checkBoxOpenTeam.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOpenTeam.Name = "checkBoxOpenTeam";
            this.checkBoxOpenTeam.Size = new System.Drawing.Size(48, 16);
            this.checkBoxOpenTeam.TabIndex = 20;
            this.checkBoxOpenTeam.Text = "Open";
            this.checkBoxOpenTeam.UseVisualStyleBackColor = false;
            this.checkBoxOpenTeam.CheckedChanged += new System.EventHandler(this.displayOpenArchivedTeam);
            // 
            // labelTitreListeUtilisateur
            // 
            this.labelTitreListeUtilisateur.AutoSize = true;
            this.labelTitreListeUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.labelTitreListeUtilisateur.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreListeUtilisateur.Location = new System.Drawing.Point(696, 415);
            this.labelTitreListeUtilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitreListeUtilisateur.Name = "labelTitreListeUtilisateur";
            this.labelTitreListeUtilisateur.Size = new System.Drawing.Size(202, 22);
            this.labelTitreListeUtilisateur.TabIndex = 19;
            this.labelTitreListeUtilisateur.Text = "Liste des Utilisateurs :";
            // 
            // labelTitreListeTeam
            // 
            this.labelTitreListeTeam.AutoSize = true;
            this.labelTitreListeTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelTitreListeTeam.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreListeTeam.Location = new System.Drawing.Point(389, 415);
            this.labelTitreListeTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitreListeTeam.Name = "labelTitreListeTeam";
            this.labelTitreListeTeam.Size = new System.Drawing.Size(168, 22);
            this.labelTitreListeTeam.TabIndex = 18;
            this.labelTitreListeTeam.Text = "Liste des Équipes :";
            // 
            // NbArchivedProjects
            // 
            this.NbArchivedProjects.AutoSize = true;
            this.NbArchivedProjects.BackColor = System.Drawing.Color.Transparent;
            this.NbArchivedProjects.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbArchivedProjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbArchivedProjects.Location = new System.Drawing.Point(80, 190);
            this.NbArchivedProjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbArchivedProjects.Name = "NbArchivedProjects";
            this.NbArchivedProjects.Size = new System.Drawing.Size(262, 22);
            this.NbArchivedProjects.TabIndex = 17;
            this.NbArchivedProjects.Text = "Nombre de projets archivés : ";
            // 
            // checkBoxOpenProject
            // 
            this.checkBoxOpenProject.AutoSize = true;
            this.checkBoxOpenProject.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpenProject.Checked = true;
            this.checkBoxOpenProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOpenProject.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic);
            this.checkBoxOpenProject.Location = new System.Drawing.Point(248, 422);
            this.checkBoxOpenProject.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOpenProject.Name = "checkBoxOpenProject";
            this.checkBoxOpenProject.Size = new System.Drawing.Size(48, 16);
            this.checkBoxOpenProject.TabIndex = 16;
            this.checkBoxOpenProject.Text = "Open";
            this.checkBoxOpenProject.UseVisualStyleBackColor = false;
            this.checkBoxOpenProject.CheckedChanged += new System.EventHandler(this.displayOpenArchivedProject);
            // 
            // GraphiqueRatioTaskOrganization
            // 
            this.GraphiqueRatioTaskOrganization.BackColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 45;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.GraphiqueRatioTaskOrganization.Legends.Add(legend2);
            this.GraphiqueRatioTaskOrganization.Location = new System.Drawing.Point(411, 150);
            this.GraphiqueRatioTaskOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.GraphiqueRatioTaskOrganization.Name = "GraphiqueRatioTaskOrganization";
            this.GraphiqueRatioTaskOrganization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Task";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.GraphiqueRatioTaskOrganization.Series.Add(series2);
            this.GraphiqueRatioTaskOrganization.Size = new System.Drawing.Size(284, 207);
            this.GraphiqueRatioTaskOrganization.TabIndex = 8;
            this.GraphiqueRatioTaskOrganization.Text = "Stats Des Tâches de l\'Organisation en cours";
            title2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Stats des Tâches En Cours de l\'Organisation";
            this.GraphiqueRatioTaskOrganization.Titles.Add(title2);
            // 
            // checkBoxArchivedProject
            // 
            this.checkBoxArchivedProject.AutoSize = true;
            this.checkBoxArchivedProject.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxArchivedProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxArchivedProject.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArchivedProject.ForeColor = System.Drawing.Color.Red;
            this.checkBoxArchivedProject.Location = new System.Drawing.Point(300, 422);
            this.checkBoxArchivedProject.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxArchivedProject.Name = "checkBoxArchivedProject";
            this.checkBoxArchivedProject.Size = new System.Drawing.Size(64, 16);
            this.checkBoxArchivedProject.TabIndex = 15;
            this.checkBoxArchivedProject.Text = "Archived";
            this.checkBoxArchivedProject.UseVisualStyleBackColor = false;
            this.checkBoxArchivedProject.CheckedChanged += new System.EventHandler(this.displayOpenArchivedProject);
            // 
            // labelTitreListeProjet
            // 
            this.labelTitreListeProjet.AutoSize = true;
            this.labelTitreListeProjet.BackColor = System.Drawing.Color.Transparent;
            this.labelTitreListeProjet.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreListeProjet.Location = new System.Drawing.Point(80, 415);
            this.labelTitreListeProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitreListeProjet.Name = "labelTitreListeProjet";
            this.labelTitreListeProjet.Size = new System.Drawing.Size(163, 22);
            this.labelTitreListeProjet.TabIndex = 14;
            this.labelTitreListeProjet.Text = "Liste des Projets :";
            // 
            // PanelListUsers
            // 
            this.PanelListUsers.BackColor = System.Drawing.Color.Transparent;
            this.PanelListUsers.Location = new System.Drawing.Point(700, 442);
            this.PanelListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListUsers.Name = "PanelListUsers";
            this.PanelListUsers.Size = new System.Drawing.Size(340, 410);
            this.PanelListUsers.TabIndex = 13;
            // 
            // PanelListTeams
            // 
            this.PanelListTeams.BackColor = System.Drawing.Color.Transparent;
            this.PanelListTeams.Location = new System.Drawing.Point(383, 442);
            this.PanelListTeams.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListTeams.Name = "PanelListTeams";
            this.PanelListTeams.Size = new System.Drawing.Size(289, 410);
            this.PanelListTeams.TabIndex = 12;
            // 
            // PanelListProjects
            // 
            this.PanelListProjects.BackColor = System.Drawing.Color.Transparent;
            this.PanelListProjects.Location = new System.Drawing.Point(84, 442);
            this.PanelListProjects.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListProjects.Name = "PanelListProjects";
            this.PanelListProjects.Size = new System.Drawing.Size(260, 410);
            this.PanelListProjects.TabIndex = 11;
            // 
            // NbUtilisateurs
            // 
            this.NbUtilisateurs.AutoSize = true;
            this.NbUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.NbUtilisateurs.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbUtilisateurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbUtilisateurs.Location = new System.Drawing.Point(80, 270);
            this.NbUtilisateurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbUtilisateurs.Name = "NbUtilisateurs";
            this.NbUtilisateurs.Size = new System.Drawing.Size(206, 22);
            this.NbUtilisateurs.TabIndex = 10;
            this.NbUtilisateurs.Text = "Nombre d\'utilisateur : ";
            // 
            // NbTeams
            // 
            this.NbTeams.AutoSize = true;
            this.NbTeams.BackColor = System.Drawing.Color.Transparent;
            this.NbTeams.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbTeams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbTeams.Location = new System.Drawing.Point(80, 230);
            this.NbTeams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbTeams.Name = "NbTeams";
            this.NbTeams.Size = new System.Drawing.Size(176, 22);
            this.NbTeams.TabIndex = 7;
            this.NbTeams.Text = "Nombre de teams : ";
            // 
            // NbProjects
            // 
            this.NbProjects.AutoSize = true;
            this.NbProjects.BackColor = System.Drawing.Color.Transparent;
            this.NbProjects.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbProjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbProjects.Location = new System.Drawing.Point(80, 150);
            this.NbProjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbProjects.Name = "NbProjects";
            this.NbProjects.Size = new System.Drawing.Size(264, 22);
            this.NbProjects.TabIndex = 2;
            this.NbProjects.Text = "Nombre de projets en cours : ";
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrganizationLabel.Location = new System.Drawing.Point(47, 43);
            this.OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(584, 41);
            this.OrganizationLabel.TabIndex = 1;
            this.OrganizationLabel.Text = "Vue d\'ensemble de l\'Organisation : ";
            // 
            // OrganizationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrganizationMain";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradient.ResumeLayout(false);
            this.gradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskOrganization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label NbProjects;
        private System.Windows.Forms.Label NbTeams;
        private System.Windows.Forms.Label NbUtilisateurs;
        private System.Windows.Forms.Panel PanelListProjects;
        private System.Windows.Forms.Panel PanelListTeams;
        private System.Windows.Forms.Panel PanelListUsers;
        private System.Windows.Forms.Label labelTitreListeProjet;
        private System.Windows.Forms.CheckBox checkBoxArchivedProject;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphiqueRatioTaskOrganization;
        private System.Windows.Forms.CheckBox checkBoxOpenProject;
        private System.Windows.Forms.Label NbArchivedProjects;
        private Services.GradientPageConnexion gradient;
        private System.Windows.Forms.Label labelTitreListeTeam;
        private System.Windows.Forms.Label labelTitreListeUtilisateur;
        private System.Windows.Forms.CheckBox checkBoxArchivedTeam;
        private System.Windows.Forms.CheckBox checkBoxOpenTeam;
    }
}
