using SportReserve_Reservations.Interfaces;
using SportReserve_Shared.Models;

namespace SportReserve_Reservations
{
    public class MongoDbConfig : IMongoDbConfig
    {
        private readonly IConfiguration _config;

        public MongoDbConfig(IConfiguration config)
        {
            _config = config;
        }
        public MongoDbConfiguration GetConfiguration()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            string connectionString;

            if (environment == "Test")
            {
                connectionString = _config.GetConnectionString("Mongo") ?? "mongodb://reservation_db:27017";
            }
            else
            {
                connectionString = _config.GetConnectionString("Mongo") ?? "mongodb://127.0.0.1:27017";
            }

            string databaseName = _config["DatabaseName"] ?? "reservationDb";

            var configuration = new MongoDbConfiguration
            {
                ConnectionString = connectionString,
                DatabaseName = databaseName
            };

            return configuration;
        }
    }
}
