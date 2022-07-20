using Switcher.Configs;

namespace Switcher.Interfaces
{
    public interface IConfigService
    {
        MongoConfig MongoDbInfo { get; }
    }
}