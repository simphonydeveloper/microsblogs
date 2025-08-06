## Read Content like JSON

Generally speaking, it is very simple to do this in .net. The key point here is to convert byte[] into a string to get the content we want.

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;
var _dataStore = _api.Environment.DataStore;
var _net = _api.Common.LoadCommonNetAsssembles();


globalThis.test = function () {
    var data = _dataStore.ReadContentByName(_opsContext.RvcID, "Your Content Name");
    _opsContext.ShowMessage(byteToString(data.ContentData.DataBlob))
}

function byteToString(array) {
    var result = "";
    for (var i = 0; i < array.Count(); i++) {
        result += String.fromCharCode(array[i])
    }
    return result;
}
```

