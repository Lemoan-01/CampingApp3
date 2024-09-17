using System;
using System.Collections.Generic;
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
    }
}
