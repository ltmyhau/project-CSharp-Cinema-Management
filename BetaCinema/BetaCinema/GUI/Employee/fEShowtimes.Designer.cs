namespace BetaCinema.GUI.Employee.Movie
{
    partial class fEShowtimes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvShowtimes = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMoiveInfo = new System.Windows.Forms.Panel();
            this.txtDatetime = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMovieRating = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMoiveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 630);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.dgvShowtimes);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 630);
            this.panel3.TabIndex = 20;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 30);
            this.txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::BetaCinema.Properties.Resources.loupe;
            this.btnSearch.Location = new System.Drawing.Point(489, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvShowtimes
            // 
            this.dgvShowtimes.AllowUserToResizeColumns = false;
            this.dgvShowtimes.AllowUserToResizeRows = false;
            this.dgvShowtimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowtimes.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowtimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowtimes.ColumnHeadersHeight = 50;
            this.dgvShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowtimes.Location = new System.Drawing.Point(24, 128);
            this.dgvShowtimes.Name = "dgvShowtimes";
            this.dgvShowtimes.ReadOnly = true;
            this.dgvShowtimes.RowHeadersVisible = false;
            this.dgvShowtimes.RowHeadersWidth = 51;
            this.dgvShowtimes.RowTemplate.Height = 24;
            this.dgvShowtimes.Size = new System.Drawing.Size(500, 477);
            this.dgvShowtimes.TabIndex = 18;
            this.dgvShowtimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtimes_CellClick);
            this.dgvShowtimes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtimes_CellDoubleClick);
            this.dgvShowtimes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShowtimes_CellFormatting);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(340, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(184, 37);
            this.dtpDate.TabIndex = 15;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlMoiveInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(548, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 630);
            this.panel1.TabIndex = 19;
            // 
            // pnlMoiveInfo
            // 
            this.pnlMoiveInfo.Controls.Add(this.txtDatetime);
            this.pnlMoiveInfo.Controls.Add(this.btnShow);
            this.pnlMoiveInfo.Controls.Add(this.lblGenre);
            this.pnlMoiveInfo.Controls.Add(this.label6);
            this.pnlMoiveInfo.Controls.Add(this.lblMovieRating);
            this.pnlMoiveInfo.Controls.Add(this.label8);
            this.pnlMoiveInfo.Controls.Add(this.lblDuration);
            this.pnlMoiveInfo.Controls.Add(this.label4);
            this.pnlMoiveInfo.Controls.Add(this.lblCountry);
            this.pnlMoiveInfo.Controls.Add(this.label1);
            this.pnlMoiveInfo.Controls.Add(this.txtMovieName);
            this.pnlMoiveInfo.Controls.Add(this.picPoster);
            this.pnlMoiveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoiveInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMoiveInfo.Name = "pnlMoiveInfo";
            this.pnlMoiveInfo.Size = new System.Drawing.Size(392, 630);
            this.pnlMoiveInfo.TabIndex = 11;
            this.pnlMoiveInfo.Visible = false;
            // 
            // txtDatetime
            // 
            this.txtDatetime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatetime.Enabled = false;
            this.txtDatetime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatetime.Location = new System.Drawing.Point(6, 347);
            this.txtDatetime.Name = "txtDatetime";
            this.txtDatetime.Size = new System.Drawing.Size(366, 23);
            this.txtDatetime.TabIndex = 22;
            this.txtDatetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(95, 555);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(189, 50);
            this.btnShow.TabIndex = 21;
            this.btnShow.Text = "Chọn ghế";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(120, 492);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(70, 23);
            this.lblGenre.TabIndex = 20;
            this.lblGenre.Text = "Thể loại";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thể loại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.AutoSize = true;
            this.lblMovieRating.Location = new System.Drawing.Point(120, 457);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(81, 23);
            this.lblMovieRating.TabIndex = 18;
            this.lblMovieRating.Text = "Phân loại";
            this.lblMovieRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phân loại:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(122, 423);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(92, 23);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Thời lượng";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thời lượng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(122, 391);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(79, 23);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Quốc gia";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quốc gia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMovieName
            // 
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Enabled = false;
            this.txtMovieName.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(6, 302);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(366, 30);
            this.txtMovieName.TabIndex = 12;
            this.txtMovieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPoster.Location = new System.Drawing.Point(110, 36);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(158, 248);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 11;
            this.picPoster.TabStop = false;
            // 
            // fEShowtimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 630);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEShowtimes";
            this.Text = "fEMovie";
            this.Load += new System.EventHandler(this.fEMovie_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtimes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlMoiveInfo.ResumeLayout(false);
            this.pnlMoiveInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMoiveInfo;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMovieRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShowtimes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtDatetime;
    }
}