using LearningPlatform.Model;
using LearningPlatform.View;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
using Pbkdf2;
using LearningPlatform.Classes;

namespace LearningPlatform
{
    public partial class AuthorizationForm : Form
    {
        private readonly LearningPlatformDbContext _context;
        public User user = new User();
        public Encrypt encrypt = new Encrypt();

        public AuthorizationForm()
        {
            InitializeComponent();
            #region
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            #endregion
            PasswordCheckBox.CheckedChanged += PasswordShow;
        }
        private void PasswordShow(object sender, EventArgs e)
        {
            if (PasswordCheckBox.Checked == false)
            {
                PasswordCheckBox.BackgroundImage = Properties.Resources.ClosedEyeIcon;
                PasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordCheckBox.BackgroundImage = Properties.Resources.OpenEyeIcon;
                PasswordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            user = _context.ApplicationUsers.FirstOrDefault(l => l.Login == LoginTextBox.Text);
            string tempPassword = PasswordTextBox.Text;
            if (user != null)
            {
                if ((encrypt.HashPassword(tempPassword, user.Salt)) == user.Password)
                {
                    this.Close();
                    new MainMenuForm(user).ShowDialog();
                }
                else
                {
                    Label.Visible = true;
                }

            }
            else
            {
                Label.Visible = true;
            }
        }

    }

}