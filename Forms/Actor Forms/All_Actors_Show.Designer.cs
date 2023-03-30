namespace Movie_Database.Forms.Actor_Forms
{
    partial class All_Actors_Show
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
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "filter by",
            "filter by name",
            "filter by date_of_birth",
            "filter by place_of_birth"});
            this.filter.Location = new System.Drawing.Point(3, 12);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(121, 28);
            this.filter.TabIndex = 0;
            this.filter.Text = "filter by";
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            this.filter.TextChanged += new System.EventHandler(this.filter_changed);
            // 
            // All_Actors_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.filter);
            this.Name = "All_Actors_Show";
            this.Text = "All_Actors_Show";
            this.Load += new System.EventHandler(this.All_Actors_Show_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox filter;
    }
}