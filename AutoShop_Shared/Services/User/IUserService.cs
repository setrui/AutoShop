using System;
using System.Collections.Generic;
using System.Text;
using AutoShop_Shared.Models;

namespace AutoShop_Shared.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public List<User> GetUsers(byte level);
        public User GetUser(string id);
    }
}
