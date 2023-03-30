using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Movie_Database.Forms.Actor_Forms
{
    public partial class All_Actors_Show : Form, BaseForm
    {
        public new Form ParentForm { get; set; }

        private PictureBox image = new PictureBox();
        private Label text = new Label();
        private Label line = new Label();

        public All_Actors_Show()
        {
            InitializeComponent();
        }

        private void All_Actors_Show_Load(object sender, EventArgs e)
        {
            generate_actors_layout(SQL_Utils.get_all_actors());
        }

        private void filter_changed(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].GetType().Name == "ComboBox")
                {
                    continue;
                }

                this.Controls.Remove(this.Controls[i]);
                i--;
            }

            var splitted_filter = filter.Text.Split(' ').ToArray();

            if (splitted_filter.Length > 2)
            {
                generate_actors_layout(
                        SQL_Utils.get_all_actors(true, splitted_filter[2])
                );
            }
            else
            {
                generate_actors_layout(SQL_Utils.get_all_actors());
            }
        }

        private void generate_actors_layout(List<actor> actors)
        {
            image = new PictureBox();
            PictureBox image_prev = image;

            text = new Label();
            Label text_prev = text;

            line = new Label();
            Label line_prev = line;

            bool first = true;
            foreach (var actor in actors)
            {
                image = new PictureBox();
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                image.Size = new Size(168, 235);
                if (first)
                {
                    image.Location = new Point(49, 59);
                }
                else
                {
                    image.Location = new Point(image_prev.Location.X, line_prev.Location.Y + line_prev.Height + 30);
                }
                image.Image = Data_Container.Actors[actor.ID - 1];

                text = new Label();
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
                    text.Location = new Point(image.Location.X + image.Width + 5, image.Location.Y + 10);

                }
                text.Text = actor.ToString();

                line = new Label();
                line.AutoSize = false;
                line.Size = new Size(713, 10);
                if (first)
                {
                    line.Location = new Point(46, 331);
                }
                else
                {
                    line.Location = new Point(image.Location.X, image.Location.Y + image.Height + 30);
                }
                line.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

                this.Controls.Add(image);
                this.Controls.Add(text);
                this.Controls.Add(line);

                image_prev = image;
                line_prev = line;
                text_prev = text;

                first = false;
            }

            generate_return_button();
        }

        private void generate_return_button()
        {
            Button @return = new Button();
            @return.Size = new Size(180, 33);
            @return.Font = new Font("Microsoft Sans Serif", 12);
            @return.Location = new Point(this.ClientSize.Width / 2 - @return.Width / 2, line.Location.Y + 20);
            @return.Click += new EventHandler(return_main_form);
            @return.Text = "Return to actors form";
            @return.TabStop = false;

            this.Controls.Add(@return);
        }

        private void return_main_form(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
