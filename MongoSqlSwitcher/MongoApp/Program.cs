using MongoDB.Driver;
using MongoApp.DbAccessor;
using MongoApp.Models;

namespace MongoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mongoDb = new MongoDbContext();

            var person1 = new User() { Name = "Andrew", Age = 28 };
            mongoDb.Users.InsertOne(person1);

            var person2 = new User() { Name = "Katerina", Age = 33 };
            mongoDb.Users.InsertOne(person2);

            var users = mongoDb.Users.Find(_ => true).ToList();

            foreach (var user in users)
            {
                Console.WriteLine($"User Id {user.Id}: Name {user.Name} Age {user.Age}");
            }
        }
    }
}