using Micros.PosCore.Extensibility.DataStore.DbRecords;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part9Test1()
        {
            Logger.LogAlways("Part9Test1");


            var test1 = this.DataStore.ReadExtensionDataValue("Property", "Test1", this.OpsContext.PropertyID);
            var test2 = this.DataStore.ReadExtensionDataValue("Property", "Test2", this.OpsContext.PropertyID);

            this.OpsContext.ShowMessage($"{test1} and {test2}");

        }
    }
}
