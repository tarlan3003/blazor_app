using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eilink_webapp.Data
{
    interface IShipWrecksService
    {
        Task<List<ShipWrecks>> GetShipWrecks();
        Task<bool> CreateShipWreck(ShipWrecks wreck);
        Task<bool> EditShipWreck(ObjectId id, ShipWrecks wreck);
        Task<ShipWrecks> SingleShipWreck(ObjectId id);
        Task<bool> DeleteShipWreck(ObjectId id);
    }
}
