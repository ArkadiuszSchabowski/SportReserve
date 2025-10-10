using SportReserve_Shared.Models;

namespace SportReserve_Reservations.Interfaces
{
    public interface IMongoDbConfig
    {
        MongoDbConfiguration GetConfiguration();
    }
}
