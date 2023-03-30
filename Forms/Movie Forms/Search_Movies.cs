using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Movie_Database.Forms
{
    public partial class Search_Movies : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        private PictureBox poster;
        private Label text;

        public Search_Movies()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void Search(object sender, EventArgs e)
        {
            string title = title_txt.Text;

            var movie = find_movie(title);

            if (movie is null)
            {
                MessageBox.Show($"Cannot find movie with title = {title}!\nPlease make sure that you typed it correctly.");
                return;
            }

            poster = new PictureBox();
            poster.Size = new Size(168, 235);
            poster.Location = new Point(49, 59);
            poster.SizeMode = PictureBoxSizeMode.StretchImage;
            poster.Image = utils.Data_Container.Posters[movie.Id - 1];

            text = new Label();
            text.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            text.TextAlign = ContentAlignment.TopLeft;
            text.AutoSize = false;
            text.Size = new Size(567, 235);
            text.Location = new Point(233, 69);
            text.BackColor = Color.Black;
            text.ForeColor = Color.White;

            string movie_resume = movie.ToString();
            movie_resume += $"\n\nCast: {string.Join(", ", SQL_Utils.get_actors_names(movie.Id))}";

            text.Text = movie_resume;

            this.Controls.Add(poster);
            this.Controls.Add(text);

            title_txt.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
        }

        private Movie find_movie(string title)
        {
            var movies = Data_Container.movies;

            if (!movies.Any(x => Utils.compare_movies_names(title, x.Title))) return null;

            return movies.FirstOrDefault(x => Utils.compare_movies_names(title, x.Title));
        }

        private void Reload_search(object sender, EventArgs e)
        {
            if (poster is null || text is null) return;

            title_txt.Visible = true;
            label1.Visible = true;
            button1.Visible = true;

            this.Controls.Remove(poster);
            this.Controls.Remove(text);

            title_txt.Focus();
            title_txt.SelectAll();
        }
    }
}
