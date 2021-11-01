
namespace StoriesHelper
{
    partial class Collaborators
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
            this.CollaboratorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CollaboratorLabel
            // 
            this.CollaboratorLabel.AutoSize = true;
            this.CollaboratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CollaboratorLabel.Location = new System.Drawing.Point(408, 321);
            this.CollaboratorLabel.Name = "CollaboratorLabel";
            this.CollaboratorLabel.Size = new System.Drawing.Size(292, 48);
            this.CollaboratorLabel.TabIndex = 0;
            this.CollaboratorLabel.Text = "Collaborateurs";
            // 
            // Collaborators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CollaboratorLabel);
            this.Name = "Collaborators";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CollaboratorLabel;
    }
}
