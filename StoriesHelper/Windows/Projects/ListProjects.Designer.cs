
namespace StoriesHelper.Windows.Projects
{
    partial class ListProjects
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
            this.labelTitreListeProjet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitreListeProjet
            // 
            this.labelTitreListeProjet.AutoSize = true;
            this.labelTitreListeProjet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreListeProjet.Location = new System.Drawing.Point(3, 21);
            this.labelTitreListeProjet.Name = "labelTitreListeProjet";
            this.labelTitreListeProjet.Size = new System.Drawing.Size(169, 23);
            this.labelTitreListeProjet.TabIndex = 0;
            this.labelTitreListeProjet.Text = "Liste des projets :";
            // 
            // ListProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTitreListeProjet);
            this.Name = "ListProjects";
            this.Size = new System.Drawing.Size(330, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreListeProjet;
    }
}
