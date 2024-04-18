using BetaCinema.DAO;
using BetaCinema.DTO;
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

        void LoadProductType()
        {
            cboProductType.DataSource = ProductTypeDAO.Instance.GetListProductType();
            cboProductType.DisplayMember = "TenLoaiSP";
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
            if (!int.TryParse(txtPrice.Text, out int thoiLuong) || thoiLuong < 0)
            {
                MessageBox.Show("Đơn giá của sản phẩm phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }
            if (!int.TryParse(txtQuantityStock.Text, out int soLuongTon) || soLuongTon < 0)
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
            ProductTypeDTO productType = (ProductTypeDTO)cboProductType.SelectedItem;
            string productTypeID = productType.MaLoaiSP;
            int price = Convert.ToInt32(txtPrice.Text);
            int quantityStock = Convert.ToInt32(txtQuantityStock.Text);
            byte[] poster = GetPosterData();

            return ProductDAO.Instance.InsertProduct(productName, productTypeID, price, quantityStock, poster);
        }

        private bool UpdateProductToDatabase()
        {
            string productID = txtProductID.Text.Trim();
            string productName = txtProductName.Text.Trim();
            ProductTypeDTO productType = (ProductTypeDTO)cboProductType.SelectedItem;
            string productTypeID = productType.MaLoaiSP;
            int price = Convert.ToInt32(txtPrice.Text);
            int quantityStock = Convert.ToInt32(txtQuantityStock.Text);
            byte[] poster = GetPosterData();

            return ProductDAO.Instance.UpdateProduct(productID, productName, productTypeID, price, quantityStock, poster);
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

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oExcel.Workbooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã sản phẩm";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên sản phẩm";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Đơn giá";
            cl3.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số lượng tồn";
            cl4.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "11";

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c0 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range cN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c0, cN);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c0, cN).Font.Name = "Times New Roman";
            oSheet.get_Range(c0, cN).Font.Size = "11";
            oSheet.get_Range(c0, cN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c02 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 1];
            Microsoft.Office.Interop.Excel.Range cN2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 1];
            oSheet.get_Range(c02, cN2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
        #endregion

        #region Events
        private void fProduct_Load(object sender, EventArgs e)
        {
            pnlConfirm.Location = new Point(230, 320);
            LoadListProduct();
            dgvProduct.DataSource = bsProductList;
            BindingGenre();
            LoadProductType();
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
            LoadProductType();
            picProductImg.Image = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            if (UpdateProductToDatabase())
            {
                MessageBox.Show("Đã chỉnh sửa sản phẩm phim thành công.", "Thông báo", MessageBoxButtons.OK);
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (ProductDAO.Instance.DeleteProduct(txtProductID.Text))
                {
                    MessageBox.Show("Đã xoá thể sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListProduct();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            if (InsertProductToDatabase())
            {
                MessageBox.Show("Đã thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK);
                LoadListProduct();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlConfirm.Visible = false;
            pnlControls.Visible = true;
            ClearTextbox();
            txtProductID.Clear();
            picProductImg.Image = null;
            LoadProductType();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoProductName.Checked)
            {
                if (!string.IsNullOrEmpty(txtInputProductName.Text))
                {
                    bsProductList.DataSource = ProductDAO.Instance.GetListProductByProductName(txtInputProductName.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInputProductName.Focus();
                }
            } 
            else
            {
                if (!int.TryParse(txtFromPrice.Text, out int fromPrice) || fromPrice < 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng giá bán của sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFromPrice.Focus();
                    return;
                }
                if (!int.TryParse(txtFromPrice.Text, out int toPrice) || toPrice < 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng giá bán của sản phẩm cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtToPrice.Focus();
                    return;
                }
                bsProductList.DataSource = ProductDAO.Instance.GetListProductByPrice(Convert.ToInt32(txtFromPrice.Text), Convert.ToInt32(txtToPrice.Text));
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            txtInputProductName.Clear();
            txtFromPrice.Clear();
            txtToPrice.Clear();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlControls.Visible = true;
            pnlConfirm.Visible = false;

            if (e.RowIndex >= 0 && e.RowIndex < dgvProduct.Rows.Count)
            {
                string maLoaiSP = dgvProduct.Rows[e.RowIndex].Cells["MaLoaiSP"].Value?.ToString();
                if (!string.IsNullOrEmpty(maLoaiSP))
                {
                    foreach (ProductTypeDTO item in cboProductType.Items)
                    {
                        if (item.MaLoaiSP == maLoaiSP)
                        {
                            cboProductType.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

        private void rdoProductName_CheckedChanged(object sender, EventArgs e)
        {
            txtFromPrice.Clear();
            txtToPrice.Clear();
        }

        private void rdoPrice_CheckedChanged(object sender, EventArgs e)
        {
            txtInputProductName.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSP");
            DataColumn col2 = new DataColumn("TenSP");
            DataColumn col3 = new DataColumn("GiaBan");
            DataColumn col4 = new DataColumn("SoLuongTon");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);

            foreach (DataGridViewRow dgvRow in dgvProduct.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSP"].Value;
                row[1] = dgvRow.Cells["TenSP"].Value;
                row[2] = dgvRow.Cells["GiaBan"].Value;
                row[3] = dgvRow.Cells["SoLuongTon"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Sản phẩm", "DANH SÁCH SẢN PHẨM");
        }
        #endregion
    }
}
