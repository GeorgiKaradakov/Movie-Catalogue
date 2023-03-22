namespace Movie_Database.Forms
{
    partial class Movies
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
            this.filter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "filter by",
            "filter by year_of_release",
            "filter by title",
            "filter by genre"});
            this.filter.Location = new System.Drawing.Point(12, 12);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(164, 32);
            this.filter.TabIndex = 0;
            this.filter.Text = "Filter by";
            this.filter.TextChanged += new System.EventHandler(this.filter_func);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.filter);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox filter;
    }
}