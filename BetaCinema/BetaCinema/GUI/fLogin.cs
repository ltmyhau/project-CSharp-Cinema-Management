using BetaCinema.DAO;
using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema
{
    public partial class fLogin : Form
    {
        EmployeeDTO employee;

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                EmployeeQAccount(userName, passWord);
                switch (employee.MaCV)
                {
                    case "QL":
                    {
                        fMain f = new fMain(employee);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        break;
                    }
                    case "NV":
                    {
                        fEMain f = new fEMain(employee);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        break;
                    }
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
        }

        bool Login(string userName, string passWord)
        {
            return EmployeeDAO.Instance.Login(userName, passWord);
        }

        void EmployeeQAccount(string userName, string passWord)
        {
            List<EmployeeDTO> employees = EmployeeDAO.Instance.GetEmployeeByAccount(userName, passWord);
            if (employees != null && employees.Count > 0)
            {
                employee = employees[0];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
