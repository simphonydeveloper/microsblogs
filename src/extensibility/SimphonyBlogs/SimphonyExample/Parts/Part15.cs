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
        public void Part15Test1()
        {
            Logger.LogAlways("Part15Test1");

            //get currnet selected
            var currentItemDetailLink = this.OpsContext.CurrentChildItem;
            //discount parent menuitem
            var currentItemParentDetailLink = this.OpsContext.CurrentParentItem;

            Logger.LogAlways("get detailLink " + currentItemDetailLink);

            var discountItem = this.OpsContext.CheckDetail.FirstOrDefault(f => f.DetailLink == currentItemDetailLink);
            var menuitemItem = this.OpsContext.CheckDetail.FirstOrDefault(f => f.DetailLink == currentItemParentDetailLink);
            if (discountItem != null&& menuitemItem!=null)
            {
                this.OpsContext.ShowMessage($"Menuitem {menuitemItem.Name}-discountName {discountItem.Name}-discountAmt {discountItem.Total}");
            }
        }
    }
}
