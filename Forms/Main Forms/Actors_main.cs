using Movie_Database.Forms.Actor_Forms;
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
    public partial class Actors_main : Form, BaseForm
    {
        public new Form ParentForm { get; set; }

        public Actors_main()
        {
            InitializeComponent();
        }

        private void return_to_main(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Actors_Show aas = new All_Actors_Show();
            aas.ParentForm = this;
            aas.StartPosition = FormStartPosition.CenterScreen;
            aas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Actor sa = new Search_Actor();
            sa.ParentForm = this;
            sa.StartPosition = FormStartPosition.CenterScreen;
            sa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actor_In_Movies aim = new Actor_In_Movies();
            aim.ParentForm = this;
            aim.StartPosition = FormStartPosition.CenterScreen;
            aim.Show();
        }
    }
}
