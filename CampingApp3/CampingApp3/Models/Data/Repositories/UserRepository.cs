using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public string GetEmail(int userID)
        {
            string _email = null; // Initialiseer _email om compilerfouten te voorkomen

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT email FROM user WHERE userID = @userID;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Controleer of er resultaten zijn
                        {
                            // Haal de email op uit de reader en wijs deze toe aan _email
                            _email = reader["email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return _email;
        }

    }
}
