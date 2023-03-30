using Movie_Database.Models;
using Movie_Database.utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = "SELECT * FROM movies";

                if (filter)
                {
                    query += $" ORDER BY {filter_str};";
                }

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
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

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"SELECT a.first_name, a.last_name FROM actors AS a WHERE a.movie_id = {movie_id};";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
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
            if (!Data_Container.movies.Any(x => Utils.compare_movies_names(x.Title, title)))
            {
                return null;
            }

            List<actor> actors = new List<actor>();

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"SELECT a.id, ai.name, ai.birthdate, a.place_of_birth, ai.bio FROM movies as m left join actors as a on m.id = a.movie_id left join actors_info as ai on ai.id = a.id where m.title = '{title}';";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
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

        public static List<actor> get_all_actors(bool filtered = false, string filter_string = "")
        {
            List<actor> actors = new List<actor>();
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                string query = $"use Movie_Database select a.id, a.first_name, a.last_name, a.date_of_birth, a.place_of_birth, af.bio from actors as a left join actors_info as af on af.id = a.id";

                if (filtered)
                {
                    if (filter_string == "name")
                    {
                        query += " order by a.first_name, a.last_name;";
                    }
                    else
                    {
                        query += $" order by a.{filter_string};";
                    }
                }

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = string.Concat(reader["first_name"].ToString(), " ", reader["last_name"].ToString());

                    if (actors.Any(x => string.Concat(x.First_name, " ", x.Last_name) == name)) continue;

                    actors.Add(
                            new actor(
                                    int.Parse(reader["id"].ToString()),
                                    name,
                                    reader["date_of_birth"].ToString(),
                                    reader["place_of_birth"].ToString(),
                                    reader["bio"].ToString()
                                )
                        );
                }
            }

            return actors;
        }

        public static List<Movie> get_movies_actor_plays_in(string name)
        {
            List<Movie> movies = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                var all_actors = SQL_Utils.get_all_actors();

                var actor = all_actors.FirstOrDefault(x => Utils.compare_actors_names(string.Concat(x.First_name, " ", x.Last_name), name));

                if (actor is null) return null;

                string query = $"use Movie_Database select m.* from actors as a left join movies as m on m.id = a.movie_id Where first_name = '{actor.First_name}' and last_name = '{actor.Last_name}'";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    movies.Add(
                            new Movie(
                                int.Parse(reader["id"].ToString()),
                                reader["title"].ToString(),
                                reader["director"].ToString(),
                                reader["year_of_release"].ToString(),
                                reader["genre"].ToString(),
                                reader["summary"].ToString()
                                )
                        );
                }
            }

            return movies;
        }
    }
}
