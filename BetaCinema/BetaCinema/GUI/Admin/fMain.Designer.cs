namespace BetaCinema
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpSidebarTransition = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrSidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnShowTime = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flpSidebarTransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.picMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 50);
            this.panel1.TabIndex = 0;
            // 
            // flpSidebarTransition
            // 
            this.flpSidebarTransition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.flpSidebarTransition.Controls.Add(this.btnMovie);
            this.flpSidebarTransition.Controls.Add(this.btnShowTime);
            this.flpSidebarTransition.Controls.Add(this.btnProduct);
            this.flpSidebarTransition.Controls.Add(this.btnLogout);
            this.flpSidebarTransition.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSidebarTransition.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebarTransition.Location = new System.Drawing.Point(0, 50);
            this.flpSidebarTransition.Name = "flpSidebarTransition";
            this.flpSidebarTransition.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.flpSidebarTransition.Size = new System.Drawing.Size(230, 503);
            this.flpSidebarTransition.TabIndex = 1;
            // 
            // tmrSidebarTransition
            // 
            this.tmrSidebarTransition.Interval = 10;
            this.tmrSidebarTransition.Tick += new System.EventHandler(this.tmrSidebarTransition_Tick);
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.Image = global::BetaCinema.Properties.Resources.film;
            this.btnMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.Location = new System.Drawing.Point(3, 27);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnMovie.Size = new System.Drawing.Size(230, 50);
            this.btnMovie.TabIndex = 2;
            this.btnMovie.Text = "      Phim";
            this.btnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovie.UseVisualStyleBackColor = false;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            this.btnMovie.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnMovie.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnShowTime
            // 
            this.btnShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnShowTime.FlatAppearance.BorderSize = 0;
            this.btnShowTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTime.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTime.ForeColor = System.Drawing.Color.White;
            this.btnShowTime.Image = global::BetaCinema.Properties.Resources.cinema;
            this.btnShowTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTime.Location = new System.Drawing.Point(3, 83);
            this.btnShowTime.Name = "btnShowTime";
            this.btnShowTime.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnShowTime.Size = new System.Drawing.Size(230, 50);
            this.btnShowTime.TabIndex = 3;
            this.btnShowTime.Text = "      Lịch chiếu";
            this.btnShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTime.UseVisualStyleBackColor = false;
            this.btnShowTime.Click += new System.EventHandler(this.btnShowTime_Click);
            this.btnShowTime.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnShowTime.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::BetaCinema.Properties.Resources.popcorn;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 139);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(230, 50);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "      Sản phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnProduct.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::BetaCinema.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 195);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(230, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "      Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BetaCinema.Properties.Resources.beta_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(53, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Image = global::BetaCinema.Properties.Resources.menu;
            this.picMenu.Location = new System.Drawing.Point(1, 3);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(45, 45);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            this.picMenu.MouseEnter += new System.EventHandler(this.picMenu_MouseEnter);
            this.picMenu.MouseLeave += new System.EventHandler(this.picMenu_MouseLeave);
            // 
            // fMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.flpSidebarTransition);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beta Cinema";
            this.panel1.ResumeLayout(false);
            this.flpSidebarTransition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpSidebarTransition;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnShowTime;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer tmrSidebarTransition;
    }
}