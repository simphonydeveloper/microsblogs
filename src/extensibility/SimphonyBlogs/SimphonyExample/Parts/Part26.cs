using Micros.Ops;
using Micros.Ops.Input;
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
        public void Part26Test1()
        {
            Logger.LogAlways("Part26Test1");

            var selectedIndex = this.OpsContext.SelectionRequest("Select", "Select", new object[] { 1, 2 });
            if (!selectedIndex.HasValue)
                return;

            if (selectedIndex == 1)
            {
                this.OpsContext.ProcessCommand(new Micros.Ops.OpsCommand(Micros.Ops.OpsCommandType.MenuItem)
                {
                    Number = 9224003,
                });
            }
            else
            {
                MenuItemCommandData menuItemCommandData = new MenuItemCommandData()
                {
                    ObjectNumber = 9224003,
                };

                this.OpsContext.ProcessCommand(new Micros.Ops.OpsCommand(Micros.Ops.OpsCommandType.MenuItem)
                {
                    Data = menuItemCommandData,
                    Text = "1"
                });
            }
        }


        [ExtensibilityMethod]
        public void Part26Test2()
        {
            Logger.LogAlways("Part26Test2");

            var selectedIndex = this.OpsContext.SelectionRequest("Select", "Select", new object[] { 1, 2 });
            if (!selectedIndex.HasValue)
                return;

            if (selectedIndex == 1)
            {
                this.OpsContext.ProcessCommand(new Micros.Ops.OpsCommand(Micros.Ops.OpsCommandType.AddMenuItem)
                {
                    Number = 9224003,
                    Text = "1"
                });
            }
            else
            {
                MenuItemCommandData menuItemCommandData = new MenuItemCommandData()
                {
                    ObjectNumber = 9224003,
                };

                this.OpsContext.ProcessCommand(new Micros.Ops.OpsCommand(Micros.Ops.OpsCommandType.AddMenuItem)
                {
                    Data = menuItemCommandData,
                    Number = 9224003,
                    Text = "1"
                });
            }
        }
    }

}
