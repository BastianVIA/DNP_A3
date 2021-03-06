using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1.Networking;
using Entities;

namespace A1.Models.Impl
{
    public class UserService : IUserService {
        private IList<User> users;
        private IClient _client = new Client();

        public UserService() {
            users = _client.GetUsers().Result;
        }
        
        public async Task<User> ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public async Task RegisterUser(User user)
        {
            await _client.RegisterUser(user);
        }
    }
}