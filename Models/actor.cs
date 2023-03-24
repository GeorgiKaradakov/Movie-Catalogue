using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database.Models
{
    public class actor
    {
        private const int COUNT_OF_SYMBOLS_PER_LINE = 52;

        public int ID { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Date_of_birth { get; set; }
        public string Place_of_birth { get; set; }
        public int Movie_id { get; set; }
        public string bio { get; set; }

        public actor(int iD, string first_name, string last_name, string date_of_birth, string place_of_birth, int movie_id)
        {
            ID = iD;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            Place_of_birth = place_of_birth;
            Movie_id = movie_id;
        }

        public actor(int id, string name, string date_of_birth, string place_of_birth, string bio)
        {
            this.ID = id;
            var names = name.Split(' ');
            this.First_name = names[0];
            this.Last_name = string.Join(" ", names.Skip(1).ToArray());
            this.Date_of_birth = date_of_birth;
            this.Place_of_birth = place_of_birth;
            this.bio = bio;
        }

        public override string ToString()
        {
            string _bio = "";
            bool is_time = false;
            int count = 0;
            for (int i = 0; i < this.bio.Length; i++)
            {
                _bio += this.bio[i];

                if (count == COUNT_OF_SYMBOLS_PER_LINE) is_time = true;

                if (is_time && this.bio[i] == ' ')
                {
                    _bio += "\n  ";
                    count = 0;
                    is_time = false;
                }

                count++;
            }

            return $"Name: {string.Concat(this.First_name, " ", this.Last_name)}\n" +
                   $"Born: {this.Date_of_birth}\n" +
                   $"From: {this.Place_of_birth}\n\n" +
                   $"   About: {_bio}";
        }
    }
}