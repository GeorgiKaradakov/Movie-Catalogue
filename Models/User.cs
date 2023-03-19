using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database.Models
{
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        public static User current_user;

        public User(string first_name, string last_name, string username, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.username = username;
            this.email = email;

            current_user = this;
        }
    }
}
