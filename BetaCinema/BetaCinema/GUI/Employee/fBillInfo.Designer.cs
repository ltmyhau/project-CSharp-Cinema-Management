namespace BetaCinema.GUI.Employee
{
    partial class fBillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBillInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.txtCusDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMovie = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalMovie = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlMovie.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlCustomerInfo);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.pnlAddCustomer);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 291);
            this.panel1.TabIndex = 0;
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.Controls.Add(this.txtCusDiscount);
            this.pnlCustomerInfo.Controls.Add(this.label13);
            this.pnlCustomerInfo.Controls.Add(this.txtPoint);
            this.pnlCustomerInfo.Controls.Add(this.label11);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.label12);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(3, 132);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(290, 123);
            this.pnlCustomerInfo.TabIndex = 26;
            this.pnlCustomerInfo.Visible = false;
            // 
            // txtCusDiscount
            // 
            this.txtCusDiscount.BackColor = System.Drawing.Color.White;
            this.txtCusDiscount.Enabled = false;
            this.txtCusDiscount.Location = new System.Drawing.Point(127, 85);
            this.txtCusDiscount.Name = "txtCusDiscount";
            this.txtCusDiscount.Size = new System.Drawing.Size(151, 30);
            this.txtCusDiscount.TabIndex = 10;
            this.txtCusDiscount.Text = "15%";
            this.txtCusDiscount.TextChanged += new System.EventHandler(this.txtCusDiscount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Chiết khấu:";
            // 
            // txtPoint
            // 
            this.txtPoint.BackColor = System.Drawing.Color.White;
            this.txtPoint.Enabled = false;
            this.txtPoint.Location = new System.Drawing.Point(127, 49);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(151, 30);
            this.txtPoint.TabIndex = 8;
            this.txtPoint.Text = "17042003";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Điểm tích lũy:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(127, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 30);
            this.txtCustomerName.TabIndex = 6;
            this.txtCustomerName.Text = "Lê Thị Mỹ Hậu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ và tên:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 30);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "THÔNG TIN KHÁCH HÀNG";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.btnAdd);
            this.pnlAddCustomer.Controls.Add(this.rdoOther);
            this.pnlAddCustomer.Controls.Add(this.rdoFemale);
            this.pnlAddCustomer.Controls.Add(this.rdoMale);
            this.pnlAddCustomer.Controls.Add(this.txtFirstName);
            this.pnlAddCustomer.Controls.Add(this.label4);
            this.pnlAddCustomer.Controls.Add(this.txtLastName);
            this.pnlAddCustomer.Controls.Add(this.label3);
            this.pnlAddCustomer.Location = new System.Drawing.Point(3, 132);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(290, 133);
            this.pnlAddCustomer.TabIndex = 4;
            this.pnlAddCustomer.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::BetaCinema.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(243, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(156, 92);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(68, 27);
            this.rdoOther.TabIndex = 11;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Khác";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(93, 92);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(54, 27);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(16, 92);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 27);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(69, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(208, 30);
            this.txtFirstName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(69, 13);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(208, 30);
            this.txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ:";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::BetaCinema.Properties.Resources.loupe;
            this.btnSearch.Location = new System.Drawing.Point(246, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(113, 83);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(127, 30);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện thoại:";
            // 
            // pnlMovie
            // 
            this.pnlMovie.BackColor = System.Drawing.Color.White;
            this.pnlMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMovie.Controls.Add(this.label9);
            this.pnlMovie.Controls.Add(this.txtTotalMovie);
            this.pnlMovie.Controls.Add(this.panel4);
            this.pnlMovie.Controls.Add(this.label8);
            this.pnlMovie.Controls.Add(this.txtSeats);
            this.pnlMovie.Controls.Add(this.label7);
            this.pnlMovie.Controls.Add(this.txtRoom);
            this.pnlMovie.Controls.Add(this.label6);
            this.pnlMovie.Controls.Add(this.txtTime);
            this.pnlMovie.Controls.Add(this.label5);
            this.pnlMovie.Controls.Add(this.txtDate);
            this.pnlMovie.Controls.Add(this.label1);
            this.pnlMovie.Controls.Add(this.txtMovieName);
            this.pnlMovie.Controls.Add(this.textBox4);
            this.pnlMovie.Location = new System.Drawing.Point(315, 22);
            this.pnlMovie.Name = "pnlMovie";
            this.pnlMovie.Size = new System.Drawing.Size(275, 479);
            this.pnlMovie.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng:";
            // 
            // txtTotalMovie
            // 
            this.txtTotalMovie.BackColor = System.Drawing.Color.White;
            this.txtTotalMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalMovie.Enabled = false;
            this.txtTotalMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMovie.Location = new System.Drawing.Point(127, 402);
            this.txtTotalMovie.Name = "txtTotalMovie";
            this.txtTotalMovie.Size = new System.Drawing.Size(135, 23);
            this.txtTotalMovie.TabIndex = 24;
            this.txtTotalMovie.Text = "100.000";
            this.txtTotalMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(15, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 2);
            this.panel4.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ghế:";
            // 
            // txtSeats
            // 
            this.txtSeats.BackColor = System.Drawing.Color.White;
            this.txtSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeats.Enabled = false;
            this.txtSeats.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.Location = new System.Drawing.Point(62, 223);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(197, 23);
            this.txtSeats.TabIndex = 21;
            this.txtSeats.Text = "A4, A10";
            this.txtSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phòng chiếu:";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.White;
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoom.Enabled = false;
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(124, 186);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(135, 23);
            this.txtRoom.TabIndex = 19;
            this.txtRoom.Text = "Phòng 4";
            this.txtRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giờ chiếu:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.White;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(98, 152);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(161, 23);
            this.txtTime.TabIndex = 17;
            this.txtTime.Text = "10:04 ~ 10:04";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày chiếu:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(114, 117);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(145, 23);
            this.txtDate.TabIndex = 15;
            this.txtDate.Text = "10/04/2024";
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên phim:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.Color.White;
            this.txtMovieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMovieName.Enabled = false;
            this.txtMovieName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(98, 83);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(161, 23);
            this.txtMovieName.TabIndex = 12;
            this.txtMovieName.Text = "TÊN PHIM";
            this.txtMovieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 30);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "PHIM";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.White;
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduct.Controls.Add(this.flpProducts);
            this.pnlProduct.Controls.Add(this.label10);
            this.pnlProduct.Controls.Add(this.textBox5);
            this.pnlProduct.Controls.Add(this.txtTotalProduct);
            this.pnlProduct.Controls.Add(this.panel5);
            this.pnlProduct.Location = new System.Drawing.Point(596, 22);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(275, 479);
            this.pnlProduct.TabIndex = 2;
            // 
            // flpProducts
            // 
            this.flpProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpProducts.Location = new System.Drawing.Point(-1, 77);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(275, 313);
            this.flpProducts.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tổng:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(12, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(247, 30);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "BẮP - NƯỚC";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.BackColor = System.Drawing.Color.White;
            this.txtTotalProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalProduct.Enabled = false;
            this.txtTotalProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProduct.Location = new System.Drawing.Point(124, 402);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(135, 23);
            this.txtTotalProduct.TabIndex = 27;
            this.txtTotalProduct.Text = "100.000";
            this.txtTotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(12, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 2);
            this.panel5.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tổng tiền:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(127, 17);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 23);
            this.txtTotal.TabIndex = 33;
            this.txtTotal.Text = "100.000 đ";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "Khuyến mãi:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(127, 46);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(150, 23);
            this.txtDiscount.TabIndex = 35;
            this.txtDiscount.Text = "0 đ";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "Phải thanh toán:";
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.Color.White;
            this.txtPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPay.Enabled = false;
            this.txtPay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(155, 75);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(123, 23);
            this.txtPay.TabIndex = 37;
            this.txtPay.Text = "100.000 đ";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.txtTotal);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.txtDiscount);
            this.panel8.Controls.Add(this.txtPay);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(12, 319);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(297, 116);
            this.panel8.TabIndex = 38;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnCreateBill.FlatAppearance.BorderSize = 0;
            this.btnCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBill.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBill.ForeColor = System.Drawing.Color.White;
            this.btnCreateBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBill.Location = new System.Drawing.Point(120, 462);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(189, 39);
            this.btnCreateBill.TabIndex = 39;
            this.btnCreateBill.Text = "Tạo hóa đơn";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Visible = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // fBillInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.btnCreateBill);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlMovie);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBillInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fBillInfo_FormClosing);
            this.Load += new System.EventHandler(this.fBillInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlMovie.ResumeLayout(false);
            this.pnlMovie.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Panel pnlMovie;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalMovie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCusDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCreateBill;
    }
}