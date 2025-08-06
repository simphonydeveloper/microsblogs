## JavaScript Run HTML5

The key point to note here is that html needs to be in the same module as your ExtensionApplicationContent.

The example I use here is the HTML code from the official example.

```javascript
var _api = SimphonyExtensibilityAPI;
var _logger = _api.Logger;
var _pos = _api.Common.LoadPosCore();
var _dataStore = _api.Environment.DataStore;
var _opsContext = _api.Environment.Context;
globalThis.test = function test() {
    var parms = new _pos.Micros.PosCore.Extensibility.UserInterface.ExtensibilityInPlaceHtmlDialogParameters();
    parms.HTML = _dataStore.ReadExtensionApplicationContentTextByNameKey(_opsContext.RvcID, "CustomHTMLDialogSample", "html");
    parms.Sender = "MyDialog";
    parms.Argument = "argument from ext app" ;
    parms.ShowCloseButton = false;
    parms.DebugMode = false;
           
    var result = _opsContext.ShowExtensibilityHtmlDialog(parms);
    _opsContext.ShowMessage("Dialog returned: " + result);
};

```

