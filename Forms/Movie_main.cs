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
    public partial class Movie_main : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public Movie_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movies m = new Movies();
            m.ParentForm = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Movies sm = new Search_Movies();
            sm.ParentForm = this;
            sm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            sm.Show();
        }
    }
}
