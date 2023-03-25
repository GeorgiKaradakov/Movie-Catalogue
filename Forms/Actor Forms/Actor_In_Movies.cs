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

namespace Movie_Database.Forms.Actor_Forms
{
    public partial class Actor_In_Movies : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public Actor_In_Movies()
        {
            InitializeComponent();
        }

        private void search_click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            var movies = SQL_Utils.get_movies_actor_plays_in(name);

            PictureBox prev = new PictureBox();
            Label text_prev = new Label();
            Label line_prev = new Label();
            bool first = true;
            foreach (var movie in movies)
            {
                PictureBox icon = new PictureBox();
                icon.SizeMode = PictureBoxSizeMode.StretchImage;
                icon.Size = new Size(168, 235);
                if (first)
                {
                    icon.Location = new Point(49, 59);
                }
                else
                {
                    icon.Location = new Point(prev.Location.X, line_prev.Location.Y + line_prev.Height + 30);
                }
                icon.Image = utils.Data_Container.Posters[movie.Id - 1];

                Label text = new Label();
                text.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                text.TextAlign = ContentAlignment.TopLeft;
                text.AutoSize = false;
                text.Size = new Size(567, 235);
                if (first)
                {
                    text.Location = new Point(233, 69);
                }
                else
                {
                    text.Location = new Point(icon.Location.X + icon.Width + 5, icon.Location.Y + 10);

                }
                text.Text = movie.ToString();

                Label line = new Label();
                line.AutoSize = false;
                line.Size = new Size(713, 10);
                if (first)
                {
                    line.Location = new Point(46, 331);
                }
                else
                {
                    line.Location = new Point(icon.Location.X, icon.Location.Y + icon.Height + 30);
                }
                line.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

                this.Controls.Add(icon);
                this.Controls.Add(text);
                this.Controls.Add(line);

                prev = icon;
                line_prev = line;
                text_prev = text;

                first = false;
            }

            button1.Visible = false;
            button2.Visible = false;
            name_txt.Visible = false;
            label2.Visible = false;
        }

        private void return_to_main(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void reload_click(object sender, EventArgs e)
        {
            for(int i = 0; i <  this.Controls.Count; i++)
            {
                var control = this.Controls[i];

                if(control.GetType().Name == "PictureBox" ||
                    (control.GetType().Name == "Label" && ((Label)control).Tag is null))
                {
                    this.Controls.Remove(this.Controls[i]);
                    i--;
                }
            }

            button1.Visible = true;
            button2.Visible = true;
            name_txt.Visible = true;
            label2.Visible = true;
        }
    }
}
