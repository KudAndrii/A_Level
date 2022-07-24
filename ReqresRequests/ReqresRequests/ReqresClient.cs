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

        public async Task<string> GetUsersList(int page)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/users?page={page}");
            Task<string> result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new WebException($"HttpStatusCode is {response.StatusCode}");
            }

            return await result;
        }

        private string SerializeObject(UserParams userParams)
        {
            if (userParams.Name != null || userParams.Job != null)
            {
                string jsomUserParams = JsonConvert.SerializeObject(userParams);
                return jsomUserParams;
            }
            else
            {
                throw new NullReferenceException("userParams not setted, or wrong converting to json format");
            }
        }
    }
}
