namespace BetaCinema
{
    partial class fMovieTrailer
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
            this.wbsTrailer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbsTrailer
            // 
            this.wbsTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbsTrailer.Location = new System.Drawing.Point(-1, -1);
            this.wbsTrailer.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbsTrailer.Name = "wbsTrailer";
            this.wbsTrailer.ScrollBarsEnabled = false;
            this.wbsTrailer.Size = new System.Drawing.Size(621, 321);
            this.wbsTrailer.TabIndex = 0;
            // 
            // fMovieTrailer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 320);
            this.Controls.Add(this.wbsTrailer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMovieTrailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trailer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbsTrailer;
    }
}