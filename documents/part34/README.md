## Get Transaction Amount

The same as in C #, you only need to obtain the corresponding attribute to get the amount.

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;
var _logger = _api.Logger;


globalThis.test = function test() {

    var subTotal = _opsContext.Check.SubTotal;
    var discount = _opsContext.CheckDiscount;
    var totaldue = _opsContext.CheckTotalDue;
    //....
    _opsContext.ShowMessage('subtotal-' + subTotal);
    _opsContext.ShowMessage('discount-' + discount);
    _opsContext.ShowMessage('totaldue-' + totaldue);

};
```

