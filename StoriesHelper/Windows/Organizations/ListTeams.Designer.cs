
namespace StoriesHelper.Windows.Organizations
{
    partial class ListTeams
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
            this.labelTitreListeTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitreListeTeam
            // 
            this.labelTitreListeTeam.AutoSize = true;
            this.labelTitreListeTeam.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitreListeTeam.Location = new System.Drawing.Point(3, 21);
            this.labelTitreListeTeam.Name = "labelTitreListeTeam";
            this.labelTitreListeTeam.Size = new System.Drawing.Size(178, 23);
            this.labelTitreListeTeam.TabIndex = 0;
            this.labelTitreListeTeam.Text = "Liste des Équipes :";
            // 
            // ListTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTitreListeTeam);
            this.Name = "ListTeams";
            this.Size = new System.Drawing.Size(330, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreListeTeam;
    }
}
