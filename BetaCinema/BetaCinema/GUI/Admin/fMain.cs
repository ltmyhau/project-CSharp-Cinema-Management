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
        fMovie fMovie;
        InsertImage fInsertImage;
        public fMain()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.FromArgb(86, 144, 214);
            Cursor = Cursors.Hand;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.FromArgb(1, 81, 152);
            Cursor = Cursors.Default;
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

                    btnMovie.Width = flpSidebarTransition.Width;
                    btnShowTime.Width = flpSidebarTransition.Width;
                    btnProduct.Width = flpSidebarTransition.Width;
                    btnLogout.Width = flpSidebarTransition.Width;
                }
            }
            else
            {
                flpSidebarTransition.Width += 5;
                if (flpSidebarTransition.Width >= 230)
                {
                    sidebarExpand = true;
                    tmrSidebarTransition.Stop();

                    btnMovie.Width = flpSidebarTransition.Width;
                    btnShowTime.Width = flpSidebarTransition.Width;
                    btnProduct.Width = flpSidebarTransition.Width;
                    btnLogout.Width = flpSidebarTransition.Width;
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

        private void btnShowTime_Click(object sender, EventArgs e)
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
    }
}
