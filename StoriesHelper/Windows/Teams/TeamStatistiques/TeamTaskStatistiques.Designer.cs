
namespace StoriesHelper.Windows.Teams.TeamStatistiques
{
    partial class TeamTaskStatistiques
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
            this.precedent = new System.Windows.Forms.Button();
            this.jour = new System.Windows.Forms.Button();
            this.mois = new System.Windows.Forms.Button();
            this.annee = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.semaine = new System.Windows.Forms.Button();
            this.PanelTeamTaskGraphics = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(322, 4);
            this.precedent.Margin = new System.Windows.Forms.Padding(4);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(116, 33);
            this.precedent.TabIndex = 32;
            this.precedent.Text = "<< précédent";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // jour
            // 
            this.jour.Location = new System.Drawing.Point(481, 4);
            this.jour.Margin = new System.Windows.Forms.Padding(4);
            this.jour.Name = "jour";
            this.jour.Size = new System.Drawing.Size(116, 33);
            this.jour.TabIndex = 33;
            this.jour.Text = "Jour";
            this.jour.UseVisualStyleBackColor = true;
            this.jour.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // mois
            // 
            this.mois.Location = new System.Drawing.Point(810, 4);
            this.mois.Margin = new System.Windows.Forms.Padding(4);
            this.mois.Name = "mois";
            this.mois.Size = new System.Drawing.Size(116, 33);
            this.mois.TabIndex = 34;
            this.mois.Text = "Mois";
            this.mois.UseVisualStyleBackColor = true;
            this.mois.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // annee
            // 
            this.annee.Location = new System.Drawing.Point(978, 4);
            this.annee.Margin = new System.Windows.Forms.Padding(4);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(116, 33);
            this.annee.TabIndex = 35;
            this.annee.Text = "Année";
            this.annee.UseVisualStyleBackColor = true;
            this.annee.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(1132, 4);
            this.suivant.Margin = new System.Windows.Forms.Padding(4);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(116, 33);
            this.suivant.TabIndex = 36;
            this.suivant.Text = "Suivant >>";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // semaine
            // 
            this.semaine.Location = new System.Drawing.Point(645, 4);
            this.semaine.Margin = new System.Windows.Forms.Padding(4);
            this.semaine.Name = "semaine";
            this.semaine.Size = new System.Drawing.Size(116, 33);
            this.semaine.TabIndex = 37;
            this.semaine.Text = "Semaine";
            this.semaine.UseVisualStyleBackColor = true;
            this.semaine.Click += new System.EventHandler(this.btnDateGraphics);
            // 
            // PanelTeamTaskGraphics
            // 
            this.PanelTeamTaskGraphics.Location = new System.Drawing.Point(280, 49);
            this.PanelTeamTaskGraphics.Name = "PanelTeamTaskGraphics";
            this.PanelTeamTaskGraphics.Size = new System.Drawing.Size(1050, 502);
            this.PanelTeamTaskGraphics.TabIndex = 38;
            // 
            // TeamTaskStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.PanelTeamTaskGraphics);
            this.Controls.Add(this.semaine);
            this.Controls.Add(this.mois);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.annee);
            this.Controls.Add(this.jour);
            this.Controls.Add(this.precedent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamTaskStatistiques";
            this.Size = new System.Drawing.Size(1333, 554);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button jour;
        private System.Windows.Forms.Button mois;
        private System.Windows.Forms.Button annee;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button semaine;
        private System.Windows.Forms.Panel PanelTeamTaskGraphics;
    }
}
