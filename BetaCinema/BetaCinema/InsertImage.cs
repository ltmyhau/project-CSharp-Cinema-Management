using BetaCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BetaCinema
{
    public partial class InsertImage : Form
    {
        public InsertImage()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string imgLocation = "";

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"D:\MIS\2024 HK I\Lập trình C#.NET\Đồ án\Beta-Cinema\Image\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                picImage.ImageLocation = imgLocation;
            }
        }

        private void btnThemVaoCSDL_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] hinhAnh = null;
                string ma = txtID.Text;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(streem);
                hinhAnh = br.ReadBytes((int)streem.Length);
                string query = "UPDATE PhanLoai SET BieuTuongPL = @hinhAnh WHERE MaPL = @ma";
                //string query = "UPDATE Phim SET Poster = @hinhAnh WHERE MaPhim = @ma";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hinhAnh, ma });
                MessageBox.Show("Đã thêm ảnh vào cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, GetYouTubeVideoId(txtID.Text));
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
                return "Video ID not found";
            }
        }
    }
}
