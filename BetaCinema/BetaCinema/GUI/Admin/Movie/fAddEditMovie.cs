using BetaCinema.DAO;
using BetaCinema.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Movie
{
    public partial class fAddEditMovie : Form
    {
        public fAddEditMovie()
        {
            InitializeComponent();

            btnAdd.Visible = true;
            btnSave.Visible = false;
            txtMovieID.Text = MovieDAO.Instance.GetNextMaPhim();
            LoadGenre();
            LoadMovieRatingSystem();
        }

        #region Methods
        void LoadGenre()
        {
            clbGenre.Items.Clear();
            List<GenreDTO> listGenre = GenreDAO.Instance.GetListGenre();
            foreach (GenreDTO genre in listGenre)
            {
                clbGenre.Items.Add(genre.TenTheLoai);
            }
        }

        void LoadMovieRatingSystem()
        {
            cboMovieRatingSystem.Items.Clear();
            List<MovieRatingSystemDTO> listMovieRatingSystem = MovieRatingSystemDAO.Instance.GetListMovieRatingSystem();
            cboMovieRatingSystem.DataSource = listMovieRatingSystem;
            cboMovieRatingSystem.DisplayMember = "MaPL";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnAdd.Visible = false;
            btnSave.Visible = true;
            string maPhim = selectedRow.Cells["MaPhim"].Value?.ToString();
            CheckGenreInCheckListBox(maPhim);
            txtMovieID.Text = maPhim;
            txtMovieName.Text = selectedRow.Cells["TenPhim"].Value?.ToString();
            txtCountry.Text = selectedRow.Cells["QuocGia"].Value?.ToString();
            txtDuration.Text = selectedRow.Cells["ThoiLuong"].Value?.ToString();
            txtDirector.Text = selectedRow.Cells["DaoDien"].Value?.ToString();
            txtSynopsis.Text = selectedRow.Cells["MoTa"].Value?.ToString();
            dtpReleaseDate.Value = DateTime.Parse(selectedRow.Cells["NgayKhoiChieu"].Value?.ToString());
            txtTrailerURL.Text = selectedRow.Cells["Trailer"].Value?.ToString();

            foreach (MovieRatingSystemDTO item in cboMovieRatingSystem.Items)
            {
                if (item.MaPL == selectedRow.Cells["MaPL"].Value.ToString())
                {
                    cboMovieRatingSystem.SelectedItem = item;
                    break;
                }
            }

            if (selectedRow.Cells["Poster"].Value != null)
            {
                byte[] posterData = (byte[])selectedRow.Cells["Poster"].Value;
                using (MemoryStream ms = new MemoryStream(posterData))
                {
                    picPoster.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            else
            {
                picPoster.Image = Properties.Resources.poster;
            }
        }

        void CheckGenreInCheckListBox(string maPhim)
        {
            List<GenreMovieDTO> genreMovies = GenreMovieDAO.Instance.GetListGenreMovieByMovieID(maPhim);
            for (int i = 0; i < clbGenre.Items.Count; i++)
            {
                string genreName = clbGenre.Items[i].ToString();
                foreach (GenreMovieDTO genreMovie in genreMovies)
                {
                    List<GenreDTO> genreList = GenreDAO.Instance.GetListGenreByGenreID(genreMovie.MaTL);
                    foreach (GenreDTO genre in genreList)
                    {
                        if (genreName == genre.TenTheLoai)
                        {
                            clbGenre.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                MessageBox.Show("Tên phim không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMovieName.Focus();
                return false;
            }
            if (!int.TryParse(txtDuration.Text, out int thoiLuong) || thoiLuong <= 0)
            {
                MessageBox.Show("Thời lượng phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
                return false;
            }
            if (!IsAtLeastOneItemChecked(clbGenre))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một thể loại phim.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsAtLeastOneItemChecked(CheckedListBox checkListBox)
        {
            bool atLeastOneChecked = false;
            foreach (object item in checkListBox.Items)
            {
                if (checkListBox.CheckedItems.Contains(item))
                {
                    atLeastOneChecked = true;
                    break;
                }
            }
            return atLeastOneChecked;
        }

        private bool InsertMovieToDatabase()
        {
            string tenPhim = txtMovieName.Text.Trim();
            string maPL = cboMovieRatingSystem.Text;
            string daoDien = !string.IsNullOrEmpty(txtDirector.Text.Trim()) ? txtDirector.Text.Trim() : null;
            string quocGia = !string.IsNullOrEmpty(txtCountry.Text.Trim()) ? txtCountry.Text.Trim() : null;
            int thoiLuong = int.Parse(txtDuration.Text);
            DateTime ngayKhoiChieu = dtpReleaseDate.Value;
            string trailer = !string.IsNullOrEmpty(txtTrailerURL.Text.Trim()) ? txtTrailerURL.Text.Trim() : null;
            string moTa = !string.IsNullOrEmpty(txtSynopsis.Text.Trim()) ? txtSynopsis.Text.Trim() : null;
            byte[] poster = GetPosterData();

            return MovieDAO.Instance.InsertMovie(tenPhim, maPL, daoDien, quocGia, thoiLuong, ngayKhoiChieu, poster, trailer, moTa);
        }
        private byte[] GetPosterData()
        {
            byte[] poster = new byte[0];
            if (!string.IsNullOrEmpty(image))
            {
                using (FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        poster = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            return poster;
        }

        private bool InsertGenreMovieToDatabase()
        {
            string maPhim = txtMovieID.Text;
            List<string> selectedGenreIDs = GetSelectedGenreIDs();
            foreach (string genreID in selectedGenreIDs)
            {
                if (!GenreMovieDAO.Instance.InsertGenreMovie(maPhim, genreID))
                {
                    return false;
                }
            }
            return true;
        }

        private List<string> GetSelectedGenreIDs()
        {
            List<string> selectedGenreIDs = new List<string>();
            foreach (int index in clbGenre.CheckedIndices)
            {
                string maTL = GetMaTLFromIndex(index);
                selectedGenreIDs.Add(maTL);
            }
            return selectedGenreIDs;
        }

        private string GetMaTLFromIndex(int index)
        {
            List<GenreDTO> listGenre = GenreDAO.Instance.GetListGenre();
            if (index >= 0 && index < listGenre.Count)
            {
                return listGenre[index].MaTL;
            }
            return null;
        }

        private bool UpdateMovieToDatabase()
        {
            string maPhim = txtMovieID.Text.Trim();
            string tenPhim = txtMovieName.Text.Trim();
            string maPL = cboMovieRatingSystem.Text;
            string daoDien = !string.IsNullOrEmpty(txtDirector.Text.Trim()) ? txtDirector.Text.Trim() : null;
            string quocGia = !string.IsNullOrEmpty(txtCountry.Text.Trim()) ? txtCountry.Text.Trim() : null;
            int thoiLuong = int.Parse(txtDuration.Text);
            DateTime ngayKhoiChieu = dtpReleaseDate.Value;
            string trailer = !string.IsNullOrEmpty(txtTrailerURL.Text.Trim()) ? txtTrailerURL.Text.Trim() : null;
            string moTa = !string.IsNullOrEmpty(txtSynopsis.Text.Trim()) ? txtSynopsis.Text.Trim() : null;
            byte[] poster = GetPosterData();

            return MovieDAO.Instance.UpdateMovie(maPhim, tenPhim, maPL, daoDien, quocGia, thoiLuong, ngayKhoiChieu, poster, trailer, moTa);
        }

        private bool UpdateGenreMovieToDatabase()
        {
            string movieID = txtMovieID.Text;
            if (GenreMovieDAO.Instance.DeleteGenreMovie(movieID))
            {
                List<string> selectedGenreIDs = GetSelectedGenreIDs();
                foreach (string genreID in selectedGenreIDs)
                {
                    if (!GenreMovieDAO.Instance.InsertGenreMovie(movieID, genreID))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        #endregion

        #region Events
        OpenFileDialog ofd = new OpenFileDialog();
        string image = "";

        private void btnUpLoadImg_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"D:\MIS\2024 HK I\Lập trình C#.NET\Đồ án\Beta-Cinema\Image\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = ofd.FileName.ToString();
                picPoster.ImageLocation = image;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertMovieToDatabase() && InsertGenreMovieToDatabase())
            {
                fMovie fMovie = Application.OpenForms.OfType<fMovie>().FirstOrDefault();
                if (fMovie != null)
                {
                    fMovie.LoadListMovie();
                }
                MessageBox.Show("Đã thêm phim thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm phim vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateMovieToDatabase() && UpdateGenreMovieToDatabase())
            {
                fMovie fMovie = Application.OpenForms.OfType<fMovie>().FirstOrDefault();
                if (fMovie != null)
                {
                    fMovie.LoadListMovie();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin phim thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
