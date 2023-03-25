namespace Movie_Database
{
    partial class Register
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
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usrnamelbl = new System.Windows.Forms.Label();
            this.passwordReg = new System.Windows.Forms.TextBox();
            this.usernameReg = new System.Windows.Forms.TextBox();
            this.registerButt = new System.Windows.Forms.Button();
            this.confirmPassReg = new System.Windows.Forms.TextBox();
            this.confirmPasslbl = new System.Windows.Forms.Label();
            this.emailReg = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(341, 267);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(56, 13);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password:";
            // 
            // usrnamelbl
            // 
            this.usrnamelbl.AutoSize = true;
            this.usrnamelbl.Location = new System.Drawing.Point(341, 175);
            this.usrnamelbl.Name = "usrnamelbl";
            this.usrnamelbl.Size = new System.Drawing.Size(58, 13);
            this.usrnamelbl.TabIndex = 6;
            this.usrnamelbl.Text = "Username:";
            // 
            // passwordReg
            // 
            this.passwordReg.Location = new System.Drawing.Point(264, 292);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.Size = new System.Drawing.Size(215, 20);
            this.passwordReg.TabIndex = 5;
            // 
            // usernameReg
            // 
            this.usernameReg.Location = new System.Drawing.Point(264, 205);
            this.usernameReg.Name = "usernameReg";
            this.usernameReg.Size = new System.Drawing.Size(215, 20);
            this.usernameReg.TabIndex = 4;
            // 
            // registerButt
            // 
            this.registerButt.Location = new System.Drawing.Point(319, 415);
            this.registerButt.Name = "registerButt";
            this.registerButt.Size = new System.Drawing.Size(75, 23);
            this.registerButt.TabIndex = 8;
            this.registerButt.Text = "Register";
            this.registerButt.UseVisualStyleBackColor = true;
            this.registerButt.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // confirmPassReg
            // 
            this.confirmPassReg.Location = new System.Drawing.Point(264, 364);
            this.confirmPassReg.Name = "confirmPassReg";
            this.confirmPassReg.Size = new System.Drawing.Size(215, 20);
            this.confirmPassReg.TabIndex = 9;
            // 
            // confirmPasslbl
            // 
            this.confirmPasslbl.AutoSize = true;
            this.confirmPasslbl.Location = new System.Drawing.Point(323, 338);
            this.confirmPasslbl.Name = "confirmPasslbl";
            this.confirmPasslbl.Size = new System.Drawing.Size(93, 13);
            this.confirmPasslbl.TabIndex = 10;
            this.confirmPasslbl.Text = "Confirm password:";
            // 
            // emailReg
            // 
            this.emailReg.Location = new System.Drawing.Point(264, 116);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(215, 20);
            this.emailReg.TabIndex = 11;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(341, 86);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(38, 13);
            this.emaillbl.TabIndex = 12;
            this.emaillbl.Text = "E-mail:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Return to login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.return_to_login);
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(167, 39);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(215, 20);
            this.first_name_txt.TabIndex = 15;
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(461, 39);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(215, 20);
            this.last_name_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_name_txt);
            this.Controls.Add(this.first_name_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailReg);
            this.Controls.Add(this.confirmPasslbl);
            this.Controls.Add(this.confirmPassReg);
            this.Controls.Add(this.registerButt);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usrnamelbl);
            this.Controls.Add(this.passwordReg);
            this.Controls.Add(this.usernameReg);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label usrnamelbl;
        private System.Windows.Forms.TextBox passwordReg;
        private System.Windows.Forms.TextBox usernameReg;
        private System.Windows.Forms.Button registerButt;
        private System.Windows.Forms.TextBox confirmPassReg;
        private System.Windows.Forms.Label confirmPasslbl;
        private System.Windows.Forms.TextBox emailReg;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}