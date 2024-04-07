## Two different extensibility operations with the same value.

We all know that within the same extensibility, we control certain switches and using variables to control them is very simple.
If method 1 in extensibility A is used, I do not want method 2 in extensibility 2 to be executed.

What would you do at this time?

Look at the code below me.

```c#
 [ExtensibilityMethod]
 public void Part21Test1()
 {

     Logger.LogAlways("Par21Test1");
     GlobalApplicationCache.Add("flag", false);
 }

 /// <summary>
 /// the method in other dll
 /// </summary>
 [ExtensibilityMethod]
 public void Part21Test2()
 {

     Logger.LogAlways("Par21Test2");
     var flag = GlobalApplicationCache.ContainsKey("flag");
     if (flag)
     {
         this.OpsContext.ShowMessage("get flag");

         var flagValue = GlobalApplicationCache["flag"];
         if (Convert.ToBoolean(flagValue))
         {
             this.OpsContext.ShowMessage("get flag true");
         }
         else
         {
             this.OpsContext.ShowMessage("get flag false");
         }
     }
     else
     {
         this.OpsContext.ShowMessage("no flag");
     }
 }
```

So when you have such a need, doing so is very simple. No other more complex methods are needed.