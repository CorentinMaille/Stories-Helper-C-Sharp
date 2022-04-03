
namespace StoriesHelper.Windows.Logs
{
    partial class LogMain
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
            this.PanelLogConsole = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelLogConsole
            // 
            this.PanelLogConsole.AutoScroll = true;
            this.PanelLogConsole.BackColor = System.Drawing.Color.Black;
            this.PanelLogConsole.Location = new System.Drawing.Point(0, 0);
            this.PanelLogConsole.Name = "PanelLogConsole";
            this.PanelLogConsole.Size = new System.Drawing.Size(1101, 650);
            this.PanelLogConsole.TabIndex = 0;
            // 
            // LogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelLogConsole);
            this.Name = "LogMain";
            this.Size = new System.Drawing.Size(1101, 900);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogConsole;
    }
}
