using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly string _connectionString;

        public PlaceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetDescription(int placeID)
        {
            string description = "You are not connected to the Database";
            string water = "Not Available";
            string electric = "Not Available";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    // Query voor het ophalen van de oppervlakte
                    string querySurface = "SELECT IFNULL(surface, '') AS Surface FROM place WHERE placeID = @plekID;";
                    MySqlCommand commandSurface = new MySqlCommand(querySurface, connection);
                    commandSurface.Parameters.AddWithValue("@plekID", placeID);
                    string surface = commandSurface.ExecuteScalar()?.ToString() ?? "";

                    // Query voor het ophalen van het water
                    string queryWater = "SELECT IFNULL(water, '') AS Water FROM place WHERE placeID = @plekID;";
                    MySqlCommand commandWater = new MySqlCommand(queryWater, connection);
                    commandWater.Parameters.AddWithValue("@plekID", placeID);
                    if ((commandWater.ExecuteScalar()?.ToString()) == "0")
                    {
                        water = "Not Available";
                    }
                    else
                    {
                        water = "Available";
                    }

                    // Query voor het ophalen van de elektriciteit
                    string queryElectric = "SELECT IFNULL(electric, '') AS Electric FROM place WHERE placeID = @plekID;";
                    MySqlCommand commandElectric = new MySqlCommand(queryElectric, connection);
                    commandElectric.Parameters.AddWithValue("@plekID", placeID);
                    if ((commandElectric.ExecuteScalar()?.ToString()) == "0")
                    {
                        electric = "Not Available";
                    }
                    else
                    {
                        electric = "Available";
                    }

                    // Query voor het ophalen van de prijs
                    string queryPrice = "SELECT IFNULL(price, '') AS Price FROM place WHERE placeID = @plekID;";
                    MySqlCommand commandPrice = new MySqlCommand(queryPrice, connection);
                    commandPrice.Parameters.AddWithValue("@plekID", placeID);
                    string price = commandPrice.ExecuteScalar()?.ToString() ?? "";

                    // Voeg de attributen samen tot één string
                    description = $"Surface: {surface}m²\n" +
                                   $"Water: {water}\n" +
                                   $"Electricity: {electric}\n" +
                                   $"Price: €{price},- /day";
                }
            }
            catch (Exception ex)
            {
                description = "You are not connected to the database";
                Console.WriteLine("Error retrieving the description: " + ex.Message);
            }
            return description;
        }

        public bool IsBlockedOnID(int placeID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT isBlocked FROM place WHERE placeID = " + placeID + ";";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Haal de bitgegevens op
                        bool isBlockedOnID = reader.GetBoolean("isBlocked");

                        return isBlockedOnID;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }

        public byte[] GetImageFromDatabase(int placeID)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT images FROM place WHERE PlaceID = @PlaceID";

                    using (var command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@PlaceID", placeID);

                        using (var reader = command.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                // Assuming the images column is of type BLOB
                                return reader["images"] as byte[];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null;
        }
    }
}
