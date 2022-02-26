
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TitreStatistique
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
            this.Titre = new System.Windows.Forms.Label();
            this.Rendement = new System.Windows.Forms.Label();
            this.ValueRendement = new System.Windows.Forms.Label();
            this.Taches = new System.Windows.Forms.Label();
            this.ValueTache = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.Black;
            this.Titre.Location = new System.Drawing.Point(10, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(76, 32);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Titre";
            // 
            // Rendement
            // 
            this.Rendement.AutoSize = true;
            this.Rendement.BackColor = System.Drawing.Color.Transparent;
            this.Rendement.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendement.ForeColor = System.Drawing.Color.Black;
            this.Rendement.Location = new System.Drawing.Point(23, 55);
            this.Rendement.Name = "Rendement";
            this.Rendement.Size = new System.Drawing.Size(157, 32);
            this.Rendement.TabIndex = 2;
            this.Rendement.Text = "Rendement";
            // 
            // ValueRendement
            // 
            this.ValueRendement.AutoSize = true;
            this.ValueRendement.BackColor = System.Drawing.Color.Transparent;
            this.ValueRendement.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueRendement.ForeColor = System.Drawing.Color.Black;
            this.ValueRendement.Location = new System.Drawing.Point(40, 98);
            this.ValueRendement.Name = "ValueRendement";
            this.ValueRendement.Size = new System.Drawing.Size(108, 41);
            this.ValueRendement.TabIndex = 3;
            this.ValueRendement.Text = "Value";
            // 
            // Taches
            // 
            this.Taches.AutoSize = true;
            this.Taches.BackColor = System.Drawing.Color.Transparent;
            this.Taches.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taches.ForeColor = System.Drawing.Color.Black;
            this.Taches.Location = new System.Drawing.Point(48, 190);
            this.Taches.Name = "Taches";
            this.Taches.Size = new System.Drawing.Size(100, 32);
            this.Taches.TabIndex = 4;
            this.Taches.Text = "Tâches";
            // 
            // ValueTache
            // 
            this.ValueTache.AutoSize = true;
            this.ValueTache.BackColor = System.Drawing.Color.Transparent;
            this.ValueTache.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold);
            this.ValueTache.ForeColor = System.Drawing.Color.Black;
            this.ValueTache.Location = new System.Drawing.Point(48, 237);
            this.ValueTache.Name = "ValueTache";
            this.ValueTache.Size = new System.Drawing.Size(108, 41);
            this.ValueTache.TabIndex = 5;
            this.ValueTache.Text = "Value";
            // 
            // TitreStatistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ValueTache);
            this.Controls.Add(this.Taches);
            this.Controls.Add(this.ValueRendement);
            this.Controls.Add(this.Rendement);
            this.Controls.Add(this.Titre);
            this.Name = "TitreStatistique";
            this.Size = new System.Drawing.Size(250, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Rendement;
        private System.Windows.Forms.Label ValueRendement;
        private System.Windows.Forms.Label Taches;
        private System.Windows.Forms.Label ValueTache;
    }
}
