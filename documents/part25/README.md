## View the logs of the Extension Application

Usually, we use built-in logs in the Extension Application.

So where is this log output?

For example, I print this log in the code.

```c#
Logger.LogAlways("Part25Test1");
```

In your POS machine directory.

Found it in the latest txt file.

**C:\Micros\Simphony\WebServer\wwwroot\EGateway\EGatewayLog**

```txt
ExtApps     ,       11,Part25Test1,
```



The above mentioned is what you can do when implementing **OpsExtensibilityApplication**.

If a new class is added to handle certain content, of course, you want to record some logs. You can do this.

```c#
 internal class SimphonyLogHelper
 {
     public static void LogAlways(string message)
     {
         ExtensibilityAppLogger.CurrentInstance.LogAlways(message);
     }
 }
```

To use.

```c#
 [ExtensibilityMethod]
 public void Part25Test1()
 {
     Logger.LogAlways("Part25Test1");

     SimphonyLogHelper.LogAlways("SimphonyLogHelper");
 }
```

You can see you ouput log.

```txt
ExtApps     ,       11,SimphonyLogHelper,
```



