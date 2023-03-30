namespace Movie_Database.Forms.Actor_Forms
{
    partial class Search_Actor
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(50, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reload_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(258, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Return to movies form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.return_main_menu);
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_txt.Location = new System.Drawing.Point(217, 75);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(285, 29);
            this.title_txt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(377, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(267, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type an actor\'s name:";
            // 
            // Search_Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Movie_Database.Properties.Resources.cast;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 386);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Search_Actor";
            this.Text = "Search_Actor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}