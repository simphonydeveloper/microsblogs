using Micros.Ops;
using Micros.PosCore.Common.Classes;
using Micros.PosCore.Extensibility;
using Micros.PosCore.Extensibility.Ops;
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
        public void Part19Test1()
        {
            Logger.LogAlways("Part19Test1");

            //custom input content
            var character = this.OpsContext.RequestAlphaEntry("custom detail line", "custom");

            //remember check null
            if (!string.IsNullOrEmpty(character))
            {
                //add info
                this.OpsContext.Check.AddExtensibilityData(new ExtensibilityDataInfo(character, "test", "test"));
            }
        }
    }
}
