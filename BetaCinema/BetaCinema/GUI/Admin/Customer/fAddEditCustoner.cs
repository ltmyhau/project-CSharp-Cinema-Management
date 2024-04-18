using BetaCinema.DAO;
using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Customer
{
    public partial class fAddEditCustoner : Form
    {
        public fAddEditCustoner()
        {
            InitializeComponent();
            btnAdd.Visible = true;
            btnSave.Visible = false;
            cboCustomerType.Enabled = false;
            txtPoint.Enabled = false;
            txtCustomerID.Text = CustomerDAO.Instance.GetNextMaKH();
            LoadListCustomerType();
        }

        #region Methods
        void LoadListCustomerType()
        {
            cboCustomerType.DataSource = CustomerTypeDAO.Instance.GetListCustomerType();
            cboCustomerType.DisplayMember = "TenBacTV";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnAdd.Visible = false;
            btnSave.Visible = true;
            cboCustomerType.Enabled = true;
            txtPoint.Enabled = true;
            string maKH = selectedRow.Cells["MaKH"].Value?.ToString();
            txtCustomerID.Text = maKH;
            txtLastName.Text = selectedRow.Cells["HoKH"].Value?.ToString();
            txtFirstName.Text = selectedRow.Cells["TenKH"].Value?.ToString();
            txtPoint.Text = selectedRow.Cells["DiemTichLuy"].Value?.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            txtPhoneNumber.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
            txtAddress.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
            dtpDate.Value = DateTime.Parse(selectedRow.Cells["NgaySinh"].Value?.ToString());
            foreach (CustomerTypeDTO item in cboCustomerType.Items)
            {
                if (item.MaBacTV == selectedRow.Cells["MaBacTV"].Value.ToString())
                {
                    cboCustomerType.SelectedItem = item;
                    break;
                }
            }
            string gioiTinh = selectedRow.Cells["GioiTinh"].Value?.ToString();
            switch (gioiTinh)
            {
                case "Nam":
                    rdoMale.Checked = true;
                    break;
                case "Nữ":
                    rdoFemale.Checked = true;
                    break;
                default:
                    rdoOther.Checked = true;
                    break;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Họ khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return false;
            }
            return true;
        }

        private bool InsertCustomerToDatabase()
        {
            string hoKH = txtLastName.Text;
            string tenKH = txtFirstName.Text;
            DateTime ngaySinh = dtpDate.Value;
            DateTime ngayDangKy = DateTime.Now;
            int diemTichLuy = !string.IsNullOrEmpty(txtPoint.Text.Trim()) ? Convert.ToInt32(txtPoint.Text) : 0;
            string dienThoai = txtPhoneNumber.Text;
            string email = !string.IsNullOrEmpty(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : null;
            string diaChi = !string.IsNullOrEmpty(txtAddress.Text.Trim()) ? txtAddress.Text.Trim() : null;

            string gioiTinh;
            if (rdoMale.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Khác";
            }

            CustomerTypeDTO bacTV = (CustomerTypeDTO)cboCustomerType.SelectedItem;
            string maBacTV = bacTV.MaBacTV;

            return CustomerDAO.Instance.InsertCustomer(hoKH, tenKH, ngaySinh, gioiTinh, ngayDangKy, diemTichLuy, maBacTV, dienThoai, email, diaChi);
        }

        private bool UpdateCustomerToDatabase()
        {
            string maKH = txtCustomerID.Text;
            string hoKH = txtLastName.Text;
            string tenKH = txtFirstName.Text;
            DateTime ngaySinh = dtpDate.Value;
            int diemTichLuy = !string.IsNullOrEmpty(txtPoint.Text.Trim()) ? Convert.ToInt32(txtPoint.Text) : 0;
            string dienThoai = txtPhoneNumber.Text;
            string email = !string.IsNullOrEmpty(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : null;
            string diaChi = !string.IsNullOrEmpty(txtAddress.Text.Trim()) ? txtAddress.Text.Trim() : null;

            string gioiTinh;
            if (rdoMale.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Khác";
            }

            CustomerTypeDTO bacTV = (CustomerTypeDTO)cboCustomerType.SelectedItem;
            string maBacTV = bacTV.MaBacTV;

            return CustomerDAO.Instance.UpdateCustomer(maKH, hoKH, tenKH, ngaySinh, gioiTinh, diemTichLuy, maBacTV, dienThoai, email, diaChi);
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertCustomerToDatabase())
            {
                fCustomer f = Application.OpenForms.OfType<fCustomer>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListCustomer();
                }
                MessageBox.Show("Đã thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateCustomerToDatabase())
            {
                fCustomer f = Application.OpenForms.OfType<fCustomer>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListCustomer();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin khách hàng.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
