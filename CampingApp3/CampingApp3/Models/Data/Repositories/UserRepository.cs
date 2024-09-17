using System;
using System.Data;
using MySqlConnector;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Data;

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
            string query = "SELECT email FROM user WHERE userID = @userID;";
            var parameters = new[]
            {
                new MySqlParameter("@userID", userID)
            };

            DataTable dataTable = _dbConnection.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                email = dataTable.Rows[0]["email"].ToString();
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
        var parameters = new[]
        {
            new MySqlParameter("@email", email),
            new MySqlParameter("@phoneNumber", phoneNumber),
            new MySqlParameter("@password", password)
        };

        try
        {
            _dbConnection.ExecuteNonQuery(query, parameters);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while registering: " + ex.Message);
            throw;
        }
    }

    public bool LoginVerification(string email, string password)
    {
        string loginQuery = "SELECT COUNT(*) FROM user WHERE email = @Email AND password = SHA2(@Password, 256)";
        var parameters = new[]
        {
            new MySqlParameter("@Email", email),
            new MySqlParameter("@Password", password)
        };

        try
        {
            DataTable resultTable = _dbConnection.ExecuteQuery(loginQuery, parameters);

            // Check the count from the result
            if (resultTable.Rows.Count > 0)
            {
                int count = Convert.ToInt32(resultTable.Rows[0][0]);
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred during login: " + ex.Message);
            throw;
        }

        return false;
    }
}
