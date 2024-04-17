using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Employee.Showtimes;
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
        EmployeeDTO employee;
        CustomerDTO customer;

        private Dictionary<string, int> productList = new Dictionary<string, int>();
        private List<string> seatList = new List<string>();
        private string showtimesID;
        private double totalMovie = 0;
        private double totalProduct = 0;

        private double total = 0;
        private double cusDiscountPercent = 0;
        private double cusDiscount = 0;
        private double pay = 0;

        public fBillInfo()
        {
            InitializeComponent();
            employee = fEmployee.employee;

            seatList = fEShowtimesDetail.selectedSeats;
            showtimesID = fEShowtimesDetail.maSC;
            totalMovie = fEShowtimesDetail.totalAmount;
            productList = fEProduct.productList;
        }

        #region Methods
        private void LoadShowtimesInfo()
        {
            ShowtimesDTO showtimes = ShowtimesDAO.Instance.GetShowtimesByShowtimesID(showtimesID)[0];
            txtMovieName.Text = showtimes.TenPhim;
            txtDate.Text = showtimes.ThoiGianBD.ToString("dd/MM/yyyy");
            txtTime.Text = showtimes.ThoiGianBD.ToString("HH:mm") + " ~ " + showtimes.ThoiGianKT.ToString("HH:mm");
            txtRoom.Text = showtimes.TenPhong;
            txtSeats.Text = string.Join(", ", seatList);
            txtTotalMovie.Text = string.Format("{0:N0} đ", totalMovie);
        }

        private void LoadProducts()
        {
            foreach (KeyValuePair<string, int> pair in productList)
            {
                string productID = pair.Key;
                int quantity = pair.Value;

                ProductDTO product = ProductDAO.Instance.GetListProductByProductID(productID)[0];

                CreatePanelProduct(product.TenSP, quantity, product.GiaBan);
            }
            txtTotalProduct.Text = string.Format("{0:N0} đ", totalProduct);
        }

        private void CreatePanelProduct(string productName, int quantity, int price)
        {
            Panel pnlProducts = new Panel();
            pnlProducts.Size = new System.Drawing.Size(267, 60);
            flpProducts.Controls.Add(pnlProducts);

            TextBox txtProductName = new TextBox();
            txtProductName.Size = new System.Drawing.Size(247, 23);
            txtProductName.Location = new System.Drawing.Point(9, 3);
            txtProductName.Font = new System.Drawing.Font(flpProducts.Font, FontStyle.Bold);
            txtProductName.BackColor = Color.White;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.TextAlign = HorizontalAlignment.Left;
            txtProductName.Enabled = false;
            pnlProducts.Controls.Add(txtProductName);

            TextBox txtPriceQuantity = new TextBox();
            txtPriceQuantity.Size = new System.Drawing.Size(94, 23);
            txtPriceQuantity.Location = new System.Drawing.Point(9, 32);
            txtPriceQuantity.BackColor = Color.White;
            txtPriceQuantity.BorderStyle = BorderStyle.None;
            txtPriceQuantity.TextAlign = HorizontalAlignment.Left;
            txtPriceQuantity.Enabled = false;
            pnlProducts.Controls.Add(txtPriceQuantity);

            TextBox txtTotalAmount = new TextBox();
            txtTotalAmount.Size = new System.Drawing.Size(125, 23);
            txtTotalAmount.Location = new System.Drawing.Point(131,32);
            txtTotalAmount.BackColor = Color.White;
            txtTotalAmount.BorderStyle = BorderStyle.None;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            txtTotalAmount.Enabled = false;
            pnlProducts.Controls.Add(txtTotalAmount);

            txtProductName.Text = productName;
            txtPriceQuantity.Text = string.Format("{0} x {1:N0} đ", quantity, price);
            txtTotalAmount.Text = string.Format("{0:N0} đ", price * quantity);

            totalProduct += (price * quantity);
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
                txtFirstName.Clear();
                txtLastName.Clear();

                customer = customerList[0];
                txtCustomerName.Text = customer.HoKH + " " + customer.TenKH;
                txtPoint.Text = customer.DiemTichLuy.ToString();

                List<CustomerTypeDTO> customerTypeList = CustomerTypeDAO.Instance.GetListCustomerTypeByCustomerTypeID(customer.MaBacTV);
                if (customerTypeList != null && customerTypeList.Count > 0)
                {
                    cusDiscountPercent = customerTypeList[0].ChietKhau;
                    txtCusDiscount.Text = cusDiscountPercent.ToString() + "%";
                }
            }
            else
            {
                DialogResult result = MessageBox.Show($"Không tìm thấy khách hàng có số điện thoại {txtPhoneNumber.Text}.\r\n\r\nBạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    pnlCustomerInfo.Visible = false;
                    txtCustomerName.Clear();
                    txtPoint.Clear();
                    txtCusDiscount.Clear();
                    pnlAddCustomer.Visible = true;
                    txtLastName.Focus();
                }
                else
                {
                    pnlCustomerInfo.Visible = false;
                    txtCustomerName.Clear();
                    txtPoint.Clear();
                    txtCusDiscount.Clear();
                    pnlAddCustomer.Visible = false;
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhoneNumber.Focus();
                }
            }
            LoadTotalPay();
        }

        private void LoadTotalPay()
        {
            total = totalMovie + totalProduct;
            cusDiscount = total * cusDiscountPercent / 100;
            pay = total - cusDiscount;

            txtTotal.Text = string.Format("{0:N0} đ", total);
            txtDiscount.Text = string.Format("{0:N0} đ", cusDiscount);
            txtPay.Text = string.Format("{0:N0} đ", pay);
        }

        string maHD;
        DateTime ngayTao;
        private bool InsertBillToDatabase()
        {
            ngayTao = DateTime.Now;
            return BillDAO.Instance.InsertBill(customer.MaKH, employee.MaNV, ngayTao);
        }

        private bool InsertTicketToDatabase()
        {
            bool success = true;
            foreach (string seat in seatList)
            {
                bool insertResult = TicketDAO.Instance.InsertTicketToBill(maHD, seat, showtimesID);
                if (!insertResult)
                {
                    success = false;
                }
            }
            return success;
        }

        private bool InsertProductBillToDatabase()
        {
            bool success = true;
            foreach (KeyValuePair<string, int> pair in productList)
            {
                string maSP = pair.Key;
                int soLuong = pair.Value;
                bool insertResult = ProductBillDAO.Instance.InsertProductToBill(maHD, maSP, soLuong);
                if (!insertResult)
                {
                    success = false;
                }
            }
            return success;
        }

        private void PrintBill()
        {

        }
        #endregion

        #region Events
        private void fBillInfo_Load(object sender, EventArgs e)
        {
            LoadShowtimesInfo();
            LoadProducts();
            LoadTotalPay();

            if (productList.Count == 0)
            {
                pnlProduct.Visible = false;
                pnlMovie.Location = new Point(450, 22);
            }
        }

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
                MessageBox.Show("Vui lòng nhập họ của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            pnlAddCustomer.Visible = false;
            pnlCustomerInfo.Visible = false;
        }

        private void fBillInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Application.OpenForms["fEProduct"] == null || Application.OpenForms["fEProduct"].IsDisposed))
            {
                Application.OpenForms["fEProduct"].Show();
                Application.OpenForms["fEProduct"].Focus();
            }
        }

        private void txtCusDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCusDiscount.Text))
            {
                cusDiscountPercent = 0;
            }
            else
            {
                string chietKhau = txtCusDiscount.Text.Replace("%", "");
                cusDiscountPercent = int.Parse(chietKhau);
            }
            LoadTotalPay();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (InsertBillToDatabase())
            {
                maHD = BillDAO.Instance.GetMaHD(customer.MaKH, employee.MaNV, ngayTao);
                if (InsertTicketToDatabase())
                {
                    if (productList.Count > 0)
                    {
                        if (InsertProductBillToDatabase())
                        {
                            MessageBox.Show("Tạo hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tạo hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình tạo hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
