using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eilink_webapp.Data
{
    public class ShipWrecksService : IShipWrecksService
    {
        private readonly IMongoCollection<ShipWrecks> _wrecks;
        public ShipWrecksService(IMongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _wrecks = (IMongoCollection<ShipWrecks>)database.GetCollection<ShipWrecks>(settings.CollectionName);
        }
        public async Task<bool> CreateShipWreck(ShipWrecks wreck)
        {
            try
            {
                await _wrecks.InsertOneAsync(wreck);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public async Task<bool> DeleteShipWreck(ObjectId id)
        {
            try
            {
                await _wrecks.DeleteOneAsync(book => book.Id == id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public async Task<bool> EditShipWreck(ObjectId id, ShipWrecks wreck)
        {
            try
            {
                await _wrecks.ReplaceOneAsync(book => book.Id == id, wreck);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public async Task<List<ShipWrecks>> GetShipWrecks()
        {
            try
            {
                return await _wrecks.Find(city => true).ToListAsync();
            }
            catch
            {
                return null;
            }
        }


        public async Task<ShipWrecks> SingleShipWreck(ObjectId id)
        {
            try
            {
                return await _wrecks.Find<ShipWrecks>(city => city.Id == id).FirstOrDefaultAsync();
            }
            catch
            {
                return null;
            }
        }
    }
}
