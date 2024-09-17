using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Data.Repositories;
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

        public bool Register(string email, int phoneNumber, string password)
        {
            return _userRepository.Register(email, phoneNumber, password);
        }

        public int LoginVerification(string email, string password)
        {
            return _userRepository.LoginVerification(email, password);
        }

        public bool IsAdmin(int UserID)
        {
            return _userRepository.IsAdmin(UserID);
        }
    }
}