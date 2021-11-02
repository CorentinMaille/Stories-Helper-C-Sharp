
namespace StoriesHelper.Fenetre
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputLastname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.InputFirstname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.Label();
            this.InputBirth = new System.Windows.Forms.DateTimePicker();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InscriptionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CollaboratorLabel
            // 
            this.CollaboratorLabel.AutoSize = true;
            this.CollaboratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CollaboratorLabel.Location = new System.Drawing.Point(437, 18);
            this.CollaboratorLabel.Name = "CollaboratorLabel";
            this.CollaboratorLabel.Size = new System.Drawing.Size(292, 48);
            this.CollaboratorLabel.TabIndex = 0;
            this.CollaboratorLabel.Text = "Collaborateurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inscription d\'un utilisateur";
            // 
            // InputLastname
            // 
            this.InputLastname.Location = new System.Drawing.Point(90, 303);
            this.InputLastname.Name = "InputLastname";
            this.InputLastname.Size = new System.Drawing.Size(323, 22);
            this.InputLastname.TabIndex = 2;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(87, 283);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(37, 17);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "Nom";
            this.lastname.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(87, 339);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(57, 17);
            this.firstname.TabIndex = 4;
            this.firstname.Text = "Prénom";
            // 
            // InputFirstname
            // 
            this.InputFirstname.Location = new System.Drawing.Point(88, 359);
            this.InputFirstname.Name = "InputFirstname";
            this.InputFirstname.Size = new System.Drawing.Size(325, 22);
            this.InputFirstname.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(87, 402);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 6;
            this.email.Text = "email";
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(88, 426);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(325, 22);
            this.InputEmail.TabIndex = 7;
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(87, 465);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(124, 17);
            this.birth.TabIndex = 8;
            this.birth.Text = "date de naissance";
            // 
            // InputBirth
            // 
            this.InputBirth.Location = new System.Drawing.Point(88, 485);
            this.InputBirth.Name = "InputBirth";
            this.InputBirth.Size = new System.Drawing.Size(325, 22);
            this.InputBirth.TabIndex = 9;
            // 
            // InputPassword
            // 
            this.InputPassword.Location = new System.Drawing.Point(90, 555);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(322, 22);
            this.InputPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "mot de passe";
            // 
            // InscriptionButton
            // 
            this.InscriptionButton.Location = new System.Drawing.Point(90, 639);
            this.InscriptionButton.Name = "InscriptionButton";
            this.InscriptionButton.Size = new System.Drawing.Size(323, 84);
            this.InscriptionButton.TabIndex = 12;
            this.InscriptionButton.Text = "Inscrire";
            this.InscriptionButton.UseVisualStyleBackColor = true;
            this.InscriptionButton.Click += new System.EventHandler(this.inscription);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(573, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 48);
            this.label3.TabIndex = 13;
            this.label3.Text = "Suppression d\'un utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "email";
            // 
            // emailUser
            // 
            this.emailUser.Location = new System.Drawing.Point(581, 303);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(231, 22);
            this.emailUser.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 75);
            this.button1.TabIndex = 17;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteUser);
            // 
            // Collaborators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InscriptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.InputBirth);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.InputFirstname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.InputLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CollaboratorLabel);
            this.Name = "Collaborators";
            this.Size = new System.Drawing.Size(1300, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CollaboratorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputLastname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox InputFirstname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.DateTimePicker InputBirth;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InscriptionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailUser;
        private System.Windows.Forms.Button button1;
    }
}
