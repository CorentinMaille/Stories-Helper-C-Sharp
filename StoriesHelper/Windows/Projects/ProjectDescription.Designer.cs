
namespace StoriesHelper.Windows.Projects
{
    partial class ProjectDescription
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
            this.DescriptionTitre = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionTitre
            // 
            this.DescriptionTitre.AutoEllipsis = true;
            this.DescriptionTitre.AutoSize = true;
            this.DescriptionTitre.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.DescriptionTitre.Location = new System.Drawing.Point(4, 4);
            this.DescriptionTitre.MaximumSize = new System.Drawing.Size(305, 0);
            this.DescriptionTitre.Name = "DescriptionTitre";
            this.DescriptionTitre.Size = new System.Drawing.Size(125, 22);
            this.DescriptionTitre.TabIndex = 0;
            this.DescriptionTitre.Text = "Description : ";
            // 
            // Description
            // 
            this.Description.AutoEllipsis = true;
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(4, 37);
            this.Description.MaximumSize = new System.Drawing.Size(305, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(0, 22);
            this.Description.TabIndex = 1;
            // 
            // ProjectDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionTitre);
            this.MaximumSize = new System.Drawing.Size(305, 150000);
            this.Name = "ProjectDescription";
            this.Size = new System.Drawing.Size(305, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionTitre;
        private System.Windows.Forms.Label Description;
    }
}
