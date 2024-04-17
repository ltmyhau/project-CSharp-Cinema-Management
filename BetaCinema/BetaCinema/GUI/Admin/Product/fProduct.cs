using BetaCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BetaCinema.GUI.Admin.Product
{
    public partial class fProduct : Form
    {
        BindingSource bsProductList = new BindingSource();

        public fProduct()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadListProduct()
        {
            bsProductList.DataSource = ProductDAO.Instance.GetListProduct();
        }

        private void BindingGenre()
        {
            txtProductID.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
            txtProductName.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
            txtQuantityStock.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "SoLuongTon", true, DataSourceUpdateMode.Never));
            picProductImg.DataBindings.Add(new Binding("Image", dgvProduct.DataSource, "HinhAnh", true, DataSourceUpdateMode.Never));
        }

        private void CustomizeDataGridView()
        {
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProduct.RowTemplate.Height = 30;

            dgvProduct.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns["GiaBan"].HeaderText = "Đơn giá";
            dgvProduct.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";

            dgvProduct.Columns["MaSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["MaLoaiSP"].Visible = false;
            dgvProduct.Columns["HinhAnh"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvProduct.Width;

            dgvProduct.Columns["MaSP"].Width = (int)(0.2 * totalWidth);
            dgvProduct.Columns["TenSP"].Width = (int)(0.4 * totalWidth);
            dgvProduct.Columns["GiaBan"].Width = (int)(0.2 * totalWidth);
            dgvProduct.Columns["SoLuongTon"].Width = (int)(0.2 * totalWidth);

            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        void ClearTextbox()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantityStock.Clear();
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
                return false;
            }
            if (!int.TryParse(txtPrice.Text, out int thoiLuong) || thoiLuong <= 0)
            {
                MessageBox.Show("Đơn giá của sản phẩm phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            if (!int.TryParse(txtQuantityStock.Text, out int soLuongTon) || soLuongTon <= 0)
            {
                MessageBox.Show("Số lượng tồn của sản phẩm phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityStock.Focus();
                return false;
            }
            return true;
        }

        private bool InsertProductToDatabase()
        {
            string productName = txtProductName.Text.Trim();
            int price = Convert.ToInt32(txtPrice.Text);
            int quantityStock = Convert.ToInt32(txtQuantityStock.Text);
            byte[] poster = GetPosterData();

            //return ProductDAO.Instance.InsertProduct(productName, price, quantityStock, poster);
            return true;
        }

        private byte[] GetPosterData()
        {
            byte[] productImg = new byte[0];
            if (!string.IsNullOrEmpty(image))
            {
                using (FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        productImg = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
            return productImg;
        }
        #endregion

        #region Events
        private void fProduct_Load(object sender, EventArgs e)
        {
            pnlConfirm.Location = new Point(230, 320);

            LoadListProduct();
            dgvProduct.DataSource = bsProductList;
            BindingGenre();

            CustomizeDataGridView();
            this.SizeChanged += fProduct_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void fProduct_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string image = "";
        private void btnUpLoadImg_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = ofd.FileName.ToString();
                picProductImg.ImageLocation = image;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlControls.Visible = false;
            pnlConfirm.Visible = true;
            ClearTextbox();
            txtProductName.Focus();
            txtProductID.Text = ProductDAO.Instance.GetNextMaSP();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            //if (GenreDAO.Instance.UpdateGenre(txtGenreID.Text, txtGenreName.Text))
            //{
            //    MessageBox.Show("Đã chỉnh sửa thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
            //    LoadListGenre();
            //}
            //else
            //{
            //    MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thể loại phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlControls.Visible = true;
            pnlConfirm.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
