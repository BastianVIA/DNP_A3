using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Server.Persistence
{
    public interface IAdultRepo
    {
        void AddAdult(Adult adult);
        IList<Adult> GetAdults();
        void RemoveAdult(Adult adult);
    }
}