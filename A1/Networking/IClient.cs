using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace A1.Networking
{
    public interface IClient
    {
        Task<IList<Adult>> GetAdults();
        Task<IList<User>> GetUsers();
        Task AddAdult(Adult adult);
        Task RemoveAdult(Adult adult);
        Task RegisterUser(User user);
    }
}