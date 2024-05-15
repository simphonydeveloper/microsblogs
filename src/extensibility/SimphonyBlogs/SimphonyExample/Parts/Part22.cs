using Micros.Ops;
using Micros.PosCore.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimphonyExample
{
    partial class SimphonyExampleApplication
    {
        [ExtensibilityMethod]
        public void Part22Test1()
        {

            Logger.LogAlways("Part22Test1");

            List<OpsSelectionEntry> opsSelectionEntries = new List<OpsSelectionEntry>();

            
            foreach (var item in this.OpsContext.CheckDetail)
            {
                opsSelectionEntries.Add(new OpsSelectionEntry(item.DetailLink, item.Name));
            }

            var voidItems = this.OpsContext.MultiSelectionRequest(Title.VoidMultiMenuItem, Title.VoidMultiMenuItem, opsSelectionEntries);
            if (voidItems == null || voidItems.Count == 0)
                return;

            List<OpsCommand> commands = new List<OpsCommand>();
            foreach (var item in voidItems)
            {
                var voidItem = opsSelectionEntries[item];

                commands.Add(new OpsCommand(OpsCommandType.DetailSelected) { Number = voidItem.Number });
                commands.Add(new OpsCommand(OpsCommandType.Void) { Number = voidItem.Number });
            }

            OpsCommand macroCommand = new OpsCommand(OpsCommandType.Macro)
            {
                Data = commands
            };

            this.OpsContext.ProcessCommand(macroCommand);
        }
    }

    public enum Title
    {
        VoidMultiMenuItem
    }
}
