using Dapper;
using Micros.Ops;
using Micros.PosCore.Extensibility;
using SimphonyExample.Database;
using SimphonyUtilities.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {

        [ExtensibilityMethod]
        public void Part6Test1()
        {
            Logger.LogAlways("Part6Test1");

            List<OpsSelectionEntry> entries = new List<OpsSelectionEntry>();

            entries.Add(new OpsSelectionEntry((int)DatabaseSettings.DatabaseAlias.LocalDb, "DataStore"));
            entries.Add(new OpsSelectionEntry((int)DatabaseSettings.DatabaseAlias.CPServiceDb, "CheckPostingDB"));

            var selected = this.OpsContext.SelectionRequest("Select Database", "Please Select Execute Database", entries);
            if (!selected.HasValue)
                return;

            var selectedDB = entries[selected.Value];

            SimphonyDbConnectionFactory simphonyDbConnectionFactory = new SimphonyDbConnectionFactory((DatabaseSettings.DatabaseAlias)selectedDB.Number);

            using (var conn = simphonyDbConnectionFactory.CreateConnection())
            {
                var checks = conn.Query<dynamic>("select * from checks");

                string msg = $"{selectedDB.Name} checks count {checks.Count()}";
                this.OpsContext.ShowMessage(msg);
            };
        }
    }
}
