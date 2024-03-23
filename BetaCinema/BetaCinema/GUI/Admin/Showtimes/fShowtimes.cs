using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Movie;
using BetaCinema.GUI.Admin.Showtimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Showtime
{
    public partial class fShowtimes : Form
    {
        public fShowtimes()
        {
            InitializeComponent();
        }

        #region Methods
        RadioButton rdbAllRoom;
        void LoadRoom()
        {
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();

            rdbAllRoom = CreateRadioBtnRoom("Tất cả");
            rdbAllRoom.Padding = new Padding(16, 0, 0, 0);
            rdbAllRoom.CheckedChanged += RadioButton_CheckedChanged;
            rdbAllRoom.Checked = true;
            flpRoom.Controls.Add(rdbAllRoom);

            foreach (Room room in roomList)
            {
                RadioButton rdb = CreateRadioBtnRoom(room.TenPhong);
                rdb.Padding = new Padding(16, 0, 0, 0);
                rdb.CheckedChanged += RadioButton_CheckedChanged;
                rdb.Tag = room;
                flpRoom.Controls.Add(rdb);
            }
        }

        private RadioButton CreateRadioBtnRoom(string text)
        {
            RadioButton rdb = new RadioButton()
            {
                Width = RoomDAO.RoomWidth,
                Height = RoomDAO.RoomHeight,
                Text = text,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleLeft,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Appearance = Appearance.Button,
                Checked = false
            };
            return rdb;
        }

        void ShowShowtimes()
        {
            DateTime ngayChieu = dtpNgayChieu.Value;
            string maPhong = null;
            foreach (Control control in flpRoom.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    Room room = radioButton.Tag as Room;
                    if (room != null)
                    {
                        maPhong = room.MaPhong.ToString();
                    }
                    break;
                }
            }

            if (maPhong == null)
            {
                dgvShowtimes.DataSource = ShowtimesDAO.Instance.LoadShowtimesByDate(ngayChieu);
            }
            else
            {
                dgvShowtimes.DataSource = ShowtimesDAO.Instance.LoadShowtimesByDateAndRoomID(ngayChieu, maPhong);
            }
        }

        private void CustomizeDataGridView()
        {
            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvShowtimes.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvShowtimes.Columns.Add(deleteImageColumn);
            dgvShowtimes.EnableHeadersVisualStyles = false;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvShowtimes.RowTemplate.Height = 30;

            dgvShowtimes.Columns["MaSC"].HeaderText = "Mã suất chiếu";
            dgvShowtimes.Columns["ThoiGianBD"].HeaderText = "Giờ bắt đầu";
            dgvShowtimes.Columns["ThoiGianKT"].HeaderText = "Giờ kết thúc";
            dgvShowtimes.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvShowtimes.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvShowtimes.Columns["SoGheDaDat"].HeaderText = "Số ghế đã đặt";


            dgvShowtimes.Columns["MaSC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["ThoiGianBD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["ThoiGianKT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["SoGheDaDat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShowtimes.Columns["MaPhong"].Visible = false;
            dgvShowtimes.Columns["MaPhim"].Visible = false;
            dgvShowtimes.Columns["ThoiLuong"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvShowtimes.Width;
            if (dgvShowtimes.Columns.Contains("EditColumn") && dgvShowtimes.Columns.Contains("DeleteColumn"))
            {
                dgvShowtimes.Columns["EditColumn"].Width = (int)(0.07 * totalWidth);
                dgvShowtimes.Columns["DeleteColumn"].Width = (int)(0.07 * totalWidth);
            }
            if (dgvShowtimes.Columns["TenPhong"].Visible is false)
            {
                dgvShowtimes.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvShowtimes.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["TenPhim"].Width = (int)(0.3 * totalWidth);
                dgvShowtimes.Columns["SoGheDaDat"].Width = (int)(0.13 * totalWidth);
            }
            else
            {
                dgvShowtimes.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvShowtimes.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["TenPhong"].Width = (int)(0.1 * totalWidth);
                dgvShowtimes.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
                dgvShowtimes.Columns["SoGheDaDat"].Width = (int)(0.13 * totalWidth);
            }

            dgvShowtimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        #endregion

        #region Events
        private void fShowtimes_Load(object sender, EventArgs e)
        {
            LoadRoom();
            CustomizeDataGridView();
            this.SizeChanged += fShowtimes_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void fShowtimes_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButton.ForeColor = Color.FromArgb(1, 81, 152);

            foreach (Control control in flpRoom.Controls)
            {
                if (control is RadioButton && control != radioButton)
                {
                    RadioButton radioBtn = (RadioButton)control;
                    radioBtn.ForeColor = Color.Black;
                }
            }

            ShowShowtimes();

            if (radioButton == rdbAllRoom && radioButton.Checked)
            {
                dgvShowtimes.Columns["TenPhong"].Visible = true;
                SetColumnWidthsInPercentage();
            }
            else
            {
                dgvShowtimes.Columns["TenPhong"].Visible = false;
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvShowtimes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvShowtimes.Columns[e.ColumnIndex].ValueType == typeof(DateTime))
            {
                if (e.Value != null)
                {
                    DateTime time = (DateTime)e.Value;
                    e.Value = time.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            ShowShowtimes();
        }

        private void dgvShowtimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvShowtimes.Columns["EditColumn"].Index)
            {
                fShowtimesDetail f = new fShowtimesDetail();
                f.Text = "Thông tin suất chiếu";
                f.LoadData(dgvShowtimes.Rows[e.RowIndex]);
                f.Show();
            }

            if (e.ColumnIndex == dgvShowtimes.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa suất chiếu này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maSC = dgvShowtimes.Rows[e.RowIndex].Cells["MaSC"].Value.ToString();
                    if (ShowtimesDAO.Instance.DeleteShowtimes(maSC))
                    {
                        MessageBox.Show("Đã xóa suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                        ShowShowtimes();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa suất chiếu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
