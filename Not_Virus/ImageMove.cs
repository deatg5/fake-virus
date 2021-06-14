using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Virus
{
    public partial class ImageMove : Form
    {
        Random rnd = new Random();
        List<MovingPic> picList = new List<MovingPic>();
        public ImageMove()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            for (int i = 0; i < rnd.Next(5, 101); i++)
            {
                MovingPic img1 = new MovingPic(rnd.Next(0, ClientSize.Width - 100), rnd.Next(0, ClientSize.Height - 100), ClientSize.Width, ClientSize.Height, rnd.Next(1, 21), rnd.Next(1, 21), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), rnd.Next(50, 201), rnd.Next(50, 201));
                picList.Add(img1);
            }
            Text = $"{picList.Count} images currently on the screen!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate(false);
        }

        private void ImageMove_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
            foreach (MovingPic pic in picList)
            {
                pic.Draw(e.Graphics);
            }
        }

        private void ImageMove_Resize(object sender, EventArgs e)
        {
            MovingPic ballUsedToResize = new MovingPic(1, 1, 1, 1, 1, 1, Color.Black, 1, 1);
            ballUsedToResize.formHeight = ClientSize.Height;
            ballUsedToResize.formWidth = ClientSize.Width;
        }
    }
}
