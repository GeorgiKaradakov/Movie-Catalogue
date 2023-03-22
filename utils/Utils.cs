using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database.utils
{
    public static class Utils
    {
        public static bool compare_movies_names(string left, string right)
        {
            return string.Compare(left.ToLower(), right.ToLower()) == 0;
        }

        public static bool compare_actors_names(string left, string right)
        {
            string[] names_left = left.Split(' ');
            string[] names_right = right.Split(' ');

            if(names_left.Length == 2 && names_right.Length == 3)
            {
                if (string.Compare(names_left[0].ToLower(), names_right[0].ToLower()) == 0 &&
                    string.Compare(names_left[1].ToLower(), names_right[2].ToLower()) == 0) return true;
            }else if(names_left.Length == 2 && names_right.Length == 2)
            {
                if (string.Compare(names_left[0].ToLower(), names_right[0].ToLower()) == 0 &&
                    string.Compare(names_left[1].ToLower(), names_right[1].ToLower()) == 0) return true;
            }else if(names_left.Length == 3 && names_right.Length == 3)
            {
                if (string.Compare(names_left[0].ToLower(), names_right[0].ToLower()) == 0 &&
                    string.Compare(names_left[2].ToLower(), names_right[2].ToLower()) == 0) return true;
            }else if(names_left.Length == 3 && names_right.Length == 2)
            {
                if (string.Compare(names_left[0].ToLower(), names_right[0].ToLower()) == 0 &&
                    string.Compare(names_left[2].ToLower(), names_right[1].ToLower()) == 0) return true;
            }

            return false;
        }
    }
}
