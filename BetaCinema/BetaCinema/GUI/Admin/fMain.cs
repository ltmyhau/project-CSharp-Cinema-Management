using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Genre;
using BetaCinema.GUI.Admin.Showtime;
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
    public partial class fMain : Form
    {
        EmployeeDTO employee;

        fMovie fMovie;
        fShowtimes fShowtime;
        fGenre fGenre;
        InsertImage fInsertImage;
        public fMain(EmployeeDTO e)
        {
            InitializeComponent();
            this.employee = e;
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
            btnShowTime.Width = width;
            btnGenre.Width = width;
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
            if (fMovie == null)
            {
                fMovie = new fMovie();
                fMovie.FormClosed += fMovie_FormClosed;
                fMovie.MdiParent = this;
                fMovie.Dock = DockStyle.Fill;
                fMovie.Show();
            }
            else
            {
                fMovie.Activate();
            }
        }

        private void fMovie_FormClosed(object sender, FormClosedEventArgs e)
        {
            fMovie = null;
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            if (fGenre == null)
            {
                fGenre = new fGenre();
                fGenre.FormClosed += fGenre_FormClosed;
                fGenre.MdiParent = this;
                fGenre.Dock = DockStyle.Fill;
                fGenre.Show();
            }
            else
            {
                fGenre.Activate();
            }
        }

        private void fGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            fGenre = null;
        }

        private void btnShowTime_Click(object sender, EventArgs e)
        {
            if (fShowtime == null)
            {
                fShowtime = new fShowtimes();
                fShowtime.FormClosed += fShowtime_FormClosed;
                fShowtime.MdiParent = this;
                fShowtime.Dock = DockStyle.Fill;
                fShowtime.Show();
            }
            else
            {
                fShowtime.Activate();
            }
        }

        private void fShowtime_FormClosed(object sender, FormClosedEventArgs e)
        {
            fShowtime = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (fInsertImage == null)
            {
                fInsertImage = new InsertImage();
                fInsertImage.FormClosed += fInsertImage_FormClosed;
                fInsertImage.MdiParent = this;
                fInsertImage.Dock = DockStyle.Fill;
                fInsertImage.Show();
            }
            else
            {
                fInsertImage.Activate();
            }
        }

        private void fInsertImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            fInsertImage = null;
        }
        #endregion
    }
}
