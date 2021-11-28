using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using Entities;

namespace A1.Networking
{
    public class Client : IClient
    {
        private string uri = "https://localhost:5003/";

        public async Task<IList<Adult>> GetAdults()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "Adult");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<Adult> adultList = JsonSerializer.Deserialize<IList<Adult>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return adultList;
        }

        public async Task<IList<User>> GetUsers()
        {
            using HttpClient client = new HttpClient();
           
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "User");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<User> userList = JsonSerializer.Deserialize<IList<User>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine(userList);
            return userList;
        }

        public async Task AddAdult(Adult adult)
        {
            using HttpClient client = new HttpClient();
            
            string adultListAsJson = JsonSerializer.Serialize(adult);

            StringContent content = new StringContent(adultListAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri + "Adult", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
        
        public async Task RemoveAdult(Adult adult)
        {
            using HttpClient client = new HttpClient();
            Console.WriteLine("Id of adult: " + adult.Id);
            HttpResponseMessage responseMessage = await client.DeleteAsync(uri + $"Adult?Id={adult.Id}");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }

        public async Task RegisterUser(User user)
        {
            using HttpClient client = new HttpClient();
            
            string userAsJson = JsonSerializer.Serialize(user);

            StringContent content = new StringContent(userAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri + "User", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
    }
}