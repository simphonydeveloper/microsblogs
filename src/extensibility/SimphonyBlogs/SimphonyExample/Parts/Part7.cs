using Micros.Ops;
using Micros.PosCore.Extensibility;
using Micros.PosCore.Extensibility.DataStore.DbRecords;
using Micros.PosCore.Extensibility.Ops;
using SimphonyExample.Database;
using SimphonyUtilities.Settings;
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
        public void Part7Test1()
        {
            Logger.LogAlways("Part7Test1");

            //custom receipt content
            //example：
            //custom header
            OpsCustomReceiptEventArgs args = new OpsCustomReceiptEventArgs()
            {
                HeaderAction = CustomPrintType.Append,
                CustomHeader = "custome header"
            };

            //The items you need to print
            List<int> checkDetailLinks = new List<int>();
            //example:
            //Print the first two items

            for (int i = 0; i < this.OpsContext.CheckDetail.Count; i++)
            {
                if (i == 2)
                    break;
                checkDetailLinks.Add(this.OpsContext.CheckDetail[i].DetailLink);
            }

            var isEnable = this.OpsContext.AskQuestion("enable customerReceipt");
            //Pass 'true' to use the customer receipt printer and format. If set to 'false', the guest check printer is used
            bool customerReceipt = isEnable;

            //your temd
            DbTenderMedia temd = new DbTenderMedia()
            {
                ObjectNumber = 1001
            };
            this.OpsContext.PrintReceipt(args, checkDetailLinks, customerReceipt, temd);
            this.OpsContext.ShowMessage("Success");
        }
    }
}
