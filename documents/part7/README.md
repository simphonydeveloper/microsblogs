## How to use PrintReceipt

### Guide

[PrintReceipt](https://docs.oracle.com/cd/E91245_01/api/html/c8f36a9f-0ca8-42ea-152f-a1112a694996.htm)

**Print a customized guest check or customer receipt to the guest check or customer receipt printer.**

This is the official introduction to this method.

Next, use a piece of code to use it.

### Code

```c#
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
```

### Show



![image-20231010203423451](./images/image-20231010203423451.png)





### OpsCustomReceiptEventArgs

You can use it according to different needs.

SubHeaderAction

TeamHeaderAction

DetailAction

SummaryTotalsAction

PreTrailerAction

TrailerAction

HeaderAction

```c#
public class OpsCustomReceiptEventArgs : OpsEventMonitorArgs
    {
        public object CustomHeader;
        public CustomPrintType SubHeaderAction;
        public object CustomSubHeader;
        public CustomPrintType TeamHeaderAction;
        public object CustomTeamHeader;
        public CustomPrintType DetailAction;
        public object CustomDetail;
        public CustomPrintType SummaryTotalsAction;
        public object CustomSummaryTotals;
        public CustomPrintType PreTrailerAction;
        public object CustomPreTrailer;
        public CustomPrintType TrailerAction;
        public object CustomTrailer;
        public int CashDrawerNumber;

        public OpsCustomReceiptEventArgs();

        public CustomPrintType HeaderAction { get; set; }
    }
```

