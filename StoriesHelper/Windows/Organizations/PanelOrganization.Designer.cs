
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gradientPageConnexion1 = new StoriesHelper.Service.GradientPageConnexion();
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
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPageConnexion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPageConnexion1
            // 
            this.gradientPageConnexion1.Angle = 90F;
            this.gradientPageConnexion1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradientPageConnexion1.BottomColor = System.Drawing.SystemColors.ButtonShadow;
            this.gradientPageConnexion1.Controls.Add(this.checkBoxOpen);
            this.gradientPageConnexion1.Controls.Add(this.GraphiqueRatioTaskOrganization);
            this.gradientPageConnexion1.Controls.Add(this.checkBoxArchived);
            this.gradientPageConnexion1.Controls.Add(this.labelTitreListeProjet);
            this.gradientPageConnexion1.Controls.Add(this.PanelListUsers);
            this.gradientPageConnexion1.Controls.Add(this.PanelListTeams);
            this.gradientPageConnexion1.Controls.Add(this.PanelListProjects);
            this.gradientPageConnexion1.Controls.Add(this.NbUtilisateurs);
            this.gradientPageConnexion1.Controls.Add(this.NbTeams);
            this.gradientPageConnexion1.Controls.Add(this.NbProjects);
            this.gradientPageConnexion1.Controls.Add(this.OrganizationLabel);
            this.gradientPageConnexion1.Controls.Add(this.label1);
            this.gradientPageConnexion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPageConnexion1.Location = new System.Drawing.Point(-81, -36);
            this.gradientPageConnexion1.Margin = new System.Windows.Forms.Padding(2);
            this.gradientPageConnexion1.Name = "gradientPageConnexion1";
            this.gradientPageConnexion1.Size = new System.Drawing.Size(1056, 765);
            this.gradientPageConnexion1.TabIndex = 1;
            this.gradientPageConnexion1.TopColor = System.Drawing.Color.Empty;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpen.Checked = true;
            this.checkBoxOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOpen.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic);
            this.checkBoxOpen.Location = new System.Drawing.Point(260, 271);
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
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 45;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.GraphiqueRatioTaskOrganization.Legends.Add(legend3);
            this.GraphiqueRatioTaskOrganization.Location = new System.Drawing.Point(1028, 61);
            this.GraphiqueRatioTaskOrganization.Margin = new System.Windows.Forms.Padding(2);
            this.GraphiqueRatioTaskOrganization.Name = "GraphiqueRatioTaskOrganization";
            this.GraphiqueRatioTaskOrganization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Task";
            series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.GraphiqueRatioTaskOrganization.Series.Add(series3);
            this.GraphiqueRatioTaskOrganization.Size = new System.Drawing.Size(254, 142);
            this.GraphiqueRatioTaskOrganization.TabIndex = 8;
            this.GraphiqueRatioTaskOrganization.Text = "Stats Des Tâches de l\'Organisation en cours";
            title3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Stats des Tâches En Cours de l\'Organisation";
            this.GraphiqueRatioTaskOrganization.Titles.Add(title3);
            // 
            // checkBoxArchived
            // 
            this.checkBoxArchived.AutoSize = true;
            this.checkBoxArchived.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxArchived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxArchived.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArchived.ForeColor = System.Drawing.Color.Red;
            this.checkBoxArchived.Location = new System.Drawing.Point(308, 271);
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
            this.labelTitreListeProjet.Location = new System.Drawing.Point(118, 269);
            this.labelTitreListeProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitreListeProjet.Name = "labelTitreListeProjet";
            this.labelTitreListeProjet.Size = new System.Drawing.Size(137, 19);
            this.labelTitreListeProjet.TabIndex = 14;
            this.labelTitreListeProjet.Text = "Liste des Projets :";
            // 
            // PanelListUsers
            // 
            this.PanelListUsers.BackColor = System.Drawing.Color.Transparent;
            this.PanelListUsers.Location = new System.Drawing.Point(687, 249);
            this.PanelListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListUsers.Name = "PanelListUsers";
            this.PanelListUsers.Size = new System.Drawing.Size(338, 447);
            this.PanelListUsers.TabIndex = 13;
            // 
            // PanelListTeams
            // 
            this.PanelListTeams.BackColor = System.Drawing.Color.Transparent;
            this.PanelListTeams.Location = new System.Drawing.Point(397, 249);
            this.PanelListTeams.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListTeams.Name = "PanelListTeams";
            this.PanelListTeams.Size = new System.Drawing.Size(248, 447);
            this.PanelListTeams.TabIndex = 12;
            // 
            // PanelListProjects
            // 
            this.PanelListProjects.BackColor = System.Drawing.Color.Transparent;
            this.PanelListProjects.Location = new System.Drawing.Point(121, 285);
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
            this.NbUtilisateurs.Location = new System.Drawing.Point(702, 180);
            this.NbUtilisateurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbUtilisateurs.Name = "NbUtilisateurs";
            this.NbUtilisateurs.Size = new System.Drawing.Size(135, 22);
            this.NbUtilisateurs.TabIndex = 10;
            this.NbUtilisateurs.Text = "nbUtilisateurs";
            // 
            // NbTeams
            // 
            this.NbTeams.AutoSize = true;
            this.NbTeams.BackColor = System.Drawing.Color.Transparent;
            this.NbTeams.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbTeams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbTeams.Location = new System.Drawing.Point(412, 180);
            this.NbTeams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbTeams.Name = "NbTeams";
            this.NbTeams.Size = new System.Drawing.Size(92, 22);
            this.NbTeams.TabIndex = 7;
            this.NbTeams.Text = "nbEquipe";
            // 
            // NbProjects
            // 
            this.NbProjects.AutoSize = true;
            this.NbProjects.BackColor = System.Drawing.Color.Transparent;
            this.NbProjects.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbProjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbProjects.Location = new System.Drawing.Point(117, 180);
            this.NbProjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NbProjects.Name = "NbProjects";
            this.NbProjects.Size = new System.Drawing.Size(70, 22);
            this.NbProjects.TabIndex = 2;
            this.NbProjects.Text = "nbProj";
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrganizationLabel.Location = new System.Drawing.Point(152, 67);
            this.OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(584, 41);
            this.OrganizationLabel.TabIndex = 1;
            this.OrganizationLabel.Text = "Vue d\'ensemble de l\'Organisation : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PanelOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradientPageConnexion1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelOrganization";
            this.Size = new System.Drawing.Size(975, 731);
            this.gradientPageConnexion1.ResumeLayout(false);
            this.gradientPageConnexion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphiqueRatioTaskOrganization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Service.GradientPageConnexion gradientPageConnexion1;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NbProjects;
        private System.Windows.Forms.Label NbTeams;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphiqueRatioTaskOrganization;
        private System.Windows.Forms.Label NbUtilisateurs;
        private System.Windows.Forms.Panel PanelListProjects;
        private System.Windows.Forms.Panel PanelListTeams;
        private System.Windows.Forms.Panel PanelListUsers;
        private System.Windows.Forms.Label labelTitreListeProjet;
        private System.Windows.Forms.CheckBox checkBoxArchived;
        private System.Windows.Forms.CheckBox checkBoxOpen;
    }
}
