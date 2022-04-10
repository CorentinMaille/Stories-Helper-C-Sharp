
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamGraphicsAdvanced
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
            this.TeamGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamGraphics
            // 
            this.TeamGraphics.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.TeamGraphics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TeamGraphics.Legends.Add(legend1);
            this.TeamGraphics.Location = new System.Drawing.Point(0, 0);
            this.TeamGraphics.Name = "TeamGraphics";
            this.TeamGraphics.Size = new System.Drawing.Size(1077, 450);
            this.TeamGraphics.TabIndex = 0;
            this.TeamGraphics.Text = "chart1";
            // 
            // TeamGraphicsAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeamGraphics);
            this.Name = "TeamGraphicsAdvanced";
            this.Size = new System.Drawing.Size(1077, 450);
            ((System.ComponentModel.ISupportInitialize)(this.TeamGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeamGraphics;
    }
}
