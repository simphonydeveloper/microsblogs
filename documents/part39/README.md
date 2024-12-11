## Logger

Javascript has added more methods to use compared to C #. And it's even simpler.

C# Method

```c#
public class ExtensibilityAppLogger
{
    public ExtensibilityAppLogger();
    public ExtensibilityAppLogger(string prefix);

    public static ExtensibilityAppLogger CurrentInstance { get; }

    public void Log(ELogLevel level, string message);
    public void LogAlways(string message);
}
```

Javascript Method

```c#
public class ApiLogger
{
   public void Log( string text );
   public void Log( int logLevel‚ string text );
   public void LogAlways( string text );
   public void LogLightFlow( string text );
   public void LogGeneralFlow( string text );
   public void LogDetailFlow( string text );
   public void LogBufferDumps( string text );
   public void LogError( string text );
   public void LogWarn( string text );
   public void LogInfo( string text );
   public void LogDebug( string text );
   public void LogException( string text‚ Exception ex );
   public string Prefix { get; }
   public int WsLogVerbosity { get; }
}

```

Example:

```javascript
var _api = SimphonyExtensibilityAPI;
var _logger = _api.Logger;


globalThis.test = function test() {

    _logger.Log('normal log')
    _logger.Log(1,'level log')
    _logger.LogAlways('Always log')
    _logger.LogLightFlow('LightFlow log')
    _logger.LogGeneralFlow('GeneralFlow log')
    _logger.LogDetailFlow('DetailFlow log')
    _logger.LogBufferDumps('BufferDumps log')
    _logger.LogError('Error log')
    _logger.LogWarn('Warn log')
    _logger.LogInfo('Info log')
    _logger.LogDebug('Debug log')
};
```

Log file

```txt
5, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; normal log,
5, 1,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; level log,
5, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Always log,
5, 1,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; LightFlow log,
5, 2,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; GeneralFlow log,
5, 3,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; DetailFlow log,
5, 4,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; BufferDumps log,
5,-3,ExtApps     ,       11,ErrorCode: ERR_GENERIC_ERROR. JsExt; JsExtension; OPS; JsExtension; Root; #36; Error log,
5,-2,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Warn log,
5,-1,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Info log,
5, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Debug log,
```

 when the ExtApps setting is 0 will show below.	

```txt
0, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; normal log,
0, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Always log,
0,-3,ExtApps     ,       11,ErrorCode: ERR_GENERIC_ERROR. JsExt; JsExtension; OPS; JsExtension; Root; #36; Error log,
0,-2,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Warn log,
0,-1,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Info log,
0, 0,ExtApps     ,       11,JsExt; JsExtension; OPS; JsExtension; Root; #36; Debug log,
```

For more descriptions, please refer to the [documentation](https://docs.oracle.com/en/industries/food-beverage/simphony/19.7/simjs/index.html).