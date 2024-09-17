using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace CampingApp3.Models.Data
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private static readonly string ConnectionString = "Server=localhost;Port=3306;Database=CampingDB;Uid=kbs;Pwd=camping;";



        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public void ExecuteNonQuery(string query, params MySqlParameter[]? parameters)
        {
            using (var connection = CreateConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        HandleException(ex);
                    }
                }
            }
        }

        public DataTable ExecuteQuery(string query, params MySqlParameter[]? parameters)
        {
            var dataTable = new DataTable();

            using (var connection = CreateConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        HandleException(ex);
                    }
                }
            }

            return dataTable;
        }

        private void HandleException(Exception ex)
        {
            // Log the exception or handle it as required
            // For now, simply rethrow the exception
            throw new ApplicationException("An error occurred while accessing the database.", ex);
        }
    }
}