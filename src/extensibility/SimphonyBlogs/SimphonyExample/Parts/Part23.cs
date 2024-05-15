using Micros.PosCore.Extensibility;
using Micros.PosCore.Extensibility.DataStore.DbRecords;
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
        public void Part23Test1()
        {
            Logger.LogAlways("Part23Test1");

            var current = this.OpsContext.CurrentParentItem;

            //if the menuitem not discount ,the method will return item total.
            var discount = this.OpsContext.Check.GetMenuItemDiscountedTotal(current);
            this.OpsContext.ShowMessage("discount amount-" + discount);
        }

    }
}
