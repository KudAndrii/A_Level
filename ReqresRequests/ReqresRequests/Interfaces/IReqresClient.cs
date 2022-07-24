using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Interfaces
{
    using System.Net;
    using ReqresRequests.Models;
    public interface IReqresClient
    {
        public Task<string> GetUsersListAsync(int page);
        public Task<string> GetSingleUserAsync(int id);
        public Task<string> GetNotExistingUserAsync(int id);
        public Task<string> GetResourseListAsync();
        public Task<string> GetSingleResourseAsync(int id);
        public Task<string> GetNotExistingResourseAsync(int id);
        public Task<HttpStatusCode> CreateUserParamsAsync(UserParams userParams);
        public Task<HttpStatusCode> UpdateUserParamsAsync(int id);
        public Task<HttpStatusCode> DeleteUserAsync(int id);
        public Task<HttpStatusCode> RegisterAsync(UserRegistration userRegistration);
        public Task<HttpStatusCode> RegisterUnsuccessfulAsync(UserRegistration userRegistration);
        public Task<HttpStatusCode> LoginAsync(UserRegistration userRegistration);
        public Task<HttpStatusCode> LoginUnsuccessfulAsync(UserRegistration userRegistration);
        public Task<HttpStatusCode> DelayedResponcseAsync();
    }
}
