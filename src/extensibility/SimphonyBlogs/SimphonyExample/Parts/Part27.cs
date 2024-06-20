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
        public void Part27Test1()
        {
            Logger.LogAlways("Part27Test1");

            this.OpsContext.ProcessCommand(new OpsCommand(OpsCommandType.Discount)
            {
                Number = 901,
                Text = "15.5"
            });

            //automatic discount
            //this.OpsContext.ProcessCommand(new OpsCommand(OpsCommandType.Discount)
            //{
            //    Number = 918
            //});
        }
    }
}
