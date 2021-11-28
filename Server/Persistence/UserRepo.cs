using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Server.Persistence
{
    public class UserRepo : IUserRepo
    {
        public void RegisterUser(User user)
        {
            using A3DbContext dbContext = new A3DbContext();

            dbContext.Users.Add(user);
            dbContext.SaveChangesAsync();
        }

        public IList<User> GetUsers()
        {
            using A3DbContext dbContext = new A3DbContext();

            return dbContext.Users.ToList();
        }
    }
}