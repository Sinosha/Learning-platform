namespace LearningPlatform
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            InputButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            PasswordCheckBox = new CheckBox();
            Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            resources.ApplyResources(LoginTextBox, "LoginTextBox");
            LoginTextBox.BackColor = Color.LightBlue;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.ShortcutsEnabled = false;
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(PasswordTextBox, "PasswordTextBox");
            PasswordTextBox.BackColor = Color.LightBlue;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.CausesValidation = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // InputButton
            // 
            resources.ApplyResources(InputButton, "InputButton");
            InputButton.BackColor = Color.LightBlue;
            InputButton.Name = "InputButton";
            InputButton.UseVisualStyleBackColor = false;
            InputButton.Click += InputButton_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.BackColor = Color.LightBlue;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // PasswordCheckBox
            // 
            resources.ApplyResources(PasswordCheckBox, "PasswordCheckBox");
            PasswordCheckBox.BackColor = Color.LightBlue;
            PasswordCheckBox.BackgroundImage = Properties.Resources.ClosedEyeIcon;
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.UseMnemonic = false;
            PasswordCheckBox.UseVisualStyleBackColor = false;
            // 
            // Label
            // 
            resources.ApplyResources(Label, "Label");
            Label.ForeColor = Color.Red;
            Label.Name = "Label";
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label);
            Controls.Add(PasswordCheckBox);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(InputButton);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "AuthorizationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private PictureBox pictureBox1;
        private Button InputButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox PasswordCheckBox;
        private Label Label;
    }
}