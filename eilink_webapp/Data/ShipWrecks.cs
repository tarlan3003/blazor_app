using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eilink_webapp.Data
{
    [BsonIgnoreExtraElements]
    public class ShipWrecks
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Feature_type { get; set; }
        public double Latdec { get; set; }
        public double Londec { get; set; }
    }
}
