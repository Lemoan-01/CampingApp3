using CampingApp3.Models.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Services
{
    public class UserService 
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetEmail(int UserID)
        {
            return _userRepository.GetEmail(UserID);
        }

        public void Register(string email, int phoneNumber, string password)
        {
            _userRepository.Register(email, phoneNumber, password);
        }

        public bool LoginVerification(string email, string password)
        {
            return _userRepository.LoginVerificatoin(email, password);
        }
    }
}
