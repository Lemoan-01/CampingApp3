using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data
{
    public interface IDatabaseConnection
    {
        MySqlConnection CreateConnection();

        void ExecuteNonQuery(string query, params MySqlParameter[]? parameters);

        DataTable ExecuteQuery(string query, params MySqlParameter[]? parameters);
    }
}