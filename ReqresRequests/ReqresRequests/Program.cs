namespace ReqresRequests
{
    using Microsoft.Extensions.DependencyInjection;
    using ReqresRequests.IoC_container;
    using ReqresRequests.Interfaces;
    using ReqresRequests.Models;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var container = new Container().Load();
            var client = container.GetService<IReqresClient>();

            var usersList = client!.GetUsersListAsync(2);
            var user = client!.GetSingleUserAsync(2);
            var notExistingUser = client!.GetNotExistingUserAsync(23);
            var resourseList = client!.GetResourseListAsync();
            var resourse = client!.GetSingleResourseAsync(2);
            var notExistingResourse = client!.GetNotExistingResourseAsync(23);
            var createUser = client!.CreateUserParamsAsync(new UserParams("Andrew", "Programer"));
            var updateUser = client!.UpdateUserParamsAsync(2);

            Task.WaitAll(usersList, user, notExistingUser, resourseList, resourse, notExistingResourse, createUser, updateUser);
            // Console.WriteLine($"Request #1 should be not null or empty: " + (String.IsNullOrEmpty(usersList) ? "empty" : "not empty"));
            Console.WriteLine($"Request #7 should be OK: " + await createUser);
            Console.WriteLine($"Request #8 shuold be Created: " + await updateUser);
        }
    }
}