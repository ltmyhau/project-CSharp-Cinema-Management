using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema
{
    public partial class fMovieTrailer : Form
    {
        public fMovieTrailer(string url)
        {
            InitializeComponent();

            LoadYouTubeVideo(url);
        }

        private void LoadYouTubeVideo(string url)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.wbsTrailer.DocumentText = string.Format(html, GetYouTubeVideoId(url));
        }

        static string GetYouTubeVideoId(string url)
        {
            string pattern = @"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(url);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
    }
}
