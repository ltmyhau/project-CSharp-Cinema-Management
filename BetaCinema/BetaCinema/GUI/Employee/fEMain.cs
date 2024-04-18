using BetaCinema.DTO;
using BetaCinema.GUI.Employee;
using BetaCinema.GUI.Employee.Movie;
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
    public partial class fEMain : Form
    {
        public static EmployeeDTO employee;

        fEShowtimes fEMovie;
        fEProduct fEProduct;

        public fEMain(EmployeeDTO e)
        {
            InitializeComponent();
            employee = e;
            mdiProp();

            txtName.Text = employee.HoNV + " " + employee.TenNV;

            foreach (Control control in flpSidebarTransition.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.Click += Button_Click;
                }
            }
        }

        #region Methods
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void ResizeSidebarButtons(int width)
        {
            btnMovie.Width = width;
            btnLogout.Width = width;
        }
        #endregion

        #region Events
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.FromArgb(86, 144, 214);
            foreach (Control control in flpSidebarTransition.Controls)
            {
                if (control is Button && control != button)
                {
                    Button btn = (Button)control;
                    btn.BackColor = Color.FromArgb(1, 81, 152);
                }
            }
        }

        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        bool sidebarExpand = true;
        private void tmrSidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSidebarTransition.Width -= 5;
                if (flpSidebarTransition.Width <= 45)
                {
                    sidebarExpand = false;
                    tmrSidebarTransition.Stop();
                    ResizeSidebarButtons(flpSidebarTransition.Width);
                }
            }
            else
            {
                flpSidebarTransition.Width += 5;
                if (flpSidebarTransition.Width >= 230)
                {
                    sidebarExpand = true;
                    tmrSidebarTransition.Stop();
                    ResizeSidebarButtons(flpSidebarTransition.Width);
                }
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            tmrSidebarTransition.Start();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            if (fEMovie == null)
            {
                fEMovie = new fEShowtimes();
                fEMovie.FormClosed += fEMovie_FormClosed;
                fEMovie.MdiParent = this;
                fEMovie.Dock = DockStyle.Fill;
                fEMovie.Show();
            }
            else
            {
                fEMovie.Activate();
            }
        }

        private void fEMovie_FormClosed(object sender, FormClosedEventArgs e)
        {
            fEMovie = null;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (fEProduct == null)
            {
                fEProduct = new fEProduct();
                fEProduct.FormClosed += fEProduct_FormClosed;
                fEProduct.MdiParent = this;
                fEProduct.FormBorderStyle = FormBorderStyle.None;
                fEProduct.MinimumSize = new Size(0, 0);
                fEProduct.MaximumSize = new Size(0, 0);
                fEProduct.Size = new Size(940, 630);
                fEProduct.Dock = DockStyle.Fill;
                fEProduct.Show();
            }
            else
            {
                fEProduct.Activate();
            }
        }

        private void fEProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            fEProduct = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
