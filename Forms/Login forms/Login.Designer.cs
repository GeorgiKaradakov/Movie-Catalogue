namespace Movie_Database
{
    partial class Login
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
            this.usernameLog = new System.Windows.Forms.TextBox();
            this.passwordLog = new System.Windows.Forms.TextBox();
            this.usrnameloginlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButt = new System.Windows.Forms.Button();
            this.reigster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLog
            // 
            this.usernameLog.Location = new System.Drawing.Point(263, 90);
            this.usernameLog.Name = "usernameLog";
            this.usernameLog.Size = new System.Drawing.Size(252, 20);
            this.usernameLog.TabIndex = 0;
            // 
            // passwordLog
            // 
            this.passwordLog.Location = new System.Drawing.Point(263, 163);
            this.passwordLog.Name = "passwordLog";
            this.passwordLog.PasswordChar = '*';
            this.passwordLog.Size = new System.Drawing.Size(252, 20);
            this.passwordLog.TabIndex = 1;
            // 
            // usrnameloginlbl
            // 
            this.usrnameloginlbl.AutoSize = true;
            this.usrnameloginlbl.BackColor = System.Drawing.Color.Transparent;
            this.usrnameloginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameloginlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usrnameloginlbl.Location = new System.Drawing.Point(343, 59);
            this.usrnameloginlbl.Name = "usrnameloginlbl";
            this.usrnameloginlbl.Size = new System.Drawing.Size(90, 18);
            this.usrnameloginlbl.TabIndex = 2;
            this.usrnameloginlbl.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(343, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // loginButt
            // 
            this.loginButt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButt.Location = new System.Drawing.Point(346, 273);
            this.loginButt.Name = "loginButt";
            this.loginButt.Size = new System.Drawing.Size(75, 23);
            this.loginButt.TabIndex = 4;
            this.loginButt.Text = "Login";
            this.loginButt.UseVisualStyleBackColor = true;
            this.loginButt.Click += new System.EventHandler(this.LogIn);
            // 
            // reigster
            // 
            this.reigster.AutoSize = true;
            this.reigster.BackColor = System.Drawing.Color.Transparent;
            this.reigster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reigster.ForeColor = System.Drawing.Color.White;
            this.reigster.Location = new System.Drawing.Point(237, 337);
            this.reigster.Name = "reigster";
            this.reigster.Size = new System.Drawing.Size(300, 20);
            this.reigster.TabIndex = 6;
            this.reigster.Text = "Don\'t have an account? Create one here!";
            this.reigster.Click += new System.EventHandler(this.reigster_Click);
            this.reigster.MouseLeave += new System.EventHandler(this.MouseLeave_lbl);
            this.reigster.MouseHover += new System.EventHandler(this.Hover_lbl);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Movie_Database.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reigster);
            this.Controls.Add(this.loginButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrnameloginlbl);
            this.Controls.Add(this.passwordLog);
            this.Controls.Add(this.usernameLog);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameLog;
        private System.Windows.Forms.TextBox passwordLog;
        private System.Windows.Forms.Label usrnameloginlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButt;
        private System.Windows.Forms.Label reigster;
    }
}

