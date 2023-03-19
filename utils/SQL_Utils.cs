using Movie_Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void ConfigureCurrentUser(string username)
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
    }
}
