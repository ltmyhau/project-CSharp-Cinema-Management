using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Employee
{
    public partial class fAddEditEmloyee : Form
    {
        public fAddEditEmloyee()
        {
            InitializeComponent();
            btnAdd.Visible = true;
            btnSave.Visible = false;
            txtEmployeeID.Text = EmployeeDAO.Instance.GetNextMaNV();
            LoadListEmployeeType();
        }

        #region Methods

        void LoadListEmployeeType()
        {
            cboEmployeeType.DataSource = EmployeeTypeDAO.Instance.GetListEmployeeType();
            cboEmployeeType.DisplayMember = "TenCV";
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            btnAdd.Visible = false;
            btnSave.Visible = true;
            string maNV = selectedRow.Cells["MaNV"].Value?.ToString();
            txtEmployeeID.Text = maNV;
            txtLastName.Text = selectedRow.Cells["HoNV"].Value?.ToString();
            txtFirstName.Text = selectedRow.Cells["TenNV"].Value?.ToString();
            txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            txtPhoneNumber.Text = selectedRow.Cells["DienThoai"].Value?.ToString();
            txtAddress.Text = selectedRow.Cells["DiaChi"].Value?.ToString();
            dtpDate.Value = DateTime.Parse(selectedRow.Cells["NgaySinh"].Value?.ToString());
            dtpStartWork.Value = DateTime.Parse(selectedRow.Cells["NgayVaoLam"].Value?.ToString());
            foreach (EmployeeTypeDTO item in cboEmployeeType.Items)
            {
                if (item.MaCV == selectedRow.Cells["MaCV"].Value.ToString())
                {
                    cboEmployeeType.SelectedItem = item;
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
                MessageBox.Show("Họ nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }
            return true;
        }

        private bool InsertEmployeeToDatabase()
        {
            string hoNV = txtLastName.Text;
            string tenNV = txtFirstName.Text;
            DateTime ngaySinh = dtpDate.Value;
            DateTime ngayVaoLam = dtpStartWork.Value;
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

            EmployeeTypeDTO chucVu = (EmployeeTypeDTO)cboEmployeeType.SelectedItem;
            string maCV = chucVu.MaCV;

            return EmployeeDAO.Instance.InsertEmployee(hoNV, tenNV, ngaySinh, gioiTinh, ngayVaoLam, maCV, dienThoai, email, diaChi);
        }

        private bool UpdateEmployeeToDatabase()
        {
            string maNV = txtEmployeeID.Text;
            string hoNV = txtLastName.Text;
            string tenNV = txtFirstName.Text;
            DateTime ngaySinh = dtpDate.Value;
            DateTime ngayVaoLam = dtpStartWork.Value;
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

            EmployeeTypeDTO chucVu = (EmployeeTypeDTO)cboEmployeeType.SelectedItem;
            string maCV = chucVu.MaCV;

            return EmployeeDAO.Instance.UpdateEmployee(maNV, hoNV, tenNV, ngaySinh, gioiTinh, ngayVaoLam, maCV, dienThoai, email, diaChi);
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (InsertEmployeeToDatabase())
            {
                fEmployee f = Application.OpenForms.OfType<fEmployee>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListEmployee();
                }
                MessageBox.Show("Đã thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên vào CSDL.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            if (UpdateEmployeeToDatabase())
            {
                fEmployee f = Application.OpenForms.OfType<fEmployee>().FirstOrDefault();
                if (f != null)
                {
                    f.LoadListEmployee();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thông tin nhân viên.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
