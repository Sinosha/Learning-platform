using LearningPlatform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform.View
{
    public partial class MainMenuForm : Form
    {
        private readonly LearningPlatformDbContext _context;
        public User user;

        public MainMenuForm(User user)
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
            this.user = user;
            //LabelName.Text += user.PersonalData.FirstName.ToString() + user.PersonalData.SecondName.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => { new UserForm(this.user).ShowDialog(); });
        }

        private void TestsButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new TestsForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new VideoForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void ArticlesButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new ArticlesForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}
