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

        private EventProcessingInstruction SimphonyExampleApplication_OpsCommandEvent(object sender, Micros.PosCore.Extensibility.Ops.OpsCommandEventArgs args)
        {
            var command = args.Command as OpsCommand;

            Logger.LogAlways(args.Command.ToString());
            Logger.LogAlways(command.Command.ToString());
            if (IsOpenListen)
            {
                if (command.Command == OpsCommandType.DialogCancel)
                {
                    CancelMessage = "Cancel Callback";
                }
            }
            return EventProcessingInstruction.Continue;
        }


        public static bool IsOpenListen = false;
        public static string CancelMessage = "";

        [ExtensibilityMethod]
        public void Part11Test1()
        {
            Logger.LogAlways("Part11Test1");
            
            IsOpenListen = true;
            var result = this.OpsContext.RequestAlphaEntry("test input", "test");
            IsOpenListen = false;

            this.OpsContext.ShowMessage(CancelMessage);
        }
    }
}
