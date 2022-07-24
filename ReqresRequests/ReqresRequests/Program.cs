namespace ReqresRequests
{
    using Microsoft.Extensions.DependencyInjection;
    using ReqresRequests.IoC_container;
    using ReqresRequests.Interfaces;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var container = new Container().Load();
            var client = container.GetService<IReqresClient>();
            var usersList = await client!.GetUsersList(2);
            Console.WriteLine(usersList);
        }
    }
}