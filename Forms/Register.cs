using Movie_Database.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    public partial class Register : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void registerButt_Click(object sender, EventArgs e)
        {
            if(passwordReg.Text != confirmPassReg.Text)
            {
                MessageBox.Show("The passwords does not match");
                return;
            }

            string query = $"INSERT INTO users(first_name, last_name, email, username, password) " +
                $"VALUES('{first_name_txt.Text}', '{last_name_txt.Text}', '{emailReg.Text}', '{usernameReg.Text}', '{passwordReg.Text}');";
            
            try
            {
                SQL_Utils.insert_into_table(query);

                MessageBox.Show("You have succesfully created an account");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void return_to_login(object sender, EventArgs e)
        {
            this.ParentForm.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
