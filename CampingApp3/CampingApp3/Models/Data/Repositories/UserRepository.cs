using CampingApp3.Models.Data;
using MySqlConnector;
using Homepage.ViewModels;
using System.Windows;
using System;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IDatabaseConnection _dbConnection;

    public UserRepository(IDatabaseConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public string GetEmail(int userID)
    {
        string email = null;

        try
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                connection.Open();
                string query = "SELECT email FROM user WHERE userID = @userID;";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader["email"].ToString();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return email;
    }

    public bool Register(string email, int phoneNumber, string password)
    {
        string query = "INSERT INTO user (email, phoneNumber, password) VALUES (@Email, @PhoneNumber, SHA2(@Password, 256))";

        try
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters for email, phone number, and password
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Return true if one row was affected (indicating successful insertion)
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while registering: " + ex.Message);
            return false; // Return false if an exception occurs
        }
    }


    public int LoginVerification(string email, string password)
    {
        string loginQuery = "SELECT userID FROM user WHERE email = @Email AND password = SHA2(@Password, 256)";
        int userID = -1;

        try
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(loginQuery, connection))
                {
                    // Add parameters for email and password
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the command and read the result
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if a matching user was found
                        {
                            userID = reader.GetInt32(0); // Get the userID from the first column
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred during login: " + ex.Message);
            throw;
        }

        return userID; // Return the userID, or -1 if no user was found
    }

    public bool IsAdmin(int userID)
    {
        string adminQuery = "SELECT isAdmin FROM user WHERE userID = @userID";
        bool isAdmin = false;

        try
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(adminQuery, connection))
                {
                    // Add the parameter for userID
                    command.Parameters.AddWithValue("@userID", userID);

                    // Execute the command and read the result
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Check if a result was found
                        {
                            isAdmin = reader.GetBoolean(0); // Get the isAdmin value from the first column
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while checking admin status: " + ex.Message);
            throw;
        }

        return isAdmin; // Return whether the user is an admin or not
    }

}
