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

        int LoginVerification(string email, string password);

        bool IsAdmin(int userID);

        bool Register(string email, int phoneNumber, string password);
    }
}
