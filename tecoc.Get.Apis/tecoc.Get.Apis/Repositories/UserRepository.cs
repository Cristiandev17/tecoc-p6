using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Tecoc.Get.Apis.Models;
using Tecoc.Get.Apis.Repositories.interfaces;

namespace Tecoc.Get.Apis.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IRestClient _client;

        public UserRepository(IRestClient client)
        {
            _client = client;
        }

        public async Task<List<UserModel>> GetUsers()
        {
            var request = new RestRequest("https://randomuser.me/api/?results=10", Method.Get);

            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                if(response.ResponseStatus == ResponseStatus.Completed)
                {
                    if (!string.IsNullOrEmpty(response.Content) )
                    {
                        var users = JsonSerializer.Deserialize<Response>(response?.Content);
                        return users.Results;
                       

                    }
                    
                }
                

            }
            return new List<UserModel>();
        }
    }
}