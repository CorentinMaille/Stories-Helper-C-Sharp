
namespace StoriesHelper
{
    partial class Organization
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
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.indicationLabelOrganisation = new System.Windows.Forms.Label();
            this.modOrgNomLabel = new System.Windows.Forms.Label();
            this.modOrgNomInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.OrganizationLabel.Location = new System.Drawing.Point(486, 179);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(258, 48);
            this.OrganizationLabel.TabIndex = 0;
            this.OrganizationLabel.Text = "Organisation";
            // 
            // indicationLabelOrganisation
            // 
            this.indicationLabelOrganisation.AutoSize = true;
            this.indicationLabelOrganisation.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicationLabelOrganisation.Location = new System.Drawing.Point(282, 264);
            this.indicationLabelOrganisation.Name = "indicationLabelOrganisation";
            this.indicationLabelOrganisation.Size = new System.Drawing.Size(699, 33);
            this.indicationLabelOrganisation.TabIndex = 1;
            this.indicationLabelOrganisation.Text = "Formulaire de modification du nom de l\'organisation";
            // 
            // modOrgNomLabel
            // 
            this.modOrgNomLabel.AutoSize = true;
            this.modOrgNomLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modOrgNomLabel.Location = new System.Drawing.Point(347, 357);
            this.modOrgNomLabel.Name = "modOrgNomLabel";
            this.modOrgNomLabel.Size = new System.Drawing.Size(67, 23);
            this.modOrgNomLabel.TabIndex = 2;
            this.modOrgNomLabel.Text = "Nom  :";
            // 
            // modOrgNomInput
            // 
            this.modOrgNomInput.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.modOrgNomInput.Location = new System.Drawing.Point(450, 354);
            this.modOrgNomInput.Name = "modOrgNomInput";
            this.modOrgNomInput.Size = new System.Drawing.Size(416, 31);
            this.modOrgNomInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ravie", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "MODIFIER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Organization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modOrgNomInput);
            this.Controls.Add(this.modOrgNomLabel);
            this.Controls.Add(this.indicationLabelOrganisation);
            this.Controls.Add(this.OrganizationLabel);
            this.Name = "Organization";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label indicationLabelOrganisation;
        private System.Windows.Forms.Label modOrgNomLabel;
        private System.Windows.Forms.TextBox modOrgNomInput;
        private System.Windows.Forms.Button button1;
    }
}
