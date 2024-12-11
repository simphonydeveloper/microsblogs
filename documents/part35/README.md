## Get Menuitems

The key point here is that you cannot directly iterate over the `ExtendebilityDetailArray` array.The core is to convert it into an array object that JavaScript can know.

So we can use the `ToArray()` method to convert it into an array.However, when using it, you may find that the `ToArray()` method cannot be used.

According to the document, `LoadCommonNetAsssembles( String[] assemblies )` is capable of loading references to DLLs.

By examining the namespace of `ToArray()`, it will be known that it belongs to assembly `System.Core`.

```txt
object LoadCommonNetAsssembles( String[] assemblies )	load common .net assemblies and return reference (mscorlib, System, System.Core)
```

Code Example:

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;
var _net = _api.Common.LoadCommonNetAsssembles('System.Core');

globalThis.test = function test() {

    var checkDetails = _opsContext.CheckDetail.ToArray();
    var checkDetailsCount = checkDetails.Count()

    for (let i = 0; i < checkDetailsCount; i++) {

        var checkItems = checkDetails[i];
        _opsContext.ShowMessage(checkItems.Name + '');
    }
};
```

