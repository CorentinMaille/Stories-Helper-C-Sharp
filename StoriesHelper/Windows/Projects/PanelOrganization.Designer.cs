
namespace StoriesHelper.Windows
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gradientPageConnexion1 = new StoriesHelper.Service.GradientPageConnexion();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NbUtilisateurs = new System.Windows.Forms.Label();
            this.GraphiqueRatioTaskOrganization = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.gradientPageConnexion1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gradientPageConnexion1.BottomColor = System.Drawing.Color.White;
            this.gradientPageConnexion1.Controls.Add(this.panel1);
            this.gradientPageConnexion1.Controls.Add(this.NbUtilisateurs);
            this.gradientPageConnexion1.Controls.Add(this.GraphiqueRatioTaskOrganization);
            this.gradientPageConnexion1.Controls.Add(this.NbTeams);
            this.gradientPageConnexion1.Controls.Add(this.NbProjects);
            this.gradientPageConnexion1.Controls.Add(this.OrganizationLabel);
            this.gradientPageConnexion1.Controls.Add(this.label1);
            this.gradientPageConnexion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPageConnexion1.Location = new System.Drawing.Point(-108, -44);
            this.gradientPageConnexion1.Name = "gradientPageConnexion1";
            this.gradientPageConnexion1.Size = new System.Drawing.Size(1408, 941);
            this.gradientPageConnexion1.TabIndex = 1;
            this.gradientPageConnexion1.TopColor = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(177, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 550);
            this.panel1.TabIndex = 11;
            // 
            // NbUtilisateurs
            // 
            this.NbUtilisateurs.AutoSize = true;
            this.NbUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.NbUtilisateurs.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbUtilisateurs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbUtilisateurs.Location = new System.Drawing.Point(936, 222);
            this.NbUtilisateurs.Name = "NbUtilisateurs";
            this.NbUtilisateurs.Size = new System.Drawing.Size(170, 28);
            this.NbUtilisateurs.TabIndex = 10;
            this.NbUtilisateurs.Text = "nbUtilisateurs";
            // 
            // GraphiqueRatioTaskOrganization
            // 
            this.GraphiqueRatioTaskOrganization.BackColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 45;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.GraphiqueRatioTaskOrganization.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.GraphiqueRatioTaskOrganization.Legends.Add(legend1);
            this.GraphiqueRatioTaskOrganization.Location = new System.Drawing.Point(1300, 186);
            this.GraphiqueRatioTaskOrganization.Name = "GraphiqueRatioTaskOrganization";
            this.GraphiqueRatioTaskOrganization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Task";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.GraphiqueRatioTaskOrganization.Series.Add(series1);
            this.GraphiqueRatioTaskOrganization.Size = new System.Drawing.Size(558, 312);
            this.GraphiqueRatioTaskOrganization.TabIndex = 8;
            this.GraphiqueRatioTaskOrganization.Text = "Stats Des Tâches de l\'Organisation en cours";
            title1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Stats des Tâches En Cours de l\'Organisation";
            this.GraphiqueRatioTaskOrganization.Titles.Add(title1);
            // 
            // NbTeams
            // 
            this.NbTeams.AutoSize = true;
            this.NbTeams.BackColor = System.Drawing.Color.Transparent;
            this.NbTeams.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbTeams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbTeams.Location = new System.Drawing.Point(549, 222);
            this.NbTeams.Name = "NbTeams";
            this.NbTeams.Size = new System.Drawing.Size(117, 28);
            this.NbTeams.TabIndex = 7;
            this.NbTeams.Text = "nbEquipe";
            // 
            // NbProjects
            // 
            this.NbProjects.AutoSize = true;
            this.NbProjects.BackColor = System.Drawing.Color.Transparent;
            this.NbProjects.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NbProjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NbProjects.Location = new System.Drawing.Point(172, 222);
            this.NbProjects.Name = "NbProjects";
            this.NbProjects.Size = new System.Drawing.Size(87, 28);
            this.NbProjects.TabIndex = 2;
            this.NbProjects.Text = "nbProj";
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrganizationLabel.Location = new System.Drawing.Point(215, 132);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(711, 51);
            this.OrganizationLabel.TabIndex = 1;
            this.OrganizationLabel.Text = "Vue d\'ensemble de l\'Organisation : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PanelOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradientPageConnexion1);
            this.Name = "PanelOrganization";
            this.Size = new System.Drawing.Size(1300, 900);
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
        private System.Windows.Forms.Panel panel1;
    }
}
