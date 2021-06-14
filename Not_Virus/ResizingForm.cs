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
    public partial class ResizingForm : Form
    {
        Random rnd = new Random();
        public ResizingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Width = rnd.Next(10, 1920);
            Height = rnd.Next(10, 1080);
        }
    }
}
