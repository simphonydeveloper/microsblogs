using SimphonyUtilities.Settings;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMC.Data.Sql;

namespace SimphonyExample.Database
{
    internal class SimphonyDbConnectionFactory
    {
        private readonly DatabaseSettings _databaseSettings;

        public SimphonyDbConnectionFactory()
        {
            _databaseSettings = DatabaseSettings.GetDbSettingsSafe(DatabaseSettings.DatabaseAlias.LocalDb);
        }

        public SimphonyDbConnectionFactory(DatabaseSettings.DatabaseAlias database)
        {
            _databaseSettings = DatabaseSettings.GetDbSettings(database);
        }

        public IDbConnection CreateConnection() => new DatabaseConnection(_databaseSettings).Connection as DbConnection;
    }
}
