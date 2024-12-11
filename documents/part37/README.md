## Command

When executing Command, the Command class needs to be introduced during instantiation.

So we need import `var _ops = _api.Common.LoadOps();`

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;

var _ops = _api.Common.LoadOps();


globalThis.test = function test() {

    var command = new _ops.Micros.Ops.OpsCommand();
    command.Command = _ops.Micros.Ops.OpsCommandType.MenuItem;
    command.Number = 101004;//your menuitemobjnumber

    _opsContext.ProcessCommand(command);
};

```

