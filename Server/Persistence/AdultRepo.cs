using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Persistence
{
    public class AdultRepo : IAdultRepo
    {
        public void AddAdult(Adult adult)
        {
            using A3DbContext dbContext = new A3DbContext();

            dbContext.Adults.Add(adult);
            dbContext.SaveChangesAsync();

        }

        public IList<Adult> GetAdults()
        {
            using A3DbContext dbContext = new A3DbContext();

            return dbContext.Adults.Include(adult => adult.JobTitle).ToList();
        }

        public void RemoveAdult(Adult adult)
        {
            using A3DbContext dbContext = new A3DbContext();

            dbContext.Adults.Remove(adult);
            dbContext.SaveChangesAsync();
        }
    }
}