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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Movie_Poster_Container.movies = SQL_Utils.get_all_movies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDetails ud = new UserDetails();
            ud.ParentForm = this;
            ud.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            ud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Movie_main mm = new Movie_main();
            mm.ParentForm = this;
            mm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            mm.Show();
        }
    }
}
