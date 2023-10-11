using Micros.PosCore.Extensibility.DataStore.DbRecords;
using Micros.PosCore.Extensibility.Ops;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace SimphonyExample
{
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part8Test1()
        {
            Logger.LogAlways("Part8Test1");


            var property = new DbKey.PropertyID();
            string xml = $"<value>21</value>";
            Logger.LogAlways(xml);

            StringReader sr = new StringReader(xml);
            var reader = XmlReader.Create(sr);
            reader.ReadToFollowing("value");
            property.ReadXml(reader);
            Logger.LogAlways("read success " + property.Value);

            var dbProperty = DataStore.ReadPropertyByID(property);
            Logger.LogAlways(dbProperty.PropertyID.ToString());
        }
    }
}
