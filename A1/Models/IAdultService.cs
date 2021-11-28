using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace A1.Models
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdults();
        Task AddAdult(Adult adult);
        Task RemoveAdult(Adult adult);
    }
}