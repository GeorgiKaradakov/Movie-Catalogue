using Movie_Database.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Movie_Database.utils
{
    public static class Data_Container
    {
        private static List<Movie> _movies = new List<Movie>();

        public static Image[] Actors =
        {
            Properties.Resources.Tom_Hanks,
            Properties.Resources.robin_wright,
            Properties.Resources.Gary_Sinise,
            Properties.Resources.marlon_brandon,
            Properties.Resources.Al_Pacino,
            Properties.Resources.james_caan,
            Properties.Resources.tim_robbins,
            Properties.Resources.Morgan_Freeman,
            Properties.Resources.Bob_Gunton,
            Properties.Resources.Christian_Bale,
            Properties.Resources.heath_ledger,
            Properties.Resources.Aaron_Eckhart,
            Properties.Resources.John_Travolta,
            Properties.Resources.Samuel_L__Jackson,
            Properties.Resources.Uma_Thurman,
            Properties.Resources.Elijah_Wood,
            Properties.Resources.Ian_McKellen,
            Properties.Resources.viggo_mortensen,
            Properties.Resources.Brad_Pitt,
            Properties.Resources.Edward_Norton,
            Properties.Resources.helena_carter,
            Properties.Resources.Mark_Hamill,
            Properties.Resources.Harrison_Ford,
            Properties.Resources.Carrie_Fisher,
            Properties.Resources.Leonardo_DiCaprio,
            Properties.Resources.joseph_levitt,
            Properties.Resources.ellen_page,
            Properties.Resources.Keanu_Reeves,
            Properties.Resources.Carrie_Anne_Moss,
            Properties.Resources.Laurence_Fishburne,
            Properties.Resources.Jodie_Foster,
            Properties.Resources.Anthony_Hopkins,
            Properties.Resources.ted_levine,
            Properties.Resources.Leonardo_DiCaprio,
            Properties.Resources.Matt_Damon,
            Properties.Resources.Jack_Nicholson,
            Properties.Resources.Jesse_Eisenberg,
            Properties.Resources.Andrew_Garfield,
            Properties.Resources.Armie_Hammer,
            Properties.Resources.mathew_macconaughey,
            Properties.Resources.Anne_Hathaway,
            Properties.Resources.Jessica_Chastain,
            Properties.Resources.sam_neil,
            Properties.Resources.Laura_Dern,
            Properties.Resources.Jedd_Goldblum,
            Properties.Resources.Ellen_Burstyn,
            Properties.Resources.max_von_sydow,
            Properties.Resources.Jason_Miller,
            Properties.Resources.Vivien_Leigh,
            Properties.Resources.clark_gable1,
            Properties.Resources.Olivia_de_Havilland,
            Properties.Resources.Tom_Hanks,
            Properties.Resources.Michael_Clarke_Duncan,
            Properties.Resources.David_Morse,
            Properties.Resources.Matthew_Broderick,
            Properties.Resources.Jeremy_Irons,
            Properties.Resources.James_Earl_Jones
        };
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

        public static List<Movie> movies { get => _movies; set { _movies = value; } }
    }
}
