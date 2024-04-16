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

namespace BetaCinema.GUI.Employee
{
    public partial class fBillInfo : Form
    {
        public fBillInfo()
        {
            InitializeComponent();
        }

        #region Methods
        private bool InsertBillToDatabase()
        {
            //RoomDTO room = (RoomDTO)cboRoom.SelectedItem;
            //string maPhong = room.MaPhong;
            //BetaCinema.DTO.MovieDTO movie = (BetaCinema.DTO.MovieDTO)cboMovie.SelectedItem;
            //string maPhim = movie.MaPhim;
            //string ngayChieu = dtpDate.Value.ToString("dd/MM/yyyy");
            //string gioBD = dtpTime.Value.ToString("HH:mm:ss");
            //DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            string maKH = "";
            string maNV = "";
            DateTime ngayTao = DateTime.Now;

            return BillDAO.Instance.InsertBill(maKH, maNV, ngayTao);
        }

        private bool InsertCustomerToDatabase()
        {
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

            return CustomerDAO.Instance.InsertCustomer(txtLastName.Text, txtFirstName.Text, gioiTinh, txtPhoneNumber.Text);
        }

        private void ShowCustomerInfo()
        {
            List<CustomerDTO> customerList = CustomerDAO.Instance.GetListCustomerByPhoneNumber(txtPhoneNumber.Text);
            if (customerList != null && customerList.Count > 0)
            {
                pnlCustomerInfo.Visible = true;
                pnlAddCustomer.Visible = false;

                CustomerDTO customer = customerList[0];
                txtCustomerName.Text = customer.HoKH + " " + customer.TenKH;
                txtPoint.Text = customer.DiemTichLuy.ToString();

                List<CustomerTypeDTO> customerTypeList = CustomerTypeDAO.Instance.GetListCustomerTypeByCustomerTypeID(customer.MaBacTV);
                if (customerTypeList != null && customerTypeList.Count > 0)
                {
                    txtCusDiscount.Text = customerTypeList[0].ChietKhau.ToString() + "%";
                }
            }
            else
            {
                pnlCustomerInfo.Visible = false;
                pnlAddCustomer.Visible = true;
                txtLastName.Focus();
            }
        }
        #endregion

        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                ShowCustomerInfo();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Vui lòng họ của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Vui lòng tên của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return;
            }

            if (InsertCustomerToDatabase())
            {
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowCustomerInfo();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
