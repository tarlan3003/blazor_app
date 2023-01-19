using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eilink_webapp.Data
{
    public interface IMongoDBSettings
    {
         string CollectionName { get; set; }
         string ConnectionString { get; set; }
         string DatabaseName { get; set; }
    }
}
