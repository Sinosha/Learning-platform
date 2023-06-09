﻿namespace LearningPlatform.View
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ArticlesButton = new System.Windows.Forms.Button();
            this.VideoButton = new System.Windows.Forms.Button();
            this.TestsButton = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticlesButton
            // 
            resources.ApplyResources(this.ArticlesButton, "ArticlesButton");
            this.ArticlesButton.BackColor = System.Drawing.Color.Transparent;
            this.ArticlesButton.Name = "ArticlesButton";
            this.ArticlesButton.UseVisualStyleBackColor = false;
            // 
            // VideoButton
            // 
            resources.ApplyResources(this.VideoButton, "VideoButton");
            this.VideoButton.BackColor = System.Drawing.Color.Transparent;
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.UseVisualStyleBackColor = false;
            // 
            // TestsButton
            // 
            resources.ApplyResources(this.TestsButton, "TestsButton");
            this.TestsButton.BackColor = System.Drawing.Color.Transparent;
            this.TestsButton.Name = "TestsButton";
            this.TestsButton.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.Name = "LabelName";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArticlesButton);
            this.Controls.Add(this.VideoButton);
            this.Controls.Add(this.TestsButton);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ArticlesButton;
        private Button VideoButton;
        private Button TestsButton;
        private Label LabelName;
        private PictureBox pictureBox2;
    }
}