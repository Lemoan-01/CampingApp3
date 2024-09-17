using CampingApp3.Models.Data;
using MySqlConnector;
using Homepage.ViewModels;
using System.Windows;
using System;
using CampingApp3.Models.Data.Interfaces;

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

    public void Register(string email, int phoneNumber, string password)
    {
        string query = "INSERT INTO user (email, phoneNumber, password) VALUES (@email, @phoneNumber, SHA2(@password, 256))";

        try
        {
            using (var connection = _dbConnection.CreateConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while registering: " + ex.Message);
            throw;
        }
    }

    public bool LoginVerificatoin(string email, string password)
    {
        string loginQuery = "SELECT COUNT(*) FROM user WHERE email = @Email AND password = SHA2(@Password, 256)";

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

                    // Execute scalar to check if a matching user exists
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Return true if a user was found, otherwise false
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred during login: " + ex.Message);
            throw;
        }

    }

}