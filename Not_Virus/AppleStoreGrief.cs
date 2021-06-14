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
    public partial class AppleStoreGrief : Form
    {
        public AppleStoreGrief()
        {
            InitializeComponent();

            //this code was made by: Bhuban Magar (https://www.c-sharpcorner.com/blogs/play-youtube-videos-in-desktop-application-using-c-sharp)
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe width=\"690\" height=\"400\" src=\"https://www.youtube.com/embed/wQui3VZf_gg?controls=0&autoplay=1\" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>";
            html += "</body></html>";
            webBrowser1.DocumentText = string.Format(html);
        }
    }
}
