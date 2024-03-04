using MongoDB.Driver;
using scrap.Model;

namespace Hayp.Server.Connections
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _db;

        public MongoDbContext(string database, string connectionString)
        {
            var client = new MongoClient(connectionString);
            _db = client.GetDatabase(database);
            try {
                Console.WriteLine("cccccc");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public IMongoCollection<ModeloCpu> ModeloCpus => _db.GetCollection<ModeloCpu>("ModeloCpu");
        public IMongoCollection<ModeloGpu> ModeloGpus => _db.GetCollection<ModeloGpu>("ModeloGpu");
        public IMongoCollection<ModeloCase> ModeloCases => _db.GetCollection<ModeloCase>("ModeloCase");
        public IMongoCollection<ModeloCooler> ModeloCoolers => _db.GetCollection<ModeloCooler>("ModeloCooler");
        public IMongoCollection<ModeloMonitor> ModeloMonitors => _db.GetCollection<ModeloMonitor>("ModeloMonitor");
        public IMongoCollection<ModeloPlacas> ModeloPlaca => _db.GetCollection<ModeloPlacas>("ModeloPlacas");
        public IMongoCollection<ModeloPsu> ModeloPsus => _db.GetCollection<ModeloPsu>("ModeloPsu");
        public IMongoCollection<ModelosSsd> ModelosSsds => _db.GetCollection<ModelosSsd>("ModelosSsd");
    }
}

