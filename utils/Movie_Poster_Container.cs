using Movie_Database.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database.utils
{
    public static class Movie_Poster_Container
    {
        public static Image[] Posters = { 
            Properties.Resources.the_godfather,
            Properties.Resources.The_Shawshank_Redemption,
            Properties.Resources.The_Dark_Knight,
            Properties.Resources.Pulp_Fiction,
            Properties.Resources.The_Lord_of_the_Rings,
            Properties.Resources.Forest_Gump,
            Properties.Resources.Fight_Club,
            Properties.Resources.Star_Wars,
            Properties.Resources.Inception,
            Properties.Resources.The_Matrix,
            Properties.Resources.The_Silence_of_the_Lambs,
            Properties.Resources.The_Departed,
            Properties.Resources.The_Social_Network,
            Properties.Resources.Interstellar,
            Properties.Resources.The_Lion_King,
            Properties.Resources.Jurassic_Park,
            Properties.Resources.The_Exorcist,
            Properties.Resources.Gone_with_the_Wind,
            Properties.Resources.The_Godfather_2,
            Properties.Resources.The_Green_Mile
        };

        private static List<Movie> _movies = new List<Movie>();
        public static List<Movie> movies { get => _movies; set { _movies = value; } }
    }
}
