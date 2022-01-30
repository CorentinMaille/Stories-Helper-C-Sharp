
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
            this.gradient = new StoriesHelper.Service.GradientPageConnexion();
            this.PanelListTeams = new System.Windows.Forms.Panel();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.gradient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.Angle = 90F;
            this.gradient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradient.BottomColor = System.Drawing.SystemColors.AppWorkspace;
            this.gradient.Controls.Add(this.PanelListTeams);
            this.gradient.Controls.Add(this.OrganizationLabel);
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(1101, 900);
            this.gradient.TabIndex = 0;
            this.gradient.TopColor = System.Drawing.Color.Empty;
            // 
            // PanelListTeams
            // 
            this.PanelListTeams.BackColor = System.Drawing.Color.Transparent;
            this.PanelListTeams.Location = new System.Drawing.Point(62, 542);
            this.PanelListTeams.Margin = new System.Windows.Forms.Padding(2);
            this.PanelListTeams.Name = "PanelListTeams";
            this.PanelListTeams.Size = new System.Drawing.Size(975, 300);
            this.PanelListTeams.TabIndex = 13;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.OrganizationLabel.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrganizationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OrganizationLabel.Location = new System.Drawing.Point(55, 44);
            this.OrganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(159, 41);
            this.OrganizationLabel.TabIndex = 2;
            this.OrganizationLabel.Text = "Project : ";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Service.GradientPageConnexion gradient;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Panel PanelListTeams;
    }
}
