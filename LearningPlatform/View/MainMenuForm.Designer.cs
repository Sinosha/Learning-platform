namespace LearningPlatform.View
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
            pictureBox2 = new PictureBox();
            LabelName = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LabelName
            // 
            resources.ApplyResources(LabelName, "LabelName");
            LabelName.Name = "LabelName";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Transparent;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(LabelName);
            Controls.Add(pictureBox2);
            Name = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label LabelName;
        private Button button1;
    }
}