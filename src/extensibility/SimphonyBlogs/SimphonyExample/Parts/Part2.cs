using Micros.Ops;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{

    /// <summary>
    /// Part2
    /// </summary>
    public partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part2Test1()
        {

            Logger.LogAlways("Par2Test1");

            OpsCommand cmdMacro1 = new OpsCommand(OpsCommandType.Macro);

            var commadData = new List<OpsCommand>();

            //my discount number
            commadData.Add(new OpsCommand(OpsCommandType.Discount) { Number = 1 });
            //my discount amount
            commadData.Add(new OpsCommand(OpsCommandType.AsciiData) { Text = "10.0" });
            //enter
            commadData.Add(new OpsCommand(OpsCommandType.EnterKey));
            //reference entry
            commadData.Add(new OpsCommand(OpsCommandType.AsciiData) { Text = "test reference entry" });
            //enter
            commadData.Add(new OpsCommand(OpsCommandType.EnterKey));
            cmdMacro1.Data = commadData;
            var result = OpsContext.ProcessCommand(cmdMacro1);

        }
    }
}
