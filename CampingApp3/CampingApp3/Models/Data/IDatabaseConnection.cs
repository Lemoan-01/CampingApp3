using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data
{
    public interface IDatabaseConnection
    {
        MySqlConnection CreateConnection();
    }
}
