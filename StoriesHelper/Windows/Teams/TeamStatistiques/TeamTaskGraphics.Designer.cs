
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamTaskGraphics
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TeamGraphicsStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphicsStat)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamGraphicsStat
            // 
            this.TeamGraphicsStat.BackColor = System.Drawing.Color.Transparent;
            this.TeamGraphicsStat.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.TeamGraphicsStat.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.TeamGraphicsStat.Legends.Add(legend1);
            this.TeamGraphicsStat.Location = new System.Drawing.Point(0, 3);
            this.TeamGraphicsStat.Name = "TeamGraphicsStat";
            this.TeamGraphicsStat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tâches en cours";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tâches archivées";
            this.TeamGraphicsStat.Series.Add(series1);
            this.TeamGraphicsStat.Series.Add(series2);
            this.TeamGraphicsStat.Size = new System.Drawing.Size(1050, 502);
            this.TeamGraphicsStat.TabIndex = 0;
            this.TeamGraphicsStat.Text = "chart1";
            // 
            // TeamTaskGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeamGraphicsStat);
            this.Name = "TeamTaskGraphics";
            this.Size = new System.Drawing.Size(1050, 502);
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphicsStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeamGraphicsStat;
    }
}
