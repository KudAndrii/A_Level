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

        public async Task<string> GetUsersListAsync(int page = 0, int delay = 0)
        {
            HttpResponseMessage response;

            if (delay > 0)
            {
                response = await _client.GetAsync($"api/users?delay{delay}");
            }
            else
            {
                response = await _client.GetAsync($"api/users?page={page}");
            }

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> GetSingleUserAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/users/{id}");

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            if (id > 12)
            {
                expectedStatusCode = HttpStatusCode.NotFound;
            }

            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> GetResourseListAsync()
        {
            HttpResponseMessage response = await _client.GetAsync("api/unknown");

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> GetSingleResourseAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"api/unknown/{id}");

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            if (id > 12)
            {
                expectedStatusCode = HttpStatusCode.NotFound;
            }

            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> CreateUserAsync(UserParams userParams)
        {
            var jsonUserParams = SerializeObject<UserParams>(userParams);

            StringContent stringContent = new StringContent(jsonUserParams, Encoding.Unicode, "application/json");
            HttpResponseMessage response = await _client.PostAsync("api/users", stringContent);

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            // HttpStatusCode expectedStatusCode = HttpStatusCode.Created;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> UpdateUserParamsAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"/api/users/{id}");
            UserData userData;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                userData = JsonConvert.DeserializeObject<UserData>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new WebException("Not expected StatusCode");
            }
            
            userData!.User.FirstName = "Dr Strange";
            var jsonUser = SerializeObject<UserData>(userData);
            StringContent stringContent = new StringContent(jsonUser, Encoding.Unicode, "application/json");
            response = await _client.PutAsync("api/users/2", stringContent);

            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> DeleteUserAsync(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"/api/users/{id}");

            HttpStatusCode expectedStatusCode = HttpStatusCode.NoContent;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> RegisterAsync(UserRegistration userRegistration)
        {
            StringContent content = new StringContent(SerializeObject<UserRegistration>(userRegistration), Encoding.Unicode, "application/json");
            HttpResponseMessage response = await _client.PostAsync("api/register", content);
            #region Unexpected StatusCode
            /*
            HttpStatusCode expectedStatusCode;
            if (userRegistration.Email != null && userRegistration.Password != null)
            {
                expectedStatusCode = HttpStatusCode.OK;
            }
            else
            {
                expectedStatusCode = HttpStatusCode.BadRequest;
            }
            */
            #endregion
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        public async Task<string> LoginAsync(UserRegistration userRegistration)
        {
            StringContent content = new StringContent(SerializeObject(userRegistration), Encoding.Unicode, "application/json");
            HttpResponseMessage response = await _client.PostAsync("api/login", content);
            #region Unexpected StatusCode
            /*
            HttpStatusCode expectedStatusCode;
            if (userRegistration.Email == "eve.holt@reqres.in" && userRegistration.Password == "cityslicka")
            {
                expectedStatusCode = HttpStatusCode.OK;
            }
            else
            {
                expectedStatusCode = HttpStatusCode.BadRequest;
            }
            */
            #endregion
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            return await CheckCorrectStatusCodeConstruction(response.StatusCode, expectedStatusCode);
        }

        /// <summary>
        /// Method checks the correspondence between the real and the espected StatusCode.
        /// </summary>
        /// <param name="statusCode">Real StatusCode.</param>
        /// <param name="expectedStatusCode">Expected StatusCode.</param>
        /// <returns>Message about successful operation.</returns>
        /// <exception cref="WebException">It will be thrown if StatusCodes not equal.</exception>
        private async Task<string> CheckCorrectStatusCodeConstruction(HttpStatusCode statusCode, HttpStatusCode expectedStatusCode)
        {
            if (statusCode == expectedStatusCode)
            {
                return "Successfully";
            }
            else
            {
                throw new WebException($"Wrong httpStatusCode : {expectedStatusCode} != {statusCode}.");
            }

        }

        /// <summary>
        /// Method serializes generic object if it is not null.
        /// </summary>
        /// <typeparam name="TSerializeObject">it should be class.</typeparam>
        /// <param name="serializeObject">Incoming object.</param>
        /// <returns>Object as string.</returns>
        /// <exception cref="NullReferenceException">It will be thrown if incoming object is null.</exception>
        private string SerializeObject<TSerializeObject>(TSerializeObject serializeObject)
            where TSerializeObject : class
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
