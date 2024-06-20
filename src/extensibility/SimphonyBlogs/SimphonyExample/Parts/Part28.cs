using Micros.Ops;
using Micros.PosCore.Extensibility;
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
        public void Part28Test1()
        {
            Logger.LogAlways("Part28Test1");
            //quick command menthod
            //use cash to pay 1.00
            string commandString = $"{OpsCommandType.Payment.ToString()}|1001|1.00|Cash:Cash";  
            var command = OpsCommand.FromCommandFileString(commandString);
            this.OpsContext.ProcessCommand(command);
        }
    }
}
