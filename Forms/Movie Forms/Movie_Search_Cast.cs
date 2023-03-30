using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Database.Forms
{
    public partial class Movie_Search_Cast : Form, BaseForm
    {
        public Form ParentForm { get; set; }

        public Movie_Search_Cast()
        {
            InitializeComponent();
        }

        private void search_click(object sender, EventArgs e)
        {
            string title = title_txt.Text;
            var actors = SQL_Utils.get_cast(title);

            if (actors is null)
            {
                MessageBox.Show("Cannot find movie make sure to put the right title!");
                return;
            }

            title_txt.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            PictureBox image = new PictureBox(), image_prev = image;
            Label text = new Label(), text_prev = text;
            Label line = new Label(), line_prev = line;

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
                text.BackColor = Color.Black;
                text.ForeColor = Color.White;
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
                line.BackColor = Color.Black;
                line.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

                this.Controls.Add(image);
                this.Controls.Add(text);
                this.Controls.Add(line);

                image_prev = image;
                line_prev = line;
                text_prev = text;

                first = false;
            }
        }

        private void return_click(object sender, EventArgs e)
        {
            this.Close();
            this.ParentForm.Show();
        }

        private void reload_click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                var control = this.Controls[i];

                if (control.GetType().Name == "TextBox" ||
                    control.GetType().Name == "Button" ||
                    (control.GetType().Name == "Label"))
                {
                    if (control.GetType().Name == "Label")
                    {
                        var lbl = control as Label;
                        if (lbl.Tag != null && lbl.Tag.ToString() == "no_delete")
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                this.Controls.Remove(control);
                i--;
            }

            title_txt.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            title_txt.TabIndex = 0;
            title_txt.Focus();
            title_txt.SelectAll();
        }
    }
}
