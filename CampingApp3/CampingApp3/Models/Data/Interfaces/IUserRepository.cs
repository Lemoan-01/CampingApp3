using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Interfaces
{
    public interface IUserRepository
    {
        string GetEmail(int userID);

        void Register(string email, int phoneNumber, string password);

        bool LoginVerification(string email, string password);
    }
}
