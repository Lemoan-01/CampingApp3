using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Repositories
{
    public interface IUserRepository
    {
        string GetEmail(int userID);
    }
}
