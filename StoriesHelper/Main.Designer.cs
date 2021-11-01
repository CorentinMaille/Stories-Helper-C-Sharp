
namespace StoriesHelper
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.collaboratorsButton = new System.Windows.Forms.Button();
            this.ProjectsButton = new System.Windows.Forms.Button();
            this.sideBarBackground = new System.Windows.Forms.Panel();
            this.ApplicationNamePanel = new System.Windows.Forms.Panel();
            this.StoriesHelperLabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoriesHelperLabel1 = new System.Windows.Forms.Label();
            this.organisationButton = new System.Windows.Forms.Button();
            this.PanelWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sideBarBackground.SuspendLayout();
            this.ApplicationNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // collaboratorsButton
            // 
            this.collaboratorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collaboratorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collaboratorsButton.Location = new System.Drawing.Point(12, 258);
            this.collaboratorsButton.Name = "collaboratorsButton";
            this.collaboratorsButton.Size = new System.Drawing.Size(275, 67);
            this.collaboratorsButton.TabIndex = 0;
            this.collaboratorsButton.Text = "Collaborateurs";
            this.collaboratorsButton.UseVisualStyleBackColor = true;
            this.collaboratorsButton.Click += new System.EventHandler(this.collaboratorsButton_Click);
            this.collaboratorsButton.MouseEnter += new System.EventHandler(this.buttonHover);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ProjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsButton.Location = new System.Drawing.Point(12, 342);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.Size = new System.Drawing.Size(275, 66);
            this.ProjectsButton.TabIndex = 1;
            this.ProjectsButton.Text = "Projets";
            this.ProjectsButton.UseVisualStyleBackColor = false;
            this.ProjectsButton.MouseEnter += new System.EventHandler(this.buttonHover);
            this.ProjectsButton.MouseHover += new System.EventHandler(this.buttonLeave);
            // 
            // sideBarBackground
            // 
            this.sideBarBackground.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sideBarBackground.Controls.Add(this.ApplicationNamePanel);
            this.sideBarBackground.Controls.Add(this.organisationButton);
            this.sideBarBackground.Controls.Add(this.ProjectsButton);
            this.sideBarBackground.Controls.Add(this.collaboratorsButton);
            this.sideBarBackground.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sideBarBackground.Location = new System.Drawing.Point(0, -1);
            this.sideBarBackground.Name = "sideBarBackground";
            this.sideBarBackground.Size = new System.Drawing.Size(298, 751);
            this.sideBarBackground.TabIndex = 2;
            // 
            // ApplicationNamePanel
            // 
            this.ApplicationNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationNamePanel.Controls.Add(this.StoriesHelperLabel2);
            this.ApplicationNamePanel.Controls.Add(this.pictureBox1);
            this.ApplicationNamePanel.Controls.Add(this.StoriesHelperLabel1);
            this.ApplicationNamePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ApplicationNamePanel.Location = new System.Drawing.Point(12, 13);
            this.ApplicationNamePanel.Name = "ApplicationNamePanel";
            this.ApplicationNamePanel.Size = new System.Drawing.Size(275, 138);
            this.ApplicationNamePanel.TabIndex = 3;
            // 
            // StoriesHelperLabel2
            // 
            this.StoriesHelperLabel2.AutoSize = true;
            this.StoriesHelperLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoriesHelperLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StoriesHelperLabel2.Location = new System.Drawing.Point(29, 68);
            this.StoriesHelperLabel2.Name = "StoriesHelperLabel2";
            this.StoriesHelperLabel2.Size = new System.Drawing.Size(102, 36);
            this.StoriesHelperLabel2.TabIndex = 4;
            this.StoriesHelperLabel2.Text = "Helper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(120, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StoriesHelperLabel1
            // 
            this.StoriesHelperLabel1.AutoSize = true;
            this.StoriesHelperLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoriesHelperLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StoriesHelperLabel1.Location = new System.Drawing.Point(24, 22);
            this.StoriesHelperLabel1.Name = "StoriesHelperLabel1";
            this.StoriesHelperLabel1.Size = new System.Drawing.Size(108, 36);
            this.StoriesHelperLabel1.TabIndex = 3;
            this.StoriesHelperLabel1.Text = "Stories";
            this.StoriesHelperLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // organisationButton
            // 
            this.organisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organisationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organisationButton.Location = new System.Drawing.Point(12, 176);
            this.organisationButton.Name = "organisationButton";
            this.organisationButton.Size = new System.Drawing.Size(275, 66);
            this.organisationButton.TabIndex = 3;
            this.organisationButton.Text = "Organisation";
            this.organisationButton.UseVisualStyleBackColor = true;
            this.organisationButton.MouseEnter += new System.EventHandler(this.buttonHover);
            // 
            // PanelWelcome
            // 
            this.PanelWelcome.Controls.Add(this.label1);
            this.PanelWelcome.Location = new System.Drawing.Point(293, -1);
            this.PanelWelcome.Name = "PanelWelcome";
            this.PanelWelcome.Size = new System.Drawing.Size(985, 751);
            this.PanelWelcome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 750);
            this.Controls.Add(this.PanelWelcome);
            this.Controls.Add(this.sideBarBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storie Helper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.sideBarBackground.ResumeLayout(false);
            this.ApplicationNamePanel.ResumeLayout(false);
            this.ApplicationNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelWelcome.ResumeLayout(false);
            this.PanelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button collaboratorsButton;
        private System.Windows.Forms.Button ProjectsButton;
        private System.Windows.Forms.Panel sideBarBackground;
        private System.Windows.Forms.Button organisationButton;
        private System.Windows.Forms.Panel ApplicationNamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StoriesHelperLabel1;
        private System.Windows.Forms.Label StoriesHelperLabel2;
        private System.Windows.Forms.Panel PanelWelcome;
        private System.Windows.Forms.Label label1;
    }
}