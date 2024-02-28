namespace BetaCinema
{
    partial class fMovie
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(711, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(42, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 30);
            this.txtSearch.TabIndex = 1;
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
            this.dgvMovie.GridColor = System.Drawing.Color.White;
            this.dgvMovie.Location = new System.Drawing.Point(40, 110);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.RowHeadersVisible = false;
            this.dgvMovie.RowHeadersWidth = 51;
            this.dgvMovie.RowTemplate.Height = 24;
            this.dgvMovie.RowTemplate.ReadOnly = true;
            this.dgvMovie.Size = new System.Drawing.Size(860, 480);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellDoubleClick);
            // 
            // fMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 630);
            this.Controls.Add(this.dgvMovie);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMovie";
            this.Text = "fMovie";
            this.Load += new System.EventHandler(this.fMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMovie;
    }
}