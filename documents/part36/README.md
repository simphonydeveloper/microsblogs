## Request Input Entry Method

input entry is also the most commonly used method in development.

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;


globalThis.test = function test() {
    var result = _opsContext.RequestAlphaEntry('testMsg', 'testTitle')
    _opsContext.ShowMessage(result)
};
```

