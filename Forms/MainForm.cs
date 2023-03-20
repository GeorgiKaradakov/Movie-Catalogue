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

        private void open_details(object sender, EventArgs e)
        {
            this.Hide();
            UserDetails ud = new UserDetails();
            ud.ParentForm = this;
            ud.StartPosition = FormStartPosition.CenterScreen;
            ud.Show();
        }

        private void open_movie_form(object sender, EventArgs e)
        {
            Movies movies_f = new Movies();
            movies_f.ParentForm = this;
            movies_f.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            movies_f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Movie_Poster_Container.movies = SQL_Utils.get_all_movies();
        }
    }
}
