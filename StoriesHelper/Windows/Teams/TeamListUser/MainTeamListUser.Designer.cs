
namespace StoriesHelper.Windows.Teams.TeamListUser
{
    partial class MainTeamListUser
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
            this.PanelPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelListUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelPagination
            // 
            this.PanelPagination.AutoSize = true;
            this.PanelPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPagination.Location = new System.Drawing.Point(3, 250);
            this.PanelPagination.MaximumSize = new System.Drawing.Size(625, 50);
            this.PanelPagination.Name = "PanelPagination";
            this.PanelPagination.Size = new System.Drawing.Size(0, 0);
            this.PanelPagination.TabIndex = 0;
            // 
            // PanelListUsers
            // 
            this.PanelListUsers.Location = new System.Drawing.Point(0, 0);
            this.PanelListUsers.Name = "PanelListUsers";
            this.PanelListUsers.Size = new System.Drawing.Size(575, 250);
            this.PanelListUsers.TabIndex = 1;
            // 
            // MainTeamListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelListUsers);
            this.Controls.Add(this.PanelPagination);
            this.Name = "MainTeamListUser";
            this.Size = new System.Drawing.Size(575, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelPagination;
        private System.Windows.Forms.FlowLayoutPanel PanelListUsers;
    }
}
