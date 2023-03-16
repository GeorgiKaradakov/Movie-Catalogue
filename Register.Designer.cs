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
            this.SuspendLayout();
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(334, 210);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(56, 13);
            this.passwordlbl.TabIndex = 7;
            this.passwordlbl.Text = "Password:";
            // 
            // usrnamelbl
            // 
            this.usrnamelbl.AutoSize = true;
            this.usrnamelbl.Location = new System.Drawing.Point(334, 118);
            this.usrnamelbl.Name = "usrnamelbl";
            this.usrnamelbl.Size = new System.Drawing.Size(58, 13);
            this.usrnamelbl.TabIndex = 6;
            this.usrnamelbl.Text = "Username:";
            // 
            // passwordReg
            // 
            this.passwordReg.Location = new System.Drawing.Point(257, 235);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.Size = new System.Drawing.Size(215, 20);
            this.passwordReg.TabIndex = 5;
            // 
            // usernameReg
            // 
            this.usernameReg.Location = new System.Drawing.Point(257, 148);
            this.usernameReg.Name = "usernameReg";
            this.usernameReg.Size = new System.Drawing.Size(215, 20);
            this.usernameReg.TabIndex = 4;
            // 
            // registerButt
            // 
            this.registerButt.Location = new System.Drawing.Point(319, 366);
            this.registerButt.Name = "registerButt";
            this.registerButt.Size = new System.Drawing.Size(75, 23);
            this.registerButt.TabIndex = 8;
            this.registerButt.Text = "Register";
            this.registerButt.UseVisualStyleBackColor = true;
            // 
            // confirmPassReg
            // 
            this.confirmPassReg.Location = new System.Drawing.Point(257, 307);
            this.confirmPassReg.Name = "confirmPassReg";
            this.confirmPassReg.Size = new System.Drawing.Size(215, 20);
            this.confirmPassReg.TabIndex = 9;
            // 
            // confirmPasslbl
            // 
            this.confirmPasslbl.AutoSize = true;
            this.confirmPasslbl.Location = new System.Drawing.Point(316, 281);
            this.confirmPasslbl.Name = "confirmPasslbl";
            this.confirmPasslbl.Size = new System.Drawing.Size(93, 13);
            this.confirmPasslbl.TabIndex = 10;
            this.confirmPasslbl.Text = "Confirm password:";
            // 
            // emailReg
            // 
            this.emailReg.Location = new System.Drawing.Point(257, 59);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(215, 20);
            this.emailReg.TabIndex = 11;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(334, 29);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(38, 13);
            this.emaillbl.TabIndex = 12;
            this.emaillbl.Text = "E-mail:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}