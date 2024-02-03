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
        public void Part16Test1()
        {
            Logger.LogAlways("Part16Test1");

            var currentItem = this.OpsContext.CheckDetail.FirstOrDefault(f => f.DetailLink == this.OpsContext.CurrentChildItem);

            if (currentItem != null)
            {
                this.OpsContext.ShowMessage("Hold Status-" + currentItem.MiHold.ToString());
            }
        }
    }
}
