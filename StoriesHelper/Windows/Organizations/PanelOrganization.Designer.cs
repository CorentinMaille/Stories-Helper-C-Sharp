
namespace StoriesHelper.Windows.Organizations
{
    partial class PanelOrganization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gradient = new StoriesHelper.Service.GradientPageConnexion();
            this.NbArchivedProjects = new System.Windows.Forms.Label();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.GraphiqueRatioTaskOrganization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxArchived = new System.Windows.Forms.CheckBox();
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
            this.gradient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradient.BottomColor = System.Drawing.SystemColors.ButtonShadow;
            this.gradient.Controls.Add(this.NbArchivedProjects);
            this.gradient.Controls.Add(this.checkBoxOpen);
            this.gradient.Controls.Add(this.GraphiqueRatioTaskOrganization);
            this.gradient.Controls.Add(this.checkBoxArchived);
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
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpen.Checked = true;
            this.checkBoxOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOpen.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic);
            this.checkBoxOpen.Location = new System.Drawing.Point(228, 422);
            this.checkBoxOpen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(48, 16);
            this.checkBoxOpen.TabIndex = 16;
            this.checkBoxOpen.Text = "Open";
            this.checkBoxOpen.UseVisualStyleBackColor = false;
            this.checkBoxOpen.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // GraphiqueRatioTaskOrganization
            // 
            this.GraphiqueRatioTaskOrganization.BackColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.Area3DStyle.Inclination = 45;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Name = "Legend1";
            this.GraphiqueRatioTaskOrganization.Legends.Add(legend6);
            this.GraphiqueRatioTaskOrganization.Location = new System.Drawing.Point(396, 130);
            this.GraphiqueRatioTaskOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.GraphiqueRatioTaskOrganization.Name = "GraphiqueRatioTaskOrganization";
            this.GraphiqueRatioTaskOrganization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Task";
            series6.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.GraphiqueRatioTaskOrganization.Series.Add(series6);
            this.GraphiqueRatioTaskOrganization.Size = new System.Drawing.Size(284, 207);
            this.GraphiqueRatioTaskOrganization.TabIndex = 8;
            this.GraphiqueRatioTaskOrganization.Text = "Stats Des Tâches de l\'Organisation en cours";
            title6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "Stats des Tâches En Cours de l\'Organisation";
            this.GraphiqueRatioTaskOrganization.Titles.Add(title6);
            // 
            // checkBoxArchived
            // 
            this.checkBoxArchived.AutoSize = true;
            this.checkBoxArchived.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxArchived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxArchived.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArchived.ForeColor = System.Drawing.Color.Red;
            this.checkBoxArchived.Location = new System.Drawing.Point(280, 422);
            this.checkBoxArchived.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxArchived.Name = "checkBoxArchived";
            this.checkBoxArchived.Size = new System.Drawing.Size(64, 16);
            this.checkBoxArchived.TabIndex = 15;
            this.checkBoxArchived.Text = "Archived";
            this.checkBoxArchived.UseVisualStyleBackColor = false;
            this.checkBoxArchived.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // labelTitreListeProjet
            // 
            this.labelTitreListeProjet.AutoSize = true;
            this.labelTitreListeProjet.BackColor = System.Drawing.Color.Transparent;
            this.labelTitreListeProjet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreListeProjet.Location = new System.Drawing.Point(78, 419);
            this.labelTitreListeProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitreListeProjet.Name = "labelTitreListeProjet";
            this.labelTitreListeProjet.Size = new System.Drawing.Size(137, 19);
            this.labelTitreListeProjet.TabIndex = 14;
            this.labelTitreListeProjet.Text = "Liste des Projets :";
            // 
            // PanelListUsers
            // 
            this.PanelListUsers.BackColor = System.Drawing.Color.Transparent;
            this.PanelListUsers.Location = new System.Drawing.Point(694, 403);
            this.PanelListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListUsers.Name = "PanelListUsers";
            this.PanelListUsers.Size = new System.Drawing.Size(338, 447);
            this.PanelListUsers.TabIndex = 13;
            // 
            // PanelListTeams
            // 
            this.PanelListTeams.BackColor = System.Drawing.Color.Transparent;
            this.PanelListTeams.Location = new System.Drawing.Point(396, 403);
            this.PanelListTeams.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListTeams.Name = "PanelListTeams";
            this.PanelListTeams.Size = new System.Drawing.Size(248, 447);
            this.PanelListTeams.TabIndex = 12;
            // 
            // PanelListProjects
            // 
            this.PanelListProjects.BackColor = System.Drawing.Color.Transparent;
            this.PanelListProjects.Location = new System.Drawing.Point(82, 442);
            this.PanelListProjects.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListProjects.Name = "PanelListProjects";
            this.PanelListProjects.Size = new System.Drawing.Size(248, 411);
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
            this.OrganizationLabel.Location = new System.Drawing.Point(20, 24);
            this.OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(584, 41);
            this.OrganizationLabel.TabIndex = 1;
            this.OrganizationLabel.Text = "Vue d\'ensemble de l\'Organisation : ";
            // 
            // PanelOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelOrganization";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradient.ResumeLayout(false);
            this.gradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskOrganization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Panel PanelListProjects;
        private System.Windows.Forms.Panel PanelListTeams;
        private System.Windows.Forms.Panel PanelListUsers;
        private System.Windows.Forms.Label labelTitreListeProjet;
        private System.Windows.Forms.CheckBox checkBoxArchived;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphiqueRatioTaskOrganization;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private Service.GradientPageConnexion gradient;
        private System.Windows.Forms.Label NbUtilisateurs;
        private System.Windows.Forms.Label NbTeams;
        private System.Windows.Forms.Label NbProjects;
        private System.Windows.Forms.Label NbArchivedProjects;
    }
}
