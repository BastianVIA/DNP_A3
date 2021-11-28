using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using A1.Networking;
using Entities;

namespace A1.Models.Impl
{
    public class AdultService : IAdultService
    {
        private IClient _client = new Client();
        
        public async Task<IList<Adult>> GetAdults()
        {
            return await _client.GetAdults();
        }

        public async Task AddAdult(Adult adult)
        {
            await _client.AddAdult(adult);
        }

        public async Task RemoveAdult(Adult adult)
        {
            await _client.RemoveAdult(adult);
        }
    }
}