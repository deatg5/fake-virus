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
    public partial class Balls : Form
    {
        Random rnd = new Random();
        List<Ball> ballList = new List<Ball>();
        public Balls()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            for (int i = 0; i < rnd.Next(1000, 15000); i++)
            {
                Ball myBall = new Ball(rnd.Next(0, ClientSize.Width - 100), rnd.Next(0, ClientSize.Height - 100), ClientSize.Width, ClientSize.Height, rnd.Next(1, 21), rnd.Next(1, 21), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), rnd.Next(1, 101), rnd.Next(1, 101));
                ballList.Add(myBall);
            }
            this.Text = $"{ballList.Count} balls currently on the screen!";

        }




        private void Balls_Paint(object sender, PaintEventArgs e)
        {
            timer1.Enabled = true;
            foreach (Ball ball in ballList)
            {
                ball.Draw(e.Graphics);
            }
        }

        private void Balls_Resize(object sender, EventArgs e)
        {
            Ball ballUsedToResize = new Ball(1, 1, 1, 1, 1, 1, Color.Black, 1, 1);
            ballUsedToResize.formHeight = ClientSize.Height;
            ballUsedToResize.formWidth = ClientSize.Width;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Invalidate(false);
        }
    }
}

