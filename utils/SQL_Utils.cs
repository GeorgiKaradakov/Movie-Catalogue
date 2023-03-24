using Movie_Database.Models;
using Movie_Database.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database
{
    public static class SQL_Utils
    {
        public static string connection_string = @"Data Source=DESKTOP-TC70G50;Initial Catalog=Movie_Database;Integrated Security=True";
        
        public static void insert_into_table(string insert_query)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(insert_query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool does_user_exists(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter($"SELECT username, password FROM users WHERE username = '{username}' AND password = '{password}';", connection))
                {
                    DataTable dt = new DataTable(); 
                    sda.Fill(dt);

                    return dt.Rows.Count > 0;
                }
            }
        }

        public static void configure_current_user(string username)
        {
            User _out = null;

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"SELECT first_name, last_name, email, username FROM users WHERE username = '{username}';";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                string[] data = new string[reader.FieldCount];

                while (reader.Read())
                {
                    _out = new User(
                            reader["first_name"].ToString(),
                            reader["last_name"].ToString(),
                            reader["email"].ToString(),
                            reader["username"].ToString()
                        );
                }
            }
        }

        public static List<Movie> get_all_movies(bool filter = false, string filter_str = "")
        {
            List<Movie> movies = new List<Movie>();

            using(SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT * FROM movies";

                if (filter)
                {
                    query += $" ORDER BY {filter_str};";
                }

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) {
                    movies.Add(new Movie(
                            int.Parse(reader["id"].ToString()),
                            reader["title"].ToString(),
                            reader["director"].ToString(),
                            reader["year_of_release"].ToString(),
                            reader["genre"].ToString(),
                            reader["summary"].ToString()
                        ));
                }
            }

            return movies;
        }

        public static List<string> get_actors_names(int movie_id)
        {
            List<string> actors_names = new List<string>();

            using(SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"SELECT a.first_name, a.last_name FROM actors AS a WHERE a.movie_id = {movie_id};";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    actors_names.Add(
                            string.Concat(reader["first_name"].ToString(), " ", reader["last_name"].ToString())
                        );
                }
            }

            return actors_names;
        }

        public static List<actor> get_cast(string title)
        {
            if(!Data_Container.movies.Any(x => Utils.compare_movies_names(x.Title, title)))
            {
                return null;
            }

            List<actor> actors = new List<actor>();

            using(SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"SELECT a.id, ai.name, ai.birthdate, a.place_of_birth, ai.bio FROM movies as m left join actors as a on m.id = a.movie_id left join actors_info as ai on ai.id = a.id where m.title = '{title}';"; 
                connection.Open();
                SqlCommand command = new SqlCommand (query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) {
                    actors.Add(
                            new actor(
                                int.Parse(reader["id"].ToString()),
                                reader["name"].ToString(),
                                reader["birthdate"].ToString(),
                                reader["place_of_birth"].ToString(),
                                reader["bio"].ToString()
                            )
                        );
                }
            }

            return actors;
        }
    }
}
