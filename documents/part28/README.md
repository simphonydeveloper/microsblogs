## OpsCommand  Quick Method

### OpsCommand.FromCommandFileString

This method can generate commands based on strings.

### Property

Split the content through |.

| Index | Note                 |
| ----- | -------------------- |
| 0     | OpsCommandType       |
| 1     | OpsCommand.Number    |
| 2     | OpsCommand.Text      |
| 3     | OpsCommand.Arguments |
| 4     | OpsCommand.NextPage  |

### Code

```c#
  //quick command menthod
  //use cash to pay 1.00
  string commandString = $"{OpsCommandType.Payment.ToString()}|1001|1.00|Cash:Cash";  
  var command = OpsCommand.FromCommandFileString(commandString);
  this.OpsContext.ProcessCommand(command);
```

