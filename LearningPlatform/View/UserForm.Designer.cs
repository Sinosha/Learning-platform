namespace LearningPlatform.View
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            pictureBox2 = new PictureBox();
            LabelName = new Label();
            LabelSecondName = new Label();
            LabelPhone = new Label();
            LabelMail = new Label();
            LabelMark = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.LightBlue;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(3, 5);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BorderStyle = BorderStyle.Fixed3D;
            LabelName.Location = new Point(186, 35);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 17);
            LabelName.TabIndex = 6;
            LabelName.Text = "Имя: ";
            // 
            // LabelSecondName
            // 
            LabelSecondName.AutoSize = true;
            LabelSecondName.BorderStyle = BorderStyle.Fixed3D;
            LabelSecondName.Location = new Point(186, 74);
            LabelSecondName.Name = "LabelSecondName";
            LabelSecondName.Size = new Size(66, 17);
            LabelSecondName.TabIndex = 7;
            LabelSecondName.Text = "Фамилия: ";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.BorderStyle = BorderStyle.Fixed3D;
            LabelPhone.Location = new Point(186, 118);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(109, 17);
            LabelPhone.TabIndex = 8;
            LabelPhone.Text = "Номер телефона: ";
            // 
            // LabelMail
            // 
            LabelMail.AutoSize = true;
            LabelMail.BorderStyle = BorderStyle.Fixed3D;
            LabelMail.Location = new Point(186, 155);
            LabelMail.Name = "LabelMail";
            LabelMail.Size = new Size(49, 17);
            LabelMail.TabIndex = 9;
            LabelMail.Text = "E-mail: ";
            // 
            // LabelMark
            // 
            LabelMark.AutoSize = true;
            LabelMark.BorderStyle = BorderStyle.Fixed3D;
            LabelMark.Location = new Point(186, 199);
            LabelMark.Name = "LabelMark";
            LabelMark.Size = new Size(93, 17);
            LabelMark.TabIndex = 10;
            LabelMark.Text = "Средний балл: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 295);
            label6.Name = "label6";
            label6.Size = new Size(232, 22);
            label6.TabIndex = 11;
            label6.Text = "↑ Это ваша фотография (якобы)";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(393, 362);
            Controls.Add(label6);
            Controls.Add(LabelMark);
            Controls.Add(LabelMail);
            Controls.Add(LabelPhone);
            Controls.Add(LabelSecondName);
            Controls.Add(LabelName);
            Controls.Add(pictureBox2);
            Name = "UserForm";
            Text = "Окно пользователя";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label LabelName;
        private Label LabelSecondName;
        private Label LabelPhone;
        private Label LabelMail;
        private Label LabelMark;
        private Label label6;
    }
}