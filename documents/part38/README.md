## Eventing

Call a menuitem event.

We can see all property in document.

```txt
Arguments: OpsMenuItemEventArgs
Property: OpsMenuItemEventArgs.BarcodeDef (Micros.PosCore.Extensibility.DataStore.DbRecords.DbBarcode)
Property: OpsMenuItemEventArgs.Count (System.Int32)
Property: OpsMenuItemEventArgs.Description (System.String)
Property: OpsMenuItemEventArgs.DetailLink (System.Int32)
Property: OpsMenuItemEventArgs.DiscItmzrID (Micros.PosCore.Extensibility.DataStore.DbRecords.DbKey.DscntItmzrID)
Property: OpsMenuItemEventArgs.EventName (System.String)
Property: OpsMenuItemEventArgs.ItemWeight (System.Decimal)
Property: OpsMenuItemEventArgs.MainLevelIndex (System.Int16)
Property: OpsMenuItemEventArgs.MiClass (Micros.PosCore.Extensibility.DataStore.DbRecords.DbMenuItemClass)
Property: OpsMenuItemEventArgs.MiDefinition (Micros.PosCore.Extensibility.DataStore.DbRecords.DbMenuItemDefinition)
Property: OpsMenuItemEventArgs.MiMaster (Micros.PosCore.Extensibility.DataStore.DbRecords.DbMenuItemMaster)
Property: OpsMenuItemEventArgs.MiPrice (Micros.PosCore.Extensibility.DataStore.DbRecords.DbMenuItemPrice)
Property: OpsMenuItemEventArgs.MiTaxClass (Micros.PosCore.Extensibility.DataStore.DbRecords.DbTaxClass)
Property: OpsMenuItemEventArgs.Name (System.String)
Property: OpsMenuItemEventArgs.NluIndex (System.Int16)
Property: OpsMenuItemEventArgs.Reference (System.String)
Property: OpsMenuItemEventArgs.SlsItmzrIndex (System.Int16)
Property: OpsMenuItemEventArgs.SubLevelIndex (System.Int16)
Property: OpsMenuItemEventArgs.SvcChgItmzrID (Micros.PosCore.Extensibility.DataStore.DbRecords.DbKey.SvcChgItmzrID)
Property: OpsMenuItemEventArgs.Total (System.Decimal)
Property: OpsMenuItemEventArgs.VoidDetailLink (System.Int32)
Property: OpsMenuItemEventArgs.VoidReason (Micros.PosCore.Extensibility.Ops.OpsVoidReason)
```

The document have many examples about eventing

```javascript
var _api = SimphonyExtensibilityAPI;
var _opsContext = _api.Environment.Context;

_api.Eventing.SubscribeToEvent('OpsMiEvent', onMenuItem);


function onMenuItem(sender, args) {
    _opsContext.ShowMessage(args.Name)
}

```

