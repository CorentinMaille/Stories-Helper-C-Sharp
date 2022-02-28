
namespace StoriesHelper.Windows.Users
{
    partial class UserMainList
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
            this.LabelTitreUserList = new System.Windows.Forms.Label();
            this.gradient1 = new StoriesHelper.Services.Gradient();
            this.panelListUsers = new System.Windows.Forms.Panel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilterProject = new System.Windows.Forms.Label();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.labelFilterTeam = new System.Windows.Forms.Label();
            this.comboTeam = new System.Windows.Forms.ComboBox();
            this.labelFilterFirstName = new System.Windows.Forms.Label();
            this.labelFilterEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.labelFilterName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelFilterId = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitreUserList
            // 
            this.LabelTitreUserList.AutoSize = true;
            this.LabelTitreUserList.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitreUserList.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitreUserList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTitreUserList.Location = new System.Drawing.Point(41, 26);
            this.LabelTitreUserList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitreUserList.Name = "LabelTitreUserList";
            this.LabelTitreUserList.Size = new System.Drawing.Size(234, 41);
            this.LabelTitreUserList.TabIndex = 4;
            this.LabelTitreUserList.Text = "Utilisateurs : ";
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.labelFilterId);
            this.gradient1.Controls.Add(this.textId);
            this.gradient1.Controls.Add(this.panelListUsers);
            this.gradient1.Controls.Add(this.buttonFilter);
            this.gradient1.Controls.Add(this.labelFilterProject);
            this.gradient1.Controls.Add(this.comboProject);
            this.gradient1.Controls.Add(this.labelFilterTeam);
            this.gradient1.Controls.Add(this.comboTeam);
            this.gradient1.Controls.Add(this.labelFilterFirstName);
            this.gradient1.Controls.Add(this.labelFilterEmail);
            this.gradient1.Controls.Add(this.textEmail);
            this.gradient1.Controls.Add(this.textFirstname);
            this.gradient1.Controls.Add(this.labelFilterName);
            this.gradient1.Controls.Add(this.textName);
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1101, 900);
            this.gradient1.TabIndex = 5;
            this.gradient1.TopColor = System.Drawing.Color.Empty;
            // 
            // panelListUsers
            // 
            this.panelListUsers.Location = new System.Drawing.Point(17, 234);
            this.panelListUsers.Name = "panelListUsers";
            this.panelListUsers.Size = new System.Drawing.Size(1061, 636);
            this.panelListUsers.TabIndex = 17;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(917, 183);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(149, 29);
            this.buttonFilter.TabIndex = 16;
            this.buttonFilter.Text = "Filtrer";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // labelFilterProject
            // 
            this.labelFilterProject.AutoSize = true;
            this.labelFilterProject.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterProject.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterProject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterProject.Location = new System.Drawing.Point(386, 155);
            this.labelFilterProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterProject.Name = "labelFilterProject";
            this.labelFilterProject.Size = new System.Drawing.Size(83, 25);
            this.labelFilterProject.TabIndex = 15;
            this.labelFilterProject.Text = "Projet :";
            // 
            // comboProject
            // 
            this.comboProject.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(391, 183);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(330, 29);
            this.comboProject.TabIndex = 14;
            // 
            // labelFilterTeam
            // 
            this.labelFilterTeam.AutoSize = true;
            this.labelFilterTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterTeam.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterTeam.Location = new System.Drawing.Point(43, 155);
            this.labelFilterTeam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterTeam.Name = "labelFilterTeam";
            this.labelFilterTeam.Size = new System.Drawing.Size(91, 25);
            this.labelFilterTeam.TabIndex = 13;
            this.labelFilterTeam.Text = "Équipe :";
            // 
            // comboTeam
            // 
            this.comboTeam.Font = new System.Drawing.Font("Cambria", 13.8F);
            this.comboTeam.FormattingEnabled = true;
            this.comboTeam.Location = new System.Drawing.Point(48, 183);
            this.comboTeam.MaxLength = 5;
            this.comboTeam.Name = "comboTeam";
            this.comboTeam.Size = new System.Drawing.Size(330, 29);
            this.comboTeam.TabIndex = 12;
            // 
            // labelFilterFirstName
            // 
            this.labelFilterFirstName.AutoSize = true;
            this.labelFilterFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterFirstName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterFirstName.Location = new System.Drawing.Point(386, 87);
            this.labelFilterFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterFirstName.Name = "labelFilterFirstName";
            this.labelFilterFirstName.Size = new System.Drawing.Size(101, 25);
            this.labelFilterFirstName.TabIndex = 10;
            this.labelFilterFirstName.Text = "Prénom :";
            // 
            // labelFilterEmail
            // 
            this.labelFilterEmail.AutoSize = true;
            this.labelFilterEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterEmail.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterEmail.Location = new System.Drawing.Point(731, 87);
            this.labelFilterEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterEmail.Name = "labelFilterEmail";
            this.labelFilterEmail.Size = new System.Drawing.Size(78, 25);
            this.labelFilterEmail.TabIndex = 9;
            this.labelFilterEmail.Text = "Email :";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(736, 114);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(330, 29);
            this.textEmail.TabIndex = 8;
            // 
            // textFirstname
            // 
            this.textFirstname.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstname.Location = new System.Drawing.Point(391, 114);
            this.textFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(330, 29);
            this.textFirstname.TabIndex = 7;
            // 
            // labelFilterName
            // 
            this.labelFilterName.AutoSize = true;
            this.labelFilterName.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterName.Location = new System.Drawing.Point(43, 87);
            this.labelFilterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterName.Name = "labelFilterName";
            this.labelFilterName.Size = new System.Drawing.Size(68, 25);
            this.labelFilterName.TabIndex = 6;
            this.labelFilterName.Text = "Nom :";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(48, 114);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(330, 29);
            this.textName.TabIndex = 2;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(736, 183);
            this.textId.Margin = new System.Windows.Forms.Padding(2);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(149, 29);
            this.textId.TabIndex = 18;
            // 
            // labelFilterId
            // 
            this.labelFilterId.AutoSize = true;
            this.labelFilterId.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterId.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFilterId.Location = new System.Drawing.Point(731, 155);
            this.labelFilterId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilterId.Name = "labelFilterId";
            this.labelFilterId.Size = new System.Drawing.Size(43, 25);
            this.labelFilterId.TabIndex = 19;
            this.labelFilterId.Text = "Id :";
            // 
            // UserMainList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelTitreUserList);
            this.Controls.Add(this.gradient1);
            this.Name = "UserMainList";
            this.Size = new System.Drawing.Size(1101, 900);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitreUserList;
        private Services.Gradient gradient1;
        private System.Windows.Forms.Panel panelListUsers;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFilterProject;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Label labelFilterTeam;
        private System.Windows.Forms.ComboBox comboTeam;
        private System.Windows.Forms.Label labelFilterFirstName;
        private System.Windows.Forms.Label labelFilterEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.Label labelFilterName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelFilterId;
        private System.Windows.Forms.TextBox textId;
    }
}
