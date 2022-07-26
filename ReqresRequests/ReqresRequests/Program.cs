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

            var usersList = client!.GetUsersListAsync(page: 2);
            var user = client!.GetSingleUserAsync(2);
            var notExistingUser = client!.GetSingleUserAsync(23);
            var resourseList = client!.GetResourseListAsync();
            var resourse = client!.GetSingleResourseAsync(2);
            var notExistingResourse = client!.GetSingleResourseAsync(23);
            var createUser = client!.CreateUserAsync(new UserParams("Andrew", "Programer"));
            var updateUser = client!.UpdateUserParamsAsync(2);
            var deleteUser = client!.DeleteUserAsync(2);
            var registration = client!.RegisterAsync(new UserRegistration("123@gmail.com", "1234"));
            var unsuccessfulRegistration = client!.RegisterAsync(new UserRegistration("123@gmail.com", null));
            var login = client!.LoginAsync(new UserRegistration("eve.holt@reqres.in", "cityslicka"));
            var unsuccessfulLogin = client!.LoginAsync(new UserRegistration("eve.holt@reqres.in", null));
            var delayResponse = client!.GetUsersListAsync(delay: 3);

            Console.WriteLine("Request #1: " + await usersList);
            Console.WriteLine("Request #2: " + await user);
            Console.WriteLine("Request #3: " + await notExistingUser);
            Console.WriteLine("Request #4: " + await resourseList);
            Console.WriteLine("Request #5: " + await resourse);
            Console.WriteLine("Request #6: " + await notExistingResourse);
            Console.WriteLine("Request #7: " + await createUser);
            Console.WriteLine("Request #8: " + await updateUser);
            Console.WriteLine("Request #9: " + await deleteUser);
            Console.WriteLine("Request #10: " + await registration);
            Console.WriteLine("Request #11: " + await unsuccessfulRegistration);
            Console.WriteLine("Request #12: " + await login);
            Console.WriteLine("Request #13: " + await unsuccessfulLogin);
            Console.WriteLine("Request #14: " + await delayResponse);
        }
    }
}