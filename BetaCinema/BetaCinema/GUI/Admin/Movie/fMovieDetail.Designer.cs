namespace BetaCinema
{
    partial class fMovieDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMovieDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.picRated = new System.Windows.Forms.PictureBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRated)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrailer);
            this.panel1.Controls.Add(this.picPoster);
            this.panel1.Controls.Add(this.picRated);
            this.panel1.Controls.Add(this.lblMovieID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 429);
            this.panel1.TabIndex = 0;
            // 
            // btnTrailer
            // 
            this.btnTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrailer.BackColor = System.Drawing.Color.Red;
            this.btnTrailer.FlatAppearance.BorderSize = 0;
            this.btnTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrailer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailer.ForeColor = System.Drawing.Color.White;
            this.btnTrailer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrailer.Image")));
            this.btnTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrailer.Location = new System.Drawing.Point(12, 297);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(158, 37);
            this.btnTrailer.TabIndex = 0;
            this.btnTrailer.Text = "Trailer";
            this.btnTrailer.UseVisualStyleBackColor = false;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            this.btnTrailer.MouseEnter += new System.EventHandler(this.btnTrailer_MouseEnter);
            this.btnTrailer.MouseLeave += new System.EventHandler(this.btnTrailer_MouseLeave);
            // 
            // picPoster
            // 
            this.picPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.Location = new System.Drawing.Point(12, 43);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(158, 248);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // picRated
            // 
            this.picRated.Location = new System.Drawing.Point(111, 11);
            this.picRated.Name = "picRated";
            this.picRated.Size = new System.Drawing.Size(59, 26);
            this.picRated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRated.TabIndex = 4;
            this.picRated.TabStop = false;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(5, 4);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(0, 38);
            this.lblMovieID.TabIndex = 3;
            this.lblMovieID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(188, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 414);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtGenre);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(282, 141);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(273, 63);
            this.panel7.TabIndex = 6;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.White;
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(7, 29);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(263, 31);
            this.txtGenre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thể loại";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSynopsis);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(3, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 201);
            this.panel6.TabIndex = 7;
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.BackColor = System.Drawing.Color.White;
            this.txtSynopsis.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSynopsis.Location = new System.Drawing.Point(7, 29);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.ReadOnly = true;
            this.txtSynopsis.Size = new System.Drawing.Size(542, 169);
            this.txtSynopsis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mô tả";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtReleaseDate);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(375, 72);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(180, 63);
            this.panel10.TabIndex = 4;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.BackColor = System.Drawing.Color.White;
            this.txtReleaseDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseDate.Location = new System.Drawing.Point(7, 29);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.ReadOnly = true;
            this.txtReleaseDate.Size = new System.Drawing.Size(170, 31);
            this.txtReleaseDate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày khởi chiếu";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDuration);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(189, 72);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(180, 63);
            this.panel9.TabIndex = 3;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(7, 29);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(170, 31);
            this.txtDuration.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thời lượng (phút)";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtCountry);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(3, 72);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 63);
            this.panel8.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(7, 29);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(170, 31);
            this.txtCountry.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quốc gia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDirector);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 63);
            this.panel4.TabIndex = 5;
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.White;
            this.txtDirector.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(7, 29);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.ReadOnly = true;
            this.txtDirector.Size = new System.Drawing.Size(263, 31);
            this.txtDirector.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đạo diễn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMovieName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 63);
            this.panel3.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.White;
            this.txtMovieName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(7, 27);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.ReadOnly = true;
            this.txtMovieName.Size = new System.Drawing.Size(542, 34);
            this.txtMovieName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phim";
            // 
            // fMovieDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMovieDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phim";
            this.Load += new System.EventHandler(this.fMovieDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRated)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.PictureBox picRated;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReleaseDate;
    }
}