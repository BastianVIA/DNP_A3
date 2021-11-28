using System.Collections.Generic;
using Entities;

namespace Server.Persistence
{
    public interface IUserRepo
    {
        void RegisterUser(User user);
        IList<User> GetUsers();
    }
}