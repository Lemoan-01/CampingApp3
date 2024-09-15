using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CampingApp3.Models.Data.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly string _connectionString;

        public ReservationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertReservation(int placeID, DateTime? dateStart, DateTime? dateEnd, int aantalPersonen, int userID, bool isBlock)
        {
            // Ensure dates are not null
            if (dateStart == null)
            {
                MessageBox.Show("Please select a valid start date.");
                return;
            }
            if (dateEnd == null)
            {
                MessageBox.Show("Please select a valid end date.");
                return;
            }

            // Convert nullable DateTime to non-nullable DateTime for database insertion
            DateTime startDate = dateStart.Value;
            DateTime endDate = dateEnd.Value;

            string query = "INSERT INTO reservations (placeID, startDate, endDate, personAmount, userID, isBlock) VALUES (@placeID, @startDate, @endDate, @personAmount, @userID, @isBlock)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@placeID", placeID);
                        cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@personAmount", aantalPersonen);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@isBlock", isBlock ? 1 : 0); // Correct conversion

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void DeleteReservation(int reservationID)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    //Reservation deleting query
                    string ReserveringDeleteQuery = "DELETE FROM reservations WHERE reservationID = @reservationID;";

                    //configuring the parameters
                    using (var command = new MySqlCommand(ReserveringDeleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@reservationID", reservationID);

                        //execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Reservation deleted!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
        }

        public void DeleteReservation(int userID, int placeID, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    //Reservation deleting query
                    string ReserveringDeleteQuery = "DELETE FROM reservations WHERE userID = @userID AND placeID = @placeID AND startDate = @startDate AND endDate = @endDate;";

                    //configuring the parameters
                    using (var command = new MySqlCommand(ReserveringDeleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@placeID", placeID);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        //execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public List<int> GetReservationsByUserID(int userID)
        {
            List<int> reservationIDs = new List<int>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT reservationID FROM reservations WHERE userID = @userID AND startDate > @currDate;";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@currDate", DateTime.Now);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int reservationID = reader.GetInt32("reservationID");
                                reservationIDs.Add(reservationID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message} ");
            }

            return reservationIDs;
        }

        public List<int> GetPlaceIDsByUserID(int userID)
        {
            List<int> placeIDs = new List<int>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT placeID FROM reservations WHERE userID = @userID;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int placeID = reader.GetInt32("placeID");

                            placeIDs.Add(placeID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return placeIDs;
        }

        public int GetPlaceIDByReservationID(int reservationID)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    //Reservation deleting query
                    string ReserveringDeleteQuery = "SELECT placeID FROM reservations WHERE reservationID = @reservationID ";

                    //configuring the parameters
                    using (var command = new MySqlCommand(ReserveringDeleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@reservationID", reservationID);

                        // Execute the query and return the result
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert it to an integer
                        if (result != null && int.TryParse(result.ToString(), out int placeID))
                        {
                            return placeID;
                        }
                        else
                        {
                            // Return a default value or throw an exception based on your application logic
                            return -1; // or throw new Exception("Invalid placeID"); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
                return -1; // Return a default value in case of an exception
            }
        }

        public bool isAvailable(int placeID, DateTime startDate, DateTime endDate)
        {
            DateTime currDate = DateTime.Now;
            string query = @" SELECT COUNT(*) FROM reservations 
                              WHERE placeID = @placeID
                              AND @endDate > startDate
                              AND @startDate < endDate";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@placeID", placeID);
                        cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@currDate", currDate.ToString("yyyy-MM-dd HH:mm:ss"));

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
