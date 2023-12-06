## Simphony input box cancel event listening

Usually, when we use various <code>Request</code> pop ups, we can only judge the user's behavior based on whether they input content, which is very limited in some scenarios. So it is meaningful to be able to listen for OK and Cancel pop ups in business logic.



So how to implement Cancel listening?
The Cancel button in the pop-up window is essentially an <code>OpsCommandType.DialogCancel</code>
All we need to do is listen for the **OpsCommand** event. Then determine the implementation logic based on **DialogCancel**.



### Step 1: Register the event

```c#
   public SimphonyExampleApplication(IExecutionContext context) : base(context)
        {

            //part11
            this.OpsCommandEvent += SimphonyExampleApplication_OpsCommandEvent;
        }
```

### Step 2: Implement event code

I usually suggest adding a switch to control this function, such as a Boolean value.

```c#
 private EventProcessingInstruction SimphonyExampleApplication_OpsCommandEvent(object sender, Micros.PosCore.Extensibility.Ops.OpsCommandEventArgs args)
        {
            var command = args.Command as OpsCommand;

            Logger.LogAlways(args.Command.ToString());
            Logger.LogAlways(command.Command.ToString());
            if (IsOpenListen)
            {
                if (command.Command == OpsCommandType.DialogCancel)
                {
                    CancelMessage = "Cancel Callback";
                }
            }
            return EventProcessingInstruction.Continue;
        }
```

```c#
 public static bool IsOpenListen = false;
 public static string CancelMessage = "";
```

### Step 3:Extension Method

The only thing to note here is that the switch needs to be controlled when opening and closing pop ups.

```c#
        [ExtensibilityMethod]
        public void Part11Test1()
        {
            Logger.LogAlways("Part11Test1");

            IsOpenListen = true;
            var result = this.OpsContext.RequestAlphaEntry("test input", "test");
            IsOpenListen = false;

            this.OpsContext.ShowMessage(CancelMessage);
        }
```





