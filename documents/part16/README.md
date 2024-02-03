## Distinguish menuitem hold

### Setting the Hold and Fire Option

1. Select the revenue center, click **Setup**, and then click **RVC Parameters**.

2. Click the **Options** tab, and then select **70 - Enable Hold and Fire**.

   Do not enable hold and fire if you are using DOM.

3. Click **Save**.



### Code

The code very easy, like this.

```c#
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
```



