using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database.Forms
{
    public partial class UserDetails : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public UserDetails()
        {
            InitializeComponent();
        }

        private void return_main(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            var user = User.current_user;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Your name is : {string.Concat(user.first_name, " ", user.last_name)}\n");
            sb.AppendLine($"username: {user.email}\n");
            sb.AppendLine($"Email: {user.username}\n");
            sb.AppendLine("Thats all we know for you. ;)");

            label1.Text = sb.ToString().TrimEnd();
        }
    }
}
