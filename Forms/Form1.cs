using Movie_Database.Forms;
using Movie_Database.Models;
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
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection(SQL_Utils.connection_string);
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void reigster_Click(object sender, EventArgs e)
        {
            Register reg_form = new Register();
            reg_form.StartPosition = FormStartPosition.CenterParent;
            reg_form.ParentForm = this;
            reg_form.Show();
            this.Hide();
        }

        private void LogIn(object sender, EventArgs e)
        {
            try
            {

                if (SQL_Utils.does_user_exists(usernameLog.Text, passwordLog.Text)) {
                    SQL_Utils.configure_current_user(usernameLog.Text);
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }

            }catch (Exception)
            {
                MessageBox.Show("Invalid data");
            }
            finally
            {
                connection.Close();
            }
        }

        private void Hover_lbl(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            lbl.Font = new Font("Microsoft Sans Serif", 14f);
        }

        private void MouseLeave_lbl(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            lbl.Font = new Font("Microsoft Sans Serif", 12f);
        }
    }
}
