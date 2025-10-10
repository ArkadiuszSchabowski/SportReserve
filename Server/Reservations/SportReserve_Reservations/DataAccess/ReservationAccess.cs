using MongoDB.Driver;
using SportReserve_Reservations.Interfaces;

namespace SportReserve_Reservations.DataAccess
{
    public class ReservationAccess : IReservationAccess
    {
        private readonly IMongoDbConfig _mongoDbConfig;

        public ReservationAccess(IMongoDbConfig mongoDbConfig)
        {
            _mongoDbConfig = mongoDbConfig;
        }
        public IMongoCollection<T> ConnectToMongo<T>(string collectionName)
        {
            var configuration = _mongoDbConfig.GetConfiguration();
            var client = new MongoClient(configuration.ConnectionString);
            var db = client.GetDatabase(configuration.DatabaseName);
            return db.GetCollection<T>(collectionName);
        }
    }
}
