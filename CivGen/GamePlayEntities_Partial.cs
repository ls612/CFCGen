using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivGen
{
    /// GameplayEntities class extended in a different partial class module.  This is used so that if the GameplayEntities class is
    /// rebuilt, the extension will not be lost.
    /// 
    /// Implements an additional constructor that allows a different database connection string to 
    /// be used in a model-first arrangement.
    /// 
        
        public partial class GameplayEntities : DbContext
        {
            public GameplayEntities(string connectionString)
                : base(new EntityConnection() { ConnectionString = connectionString }, true)
                {
                }


        }
}
