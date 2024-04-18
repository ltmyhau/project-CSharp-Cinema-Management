namespace BetaCinema.GUI.Admin.Statistic
{
    partial class fStatistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistic));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovie = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoPKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rdoPTatCa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPTongVe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDoanhThuPhim = new System.Windows.Forms.TextBox();
            this.dgvStatisticsByMovie = new System.Windows.Forms.DataGridView();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpSPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoSPKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rdoSPTatCa = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSoLuongDaBan = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDoanhThuSP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvStatisticsByProduct = new System.Windows.Forms.DataGridView();
            this.btnPChart = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPExport = new System.Windows.Forms.Button();
            this.btnSPChart = new System.Windows.Forms.Button();
            this.btnSPPrint = new System.Windows.Forms.Button();
            this.btnSPExport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMovie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsByMovie)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsByProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovie);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovie
            // 
            this.tabMovie.Controls.Add(this.btnPChart);
            this.tabMovie.Controls.Add(this.btnPrint);
            this.tabMovie.Controls.Add(this.btnPExport);
            this.tabMovie.Controls.Add(this.groupBox1);
            this.tabMovie.Controls.Add(this.panel2);
            this.tabMovie.Controls.Add(this.panel1);
            this.tabMovie.Controls.Add(this.dgvStatisticsByMovie);
            this.tabMovie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMovie.Location = new System.Drawing.Point(4, 32);
            this.tabMovie.Name = "tabMovie";
            this.tabMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovie.Size = new System.Drawing.Size(932, 594);
            this.tabMovie.TabIndex = 0;
            this.tabMovie.Text = "Phim";
            this.tabMovie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpPDenNgay);
            this.groupBox1.Controls.Add(this.dtpPTuNgay);
            this.groupBox1.Controls.Add(this.rdoPKhoangThoiGian);
            this.groupBox1.Controls.Add(this.rdoPTatCa);
            this.groupBox1.Location = new System.Drawing.Point(23, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến";
            // 
            // dtpPDenNgay
            // 
            this.dtpPDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPDenNgay.Location = new System.Drawing.Point(271, 69);
            this.dtpPDenNgay.Name = "dtpPDenNgay";
            this.dtpPDenNgay.Size = new System.Drawing.Size(130, 30);
            this.dtpPDenNgay.TabIndex = 3;
            this.dtpPDenNgay.ValueChanged += new System.EventHandler(this.dtpPDenNgay_ValueChanged);
            // 
            // dtpPTuNgay
            // 
            this.dtpPTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPTuNgay.Location = new System.Drawing.Point(80, 69);
            this.dtpPTuNgay.Name = "dtpPTuNgay";
            this.dtpPTuNgay.Size = new System.Drawing.Size(130, 30);
            this.dtpPTuNgay.TabIndex = 2;
            this.dtpPTuNgay.ValueChanged += new System.EventHandler(this.dtpPTuNgay_ValueChanged);
            // 
            // rdoPKhoangThoiGian
            // 
            this.rdoPKhoangThoiGian.AutoSize = true;
            this.rdoPKhoangThoiGian.Location = new System.Drawing.Point(18, 71);
            this.rdoPKhoangThoiGian.Name = "rdoPKhoangThoiGian";
            this.rdoPKhoangThoiGian.Size = new System.Drawing.Size(50, 27);
            this.rdoPKhoangThoiGian.TabIndex = 1;
            this.rdoPKhoangThoiGian.Text = "Từ";
            this.rdoPKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rdoPKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rdoKhoangThoiGian_CheckedChanged);
            // 
            // rdoPTatCa
            // 
            this.rdoPTatCa.AutoSize = true;
            this.rdoPTatCa.Checked = true;
            this.rdoPTatCa.Location = new System.Drawing.Point(18, 31);
            this.rdoPTatCa.Name = "rdoPTatCa";
            this.rdoPTatCa.Size = new System.Drawing.Size(161, 27);
            this.rdoPTatCa.TabIndex = 0;
            this.rdoPTatCa.TabStop = true;
            this.rdoPTatCa.Text = "Từ trước đến nay";
            this.rdoPTatCa.UseVisualStyleBackColor = true;
            this.rdoPTatCa.CheckedChanged += new System.EventHandler(this.rdoTatCa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.txtPTongVe);
            this.panel2.Location = new System.Drawing.Point(489, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(168, 24);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Tổng số vé đã bán";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTongVe
            // 
            this.txtPTongVe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPTongVe.BackColor = System.Drawing.Color.White;
            this.txtPTongVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPTongVe.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTongVe.Location = new System.Drawing.Point(16, 51);
            this.txtPTongVe.Name = "txtPTongVe";
            this.txtPTongVe.ReadOnly = true;
            this.txtPTongVe.Size = new System.Drawing.Size(168, 30);
            this.txtPTongVe.TabIndex = 3;
            this.txtPTongVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtDoanhThuPhim);
            this.panel1.Location = new System.Drawing.Point(707, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(168, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Tổng doanh thu";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuPhim
            // 
            this.txtDoanhThuPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoanhThuPhim.BackColor = System.Drawing.Color.White;
            this.txtDoanhThuPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoanhThuPhim.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuPhim.Location = new System.Drawing.Point(16, 51);
            this.txtDoanhThuPhim.Name = "txtDoanhThuPhim";
            this.txtDoanhThuPhim.ReadOnly = true;
            this.txtDoanhThuPhim.Size = new System.Drawing.Size(168, 30);
            this.txtDoanhThuPhim.TabIndex = 3;
            this.txtDoanhThuPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStatisticsByMovie
            // 
            this.dgvStatisticsByMovie.AllowUserToResizeColumns = false;
            this.dgvStatisticsByMovie.AllowUserToResizeRows = false;
            this.dgvStatisticsByMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatisticsByMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatisticsByMovie.ColumnHeadersHeight = 50;
            this.dgvStatisticsByMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatisticsByMovie.Location = new System.Drawing.Point(23, 130);
            this.dgvStatisticsByMovie.Name = "dgvStatisticsByMovie";
            this.dgvStatisticsByMovie.ReadOnly = true;
            this.dgvStatisticsByMovie.RowHeadersVisible = false;
            this.dgvStatisticsByMovie.RowHeadersWidth = 51;
            this.dgvStatisticsByMovie.RowTemplate.Height = 24;
            this.dgvStatisticsByMovie.Size = new System.Drawing.Size(884, 416);
            this.dgvStatisticsByMovie.TabIndex = 0;
            this.dgvStatisticsByMovie.DataSourceChanged += new System.EventHandler(this.dgvStatisticsByMovie_DataSourceChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnSPChart);
            this.tabProduct.Controls.Add(this.btnSPPrint);
            this.tabProduct.Controls.Add(this.btnSPExport);
            this.tabProduct.Controls.Add(this.groupBox2);
            this.tabProduct.Controls.Add(this.panel4);
            this.tabProduct.Controls.Add(this.panel3);
            this.tabProduct.Controls.Add(this.dgvStatisticsByProduct);
            this.tabProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProduct.Location = new System.Drawing.Point(4, 32);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(932, 594);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Bắp - Nước";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpSPDenNgay);
            this.groupBox2.Controls.Add(this.dtpSPTuNgay);
            this.groupBox2.Controls.Add(this.rdoSPKhoangThoiGian);
            this.groupBox2.Controls.Add(this.rdoSPTatCa);
            this.groupBox2.Location = new System.Drawing.Point(23, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "đến";
            // 
            // dtpSPDenNgay
            // 
            this.dtpSPDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPDenNgay.Location = new System.Drawing.Point(271, 69);
            this.dtpSPDenNgay.Name = "dtpSPDenNgay";
            this.dtpSPDenNgay.Size = new System.Drawing.Size(130, 30);
            this.dtpSPDenNgay.TabIndex = 3;
            // 
            // dtpSPTuNgay
            // 
            this.dtpSPTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPTuNgay.Location = new System.Drawing.Point(80, 69);
            this.dtpSPTuNgay.Name = "dtpSPTuNgay";
            this.dtpSPTuNgay.Size = new System.Drawing.Size(130, 30);
            this.dtpSPTuNgay.TabIndex = 2;
            this.dtpSPTuNgay.ValueChanged += new System.EventHandler(this.dtpSPTuNgay_ValueChanged);
            // 
            // rdoSPKhoangThoiGian
            // 
            this.rdoSPKhoangThoiGian.AutoSize = true;
            this.rdoSPKhoangThoiGian.Location = new System.Drawing.Point(18, 71);
            this.rdoSPKhoangThoiGian.Name = "rdoSPKhoangThoiGian";
            this.rdoSPKhoangThoiGian.Size = new System.Drawing.Size(50, 27);
            this.rdoSPKhoangThoiGian.TabIndex = 1;
            this.rdoSPKhoangThoiGian.Text = "Từ";
            this.rdoSPKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rdoSPKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rdoSPKhoangThoiGian_CheckedChanged);
            // 
            // rdoSPTatCa
            // 
            this.rdoSPTatCa.AutoSize = true;
            this.rdoSPTatCa.Checked = true;
            this.rdoSPTatCa.Location = new System.Drawing.Point(18, 31);
            this.rdoSPTatCa.Name = "rdoSPTatCa";
            this.rdoSPTatCa.Size = new System.Drawing.Size(161, 27);
            this.rdoSPTatCa.TabIndex = 0;
            this.rdoSPTatCa.TabStop = true;
            this.rdoSPTatCa.Text = "Từ trước đến nay";
            this.rdoSPTatCa.UseVisualStyleBackColor = true;
            this.rdoSPTatCa.CheckedChanged += new System.EventHandler(this.rdoSPTatCa_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.panel4.Controls.Add(this.txtSoLuongDaBan);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Location = new System.Drawing.Point(489, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // txtSoLuongDaBan
            // 
            this.txtSoLuongDaBan.BackColor = System.Drawing.Color.White;
            this.txtSoLuongDaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongDaBan.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongDaBan.Location = new System.Drawing.Point(16, 51);
            this.txtSoLuongDaBan.Name = "txtSoLuongDaBan";
            this.txtSoLuongDaBan.ReadOnly = true;
            this.txtSoLuongDaBan.Size = new System.Drawing.Size(168, 30);
            this.txtSoLuongDaBan.TabIndex = 1;
            this.txtSoLuongDaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 13);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(168, 24);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Số lượng đã bán";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.txtDoanhThuSP);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(707, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // txtDoanhThuSP
            // 
            this.txtDoanhThuSP.BackColor = System.Drawing.Color.White;
            this.txtDoanhThuSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoanhThuSP.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuSP.Location = new System.Drawing.Point(16, 51);
            this.txtDoanhThuSP.Name = "txtDoanhThuSP";
            this.txtDoanhThuSP.ReadOnly = true;
            this.txtDoanhThuSP.Size = new System.Drawing.Size(168, 30);
            this.txtDoanhThuSP.TabIndex = 1;
            this.txtDoanhThuSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(205)))), ((int)(((byte)(239)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(168, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tổng doanh thu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvStatisticsByProduct
            // 
            this.dgvStatisticsByProduct.AllowUserToResizeColumns = false;
            this.dgvStatisticsByProduct.AllowUserToResizeRows = false;
            this.dgvStatisticsByProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatisticsByProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatisticsByProduct.ColumnHeadersHeight = 50;
            this.dgvStatisticsByProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatisticsByProduct.Location = new System.Drawing.Point(23, 130);
            this.dgvStatisticsByProduct.Name = "dgvStatisticsByProduct";
            this.dgvStatisticsByProduct.ReadOnly = true;
            this.dgvStatisticsByProduct.RowHeadersVisible = false;
            this.dgvStatisticsByProduct.RowHeadersWidth = 51;
            this.dgvStatisticsByProduct.RowTemplate.Height = 24;
            this.dgvStatisticsByProduct.Size = new System.Drawing.Size(884, 416);
            this.dgvStatisticsByProduct.TabIndex = 1;
            this.dgvStatisticsByProduct.DataSourceChanged += new System.EventHandler(this.dgvProduct_DataSourceChanged);
            // 
            // btnPChart
            // 
            this.btnPChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPChart.FlatAppearance.BorderSize = 0;
            this.btnPChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPChart.Image = global::BetaCinema.Properties.Resources.bar_chart;
            this.btnPChart.Location = new System.Drawing.Point(758, 546);
            this.btnPChart.Name = "btnPChart";
            this.btnPChart.Size = new System.Drawing.Size(45, 45);
            this.btnPChart.TabIndex = 10;
            this.btnPChart.UseVisualStyleBackColor = true;
            this.btnPChart.Click += new System.EventHandler(this.btnPChart_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::BetaCinema.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(810, 546);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 45);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPExport
            // 
            this.btnPExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPExport.FlatAppearance.BorderSize = 0;
            this.btnPExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPExport.Image = global::BetaCinema.Properties.Resources.xls;
            this.btnPExport.Location = new System.Drawing.Point(862, 546);
            this.btnPExport.Name = "btnPExport";
            this.btnPExport.Size = new System.Drawing.Size(45, 45);
            this.btnPExport.TabIndex = 8;
            this.btnPExport.UseVisualStyleBackColor = true;
            this.btnPExport.Click += new System.EventHandler(this.btnPExport_Click);
            // 
            // btnSPChart
            // 
            this.btnSPChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPChart.FlatAppearance.BorderSize = 0;
            this.btnSPChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPChart.Image = global::BetaCinema.Properties.Resources.bar_chart;
            this.btnSPChart.Location = new System.Drawing.Point(758, 546);
            this.btnSPChart.Name = "btnSPChart";
            this.btnSPChart.Size = new System.Drawing.Size(45, 45);
            this.btnSPChart.TabIndex = 10;
            this.btnSPChart.UseVisualStyleBackColor = true;
            this.btnSPChart.Click += new System.EventHandler(this.btnSPChart_Click);
            // 
            // btnSPPrint
            // 
            this.btnSPPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPPrint.FlatAppearance.BorderSize = 0;
            this.btnSPPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPPrint.Image = global::BetaCinema.Properties.Resources.printer;
            this.btnSPPrint.Location = new System.Drawing.Point(810, 546);
            this.btnSPPrint.Name = "btnSPPrint";
            this.btnSPPrint.Size = new System.Drawing.Size(45, 45);
            this.btnSPPrint.TabIndex = 9;
            this.btnSPPrint.UseVisualStyleBackColor = true;
            this.btnSPPrint.Click += new System.EventHandler(this.btnSPPrint_Click);
            // 
            // btnSPExport
            // 
            this.btnSPExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPExport.FlatAppearance.BorderSize = 0;
            this.btnSPExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPExport.Image = global::BetaCinema.Properties.Resources.xls;
            this.btnSPExport.Location = new System.Drawing.Point(862, 546);
            this.btnSPExport.Name = "btnSPExport";
            this.btnSPExport.Size = new System.Drawing.Size(45, 45);
            this.btnSPExport.TabIndex = 8;
            this.btnSPExport.UseVisualStyleBackColor = true;
            this.btnSPExport.Click += new System.EventHandler(this.btnSPExport_Click);
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 630);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStatistic";
            this.Text = "fStatistic";
            this.Load += new System.EventHandler(this.fStatistic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMovie.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsByMovie)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsByProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovie;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView dgvStatisticsByMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDoanhThuPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPTongVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPKhoangThoiGian;
        private System.Windows.Forms.RadioButton rdoPTatCa;
        private System.Windows.Forms.DateTimePicker dtpPTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPDenNgay;
        private System.Windows.Forms.DataGridView dgvStatisticsByProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDoanhThuSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoLuongDaBan;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSPTatCa;
        private System.Windows.Forms.RadioButton rdoSPKhoangThoiGian;
        private System.Windows.Forms.DateTimePicker dtpSPTuNgay;
        private System.Windows.Forms.DateTimePicker dtpSPDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPExport;
        private System.Windows.Forms.Button btnPChart;
        private System.Windows.Forms.Button btnSPPrint;
        private System.Windows.Forms.Button btnSPExport;
        private System.Windows.Forms.Button btnSPChart;
    }
}