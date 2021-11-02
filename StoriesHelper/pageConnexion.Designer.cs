
namespace StoriesHelper
{
    partial class pageConnexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageConnexion));
            this.gradientPageConnexion1 = new StoriesHelper.GradientPageConnexion();
            this.erreurPassword = new System.Windows.Forms.Label();
            this.erreurEmail = new System.Windows.Forms.Label();
            this.connexion = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPageConnexion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPageConnexion1
            // 
            this.gradientPageConnexion1.Angle = 90F;
            this.gradientPageConnexion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.gradientPageConnexion1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(1)))), ((int)(((byte)(224)))));
            this.gradientPageConnexion1.Controls.Add(this.pictureBox1);
            this.gradientPageConnexion1.Controls.Add(this.erreurPassword);
            this.gradientPageConnexion1.Controls.Add(this.erreurEmail);
            this.gradientPageConnexion1.Controls.Add(this.connexion);
            this.gradientPageConnexion1.Controls.Add(this.titre);
            this.gradientPageConnexion1.Controls.Add(this.passwordInput);
            this.gradientPageConnexion1.Controls.Add(this.emailLabel);
            this.gradientPageConnexion1.Controls.Add(this.passwordLabel);
            this.gradientPageConnexion1.Controls.Add(this.emailInput);
            this.gradientPageConnexion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPageConnexion1.Location = new System.Drawing.Point(0, 0);
            this.gradientPageConnexion1.Name = "gradientPageConnexion1";
            this.gradientPageConnexion1.Size = new System.Drawing.Size(598, 694);
            this.gradientPageConnexion1.TabIndex = 7;
            this.gradientPageConnexion1.TopColor = System.Drawing.Color.Empty;
            this.gradientPageConnexion1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // erreurPassword
            // 
            this.erreurPassword.AutoSize = true;
            this.erreurPassword.BackColor = System.Drawing.Color.Transparent;
            this.erreurPassword.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.erreurPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreurPassword.Location = new System.Drawing.Point(99, 442);
            this.erreurPassword.Name = "erreurPassword";
            this.erreurPassword.Size = new System.Drawing.Size(0, 20);
            this.erreurPassword.TabIndex = 9;
            // 
            // erreurEmail
            // 
            this.erreurEmail.AutoSize = true;
            this.erreurEmail.BackColor = System.Drawing.Color.Transparent;
            this.erreurEmail.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.erreurEmail.Location = new System.Drawing.Point(99, 314);
            this.erreurEmail.Name = "erreurEmail";
            this.erreurEmail.Size = new System.Drawing.Size(0, 20);
            this.erreurEmail.TabIndex = 8;
            // 
            // connexion
            // 
            this.connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.connexion.FlatAppearance.BorderSize = 0;
            this.connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexion.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.ForeColor = System.Drawing.Color.White;
            this.connexion.Location = new System.Drawing.Point(175, 542);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(250, 56);
            this.connexion.TabIndex = 6;
            this.connexion.Text = "Connexion";
            this.connexion.UseVisualStyleBackColor = false;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(40, 108);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(516, 51);
            this.titre.TabIndex = 0;
            this.titre.Text = "StoriesHelper BackOffice";
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.passwordInput.Location = new System.Drawing.Point(81, 401);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(442, 34);
            this.passwordInput.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(93, 223);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(218, 33);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Adresse Email *";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(93, 355);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(201, 33);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Mot de passe *";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput.Location = new System.Drawing.Point(81, 273);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(442, 34);
            this.emailInput.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.quitter_Click);
            // 
            // pageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 694);
            this.Controls.Add(this.gradientPageConnexion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pageConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pageConnexion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.gradientPageConnexion1.ResumeLayout(false);
            this.gradientPageConnexion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button connexion;
        private GradientPageConnexion gradientPageConnexion1;
        private System.Windows.Forms.Label erreurEmail;
        private System.Windows.Forms.Label erreurPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

