using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database.Forms.Actor_Forms
{
    public partial class Search_Actor : Form, BaseForm
    {
        public new Form ParentForm { get; set; }

        private List<actor> actors = SQL_Utils.get_all_actors();
        private PictureBox image = new PictureBox();
        private Label text = new Label();

        public Search_Actor()
        {
            InitializeComponent();
        }


        private void return_main_menu(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void search_click(object sender, EventArgs e)
        {
            string name = title_txt.Text;

            actor actor = null;

            if((actor = find_actor(name)) is null)
            {
                MessageBox.Show("This name is incorrect. Please make sure you type it correct.");
                return;
            }

            image = new PictureBox();
            image.Size = new Size(168, 235);
            image.Location = new Point(49, 59);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Image = utils.Data_Container.Actors[actor.ID - 1];

            text = new Label();
            text.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            text.TextAlign = ContentAlignment.TopLeft;
            text.AutoSize = false;
            text.Size = new Size(567, 235);
            text.Location = new Point(233, 69);

            string actor_resume = actor.ToString();

            text.BackColor = Color.Black;
            text.ForeColor = Color.White;
            text.Text = actor_resume;

            this.Controls.Add(image);
            this.Controls.Add(text);

            title_txt.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
        }

        private void reload_click(object sender, EventArgs e)
        {
            this.Controls.Remove(image);
            this.Controls.Remove(text);

            title_txt.Visible = true;
            label1.Visible = true;
            button1.Visible = true;

            title_txt.Focus();
            title_txt.SelectAll();
        }

        private actor find_actor(string name)
            => actors.FirstOrDefault(x => Utils.compare_actors_names(string.Concat(x.First_name, " ", x.Last_name), name));
        
    }
}
