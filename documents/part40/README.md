# Simphony JavaScript Extensibility Http Request Example(GET/POST)

I have written a code example for GET/POST requests, which is very simple.

```javascript
var _api = SimphonyExtensibilityAPI;
var _logger = _api.Logger;
var _opsContext = _api.Environment.Context;
var _http = _api.Common.LoadCommonNetAsssembles('System.Net.Http');


globalThis.get = function(){
    var result = get('https://www.baidu.com/');
    _opsContext.ShowMessage(result);
};

globalThis.post = function() {

    var obj = { description: 'this is a post request' };
    var result = post('http://localhost:51901/api/test/post', JSON.stringify(obj));
    _opsContext.ShowMessage(result);
};


function get(url) {
    _logger.Log('get request')
    try {
        var httpClient = new _http.System.Net.Http.HttpClient();
        var response = httpClient.GetAsync(url).Result;
        return response.Content.ReadAsStringAsync().Result;
    }
    catch (ex)
    {
        _logger.Log(ex.message);
    }
    return '';
}


function post(url, json) {
    _logger.Log('post request parameter ' + json);
    try {
        var httpContent = new _http.System.Net.Http.StringContent(json);
        var httpClient = new _http.System.Net.Http.HttpClient();
        httpContent.Headers.ContentType = new _http.System.Net.Http.Headers.MediaTypeHeaderValue('application/json');
        var response = httpClient.PostAsync(url, httpContent).Result;
        return response.Content.ReadAsStringAsync().Result;
    }
    catch (ex) {
        _logger.Log(ex.message);
    }
    return '';
}
```

