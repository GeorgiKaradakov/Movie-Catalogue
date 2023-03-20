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
    public partial class Movies : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public Movies()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            var movies = Movie_Poster_Container.movies;

            PictureBox prev = new PictureBox();
            Label text_prev = new Label();
            Label line_prev = new Label();
            foreach(var movie in movies)
            {
                PictureBox icon = new PictureBox();
                icon.SizeMode = PictureBoxSizeMode.StretchImage;
                icon.Size = new Size(168, 235);
                if (movie.Id == 1)
                {
                    icon.Location = new Point(49, 59);
                }
                else
                {
                    icon.Location = new Point(prev.Location.X, line_prev.Location.Y + line_prev.Height + 30);
                }
                icon.Image = Movie_Poster_Container.Posters[movie.Id - 1];

                Label text = new Label();
                text.Font = new Font("Microsoft Sans Serif", 12);
                text.TextAlign = ContentAlignment.TopLeft;
                text.AutoSize = false;
                text.Size = new Size(567, 235);
                if (movie.Id == 1)
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
                if(movie.Id == 1)
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
            }

            Button @return = new Button();
            @return.Size = new Size(120, 33);
            @return.Font = new Font("Microsoft Sans Serif", 12);
            @return.Location = new Point(this.ClientSize.Width / 2 - @return.Width / 2, 6126 + 20);
            @return.Click += new EventHandler(return_main_form);
            @return.Text = "Return to main form";
            @return.TabStop = false;

            this.Controls.Add(@return);
        }

        private void return_main_form(object sender, EventArgs e)
        {
            this.ParentForm.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
            this.ParentForm.Show();
        }
    }
}
