
namespace StoriesHelper.Windows.Organizations
{
    partial class ListUsers
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
            this.labelTitreListeUtilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitreListeUtilisateur
            // 
            this.labelTitreListeUtilisateur.AutoSize = true;
            this.labelTitreListeUtilisateur.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitreListeUtilisateur.Location = new System.Drawing.Point(3, 21);
            this.labelTitreListeUtilisateur.Name = "labelTitreListeUtilisateur";
            this.labelTitreListeUtilisateur.Size = new System.Drawing.Size(211, 23);
            this.labelTitreListeUtilisateur.TabIndex = 0;
            this.labelTitreListeUtilisateur.Text = "Liste des Utilisateurs :";
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelTitreListeUtilisateur);
            this.Name = "ListUsers";
            this.Size = new System.Drawing.Size(450, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreListeUtilisateur;
    }
}
