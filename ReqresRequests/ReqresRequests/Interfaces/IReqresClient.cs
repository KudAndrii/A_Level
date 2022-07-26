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
        /// <summary>
        /// Method gets list of users from "reqres.in".
        /// </summary>
        /// <param name="page">Requested page.</param>
        /// <param name="delay">Number of seconds for delaying.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> GetUsersListAsync(int page = 0, int delay = 0);

        /// <summary>
        /// Method gets user by incoming id from "reqres.in".
        /// </summary>
        /// <param name="id">Requested id.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> GetSingleUserAsync(int id);

        /// <summary>
        /// Method gets list of resourses from "reqres.in".
        /// </summary>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> GetResourseListAsync();

        /// <summary>
        /// Method gets resourse by incoming id from "reqres.in".
        /// </summary>
        /// <param name="id"Requested id.></param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> GetSingleResourseAsync(int id);

        /// <summary>
        /// Method creates incoming user on "reqres.in".
        /// </summary>
        /// <param name="userParams">User for creating.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> CreateUserAsync(UserParams userParams);

        /// <summary>
        /// Method updates user by id on "reqres.in".
        /// </summary>
        /// <param name="id">User id for updaing.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> UpdateUserParamsAsync(int id);

        /// <summary>
        /// Method deletes user by id on "reqres.in".
        /// </summary>
        /// <param name="id">User id for deleting.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> DeleteUserAsync(int id);

        /// <summary>
        /// Method register incoming user on "reqres.in".
        /// </summary>
        /// <param name="userRegistration">User for registration.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> RegisterAsync(UserRegistration userRegistration);

        /// <summary>
        /// Method login incoming user on "reqres.in".
        /// </summary>
        /// <param name="userRegistration">User for logining.</param>
        /// <returns>Infogrmation about successful operation.</returns>
        public Task<string> LoginAsync(UserRegistration userRegistration);
    }
}
