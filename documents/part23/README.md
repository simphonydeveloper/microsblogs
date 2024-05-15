## OpsContext.Check.GetMenuItemDiscountedTotal

if the menuitem not discount ,the method will return item total.

```c#
   public partial class SimphonyExampleApplication
   {
       [ExtensibilityMethod]
       public void Part23Test1()
       {
           Logger.LogAlways("Part23Test1");

           var current = this.OpsContext.CurrentParentItem;

          
           var discount = this.OpsContext.Check.GetMenuItemDiscountedTotal(current);
           this.OpsContext.ShowMessage("discount amount-" + discount);
       }

   }
```

If you want to obtain more detailed content, I suggest using it

[How do get a discount on a menuitem?](../part15/README.md).

