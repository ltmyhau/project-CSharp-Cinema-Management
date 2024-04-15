namespace BetaCinema.GUI.Admin.Genre
{
    partial class fGenre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrintGenre = new System.Windows.Forms.Button();
            this.btnExportGenre = new System.Windows.Forms.Button();
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.btnPrintMovie = new System.Windows.Forms.Button();
            this.btnExportMovie = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlConfirm);
            this.panel1.Controls.Add(this.pnlControls);
            this.panel1.Controls.Add(this.btnPrintGenre);
            this.panel1.Controls.Add(this.btnExportGenre);
            this.panel1.Controls.Add(this.dgvGenre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGenreName);
            this.panel1.Controls.Add(this.txtGenreID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 630);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Image = global::BetaCinema.Properties.Resources.check;
            this.btnOK.Location = new System.Drawing.Point(5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 45);
            this.btnOK.TabIndex = 12;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::BetaCinema.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(56, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrintGenre
            // 
            this.btnPrintGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintGenre.FlatAppearance.BorderSize = 0;
            this.btnPrintGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintGenre.Image = global::BetaCinema.Properties.Resources.printer;
            this.btnPrintGenre.Location = new System.Drawing.Point(536, 210);
            this.btnPrintGenre.Name = "btnPrintGenre";
            this.btnPrintGenre.Size = new System.Drawing.Size(45, 45);
            this.btnPrintGenre.TabIndex = 14;
            this.btnPrintGenre.UseVisualStyleBackColor = true;
            this.btnPrintGenre.Click += new System.EventHandler(this.btnPrintGenre_Click);
            // 
            // btnExportGenre
            // 
            this.btnExportGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportGenre.FlatAppearance.BorderSize = 0;
            this.btnExportGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportGenre.Image = global::BetaCinema.Properties.Resources.xls;
            this.btnExportGenre.Location = new System.Drawing.Point(588, 210);
            this.btnExportGenre.Name = "btnExportGenre";
            this.btnExportGenre.Size = new System.Drawing.Size(45, 45);
            this.btnExportGenre.TabIndex = 13;
            this.btnExportGenre.UseVisualStyleBackColor = true;
            this.btnExportGenre.Click += new System.EventHandler(this.btnExportGenre_Click);
            // 
            // dgvGenre
            // 
            this.dgvGenre.AllowUserToResizeColumns = false;
            this.dgvGenre.AllowUserToResizeRows = false;
            this.dgvGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGenre.BackgroundColor = System.Drawing.Color.White;
            this.dgvGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGenre.ColumnHeadersHeight = 40;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGenre.Location = new System.Drawing.Point(38, 260);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.ReadOnly = true;
            this.dgvGenre.RowHeadersVisible = false;
            this.dgvGenre.RowHeadersWidth = 50;
            this.dgvGenre.RowTemplate.Height = 24;
            this.dgvGenre.Size = new System.Drawing.Size(595, 339);
            this.dgvGenre.TabIndex = 2;
            this.dgvGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenre_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã thể loại";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.Location = new System.Drawing.Point(174, 82);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(459, 30);
            this.txtGenreName.TabIndex = 23;
            // 
            // txtGenreID
            // 
            this.txtGenreID.Enabled = false;
            this.txtGenreID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreID.Location = new System.Drawing.Point(174, 28);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(459, 30);
            this.txtGenreID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên thể loại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnPrintMovie);
            this.panel2.Controls.Add(this.btnExportMovie);
            this.panel2.Controls.Add(this.dgvMovie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(654, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 630);
            this.panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 39);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(139, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 39);
            this.btnEdit.TabIndex = 25;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(275, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 39);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnEdit);
            this.pnlControls.Location = new System.Drawing.Point(225, 134);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(408, 45);
            this.pnlControls.TabIndex = 27;
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.Controls.Add(this.btnOK);
            this.pnlConfirm.Controls.Add(this.btnCancel);
            this.pnlConfirm.Location = new System.Drawing.Point(38, 130);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(110, 54);
            this.pnlConfirm.TabIndex = 28;
            this.pnlConfirm.Visible = false;
            // 
            // dgvMovie
            // 
            this.dgvMovie.AllowUserToResizeColumns = false;
            this.dgvMovie.AllowUserToResizeRows = false;
            this.dgvMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovie.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovie.ColumnHeadersHeight = 50;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovie.Location = new System.Drawing.Point(19, 82);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.RowHeadersVisible = false;
            this.dgvMovie.RowHeadersWidth = 50;
            this.dgvMovie.RowTemplate.Height = 24;
            this.dgvMovie.Size = new System.Drawing.Size(233, 517);
            this.dgvMovie.TabIndex = 13;
            // 
            // btnPrintMovie
            // 
            this.btnPrintMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintMovie.FlatAppearance.BorderSize = 0;
            this.btnPrintMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintMovie.Image = global::BetaCinema.Properties.Resources.printer;
            this.btnPrintMovie.Location = new System.Drawing.Point(155, 28);
            this.btnPrintMovie.Name = "btnPrintMovie";
            this.btnPrintMovie.Size = new System.Drawing.Size(45, 45);
            this.btnPrintMovie.TabIndex = 18;
            this.btnPrintMovie.UseVisualStyleBackColor = true;
            this.btnPrintMovie.Click += new System.EventHandler(this.btnPrintMovie_Click);
            // 
            // btnExportMovie
            // 
            this.btnExportMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportMovie.FlatAppearance.BorderSize = 0;
            this.btnExportMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportMovie.Image = global::BetaCinema.Properties.Resources.xls;
            this.btnExportMovie.Location = new System.Drawing.Point(207, 28);
            this.btnExportMovie.Name = "btnExportMovie";
            this.btnExportMovie.Size = new System.Drawing.Size(45, 45);
            this.btnExportMovie.TabIndex = 17;
            this.btnExportMovie.UseVisualStyleBackColor = true;
            this.btnExportMovie.Click += new System.EventHandler(this.btnExportMovie_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(19, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 40);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "THỂ LOẠI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fGenre";
            this.Text = "fGenre";
            this.Load += new System.EventHandler(this.fGenre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.Button btnPrintGenre;
        private System.Windows.Forms.Button btnExportGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.TextBox txtGenreID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Button btnPrintMovie;
        private System.Windows.Forms.Button btnExportMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
    }
}