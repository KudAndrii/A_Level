using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests
{
    using System.Net;
    using Newtonsoft.Json;
    using ReqresRequests.Models;
    using ReqresRequests.Interfaces;
    internal class ReqresClient : IReqresClient
    {
        private readonly HttpClient _client;
        public ReqresClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri("http://reqres.in/");
        }

        public async Task<string> GetUsersListAsync(int page)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/users?page={page}");

            return await CheckCorrectStatusCodeConstruction(response);
        }

        public async Task<string> GetSingleUserAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/users/{id}");

            return await CheckCorrectStatusCodeConstruction(response);
        }

        public async Task<string> GetNotExistingUserAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/users/{id}");

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return "";
            }
            else
            {
                throw new WebException("User who should not have been found was found, somehow.");
            }
        }

        public async Task<string> GetResourseListAsync()
        {
            HttpResponseMessage response = await _client.GetAsync("api/unknown");

            return await CheckCorrectStatusCodeConstruction(response);
        }

        public async Task<string> GetSingleResourseAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/unknown/{id}");

            return await CheckCorrectStatusCodeConstruction(response);
        }

        public async Task<string> GetNotExistingResourseAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"/api/unknown/{id}");

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return "";
            }
            else
            {
                throw new WebException("User that should not be found - found, somehow.");
            }
        }

        public async Task<HttpStatusCode> CreateUserParamsAsync(UserParams userParams)
        {
            var jsonUserParams = SerializeObject<UserParams>(userParams);

            StringContent stringContent = new StringContent(jsonUserParams, Encoding.Unicode, "application/json");
            HttpResponseMessage response = await _client.PostAsync("api/users", stringContent);

            return response.StatusCode;
        }

        public async Task<HttpStatusCode> UpdateUserParamsAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"/api/users/{id}");
            User user = JsonConvert.DeserializeObject<User>(await CheckCorrectStatusCodeConstruction(response));
            user!.FirstName = "Dr Strange";
            var jsonUser = SerializeObject<User>(user);
            StringContent stringContent = new StringContent(jsonUser, Encoding.Unicode, "application/json");
            response = await _client.PutAsync("api/users", stringContent);
            return response.StatusCode;
        }

        private async Task<string> CheckCorrectStatusCodeConstruction(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new WebException($"Wrong httpStatusCode : {response.StatusCode}.");
            }

        }

        private string SerializeObject<TSerializeObject>(TSerializeObject serializeObject)
        {
            if (serializeObject is not null)
            {
                string result = JsonConvert.SerializeObject(serializeObject);
                return result;
            }
            else
            {
                throw new NullReferenceException("Object for serialization is null.");
            }
        }
    }
}
