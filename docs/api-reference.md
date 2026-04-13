<!-- Generator: Widdershins v4.0.1 -->

<h1 id="trade-public-api">Trade Public API v1.0</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

Base URLs:

* <a href="/trade">/trade</a>

Email: <a href="mailto:support@armsoft.am">Armsoft</a> Web: <a href="https://www.armsoft.am">Armsoft</a> 

# Authentication

* API Key (API Key)
    - Parameter Name: **apiKey**, in: header. Please insert client api key into field

<h1 id="trade-public-api-barcodes">Barcodes</h1>

## post__v1_directories_barcodes_list

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/barcodes/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/barcodes/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/barcodes/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/barcodes/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/barcodes/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/barcodes/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/barcodes/list`

> Body parameter

```json
{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}
```

<h3 id="post__v1_directories_barcodes_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[BarcodeFilters](#schemabarcodefilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"code":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","weightItem":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "code": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "weightItem": true
    }
  ]
}
```

<h3 id="post__v1_directories_barcodes_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[BarcodeApiResponse](#schemabarcodeapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_barcodes_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/barcodes/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/barcodes/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/barcodes/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/barcodes/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/barcodes/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/barcodes/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/barcodes/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_barcodes_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"code":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","weightItem":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "code": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "weightItem": true
    }
  ]
}
```

<h3 id="post__v1_directories_barcodes_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[BarcodeApiResponse](#schemabarcodeapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_barcodes_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/barcodes/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/barcodes/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/barcodes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/barcodes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/barcodes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/barcodes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/barcodes/{code}`

<h3 id="get__v1_directories_barcodes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_barcodes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_barcodes_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/barcodes/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/barcodes/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/barcodes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/barcodes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/barcodes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/barcodes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/barcodes/{code}`

> Body parameter

```json
{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}
```

<h3 id="put__v1_directories_barcodes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Barcode](#schemabarcode)|false|none|

> Example responses

> 200 Response

```
{"code":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","weightItem":true}
```

```json
{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}
```

<h3 id="put__v1_directories_barcodes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Barcode](#schemabarcode)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_barcodes_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/barcodes/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/barcodes/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/barcodes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/barcodes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/barcodes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/barcodes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/barcodes/{code}`

<h3 id="delete__v1_directories_barcodes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_barcodes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_barcodes

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/barcodes \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/barcodes HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/barcodes',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/barcodes',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/barcodes', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/barcodes', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/barcodes");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/barcodes", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/barcodes`

> Body parameter

```json
{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}
```

<h3 id="post__v1_directories_barcodes-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Barcode](#schemabarcode)|false|none|

> Example responses

> 201 Response

```
{"code":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","weightItem":true}
```

```json
{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}
```

<h3 id="post__v1_directories_barcodes-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Barcode](#schemabarcode)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-cashdesks">CashDesks</h1>

## get__v1_directories_cashdesks

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/cashdesks \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/cashdesks HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/cashdesks',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/cashdesks',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/cashdesks', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/cashdesks', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/cashdesks");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/cashdesks", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/cashdesks`

<h3 id="get__v1_directories_cashdesks-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","nextCashInputOrderNumber":"string","nextCashOutputOrderNumber":"string","nextSaleNumber":"string","nextSaleReturnNumber":"string","nextShiftNumber":"string","default":true,"ecr":true,"cashLimit":"string"}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "nextCashInputOrderNumber": "string",
    "nextCashOutputOrderNumber": "string",
    "nextSaleNumber": "string",
    "nextSaleReturnNumber": "string",
    "nextShiftNumber": "string",
    "default": true,
    "ecr": true,
    "cashLimit": "string"
  }
]
```

<h3 id="get__v1_directories_cashdesks-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_cashdesks-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[CashDesk](#schemacashdesk)]|false|none|none|
|» code|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» nextCashInputOrderNumber|string¦null|false|none|none|
|» nextCashOutputOrderNumber|string¦null|false|none|none|
|» nextSaleNumber|string¦null|false|none|none|
|» nextSaleReturnNumber|string¦null|false|none|none|
|» nextShiftNumber|string¦null|false|none|none|
|» default|boolean¦null|false|none|none|
|» ecr|boolean¦null|false|none|none|
|» cashLimit|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_cashdesks

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/cashdesks \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/cashdesks HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/cashdesks',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/cashdesks',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/cashdesks', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/cashdesks', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/cashdesks");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/cashdesks", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/cashdesks`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}
```

<h3 id="post__v1_directories_cashdesks-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[CashDesk](#schemacashdesk)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","nextCashInputOrderNumber":"string","nextCashOutputOrderNumber":"string","nextSaleNumber":"string","nextSaleReturnNumber":"string","nextShiftNumber":"string","default":true,"ecr":true,"cashLimit":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}
```

<h3 id="post__v1_directories_cashdesks-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[CashDesk](#schemacashdesk)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_cashdesks_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/cashdesks/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/cashdesks/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/cashdesks/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/cashdesks/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/cashdesks/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/cashdesks/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/cashdesks/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/cashdesks/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/cashdesks/{code}`

<h3 id="get__v1_directories_cashdesks_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_cashdesks_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_cashdesks_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/cashdesks/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/cashdesks/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/cashdesks/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/cashdesks/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/cashdesks/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/cashdesks/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/cashdesks/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/cashdesks/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/cashdesks/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}
```

<h3 id="put__v1_directories_cashdesks_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[CashDesk](#schemacashdesk)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","nextCashInputOrderNumber":"string","nextCashOutputOrderNumber":"string","nextSaleNumber":"string","nextSaleReturnNumber":"string","nextShiftNumber":"string","default":true,"ecr":true,"cashLimit":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}
```

<h3 id="put__v1_directories_cashdesks_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[CashDesk](#schemacashdesk)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_cashdesks_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/cashdesks/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/cashdesks/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/cashdesks/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/cashdesks/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/cashdesks/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/cashdesks/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/cashdesks/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/cashdesks/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/cashdesks/{code}`

<h3 id="delete__v1_directories_cashdesks_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_cashdesks_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-invoice">Invoice</h1>

## get__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/invoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/invoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/invoice/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/invoice/{isn}`

<h3 id="get__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/invoice/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/invoice/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/invoice/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/invoice/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Invoice](#schemainvoice)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","customer":"string","customerContract":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","seller":"string","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","dealType":"string","priceType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierName":"string","supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","supplierAdditionalData":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","customerAdditionalData":"string","shippingMethod":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","description":"string","markingList":["string"],"cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Invoice](#schemainvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_invoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/invoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/invoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/invoice/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/invoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/invoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/invoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/invoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/invoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/invoice/{isn}`

<h3 id="delete__v1_documents_invoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_invoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_invoice

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/invoice \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/invoice HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/invoice',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/invoice',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/invoice', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/invoice', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/invoice");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/invoice", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/invoice`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_invoice-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Invoice](#schemainvoice)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","customer":"string","customerContract":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","seller":"string","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","dealType":"string","priceType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierName":"string","supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","supplierAdditionalData":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","idDocumentType":"string","passportNumber":"string","customerAdditionalData":"string","shippingMethod":"string","additionalFullName":"string","credentialNumber":"string","credentialDate":"2019-08-24","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"environmentalFeePercent":0.1,"environmentalFeeAmount":0.1,"vat":true,"dealType":"string","description":"string","markingList":["string"],"cpaClassifier":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_invoice-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Invoice](#schemainvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-journals">Journals</h1>

## post__v1_journals_alldocuments

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/journals/alldocuments \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/journals/alldocuments HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partnerCode": "string",
  "itemCode": "string",
  "employeeCode": "string",
  "documentState": "string",
  "owner": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/journals/alldocuments',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/journals/alldocuments',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/journals/alldocuments', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/journals/alldocuments', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/journals/alldocuments");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/journals/alldocuments", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/alldocuments`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partnerCode": "string",
  "itemCode": "string",
  "employeeCode": "string",
  "documentState": "string",
  "owner": "string"
}
```

<h3 id="post__v1_journals_alldocuments-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[DocumentsJournalParam](#schemadocumentsjournalparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","dayOrderNumber":0,"documentNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"state":0,"stateName":"string","storageCode":"string","storageName":"string","information":"string","comment":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","employeeCode":"string","employeeName":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z","owner":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}
```

<h3 id="post__v1_journals_alldocuments-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[DocumentsJournalDataRowApiResponse](#schemadocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_alldocuments_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/journals/alldocuments/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/journals/alldocuments/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/journals/alldocuments/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/journals/alldocuments/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/journals/alldocuments/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/journals/alldocuments/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/journals/alldocuments/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/journals/alldocuments/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/alldocuments/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_journals_alldocuments_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","dayOrderNumber":0,"documentNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"state":0,"stateName":"string","storageCode":"string","storageName":"string","information":"string","comment":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","employeeCode":"string","employeeName":"string","userName":"string","lastChange":"2019-08-24T14:15:22Z","owner":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}
```

<h3 id="post__v1_journals_alldocuments_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[DocumentsJournalDataRowApiResponse](#schemadocumentsjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_ecrchecks

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/journals/ecrchecks \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/journals/ecrchecks HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partnerCode": "string",
  "itemCode": "string",
  "storageCode": "string",
  "cashDeskCode": "string",
  "employeeCode": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string",
  "owner": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/journals/ecrchecks',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/journals/ecrchecks',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/journals/ecrchecks', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/journals/ecrchecks', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/journals/ecrchecks");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/journals/ecrchecks", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/ecrchecks`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partnerCode": "string",
  "itemCode": "string",
  "storageCode": "string",
  "cashDeskCode": "string",
  "employeeCode": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string",
  "owner": "string"
}
```

<h3 id="post__v1_journals_ecrchecks-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ECRChecksJournalParam](#schemaecrchecksjournalparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"cashAmount":0.1,"nonCashAmount":0.1,"prepaymentAmount":0.1,"bonusAmount":0.1,"creditAmount":0.1,"state":0,"stateName":"string","storageCode":"string","storageName":"string","cashDeskCode":"string","cashDeskName":"string","cashierShiftNumber":"string","posPartnerName":"string","posPartnerContractName":"string","paymentSystem":"string","paymentNumber":"string","paymentAccepted":true,"information":"string","comment":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","employeeCode":"string","employeeName":"string","lastUser":"string","lastChange":"2019-08-24T14:15:22Z","owner":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "bonusAmount": 0.1,
      "creditAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "cashDeskCode": "string",
      "cashDeskName": "string",
      "cashierShiftNumber": "string",
      "posPartnerName": "string",
      "posPartnerContractName": "string",
      "paymentSystem": "string",
      "paymentNumber": "string",
      "paymentAccepted": true,
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "lastUser": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}
```

<h3 id="post__v1_journals_ecrchecks-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ECRChecksJournalDataRowApiResponse](#schemaecrchecksjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_journals_ecrchecks_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/journals/ecrchecks/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/journals/ecrchecks/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/journals/ecrchecks/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/journals/ecrchecks/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/journals/ecrchecks/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/journals/ecrchecks/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/journals/ecrchecks/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/journals/ecrchecks/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/journals/ecrchecks/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_journals_ecrchecks_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","ecrCheckNumber":"string","type":0,"typeName":"string","currency":"string","amount":0.1,"cashAmount":0.1,"nonCashAmount":0.1,"prepaymentAmount":0.1,"bonusAmount":0.1,"creditAmount":0.1,"state":0,"stateName":"string","storageCode":"string","storageName":"string","cashDeskCode":"string","cashDeskName":"string","cashierShiftNumber":"string","posPartnerName":"string","posPartnerContractName":"string","paymentSystem":"string","paymentNumber":"string","paymentAccepted":true,"information":"string","comment":"string","partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","employeeCode":"string","employeeName":"string","lastUser":"string","lastChange":"2019-08-24T14:15:22Z","owner":"string"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "bonusAmount": 0.1,
      "creditAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "cashDeskCode": "string",
      "cashDeskName": "string",
      "cashierShiftNumber": "string",
      "posPartnerName": "string",
      "posPartnerContractName": "string",
      "paymentSystem": "string",
      "paymentNumber": "string",
      "paymentAccepted": true,
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "lastUser": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}
```

<h3 id="post__v1_journals_ecrchecks_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ECRChecksJournalDataRowApiResponse](#schemaecrchecksjournaldatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-partners">Partners</h1>

## post__v1_directories_partners_list

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "group": "string",
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/list`

> Body parameter

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "group": "string",
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}
```

<h3 id="post__v1_directories_partners_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnerFilters](#schemapartnerfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","groupName":"string","supplier":true,"customer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","stateRegisterNumber":"string","passportNumber":"string","gender":"string","birthDate":"2019-08-24","idDocumentType":"string","status":"string","settlementAccount":"string","userName":"string","creationDate":"2019-08-24T14:15:22Z","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "supplier": true,
      "customer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "stateRegisterNumber": "string",
      "passportNumber": "string",
      "gender": "string",
      "birthDate": "2019-08-24",
      "idDocumentType": "string",
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_directories_partners_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnerRowApiResponse](#schemapartnerrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_partners_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","groupName":"string","supplier":true,"customer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","stateRegisterNumber":"string","passportNumber":"string","gender":"string","birthDate":"2019-08-24","idDocumentType":"string","status":"string","settlementAccount":"string","userName":"string","creationDate":"2019-08-24T14:15:22Z","lastChange":"2019-08-24T14:15:22Z"}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "supplier": true,
      "customer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "stateRegisterNumber": "string",
      "passportNumber": "string",
      "gender": "string",
      "birthDate": "2019-08-24",
      "idDocumentType": "string",
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}
```

<h3 id="post__v1_directories_partners_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnerRowApiResponse](#schemapartnerrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/partners/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/partners/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/partners/{code}`

<h3 id="get__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/partners/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/partners/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/partners/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Partner](#schemapartner)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","supplier":true,"customer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","stateRegisterNumber":"string","passportNumber":"string","gender":"string","birthDate":"2019-08-24","idDocumentType":"string","status":"string","defaultContractCode":"string","contracts":[{"code":"string","name":"string","currency":"string","priceType":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}],"settlementAccounts":[{"account":"string","name":"string","default":true}],"additionalAddresses":[{"name":"string","default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="put__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Partner](#schemapartner)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_partners_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/partners/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/partners/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/partners/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/partners/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/partners/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/partners/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/partners/{code}`

<h3 id="delete__v1_directories_partners_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_partners_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Partner](#schemapartner)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","taxCode":"string","group":"string","supplier":true,"customer":true,"legalAddress":"string","businessAddress":"string","managerName":"string","managerPosition":"string","accountantName":"string","accountantPosition":"string","paymentMainAim":"string","phoneNumber":"string","email":"string","stateRegisterNumber":"string","passportNumber":"string","gender":"string","birthDate":"2019-08-24","idDocumentType":"string","status":"string","defaultContractCode":"string","contracts":[{"code":"string","name":"string","currency":"string","priceType":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}],"settlementAccounts":[{"account":"string","name":"string","default":true}],"additionalAddresses":[{"name":"string","default":true}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Partner](#schemapartner)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners_contracts_list

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners/contracts/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners/contracts/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "partnerCode": "string",
  "currency": "string",
  "exceptNCC": true,
  "onlyCustomers": true,
  "onlySuppliers": true,
  "onlyBonusCards": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/contracts/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners/contracts/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners/contracts/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners/contracts/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/contracts/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners/contracts/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/contracts/list`

> Body parameter

```json
{
  "pageSize": 0,
  "partnerCode": "string",
  "currency": "string",
  "exceptNCC": true,
  "onlyCustomers": true,
  "onlySuppliers": true,
  "onlyBonusCards": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}
```

<h3 id="post__v1_directories_partners_contracts_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ContractFilters](#schemacontractfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","partnerPhone":"string","partnerGroup":"string","partnerGroupName":"string","customer":true,"supplier":true,"contractCode":"string","contractName":"string","currency":"string","priceType":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerPhone": "string",
      "partnerGroup": "string",
      "partnerGroupName": "string",
      "customer": true,
      "supplier": true,
      "contractCode": "string",
      "contractName": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners_contracts_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ContractRowApiResponse](#schemacontractrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners_contracts_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners/contracts/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners/contracts/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/contracts/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners/contracts/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners/contracts/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners/contracts/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/contracts/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners/contracts/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/contracts/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_partners_contracts_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"partnerId":0,"partnerCode":"string","partnerName":"string","partnerTaxCode":"string","partnerPhone":"string","partnerGroup":"string","partnerGroupName":"string","customer":true,"supplier":true,"contractCode":"string","contractName":"string","currency":"string","priceType":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerPhone": "string",
      "partnerGroup": "string",
      "partnerGroupName": "string",
      "customer": true,
      "supplier": true,
      "contractCode": "string",
      "contractName": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_partners_contracts_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ContractRowApiResponse](#schemacontractrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_partners_{partnerCode}_contracts_{contractCode}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/partners/{partnerCode}/contracts/{contractCode}`

<h3 id="get__v1_directories_partners_{partnercode}_contracts_{contractcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|partnerCode|path|string|true|none|
|contractCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_partners_{partnercode}_contracts_{contractcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_partners_{partnerCode}_contracts_{contractCode}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/partners/{partnerCode}/contracts/{contractCode}`

> Body parameter

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}
```

<h3 id="put__v1_directories_partners_{partnercode}_contracts_{contractcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|partnerCode|path|string|true|none|
|contractCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Contract](#schemacontract)|false|none|

> Example responses

> 200 Response

```
{"partnerId":0,"partnerCode":"string","partnerName":"string","contractCode":"string","contractName":"string","currency":"string","priceType":"string","priceTypeName":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}
```

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}
```

<h3 id="put__v1_directories_partners_{partnercode}_contracts_{contractcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Contract](#schemacontract)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_partners_{partnerCode}_contracts_{contractCode}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/partners/{partnerCode}/contracts/{contractCode} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/partners/{partnerCode}/contracts/{contractCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/partners/{partnerCode}/contracts/{contractCode}`

<h3 id="delete__v1_directories_partners_{partnercode}_contracts_{contractcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|partnerCode|path|string|true|none|
|contractCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_partners_{partnercode}_contracts_{contractcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partners_contracts

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partners/contracts \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partners/contracts HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partners/contracts',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partners/contracts',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partners/contracts', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partners/contracts', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partners/contracts");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partners/contracts", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partners/contracts`

> Body parameter

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}
```

<h3 id="post__v1_directories_partners_contracts-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Contract](#schemacontract)|false|none|

> Example responses

> 201 Response

```
{"partnerId":0,"partnerCode":"string","partnerName":"string","contractCode":"string","contractName":"string","currency":"string","priceType":"string","priceTypeName":"string","date":"2019-08-24","description":"string","discountPercent":0.1,"cardCode":"string","bonusCard":true,"bonusPercent":0.1,"bonusPoint":0.1,"validationPeriodStart":"2019-08-24","validationPeriodEnd":"2019-08-24","canceled":true,"receivablesControl":true,"receivablesLimit":0.1,"default":true}
```

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}
```

<h3 id="post__v1_directories_partners_contracts-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Contract](#schemacontract)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-partnersgroups">PartnersGroups</h1>

## get__v1_directories_partnersgroups

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/partnersgroups \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/partnersgroups HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partnersgroups',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/partnersgroups',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/partnersgroups', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/partnersgroups', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partnersgroups");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/partnersgroups", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/partnersgroups`

<h3 id="get__v1_directories_partnersgroups-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","parent":"string","path":"string"}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "parent": "string",
    "path": "string"
  }
]
```

<h3 id="get__v1_directories_partnersgroups-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_partnersgroups-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[PartnersGroup](#schemapartnersgroup)]|false|none|none|
|» code|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» parent|string¦null|false|none|none|
|» path|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_partnersgroups

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/partnersgroups \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/partnersgroups HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partnersgroups',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/partnersgroups',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/partnersgroups', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/partnersgroups', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partnersgroups");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/partnersgroups", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/partnersgroups`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}
```

<h3 id="post__v1_directories_partnersgroups-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnersGroup](#schemapartnersgroup)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","parent":"string","path":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}
```

<h3 id="post__v1_directories_partnersgroups-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[PartnersGroup](#schemapartnersgroup)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_partnersgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/partnersgroups/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/partnersgroups/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partnersgroups/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/partnersgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/partnersgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/partnersgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partnersgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/partnersgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/partnersgroups/{code}`

<h3 id="get__v1_directories_partnersgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_partnersgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_partnersgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/partnersgroups/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/partnersgroups/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partnersgroups/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/partnersgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/partnersgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/partnersgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partnersgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/partnersgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/partnersgroups/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}
```

<h3 id="put__v1_directories_partnersgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnersGroup](#schemapartnersgroup)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","parent":"string","path":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}
```

<h3 id="put__v1_directories_partnersgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersGroup](#schemapartnersgroup)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_partnersgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/partnersgroups/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/partnersgroups/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/partnersgroups/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/partnersgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/partnersgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/partnersgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/partnersgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/partnersgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/partnersgroups/{code}`

<h3 id="delete__v1_directories_partnersgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_partnersgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-pricelisttypes">PriceListTypes</h1>

## get__v1_directories_pricelisttypes

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/pricelisttypes \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/pricelisttypes HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/pricelisttypes',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/pricelisttypes',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/pricelisttypes', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/pricelisttypes', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/pricelisttypes");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/pricelisttypes", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/pricelisttypes`

<h3 id="get__v1_directories_pricelisttypes-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","currency":"string","roundingDegree":"string","includingVAT":true}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "currency": "string",
    "roundingDegree": "string",
    "includingVAT": true
  }
]
```

<h3 id="get__v1_directories_pricelisttypes-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_pricelisttypes-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[PriceListType](#schemapricelisttype)]|false|none|none|
|» code|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» currency|string¦null|false|none|none|
|» roundingDegree|string¦null|false|none|none|
|» includingVAT|boolean¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_pricelisttypes

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/pricelisttypes \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/pricelisttypes HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/pricelisttypes',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/pricelisttypes',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/pricelisttypes', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/pricelisttypes', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/pricelisttypes");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/pricelisttypes", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/pricelisttypes`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}
```

<h3 id="post__v1_directories_pricelisttypes-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PriceListType](#schemapricelisttype)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","currency":"string","roundingDegree":"string","includingVAT":true}
```

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}
```

<h3 id="post__v1_directories_pricelisttypes-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[PriceListType](#schemapricelisttype)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_pricelisttypes_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/pricelisttypes/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/pricelisttypes/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/pricelisttypes/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/pricelisttypes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/pricelisttypes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/pricelisttypes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/pricelisttypes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/pricelisttypes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/pricelisttypes/{code}`

<h3 id="get__v1_directories_pricelisttypes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_pricelisttypes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_pricelisttypes_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/pricelisttypes/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/pricelisttypes/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/pricelisttypes/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/pricelisttypes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/pricelisttypes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/pricelisttypes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/pricelisttypes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/pricelisttypes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/pricelisttypes/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}
```

<h3 id="put__v1_directories_pricelisttypes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PriceListType](#schemapricelisttype)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","currency":"string","roundingDegree":"string","includingVAT":true}
```

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}
```

<h3 id="put__v1_directories_pricelisttypes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PriceListType](#schemapricelisttype)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_pricelisttypes_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/pricelisttypes/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/pricelisttypes/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/pricelisttypes/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/pricelisttypes/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/pricelisttypes/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/pricelisttypes/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/pricelisttypes/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/pricelisttypes/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/pricelisttypes/{code}`

<h3 id="delete__v1_directories_pricelisttypes_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_pricelisttypes_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-products">Products</h1>

## post__v1_directories_products_list

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "group": "string",
  "type": "string",
  "codes": [
    "string"
  ],
  "showMode": "string",
  "priceListTypes": [
    "string"
  ],
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products/list`

> Body parameter

```json
{
  "pageSize": 0,
  "group": "string",
  "type": "string",
  "codes": [
    "string"
  ],
  "showMode": "string",
  "priceListTypes": [
    "string"
  ],
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}
```

<h3 id="post__v1_directories_products_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductFilters](#schemaproductfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","type":"string","typeName":"string","cpaClassifier":"string","group":"string","groupName":"string","groupPath":"string","baseUnitMeasure":"string","baseUnitMeasureAbbreviation":"string","alternativeUnitMeasure":"string","alternativeUnitMeasureAbbreviation":"string","barcode":"string","specification":"string","externalCode":"string","costingMethod":"string","costingMethodName":"string","vat":true,"checkMarking":true,"weight":true,"pluCode":0,"showInPriceLists":true,"environmentalFeePercent":0.1,"labelUnitMeasure":"string","labelUnitMeasureAbbreviation":"string","labelUnitMeasureCoefficient":0.1,"country":"string","countryName":"string","producer":"string","producerName":"string","property1":"string","property2":"string","minimumQuantity":0.1,"maximumQuantity":0.1,"addedValuePercent":0.1,"aoeCoefficient":0.1,"bonusPercent":0.1,"bonusPoint":0.1,"discountPercent":0.1,"mainSupplierId":0,"mainSupplierName":"string","substituteItemsGroup":"string","substituteItemsGroupName":"string","nameEN":"string","nameRU":"string","additionalSpecification1":"string","additionalSpecification2":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","creatorName":"string","creationDate":"2019-08-24T14:15:22Z","prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "type": "string",
      "typeName": "string",
      "cpaClassifier": "string",
      "group": "string",
      "groupName": "string",
      "groupPath": "string",
      "baseUnitMeasure": "string",
      "baseUnitMeasureAbbreviation": "string",
      "alternativeUnitMeasure": "string",
      "alternativeUnitMeasureAbbreviation": "string",
      "barcode": "string",
      "specification": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "costingMethodName": "string",
      "vat": true,
      "checkMarking": true,
      "weight": true,
      "pluCode": 0,
      "showInPriceLists": true,
      "environmentalFeePercent": 0.1,
      "labelUnitMeasure": "string",
      "labelUnitMeasureAbbreviation": "string",
      "labelUnitMeasureCoefficient": 0.1,
      "country": "string",
      "countryName": "string",
      "producer": "string",
      "producerName": "string",
      "property1": "string",
      "property2": "string",
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "addedValuePercent": 0.1,
      "aoeCoefficient": 0.1,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "discountPercent": 0.1,
      "mainSupplierId": 0,
      "mainSupplierName": "string",
      "substituteItemsGroup": "string",
      "substituteItemsGroupName": "string",
      "nameEN": "string",
      "nameRU": "string",
      "additionalSpecification1": "string",
      "additionalSpecification2": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "creatorName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_directories_products_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductRowApiResponse](#schemaproductrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_products_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_products_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","type":"string","typeName":"string","cpaClassifier":"string","group":"string","groupName":"string","groupPath":"string","baseUnitMeasure":"string","baseUnitMeasureAbbreviation":"string","alternativeUnitMeasure":"string","alternativeUnitMeasureAbbreviation":"string","barcode":"string","specification":"string","externalCode":"string","costingMethod":"string","costingMethodName":"string","vat":true,"checkMarking":true,"weight":true,"pluCode":0,"showInPriceLists":true,"environmentalFeePercent":0.1,"labelUnitMeasure":"string","labelUnitMeasureAbbreviation":"string","labelUnitMeasureCoefficient":0.1,"country":"string","countryName":"string","producer":"string","producerName":"string","property1":"string","property2":"string","minimumQuantity":0.1,"maximumQuantity":0.1,"addedValuePercent":0.1,"aoeCoefficient":0.1,"bonusPercent":0.1,"bonusPoint":0.1,"discountPercent":0.1,"mainSupplierId":0,"mainSupplierName":"string","substituteItemsGroup":"string","substituteItemsGroupName":"string","nameEN":"string","nameRU":"string","additionalSpecification1":"string","additionalSpecification2":"string","lastModifierName":"string","lastModifyDate":"2019-08-24T14:15:22Z","creatorName":"string","creationDate":"2019-08-24T14:15:22Z","prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "type": "string",
      "typeName": "string",
      "cpaClassifier": "string",
      "group": "string",
      "groupName": "string",
      "groupPath": "string",
      "baseUnitMeasure": "string",
      "baseUnitMeasureAbbreviation": "string",
      "alternativeUnitMeasure": "string",
      "alternativeUnitMeasureAbbreviation": "string",
      "barcode": "string",
      "specification": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "costingMethodName": "string",
      "vat": true,
      "checkMarking": true,
      "weight": true,
      "pluCode": 0,
      "showInPriceLists": true,
      "environmentalFeePercent": 0.1,
      "labelUnitMeasure": "string",
      "labelUnitMeasureAbbreviation": "string",
      "labelUnitMeasureCoefficient": 0.1,
      "country": "string",
      "countryName": "string",
      "producer": "string",
      "producerName": "string",
      "property1": "string",
      "property2": "string",
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "addedValuePercent": 0.1,
      "aoeCoefficient": 0.1,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "discountPercent": 0.1,
      "mainSupplierId": 0,
      "mainSupplierName": "string",
      "substituteItemsGroup": "string",
      "substituteItemsGroupName": "string",
      "nameEN": "string",
      "nameRU": "string",
      "additionalSpecification1": "string",
      "additionalSpecification2": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "creatorName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_directories_products_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductRowApiResponse](#schemaproductrowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_products_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/products/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/products/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/products/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/products/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/products/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/products/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/products/{code}`

<h3 id="get__v1_directories_products_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_products_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_products_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/products/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/products/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/products/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/products/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/products/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/products/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/products/{code}`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}
```

<h3 id="put__v1_directories_products_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Product](#schemaproduct)|false|none|

> Example responses

> 200 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","type":"string","cpaClassifier":"string","group":"string","baseUnitMeasure":"string","baseUnitMeasureName":"string","baseUnitMeasureAbbreviation":"string","alternativeUnitMeasure":"string","alternativeUnitMeasureName":"string","alternativeUnitMeasureAbbreviation":"string","barcode":"string","specification":"string","externalCode":"string","costingMethod":"string","vat":true,"checkMarking":true,"weight":true,"pluCode":0,"showInPriceLists":true,"environmentalFeePercent":0.1,"labelUnitMeasure":"string","labelUnitMeasureCoefficient":0.1,"country":"string","producer":"string","property1":"string","property2":"string","minimumQuantity":0.1,"maximumQuantity":0.1,"addedValuePercent":0.1,"aoeCoefficient":0.1,"bonusPercent":0.1,"bonusPoint":0.1,"discountPercent":0.1,"mainSupplierId":0,"mainSupplierCode":"string","substituteItemsGroup":"string","nameEN":"string","nameRU":"string","additionalSpecification1":"string","additionalSpecification2":"string","measureUnits":[{"code":"string","abbreviation":"string","coefficient":0.1,"default":true}],"barcodes":[{"unitMeasure":"string","abbreviation":"string","barcode":"string"}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}
```

<h3 id="put__v1_directories_products_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Product](#schemaproduct)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_products_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/products/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/products/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/products/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/products/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/products/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/products/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/products/{code}`

<h3 id="delete__v1_directories_products_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_products_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_products

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products`

> Body parameter

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}
```

<h3 id="post__v1_directories_products-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Product](#schemaproduct)|false|none|

> Example responses

> 201 Response

```
{"id":0,"code":"string","name":"string","fullName":"string","type":"string","cpaClassifier":"string","group":"string","baseUnitMeasure":"string","baseUnitMeasureName":"string","baseUnitMeasureAbbreviation":"string","alternativeUnitMeasure":"string","alternativeUnitMeasureName":"string","alternativeUnitMeasureAbbreviation":"string","barcode":"string","specification":"string","externalCode":"string","costingMethod":"string","vat":true,"checkMarking":true,"weight":true,"pluCode":0,"showInPriceLists":true,"environmentalFeePercent":0.1,"labelUnitMeasure":"string","labelUnitMeasureCoefficient":0.1,"country":"string","producer":"string","property1":"string","property2":"string","minimumQuantity":0.1,"maximumQuantity":0.1,"addedValuePercent":0.1,"aoeCoefficient":0.1,"bonusPercent":0.1,"bonusPoint":0.1,"discountPercent":0.1,"mainSupplierId":0,"mainSupplierCode":"string","substituteItemsGroup":"string","nameEN":"string","nameRU":"string","additionalSpecification1":"string","additionalSpecification2":"string","measureUnits":[{"code":"string","abbreviation":"string","coefficient":0.1,"default":true}],"barcodes":[{"unitMeasure":"string","abbreviation":"string","barcode":"string"}]}
```

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}
```

<h3 id="post__v1_directories_products-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Product](#schemaproduct)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_products_measureunits_list

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products/measureunits/list \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products/measureunits/list HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/measureunits/list',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products/measureunits/list',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products/measureunits/list', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products/measureunits/list', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/measureunits/list");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products/measureunits/list", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products/measureunits/list`

> Body parameter

```json
{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}
```

<h3 id="post__v1_directories_products_measureunits_list-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[MeasureUnitFilters](#schemameasureunitfilters)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","coefficient":0.1,"default":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureName": "string",
      "unitMeasureAbbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_products_measureunits_list-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductMeasureUnitApiResponse](#schemaproductmeasureunitapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_products_measureunits_list_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products/measureunits/list/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products/measureunits/list/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/measureunits/list/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products/measureunits/list/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products/measureunits/list/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products/measureunits/list/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/measureunits/list/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products/measureunits/list/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products/measureunits/list/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_directories_products_measureunits_list_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","coefficient":0.1,"default":true}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureName": "string",
      "unitMeasureAbbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ]
}
```

<h3 id="post__v1_directories_products_measureunits_list_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductMeasureUnitApiResponse](#schemaproductmeasureunitapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_products_{productCode}_measureunits_{unitCode}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/products/{productCode}/measureunits/{unitCode} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/products/{productCode}/measureunits/{unitCode} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{productCode}/measureunits/{unitCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/products/{productCode}/measureunits/{unitCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/products/{productCode}/measureunits/{unitCode}`

<h3 id="get__v1_directories_products_{productcode}_measureunits_{unitcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|productCode|path|string|true|none|
|unitCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_products_{productcode}_measureunits_{unitcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_products_{productCode}_measureunits_{unitCode}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/products/{productCode}/measureunits/{unitCode} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/products/{productCode}/measureunits/{unitCode} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{productCode}/measureunits/{unitCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/products/{productCode}/measureunits/{unitCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/products/{productCode}/measureunits/{unitCode}`

> Body parameter

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}
```

<h3 id="put__v1_directories_products_{productcode}_measureunits_{unitcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|productCode|path|string|true|none|
|unitCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductMeasureUnit](#schemaproductmeasureunit)|false|none|

> Example responses

> 200 Response

```
{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","coefficient":0.1,"default":true}
```

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}
```

<h3 id="put__v1_directories_products_{productcode}_measureunits_{unitcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductMeasureUnit](#schemaproductmeasureunit)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_products_{productCode}_measureunits_{unitCode}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/products/{productCode}/measureunits/{unitCode} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/products/{productCode}/measureunits/{unitCode} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/products/{productCode}/measureunits/{unitCode}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/products/{productCode}/measureunits/{unitCode}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/{productCode}/measureunits/{unitCode}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/products/{productCode}/measureunits/{unitCode}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/products/{productCode}/measureunits/{unitCode}`

<h3 id="delete__v1_directories_products_{productcode}_measureunits_{unitcode}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|productCode|path|string|true|none|
|unitCode|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_products_{productcode}_measureunits_{unitcode}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_products_measureunits

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/products/measureunits \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/products/measureunits HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/products/measureunits',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/products/measureunits',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/products/measureunits', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/products/measureunits', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/products/measureunits");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/products/measureunits", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/products/measureunits`

> Body parameter

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}
```

<h3 id="post__v1_directories_products_measureunits-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductMeasureUnit](#schemaproductmeasureunit)|false|none|

> Example responses

> 201 Response

```
{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureName":"string","unitMeasureAbbreviation":"string","coefficient":0.1,"default":true}
```

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}
```

<h3 id="post__v1_directories_products_measureunits-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[ProductMeasureUnit](#schemaproductmeasureunit)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-productsgroups">ProductsGroups</h1>

## get__v1_directories_productsgroups

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/productsgroups \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/productsgroups HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/productsgroups',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/productsgroups',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/productsgroups', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/productsgroups', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/productsgroups");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/productsgroups", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/productsgroups`

<h3 id="get__v1_directories_productsgroups-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","parent":"string","path":"string","nameEN":"string","nameRU":"string"}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "parent": "string",
    "path": "string",
    "nameEN": "string",
    "nameRU": "string"
  }
]
```

<h3 id="get__v1_directories_productsgroups-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_productsgroups-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[ProductsGroup](#schemaproductsgroup)]|false|none|none|
|» code|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» parent|string¦null|false|none|none|
|» path|string¦null|false|none|none|
|» nameEN|string¦null|false|none|none|
|» nameRU|string¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_productsgroups

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/productsgroups \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/productsgroups HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/productsgroups',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/productsgroups',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/productsgroups', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/productsgroups', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/productsgroups");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/productsgroups", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/productsgroups`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}
```

<h3 id="post__v1_directories_productsgroups-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsGroup](#schemaproductsgroup)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","parent":"string","path":"string","nameEN":"string","nameRU":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}
```

<h3 id="post__v1_directories_productsgroups-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[ProductsGroup](#schemaproductsgroup)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_productsgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/productsgroups/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/productsgroups/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/productsgroups/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/productsgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/productsgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/productsgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/productsgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/productsgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/productsgroups/{code}`

<h3 id="get__v1_directories_productsgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_productsgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_productsgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/productsgroups/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/productsgroups/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/productsgroups/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/productsgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/productsgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/productsgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/productsgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/productsgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/productsgroups/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}
```

<h3 id="put__v1_directories_productsgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsGroup](#schemaproductsgroup)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","parent":"string","path":"string","nameEN":"string","nameRU":"string"}
```

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}
```

<h3 id="put__v1_directories_productsgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsGroup](#schemaproductsgroup)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_productsgroups_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/productsgroups/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/productsgroups/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/productsgroups/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/productsgroups/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/productsgroups/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/productsgroups/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/productsgroups/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/productsgroups/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/productsgroups/{code}`

<h3 id="delete__v1_directories_productsgroups_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_productsgroups_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-productsmovement">ProductsMovement</h1>

## get__v1_documents_productsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/productsmovement/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/productsmovement/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/productsmovement/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/productsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/productsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/productsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/productsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/productsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/productsmovement/{isn}`

<h3 id="get__v1_documents_productsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_productsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_productsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/productsmovement/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/productsmovement/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/productsmovement/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/productsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/productsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/productsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/productsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/productsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/productsmovement/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_productsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsMovement](#schemaproductsmovement)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","priceType":"string","comment":"string","owner":"string","mediator":"string","chiefAccount":"string","allowed":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","transportationMethod":"string","vehicle":true,"brand":"string","licensePlate":"string","baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"saleAmount":0.1,"description":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_productsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsMovement](#schemaproductsmovement)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_productsmovement_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/productsmovement/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/productsmovement/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/productsmovement/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/productsmovement/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/productsmovement/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/productsmovement/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/productsmovement/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/productsmovement/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/productsmovement/{isn}`

<h3 id="delete__v1_documents_productsmovement_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_productsmovement_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_productsmovement

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/productsmovement \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/productsmovement HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/productsmovement',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/productsmovement',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/productsmovement', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/productsmovement', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/productsmovement");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/productsmovement", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/productsmovement`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_productsmovement-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsMovement](#schemaproductsmovement)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storageOutput":"string","storageInput":"string","priceType":"string","comment":"string","owner":"string","mediator":"string","chiefAccount":"string","allowed":"string","bookNumber":"string","bookPage":0,"bookLine":0,"taxExportType":"string","taxInvoiceSeries":"string","taxInvoiceNumber":"string","submissionDate":"2019-08-24","transportationMethod":"string","vehicle":true,"brand":"string","licensePlate":"string","baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"saleAmount":0.1,"description":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_productsmovement-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[ProductsMovement](#schemaproductsmovement)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-reports">Reports</h1>

## post__v1_reports_partnersbalances

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/partnersbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/partnersbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "currency": "string",
  "reportCurrency": "string",
  "openedByContracts": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/partnersbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/partnersbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/partnersbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/partnersbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/partnersbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/partnersbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnersbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "currency": "string",
  "reportCurrency": "string",
  "openedByContracts": true
}
```

<h3 id="post__v1_reports_partnersbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PartnersBalancesParam](#schemapartnersbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","status":"string","contractCode":"string","contractName":"string","contractDate":"2019-08-24","currency":"string","balance":0.1,"balanceCurrency":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "currency": "string",
      "balance": 0.1,
      "balanceCurrency": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_partnersbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersBalancesDataRowApiResponse](#schemapartnersbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_partnersbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/partnersbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/partnersbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/partnersbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/partnersbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/partnersbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/partnersbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/partnersbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/partnersbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/partnersbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_partnersbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","status":"string","contractCode":"string","contractName":"string","contractDate":"2019-08-24","currency":"string","balance":0.1,"balanceCurrency":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "currency": "string",
      "balance": 0.1,
      "balanceCurrency": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_partnersbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PartnersBalancesDataRowApiResponse](#schemapartnersbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_productsbalances

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/productsbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/productsbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showByDifferentParties": true,
  "openedByStorages": true,
  "minimumQuantities": "string",
  "subtotalType": "string",
  "priceListTypes": [
    "string"
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/productsbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/productsbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/productsbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/productsbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/productsbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/productsbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/productsbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showByDifferentParties": true,
  "openedByStorages": true,
  "minimumQuantities": "string",
  "subtotalType": "string",
  "priceListTypes": [
    "string"
  ]
}
```

<h3 id="post__v1_reports_productsbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsBalancesParam](#schemaproductsbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","specification":"string","group":"string","groupName":"string","storage":"string","storageName":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costAmountCurrency":0.1,"costPriceWithoutVAT":0.1,"costPriceWithVAT":0.1,"costPriceCurrency":0.1,"minimumQuantity":0.1,"variance":0.1,"maximumQuantity":0.1,"orderQuantity":0.1,"orderComment":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierName":"string","partySupplierTaxCode":"string","partyContractCode":"string","partyContractName":"string","partyDocumentNumber":"string","partyDocumentType":"string","partyExpirationDate":"2019-08-24","partyCountryCode":"string","partyCountryName":"string","partyProducerCode":"string","partyProducerName":"string","partyPropertyType1Code":"string","partyPropertyType1Name":"string","partyPropertyValue1Code":"string","partyPropertyValue1Name":"string","partyPropertyType2Code":"string","partyPropertyType2Name":"string","partyPropertyValue2Code":"string","partyPropertyValue2Name":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0,"prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "specification": "string",
      "group": "string",
      "groupName": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceWithoutVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "costPriceCurrency": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractCode": "string",
      "partyContractName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryCode": "string",
      "partyCountryName": "string",
      "partyProducerCode": "string",
      "partyProducerName": "string",
      "partyPropertyType1Code": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Code": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Code": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Code": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_reports_productsbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsBalancesDataRowApiResponse](#schemaproductsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_productsbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/productsbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/productsbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/productsbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/productsbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/productsbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/productsbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/productsbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/productsbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/productsbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_productsbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","specification":"string","group":"string","groupName":"string","storage":"string","storageName":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costAmountCurrency":0.1,"costPriceWithoutVAT":0.1,"costPriceWithVAT":0.1,"costPriceCurrency":0.1,"minimumQuantity":0.1,"variance":0.1,"maximumQuantity":0.1,"orderQuantity":0.1,"orderComment":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierName":"string","partySupplierTaxCode":"string","partyContractCode":"string","partyContractName":"string","partyDocumentNumber":"string","partyDocumentType":"string","partyExpirationDate":"2019-08-24","partyCountryCode":"string","partyCountryName":"string","partyProducerCode":"string","partyProducerName":"string","partyPropertyType1Code":"string","partyPropertyType1Name":"string","partyPropertyValue1Code":"string","partyPropertyValue1Name":"string","partyPropertyType2Code":"string","partyPropertyType2Name":"string","partyPropertyValue2Code":"string","partyPropertyValue2Name":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0,"prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "specification": "string",
      "group": "string",
      "groupName": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceWithoutVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "costPriceCurrency": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractCode": "string",
      "partyContractName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryCode": "string",
      "partyCountryName": "string",
      "partyProducerCode": "string",
      "partyProducerName": "string",
      "partyPropertyType1Code": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Code": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Code": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Code": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_reports_productsbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsBalancesDataRowApiResponse](#schemaproductsbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_productsbalances_short

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/productsbalances/short \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/productsbalances/short HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "priceType": "string",
  "showZeroRows": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/productsbalances/short',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/productsbalances/short',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/productsbalances/short', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/productsbalances/short', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/productsbalances/short");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/productsbalances/short", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/productsbalances/short`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "priceType": "string",
  "showZeroRows": true
}
```

<h3 id="post__v1_reports_productsbalances_short-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[ProductsBalancesShortParam](#schemaproductsbalancesshortparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","specification":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costAmountCurrency":0.1,"salePrice":0.1,"salePriceAmount":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "specification": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "salePrice": 0.1,
      "salePriceAmount": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_productsbalances_short-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsBalancesShortDataRowApiResponse](#schemaproductsbalancesshortdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_productsbalances_short_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/productsbalances/short/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/productsbalances/short/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/productsbalances/short/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/productsbalances/short/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/productsbalances/short/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/productsbalances/short/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/productsbalances/short/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/productsbalances/short/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/productsbalances/short/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_productsbalances_short_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"id":0,"code":"string","name":"string","fullName":"string","specification":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costAmountCurrency":0.1,"salePrice":0.1,"salePriceAmount":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "specification": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "salePrice": 0.1,
      "salePriceAmount": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_productsbalances_short_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[ProductsBalancesShortDataRowApiResponse](#schemaproductsbalancesshortdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_pricelist

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/pricelist \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/pricelist HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "priceListTypes": [
    "string"
  ],
  "itemType": "string",
  "group": "string",
  "itemCodes": [
    "string"
  ],
  "itemsShowMode": "string",
  "showAvailables": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/pricelist',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/pricelist',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/pricelist', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/pricelist', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/pricelist");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/pricelist", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/pricelist`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "priceListTypes": [
    "string"
  ],
  "itemType": "string",
  "group": "string",
  "itemCodes": [
    "string"
  ],
  "itemsShowMode": "string",
  "showAvailables": true
}
```

<h3 id="post__v1_reports_pricelist-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[PriceListParam](#schemapricelistparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","group":"string","groupName":"string","specification":"string","prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_reports_pricelist-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PriceListDataRowApiResponse](#schemapricelistdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_pricelist_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/pricelist/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/pricelist/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/pricelist/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/pricelist/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/pricelist/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/pricelist/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/pricelist/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/pricelist/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/pricelist/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_pricelist_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","group":"string","groupName":"string","specification":"string","prices":{"property1":0.1,"property2":0.1}}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}
```

<h3 id="post__v1_reports_pricelist_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[PriceListDataRowApiResponse](#schemapricelistdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_salesanalysis

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/salesanalysis \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/salesanalysis HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storages": [
    "string"
  ],
  "itemType": "string",
  "itemsGroup": "string",
  "itemCode": "string",
  "partnersGroup": "string",
  "partnerCode": "string",
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showParties": true,
  "showCostAndSalePrices": true,
  "showDiscounts": true,
  "showBonusPoints": true,
  "showVATAmounts": true,
  "groupBy": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/salesanalysis',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/salesanalysis',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/salesanalysis', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/salesanalysis', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/salesanalysis");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/salesanalysis", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/salesanalysis`

> Body parameter

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storages": [
    "string"
  ],
  "itemType": "string",
  "itemsGroup": "string",
  "itemCode": "string",
  "partnersGroup": "string",
  "partnerCode": "string",
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showParties": true,
  "showCostAndSalePrices": true,
  "showDiscounts": true,
  "showBonusPoints": true,
  "showVATAmounts": true,
  "groupBy": "string"
}
```

<h3 id="post__v1_reports_salesanalysis-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[SalesAnalysisParam](#schemasalesanalysisparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"documentNumber":"string","date":"2019-08-24","isn":"13a02e4e-9f55-416a-842c-b67b097485f4","operationType":"string","documentCurrency":"string","documentVATType":"string","documentVATTypeName":"string","ecrCheckNumber":"string","itemType":"string","itemTypeName":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","storage":"string","storageName":"string","cashDesk":"string","cashDeskName":"string","customer":"string","customerName":"string","customerContractName":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costPriceWithoutVAT":0.1,"salePriceWithoutVAT":0.1,"saleAmountWithoutVAT":0.1,"profitWithoutVAT":0.1,"profitPercentBySaleWithoutVAT":0.1,"profitPercentByCostWithoutVAT":0.1,"initialPriceWithoutVAT":0.1,"initialAmountWithoutVAT":0.1,"discountPercentWithoutVAT":0.1,"discountAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costPriceWithVAT":0.1,"salePriceWithVAT":0.1,"saleAmountWithVAT":0.1,"profitWithVAT":0.1,"profitPercentBySaleWithVAT":0.1,"profitPercentByCostWithVAT":0.1,"initialPriceWithVAT":0.1,"initialAmountWithVAT":0.1,"discountPercentWithVAT":0.1,"discountAmountWithVAT":0.1,"costVATAmount":0.1,"costVATPrice":0.1,"saleVATAmount":0.1,"discountVATAmount":0.1,"costAmountCurrency":0.1,"costPriceCurrency":0.1,"salePriceCurrency":0.1,"saleAmountCurrency":0.1,"profitCurrency":0.1,"profitPercentBySaleCurrency":0.1,"profitPercentByCostCurrency":0.1,"initialPriceCurrency":0.1,"initialAmountCurrency":0.1,"discountPercentCurrency":0.1,"discountAmountCurrency":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"description":"string","seller":"string","sellerName":"string","comment":"string","itemGroup":"string","itemSpecification":"string","businessAddress":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierName":"string","partySupplierTaxCode":"string","partyContractName":"string","partyDocumentTypeName":"string","partyDocumentNumber":"string","partyExpirationDate":"2019-08-24","partyCountryName":"string","partyProducerName":"string","partyPropertyType1Name":"string","partyPropertyValue1Name":"string","partyPropertyType2Name":"string","partyPropertyValue2Name":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "documentNumber": "string",
      "date": "2019-08-24",
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "operationType": "string",
      "documentCurrency": "string",
      "documentVATType": "string",
      "documentVATTypeName": "string",
      "ecrCheckNumber": "string",
      "itemType": "string",
      "itemTypeName": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "cashDesk": "string",
      "cashDeskName": "string",
      "customer": "string",
      "customerName": "string",
      "customerContractName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costPriceWithoutVAT": 0.1,
      "salePriceWithoutVAT": 0.1,
      "saleAmountWithoutVAT": 0.1,
      "profitWithoutVAT": 0.1,
      "profitPercentBySaleWithoutVAT": 0.1,
      "profitPercentByCostWithoutVAT": 0.1,
      "initialPriceWithoutVAT": 0.1,
      "initialAmountWithoutVAT": 0.1,
      "discountPercentWithoutVAT": 0.1,
      "discountAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "salePriceWithVAT": 0.1,
      "saleAmountWithVAT": 0.1,
      "profitWithVAT": 0.1,
      "profitPercentBySaleWithVAT": 0.1,
      "profitPercentByCostWithVAT": 0.1,
      "initialPriceWithVAT": 0.1,
      "initialAmountWithVAT": 0.1,
      "discountPercentWithVAT": 0.1,
      "discountAmountWithVAT": 0.1,
      "costVATAmount": 0.1,
      "costVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "discountVATAmount": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceCurrency": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "profitCurrency": 0.1,
      "profitPercentBySaleCurrency": 0.1,
      "profitPercentByCostCurrency": 0.1,
      "initialPriceCurrency": 0.1,
      "initialAmountCurrency": 0.1,
      "discountPercentCurrency": 0.1,
      "discountAmountCurrency": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "description": "string",
      "seller": "string",
      "sellerName": "string",
      "comment": "string",
      "itemGroup": "string",
      "itemSpecification": "string",
      "businessAddress": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractName": "string",
      "partyDocumentTypeName": "string",
      "partyDocumentNumber": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryName": "string",
      "partyProducerName": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0
    }
  ]
}
```

<h3 id="post__v1_reports_salesanalysis-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[SalesAnalysisDataRowApiResponse](#schemasalesanalysisdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_salesanalysis_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/salesanalysis/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/salesanalysis/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/salesanalysis/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/salesanalysis/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/salesanalysis/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/salesanalysis/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/salesanalysis/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/salesanalysis/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/salesanalysis/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_salesanalysis_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"documentNumber":"string","date":"2019-08-24","isn":"13a02e4e-9f55-416a-842c-b67b097485f4","operationType":"string","documentCurrency":"string","documentVATType":"string","documentVATTypeName":"string","ecrCheckNumber":"string","itemType":"string","itemTypeName":"string","itemId":0,"itemCode":"string","itemName":"string","unitMeasure":"string","unitMeasureAbbreviation":"string","storage":"string","storageName":"string","cashDesk":"string","cashDeskName":"string","customer":"string","customerName":"string","customerContractName":"string","quantity":0.1,"costAmountWithoutVAT":0.1,"costPriceWithoutVAT":0.1,"salePriceWithoutVAT":0.1,"saleAmountWithoutVAT":0.1,"profitWithoutVAT":0.1,"profitPercentBySaleWithoutVAT":0.1,"profitPercentByCostWithoutVAT":0.1,"initialPriceWithoutVAT":0.1,"initialAmountWithoutVAT":0.1,"discountPercentWithoutVAT":0.1,"discountAmountWithoutVAT":0.1,"costAmountWithVAT":0.1,"costPriceWithVAT":0.1,"salePriceWithVAT":0.1,"saleAmountWithVAT":0.1,"profitWithVAT":0.1,"profitPercentBySaleWithVAT":0.1,"profitPercentByCostWithVAT":0.1,"initialPriceWithVAT":0.1,"initialAmountWithVAT":0.1,"discountPercentWithVAT":0.1,"discountAmountWithVAT":0.1,"costVATAmount":0.1,"costVATPrice":0.1,"saleVATAmount":0.1,"discountVATAmount":0.1,"costAmountCurrency":0.1,"costPriceCurrency":0.1,"salePriceCurrency":0.1,"saleAmountCurrency":0.1,"profitCurrency":0.1,"profitPercentBySaleCurrency":0.1,"profitPercentByCostCurrency":0.1,"initialPriceCurrency":0.1,"initialAmountCurrency":0.1,"discountPercentCurrency":0.1,"discountAmountCurrency":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"description":"string","seller":"string","sellerName":"string","comment":"string","itemGroup":"string","itemSpecification":"string","businessAddress":"string","incomeDate":"2019-08-24","partySupplierId":0,"partySupplierName":"string","partySupplierTaxCode":"string","partyContractName":"string","partyDocumentTypeName":"string","partyDocumentNumber":"string","partyExpirationDate":"2019-08-24","partyCountryName":"string","partyProducerName":"string","partyPropertyType1Name":"string","partyPropertyValue1Name":"string","partyPropertyType2Name":"string","partyPropertyValue2Name":"string","partyBase":"c39df95f-1f9b-4de1-8155-0f24e1c3b455","partyRow":0}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "documentNumber": "string",
      "date": "2019-08-24",
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "operationType": "string",
      "documentCurrency": "string",
      "documentVATType": "string",
      "documentVATTypeName": "string",
      "ecrCheckNumber": "string",
      "itemType": "string",
      "itemTypeName": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "cashDesk": "string",
      "cashDeskName": "string",
      "customer": "string",
      "customerName": "string",
      "customerContractName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costPriceWithoutVAT": 0.1,
      "salePriceWithoutVAT": 0.1,
      "saleAmountWithoutVAT": 0.1,
      "profitWithoutVAT": 0.1,
      "profitPercentBySaleWithoutVAT": 0.1,
      "profitPercentByCostWithoutVAT": 0.1,
      "initialPriceWithoutVAT": 0.1,
      "initialAmountWithoutVAT": 0.1,
      "discountPercentWithoutVAT": 0.1,
      "discountAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "salePriceWithVAT": 0.1,
      "saleAmountWithVAT": 0.1,
      "profitWithVAT": 0.1,
      "profitPercentBySaleWithVAT": 0.1,
      "profitPercentByCostWithVAT": 0.1,
      "initialPriceWithVAT": 0.1,
      "initialAmountWithVAT": 0.1,
      "discountPercentWithVAT": 0.1,
      "discountAmountWithVAT": 0.1,
      "costVATAmount": 0.1,
      "costVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "discountVATAmount": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceCurrency": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "profitCurrency": 0.1,
      "profitPercentBySaleCurrency": 0.1,
      "profitPercentByCostCurrency": 0.1,
      "initialPriceCurrency": 0.1,
      "initialAmountCurrency": 0.1,
      "discountPercentCurrency": 0.1,
      "discountAmountCurrency": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "description": "string",
      "seller": "string",
      "sellerName": "string",
      "comment": "string",
      "itemGroup": "string",
      "itemSpecification": "string",
      "businessAddress": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractName": "string",
      "partyDocumentTypeName": "string",
      "partyDocumentNumber": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryName": "string",
      "partyProducerName": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0
    }
  ]
}
```

<h3 id="post__v1_reports_salesanalysis_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[SalesAnalysisDataRowApiResponse](#schemasalesanalysisdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_bonusbalances

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/bonusbalances \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/bonusbalances HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "openedByContracts": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/bonusbalances',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/bonusbalances',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/bonusbalances', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/bonusbalances', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/bonusbalances");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/bonusbalances", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/bonusbalances`

> Body parameter

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "openedByContracts": true
}
```

<h3 id="post__v1_reports_bonusbalances-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[BonusBalancesParam](#schemabonusbalancesparam)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"partnerId":0,"partnerCode":"string","partnerName":"string","contractCode":"string","contractName":"string","contractDate":"2019-08-24","group":"string","taxCode":"string","legalAddress":"string","phoneNumber":"string","balance":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "group": "string",
      "taxCode": "string",
      "legalAddress": "string",
      "phoneNumber": "string",
      "balance": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_bonusbalances-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[BonusBalancesDataRowApiResponse](#schemabonusbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_reports_bonusbalances_nextpage

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/reports/bonusbalances/nextpage \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/reports/bonusbalances/nextpage HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/reports/bonusbalances/nextpage',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/reports/bonusbalances/nextpage',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/reports/bonusbalances/nextpage', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/reports/bonusbalances/nextpage', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/reports/bonusbalances/nextpage");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/reports/bonusbalances/nextpage", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/reports/bonusbalances/nextpage`

> Body parameter

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}
```

<h3 id="post__v1_reports_bonusbalances_nextpage-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[NextPageRequest](#schemanextpagerequest)|false|none|

> Example responses

> 200 Response

```
{"id":"497f6eca-6276-4993-bfeb-53cbbbba6f08","hasMore":true,"data":[{"partnerId":0,"partnerCode":"string","partnerName":"string","contractCode":"string","contractName":"string","contractDate":"2019-08-24","group":"string","taxCode":"string","legalAddress":"string","phoneNumber":"string","balance":0.1}]}
```

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "group": "string",
      "taxCode": "string",
      "legalAddress": "string",
      "phoneNumber": "string",
      "balance": 0.1
    }
  ]
}
```

<h3 id="post__v1_reports_bonusbalances_nextpage-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[BonusBalancesDataRowApiResponse](#schemabonusbalancesdatarowapiresponse)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-sale">Sale</h1>

## get__v1_documents_sale_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/sale/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/sale/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/sale/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/sale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/sale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/sale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/sale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/sale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/sale/{isn}`

<h3 id="get__v1_documents_sale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_sale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_sale_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/sale/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/sale/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/sale/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/sale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/sale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/sale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/sale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/sale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/sale/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="put__v1_documents_sale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Sale](#schemasale)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","cashDesk":"string","cashierShiftNumber":"string","ecrCheckNumber":"string","prepaymentECRCheckNumber":"string","customer":"string","customerContract":"string","seller":"string","printExpenseConfirmingCheck":true,"cashAmount":0.1,"nonCashAmount":0.1,"posBank":"string","posContract":"string","connectedDevice":"string","paymentSystem":0,"creditAmount":0.1,"prepaymentAmount":0.1,"prepaymentCustomer":"string","prepaymentContract":"string","changeAmount":0.1,"bonusAmount":0.1,"addedBonus":0.1,"accumulatedBonus":0.1,"vatCalculationType":"string","priceType":"string","discountPriceType":"string","comment":"string","owner":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"itemList":[{"type":"string","storage":"string","barcode":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"vat":true,"description":"string","deleted":true,"gift":true,"rowNumber":0,"rowId":0,"cpaClassifier":"string","markingList":["string"]}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="put__v1_documents_sale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Sale](#schemasale)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_sale_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/sale/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/sale/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/sale/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/sale/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/sale/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/sale/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/sale/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/sale/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/sale/{isn}`

<h3 id="delete__v1_documents_sale_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_sale_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_sale

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/sale \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/sale HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/sale',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/sale',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/sale', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/sale', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/sale");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/sale", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/sale`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="post__v1_documents_sale-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Sale](#schemasale)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"storage":"string","cashDesk":"string","cashierShiftNumber":"string","ecrCheckNumber":"string","prepaymentECRCheckNumber":"string","customer":"string","customerContract":"string","seller":"string","printExpenseConfirmingCheck":true,"cashAmount":0.1,"nonCashAmount":0.1,"posBank":"string","posContract":"string","connectedDevice":"string","paymentSystem":0,"creditAmount":0.1,"prepaymentAmount":0.1,"prepaymentCustomer":"string","prepaymentContract":"string","changeAmount":0.1,"bonusAmount":0.1,"addedBonus":0.1,"accumulatedBonus":0.1,"vatCalculationType":"string","priceType":"string","discountPriceType":"string","comment":"string","owner":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"itemList":[{"type":"string","storage":"string","barcode":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"vat":true,"description":"string","deleted":true,"gift":true,"rowNumber":0,"rowId":0,"cpaClassifier":"string","markingList":["string"]}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="post__v1_documents_sale-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Sale](#schemasale)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-salereturn">SaleReturn</h1>

## get__v1_documents_salereturn_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/salereturn/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/salereturn/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/salereturn/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/salereturn/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/salereturn/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/salereturn/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/salereturn/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/salereturn/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/salereturn/{isn}`

<h3 id="get__v1_documents_salereturn_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_salereturn_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_salereturn_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/salereturn/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/salereturn/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/salereturn/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/salereturn/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/salereturn/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/salereturn/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/salereturn/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/salereturn/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/salereturn/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="put__v1_documents_salereturn_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[SaleReturn](#schemasalereturn)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","state":0,"storage":"string","cashDesk":"string","cashierShiftNumber":"string","ecrReturnCheckNumber":"string","prepaymentECRCheckNumber":"string","customer":"string","customerContract":"string","seller":"string","cashAmount":0.1,"nonCashAmount":0.1,"posBank":"string","posContract":"string","connectedDevice":"string","paymentSystem":0,"creditAmount":0.1,"prepaymentAmount":0.1,"prepaymentCustomer":"string","prepaymentContract":"string","bonusAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"changeAmount":0.1,"vatCalculationType":"string","priceType":"string","comment":"string","owner":"string","vatAmount":0.1,"totalAmount":0.1,"itemList":[{"type":"string","storage":"string","barcode":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"vat":true,"description":"string","deleted":true,"gift":true,"rowNumber":0,"rowId":0,"baseRowId":0,"cpaClassifier":"string","markingList":["string"]}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="put__v1_documents_salereturn_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[SaleReturn](#schemasalereturn)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_salereturn_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/salereturn/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/salereturn/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/salereturn/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/salereturn/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/salereturn/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/salereturn/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/salereturn/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/salereturn/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/salereturn/{isn}`

<h3 id="delete__v1_documents_salereturn_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_salereturn_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_salereturn

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/salereturn \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/salereturn HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/salereturn',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/salereturn',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/salereturn', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/salereturn', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/salereturn");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/salereturn", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/salereturn`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="post__v1_documents_salereturn-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[SaleReturn](#schemasalereturn)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","state":0,"storage":"string","cashDesk":"string","cashierShiftNumber":"string","ecrReturnCheckNumber":"string","prepaymentECRCheckNumber":"string","customer":"string","customerContract":"string","seller":"string","cashAmount":0.1,"nonCashAmount":0.1,"posBank":"string","posContract":"string","connectedDevice":"string","paymentSystem":0,"creditAmount":0.1,"prepaymentAmount":0.1,"prepaymentCustomer":"string","prepaymentContract":"string","bonusAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"changeAmount":0.1,"vatCalculationType":"string","priceType":"string","comment":"string","owner":"string","vatAmount":0.1,"totalAmount":0.1,"itemList":[{"type":"string","storage":"string","barcode":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"salePrice":0.1,"discountPercent":0.1,"discountedPrice":0.1,"discountedAmount":0.1,"discountAmount":0.1,"usedBonus":0.1,"accumulatedBonus":0.1,"vat":true,"description":"string","deleted":true,"gift":true,"rowNumber":0,"rowId":0,"baseRowId":0,"cpaClassifier":"string","markingList":["string"]}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}
```

<h3 id="post__v1_documents_salereturn-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[SaleReturn](#schemasalereturn)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-storageinputorder">StorageInputOrder</h1>

## get__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/storageinputorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/storageinputorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorder/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/storageinputorder/{isn}`

<h3 id="get__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/storageinputorder/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/storageinputorder/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorder/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/storageinputorder/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrder](#schemastorageinputorder)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","storage":"string","supplierCode":"string","supplierContract":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","includeVATInCost":true,"priceType":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccount":"string","allowed":"string","accepted":"string","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"description":"string","vat":true,"expirationDate":"2019-08-24","country":"string","producer":"string","property1":"string","property2":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrder](#schemastorageinputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_storageinputorder_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/storageinputorder/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/storageinputorder/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorder/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/storageinputorder/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/storageinputorder/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/storageinputorder/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorder/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/storageinputorder/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/storageinputorder/{isn}`

<h3 id="delete__v1_documents_storageinputorder_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_storageinputorder_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_storageinputorder

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/storageinputorder \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/storageinputorder HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorder',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/storageinputorder',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/storageinputorder', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/storageinputorder', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorder");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/storageinputorder", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/storageinputorder`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorder-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrder](#schemastorageinputorder)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","storage":"string","supplierCode":"string","supplierContract":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","includeVATInCost":true,"priceType":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccount":"string","allowed":"string","accepted":"string","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"description":"string","vat":true,"expirationDate":"2019-08-24","country":"string","producer":"string","property1":"string","property2":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorder-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[StorageInputOrder](#schemastorageinputorder)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-storageinputorderretail">StorageInputOrderRetail</h1>

## get__v1_documents_storageinputorderretail_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/storageinputorderretail/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/storageinputorderretail/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorderretail/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/storageinputorderretail/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/storageinputorderretail/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/storageinputorderretail/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorderretail/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/storageinputorderretail/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/storageinputorderretail/{isn}`

<h3 id="get__v1_documents_storageinputorderretail_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_storageinputorderretail_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_storageinputorderretail_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/storageinputorderretail/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/storageinputorderretail/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorderretail/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/storageinputorderretail/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/storageinputorderretail/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/storageinputorderretail/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorderretail/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/storageinputorderretail/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/storageinputorderretail/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorderretail_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrderRetail](#schemastorageinputorderretail)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","storage":"string","supplierCode":"string","supplierContract":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","includeVATInCost":true,"priceType":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccount":"string","allowed":"string","accepted":"string","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"addedValuePercent":0.1,"salePrice":0.1,"saleAmount":0.1,"description":"string","vat":true,"expirationDate":"2019-08-24","country":"string","producer":"string","property1":"string","property2":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_storageinputorderretail_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[StorageInputOrderRetail](#schemastorageinputorderretail)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_storageinputorderretail_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/storageinputorderretail/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/storageinputorderretail/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorderretail/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/storageinputorderretail/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/storageinputorderretail/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/storageinputorderretail/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorderretail/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/storageinputorderretail/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/storageinputorderretail/{isn}`

<h3 id="delete__v1_documents_storageinputorderretail_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_storageinputorderretail_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_storageinputorderretail

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/storageinputorderretail \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/storageinputorderretail HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/storageinputorderretail',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/storageinputorderretail',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/storageinputorderretail', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/storageinputorderretail', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/storageinputorderretail");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/storageinputorderretail", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/storageinputorderretail`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorderretail-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[StorageInputOrderRetail](#schemastorageinputorderretail)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"baseDocumentISN":"e3cf3357-51e7-469a-a6c4-77dfddcb9255","storage":"string","supplierCode":"string","supplierContract":"string","purchaseDocumentNumber":"string","purchaseDocumentDate":"2019-08-24","comment":"string","owner":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"vatCalculationType":"string","includeVATInCost":true,"priceType":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"letterOfAttorney":"string","mediator":"string","vehicle":"string","chiefAccount":"string","allowed":"string","accepted":"string","productsList":[{"id":0,"code":"string","name":"string","fullName":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"addedValuePercent":0.1,"salePrice":0.1,"saleAmount":0.1,"description":"string","vat":true,"expirationDate":"2019-08-24","country":"string","producer":"string","property1":"string","property2":"string","rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_storageinputorderretail-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[StorageInputOrderRetail](#schemastorageinputorderretail)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-storages">Storages</h1>

## get__v1_directories_storages

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/storages \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/storages HTTP/1.1

Accept: text/plain
Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/storages',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/storages',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/storages', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/storages', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/storages");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/storages", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/storages`

<h3 id="get__v1_directories_storages-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

> Example responses

> 200 Response

```
[{"code":"string","name":"string","stockkeeper":"string","address":"string","retail":true}]
```

```json
[
  {
    "code": "string",
    "name": "string",
    "stockkeeper": "string",
    "address": "string",
    "retail": true
  }
]
```

<h3 id="get__v1_directories_storages-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|Inline|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<h3 id="get__v1_directories_storages-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[Storage](#schemastorage)]|false|none|none|
|» code|string¦null|false|none|none|
|» name|string¦null|false|none|none|
|» stockkeeper|string¦null|false|none|none|
|» address|string¦null|false|none|none|
|» retail|boolean¦null|false|none|none|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_directories_storages

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/directories/storages \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/directories/storages HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/storages',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/directories/storages',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/directories/storages', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/directories/storages', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/storages");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/directories/storages", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/directories/storages`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}
```

<h3 id="post__v1_directories_storages-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Storage](#schemastorage)|false|none|

> Example responses

> 201 Response

```
{"code":"string","name":"string","stockkeeper":"string","address":"string","retail":true}
```

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}
```

<h3 id="post__v1_directories_storages-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[Storage](#schemastorage)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## get__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/directories/storages/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/directories/storages/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/storages/{code}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/directories/storages/{code}`

<h3 id="get__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/directories/storages/{code} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/directories/storages/{code} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/storages/{code}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/directories/storages/{code}`

> Body parameter

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}
```

<h3 id="put__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[Storage](#schemastorage)|false|none|

> Example responses

> 200 Response

```
{"code":"string","name":"string","stockkeeper":"string","address":"string","retail":true}
```

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}
```

<h3 id="put__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[Storage](#schemastorage)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_directories_storages_{code}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/directories/storages/{code} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/directories/storages/{code} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/directories/storages/{code}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/directories/storages/{code}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/directories/storages/{code}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/directories/storages/{code}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/directories/storages/{code}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/directories/storages/{code}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/directories/storages/{code}`

<h3 id="delete__v1_directories_storages_{code}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|code|path|string|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_directories_storages_{code}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-transferinvoice">TransferInvoice</h1>

## get__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X GET /trade/v1/documents/transferinvoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
GET /trade/v1/documents/transferinvoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/transferinvoice/{isn}',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.get '/trade/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.get('/trade/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /v1/documents/transferinvoice/{isn}`

<h3 id="get__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="get__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## put__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X PUT /trade/v1/documents/transferinvoice/{isn} \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
PUT /trade/v1/documents/transferinvoice/{isn} HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/transferinvoice/{isn}',
{
  method: 'PUT',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.put '/trade/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.put('/trade/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/trade/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("PUT");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/trade/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /v1/documents/transferinvoice/{isn}`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[TransferInvoice](#schematransferinvoice)|false|none|

> Example responses

> 200 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"contract":"string","contractDate":"2019-08-24","comment":"string","owner":"string","vatCalculationType":"string","priceType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierName":"string","supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","passportNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="put__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|[TransferInvoice](#schematransferinvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## delete__v1_documents_transferinvoice_{isn}

> Code samples

```shell
# You can also use wget
curl -X DELETE /trade/v1/documents/transferinvoice/{isn} \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
DELETE /trade/v1/documents/transferinvoice/{isn} HTTP/1.1

Accept-Language: hy-AM

```

```javascript

const headers = {
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/transferinvoice/{isn}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.delete '/trade/v1/documents/transferinvoice/{isn}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.delete('/trade/v1/documents/transferinvoice/{isn}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('DELETE','/trade/v1/documents/transferinvoice/{isn}', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/transferinvoice/{isn}");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("DELETE");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("DELETE", "/trade/v1/documents/transferinvoice/{isn}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`DELETE /v1/documents/transferinvoice/{isn}`

<h3 id="delete__v1_documents_transferinvoice_{isn}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|isn|path|string(uuid)|true|none|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|

<h3 id="delete__v1_documents_transferinvoice_{isn}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|None|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

## post__v1_documents_transferinvoice

> Code samples

```shell
# You can also use wget
curl -X POST /trade/v1/documents/transferinvoice \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain' \
  -H 'Accept-Language: hy-AM' \
  -H 'apiKey: API_KEY'

```

```http
POST /trade/v1/documents/transferinvoice HTTP/1.1

Content-Type: application/json
Accept: text/plain
Accept-Language: hy-AM

```

```javascript
const inputBody = '{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain',
  'Accept-Language':'hy-AM',
  'apiKey':'API_KEY'
};

fetch('/trade/v1/documents/transferinvoice',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Content-Type' => 'application/json',
  'Accept' => 'text/plain',
  'Accept-Language' => 'hy-AM',
  'apiKey' => 'API_KEY'
}

result = RestClient.post '/trade/v1/documents/transferinvoice',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'text/plain',
  'Accept-Language': 'hy-AM',
  'apiKey': 'API_KEY'
}

r = requests.post('/trade/v1/documents/transferinvoice', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'text/plain',
    'Accept-Language' => 'hy-AM',
    'apiKey' => 'API_KEY',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/trade/v1/documents/transferinvoice', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/v1/documents/transferinvoice");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("POST");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Content-Type": []string{"application/json"},
        "Accept": []string{"text/plain"},
        "Accept-Language": []string{"hy-AM"},
        "apiKey": []string{"API_KEY"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/trade/v1/documents/transferinvoice", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /v1/documents/transferinvoice`

> Body parameter

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_transferinvoice-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|Accept-Language|header|string|false|Request culture (hy-AM, en-US, ru-RU)|
|body|body|[TransferInvoice](#schematransferinvoice)|false|none|

> Example responses

> 201 Response

```
{"isn":"13a02e4e-9f55-416a-842c-b67b097485f4","date":"2019-08-24","documentNumber":"string","state":0,"customer":"string","currency":"string","currencyExchangeRate":0.1,"currencyExchangeBase":0.1,"contract":"string","contractDate":"2019-08-24","comment":"string","owner":"string","vatCalculationType":"string","priceType":"string","storage":"string","discountPercent":0.1,"vatAmount":0.1,"totalAmount":0.1,"supplierName":"string","supplierLegalAddress":"string","supplierBusinessAddress":"string","supplierSettlementAccount":"string","supplierTaxCode":"string","supplierManagerPosition":"string","supplierManagerName":"string","supplierAccountantPosition":"string","supplierAccountantName":"string","customerName":"string","customerLegalAddress":"string","customerBusinessAddress":"string","customerSettlementAccount":"string","customerTaxCode":"string","customerManagerPosition":"string","customerManagerName":"string","customerAccountantPosition":"string","customerAccountantName":"string","stateRegisterNumber":"string","passportNumber":"string","itemList":[{"type":"string","storage":"string","id":0,"code":"string","name":"string","unit":"string","unitAbbreviation":"string","quantity":0.1,"price":0.1,"discountPercent":0.1,"discountedPrice":0.1,"amount":0.1,"vat":true,"rowNumber":0,"rowId":0}]}
```

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}
```

<h3 id="post__v1_documents_transferinvoice-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|Created|[TransferInvoice](#schematransferinvoice)|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unauthorized|None|

<aside class="warning">
To perform this operation, you must be authenticated by means of one of the following methods:
API Key
</aside>

<h1 id="trade-public-api-version">Version</h1>

## get__api_Version

> Code samples

```shell
# You can also use wget
curl -X GET /trade/api/Version \
  -H 'Accept: text/plain'

```

```http
GET /trade/api/Version HTTP/1.1

Accept: text/plain

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/trade/api/Version',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

```ruby
require 'rest-client'
require 'json'

headers = {
  'Accept' => 'text/plain'
}

result = RestClient.get '/trade/api/Version',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'text/plain'
}

r = requests.get('/trade/api/Version', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'text/plain',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/trade/api/Version', array(
        'headers' => $headers,
        'json' => $request_body,
       )
    );
    print_r($response->getBody()->getContents());
 }
 catch (\GuzzleHttp\Exception\BadResponseException $e) {
    // handle exception or api errors.
    print_r($e->getMessage());
 }

 // ...

```

```java
URL obj = new URL("/trade/api/Version");
HttpURLConnection con = (HttpURLConnection) obj.openConnection();
con.setRequestMethod("GET");
int responseCode = con.getResponseCode();
BufferedReader in = new BufferedReader(
    new InputStreamReader(con.getInputStream()));
String inputLine;
StringBuffer response = new StringBuffer();
while ((inputLine = in.readLine()) != null) {
    response.append(inputLine);
}
in.close();
System.out.println(response.toString());

```

```go
package main

import (
       "bytes"
       "net/http"
)

func main() {

    headers := map[string][]string{
        "Accept": []string{"text/plain"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/trade/api/Version", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /api/Version`

> Example responses

> 200 Response

```
"string"
```

```json
"string"
```

<h3 id="get__api_version-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|OK|string|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_Barcode">Barcode</h2>
<!-- backwards compatibility -->
<a id="schemabarcode"></a>
<a id="schema_Barcode"></a>
<a id="tocSbarcode"></a>
<a id="tocsbarcode"></a>

```json
{
  "code": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "weightItem": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|itemId|integer(int32)|false|none|none|
|itemCode|string¦null|false|none|none|
|itemName|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|weightItem|boolean|false|none|none|

<h2 id="tocS_BarcodeApiResponse">BarcodeApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemabarcodeapiresponse"></a>
<a id="schema_BarcodeApiResponse"></a>
<a id="tocSbarcodeapiresponse"></a>
<a id="tocsbarcodeapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "code": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "weightItem": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[Barcode](#schemabarcode)]¦null|false|none|none|

<h2 id="tocS_BarcodeFilters">BarcodeFilters</h2>
<!-- backwards compatibility -->
<a id="schemabarcodefilters"></a>
<a id="schema_BarcodeFilters"></a>
<a id="tocSbarcodefilters"></a>
<a id="tocsbarcodefilters"></a>

```json
{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|itemCodes|[string]¦null|false|none|none|

<h2 id="tocS_BonusBalancesDataRow">BonusBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemabonusbalancesdatarow"></a>
<a id="schema_BonusBalancesDataRow"></a>
<a id="tocSbonusbalancesdatarow"></a>
<a id="tocsbonusbalancesdatarow"></a>

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "contractDate": "2019-08-24",
  "group": "string",
  "taxCode": "string",
  "legalAddress": "string",
  "phoneNumber": "string",
  "balance": 0.1
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|partnerId|integer(int32)|false|none|none|
|partnerCode|string¦null|false|none|none|
|partnerName|string¦null|false|none|none|
|contractCode|string¦null|false|none|none|
|contractName|string¦null|false|none|none|
|contractDate|string(date)¦null|false|none|none|
|group|string¦null|false|none|none|
|taxCode|string¦null|false|none|none|
|legalAddress|string¦null|false|none|none|
|phoneNumber|string¦null|false|none|none|
|balance|number(double)|false|none|none|

<h2 id="tocS_BonusBalancesDataRowApiResponse">BonusBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemabonusbalancesdatarowapiresponse"></a>
<a id="schema_BonusBalancesDataRowApiResponse"></a>
<a id="tocSbonusbalancesdatarowapiresponse"></a>
<a id="tocsbonusbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "group": "string",
      "taxCode": "string",
      "legalAddress": "string",
      "phoneNumber": "string",
      "balance": 0.1
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[BonusBalancesDataRow](#schemabonusbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_BonusBalancesParam">BonusBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemabonusbalancesparam"></a>
<a id="schema_BonusBalancesParam"></a>
<a id="tocSbonusbalancesparam"></a>
<a id="tocsbonusbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "openedByContracts": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|date|string(date)|true|none|none|
|partnerGroup|string¦null|false|none|none|
|partner|string¦null|false|none|none|
|contract|string¦null|false|none|none|
|openedByContracts|boolean|false|none|none|

<h2 id="tocS_CashDesk">CashDesk</h2>
<!-- backwards compatibility -->
<a id="schemacashdesk"></a>
<a id="schema_CashDesk"></a>
<a id="tocScashdesk"></a>
<a id="tocscashdesk"></a>

```json
{
  "code": "string",
  "name": "string",
  "nextCashInputOrderNumber": "string",
  "nextCashOutputOrderNumber": "string",
  "nextSaleNumber": "string",
  "nextSaleReturnNumber": "string",
  "nextShiftNumber": "string",
  "default": true,
  "ecr": true,
  "cashLimit": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|nextCashInputOrderNumber|string¦null|false|none|none|
|nextCashOutputOrderNumber|string¦null|false|none|none|
|nextSaleNumber|string¦null|false|none|none|
|nextSaleReturnNumber|string¦null|false|none|none|
|nextShiftNumber|string¦null|false|none|none|
|default|boolean¦null|false|none|none|
|ecr|boolean¦null|false|none|none|
|cashLimit|string¦null|false|none|none|

<h2 id="tocS_Contract">Contract</h2>
<!-- backwards compatibility -->
<a id="schemacontract"></a>
<a id="schema_Contract"></a>
<a id="tocScontract"></a>
<a id="tocscontract"></a>

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "priceTypeName": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|partnerId|integer(int32)|false|none|none|
|partnerCode|string¦null|false|none|none|
|partnerName|string¦null|false|none|none|
|contractCode|string¦null|false|none|none|
|contractName|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|priceTypeName|string¦null|false|none|none|
|date|string(date)¦null|false|none|none|
|description|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|cardCode|string¦null|false|none|none|
|bonusCard|boolean¦null|false|none|none|
|bonusPercent|number(double)¦null|false|none|none|
|bonusPoint|number(double)¦null|false|none|none|
|validationPeriodStart|string(date)¦null|false|none|none|
|validationPeriodEnd|string(date)¦null|false|none|none|
|canceled|boolean¦null|false|none|none|
|receivablesControl|boolean¦null|false|none|none|
|receivablesLimit|number(double)¦null|false|none|none|
|default|boolean¦null|false|none|none|

<h2 id="tocS_ContractFilters">ContractFilters</h2>
<!-- backwards compatibility -->
<a id="schemacontractfilters"></a>
<a id="schema_ContractFilters"></a>
<a id="tocScontractfilters"></a>
<a id="tocscontractfilters"></a>

```json
{
  "pageSize": 0,
  "partnerCode": "string",
  "currency": "string",
  "exceptNCC": true,
  "onlyCustomers": true,
  "onlySuppliers": true,
  "onlyBonusCards": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|partnerCode|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|exceptNCC|boolean|false|none|none|
|onlyCustomers|boolean|false|none|none|
|onlySuppliers|boolean|false|none|none|
|onlyBonusCards|boolean|false|none|none|
|lastModifiedDate|string(date-time)¦null|false|none|none|

<h2 id="tocS_ContractRow">ContractRow</h2>
<!-- backwards compatibility -->
<a id="schemacontractrow"></a>
<a id="schema_ContractRow"></a>
<a id="tocScontractrow"></a>
<a id="tocscontractrow"></a>

```json
{
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "partnerTaxCode": "string",
  "partnerPhone": "string",
  "partnerGroup": "string",
  "partnerGroupName": "string",
  "customer": true,
  "supplier": true,
  "contractCode": "string",
  "contractName": "string",
  "currency": "string",
  "priceType": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|partnerId|integer(int32)|false|none|none|
|partnerCode|string¦null|false|none|none|
|partnerName|string¦null|false|none|none|
|partnerTaxCode|string¦null|false|none|none|
|partnerPhone|string¦null|false|none|none|
|partnerGroup|string¦null|false|none|none|
|partnerGroupName|string¦null|false|none|none|
|customer|boolean|false|none|none|
|supplier|boolean|false|none|none|
|contractCode|string¦null|false|none|none|
|contractName|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|date|string(date)¦null|false|none|none|
|description|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|cardCode|string¦null|false|none|none|
|bonusCard|boolean¦null|false|none|none|
|bonusPercent|number(double)¦null|false|none|none|
|bonusPoint|number(double)¦null|false|none|none|
|validationPeriodStart|string(date)¦null|false|none|none|
|validationPeriodEnd|string(date)¦null|false|none|none|
|canceled|boolean¦null|false|none|none|
|receivablesControl|boolean¦null|false|none|none|
|receivablesLimit|number(double)¦null|false|none|none|
|default|boolean¦null|false|none|none|

<h2 id="tocS_ContractRowApiResponse">ContractRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemacontractrowapiresponse"></a>
<a id="schema_ContractRowApiResponse"></a>
<a id="tocScontractrowapiresponse"></a>
<a id="tocscontractrowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "partnerPhone": "string",
      "partnerGroup": "string",
      "partnerGroupName": "string",
      "customer": true,
      "supplier": true,
      "contractCode": "string",
      "contractName": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ContractRow](#schemacontractrow)]¦null|false|none|none|

<h2 id="tocS_DocumentsJournalDataRow">DocumentsJournalDataRow</h2>
<!-- backwards compatibility -->
<a id="schemadocumentsjournaldatarow"></a>
<a id="schema_DocumentsJournalDataRow"></a>
<a id="tocSdocumentsjournaldatarow"></a>
<a id="tocsdocumentsjournaldatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "dayOrderNumber": 0,
  "documentNumber": "string",
  "type": 0,
  "typeName": "string",
  "currency": "string",
  "amount": 0.1,
  "state": 0,
  "stateName": "string",
  "storageCode": "string",
  "storageName": "string",
  "information": "string",
  "comment": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "partnerTaxCode": "string",
  "employeeCode": "string",
  "employeeName": "string",
  "userName": "string",
  "lastChange": "2019-08-24T14:15:22Z",
  "owner": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|none|
|dayOrderNumber|integer(int32)|false|none|none|
|documentNumber|string¦null|false|none|none|
|type|integer(int32)|false|none|none|
|typeName|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|amount|number(double)|false|none|none|
|state|integer(int32)|false|none|none|
|stateName|string¦null|false|none|none|
|storageCode|string¦null|false|none|none|
|storageName|string¦null|false|none|none|
|information|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|partnerId|integer(int32)|false|none|none|
|partnerCode|string¦null|false|none|none|
|partnerName|string¦null|false|none|none|
|partnerTaxCode|string¦null|false|none|none|
|employeeCode|string¦null|false|none|none|
|employeeName|string¦null|false|none|none|
|userName|string¦null|false|none|none|
|lastChange|string(date-time)|false|none|none|
|owner|string¦null|false|none|none|

<h2 id="tocS_DocumentsJournalDataRowApiResponse">DocumentsJournalDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemadocumentsjournaldatarowapiresponse"></a>
<a id="schema_DocumentsJournalDataRowApiResponse"></a>
<a id="tocSdocumentsjournaldatarowapiresponse"></a>
<a id="tocsdocumentsjournaldatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "dayOrderNumber": 0,
      "documentNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "userName": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[DocumentsJournalDataRow](#schemadocumentsjournaldatarow)]¦null|false|none|none|

<h2 id="tocS_DocumentsJournalParam">DocumentsJournalParam</h2>
<!-- backwards compatibility -->
<a id="schemadocumentsjournalparam"></a>
<a id="schema_DocumentsJournalParam"></a>
<a id="tocSdocumentsjournalparam"></a>
<a id="tocsdocumentsjournalparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "currency": "string",
  "partnerCode": "string",
  "itemCode": "string",
  "employeeCode": "string",
  "documentState": "string",
  "owner": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|startDate|string(date)|true|none|none|
|endDate|string(date)|true|none|none|
|documentTypes|[string]¦null|false|none|none|
|currency|string¦null|false|none|none|
|partnerCode|string¦null|false|none|none|
|itemCode|string¦null|false|none|none|
|employeeCode|string¦null|false|none|none|
|documentState|string¦null|false|none|none|
|owner|string¦null|false|none|none|

<h2 id="tocS_ECRChecksJournalDataRow">ECRChecksJournalDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournaldatarow"></a>
<a id="schema_ECRChecksJournalDataRow"></a>
<a id="tocSecrchecksjournaldatarow"></a>
<a id="tocsecrchecksjournaldatarow"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "ecrCheckNumber": "string",
  "type": 0,
  "typeName": "string",
  "currency": "string",
  "amount": 0.1,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "prepaymentAmount": 0.1,
  "bonusAmount": 0.1,
  "creditAmount": 0.1,
  "state": 0,
  "stateName": "string",
  "storageCode": "string",
  "storageName": "string",
  "cashDeskCode": "string",
  "cashDeskName": "string",
  "cashierShiftNumber": "string",
  "posPartnerName": "string",
  "posPartnerContractName": "string",
  "paymentSystem": "string",
  "paymentNumber": "string",
  "paymentAccepted": true,
  "information": "string",
  "comment": "string",
  "partnerId": 0,
  "partnerCode": "string",
  "partnerName": "string",
  "partnerTaxCode": "string",
  "employeeCode": "string",
  "employeeName": "string",
  "lastUser": "string",
  "lastChange": "2019-08-24T14:15:22Z",
  "owner": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)|false|none|none|
|documentNumber|string¦null|false|none|none|
|ecrCheckNumber|string¦null|false|none|none|
|type|integer(int32)|false|none|none|
|typeName|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|amount|number(double)|false|none|none|
|cashAmount|number(double)|false|none|none|
|nonCashAmount|number(double)|false|none|none|
|prepaymentAmount|number(double)|false|none|none|
|bonusAmount|number(double)|false|none|none|
|creditAmount|number(double)|false|none|none|
|state|integer(int32)|false|none|none|
|stateName|string¦null|false|none|none|
|storageCode|string¦null|false|none|none|
|storageName|string¦null|false|none|none|
|cashDeskCode|string¦null|false|none|none|
|cashDeskName|string¦null|false|none|none|
|cashierShiftNumber|string¦null|false|none|none|
|posPartnerName|string¦null|false|none|none|
|posPartnerContractName|string¦null|false|none|none|
|paymentSystem|string¦null|false|none|none|
|paymentNumber|string¦null|false|none|none|
|paymentAccepted|boolean|false|none|none|
|information|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|partnerId|integer(int32)|false|none|none|
|partnerCode|string¦null|false|none|none|
|partnerName|string¦null|false|none|none|
|partnerTaxCode|string¦null|false|none|none|
|employeeCode|string¦null|false|none|none|
|employeeName|string¦null|false|none|none|
|lastUser|string¦null|false|none|none|
|lastChange|string(date-time)|false|none|none|
|owner|string¦null|false|none|none|

<h2 id="tocS_ECRChecksJournalDataRowApiResponse">ECRChecksJournalDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournaldatarowapiresponse"></a>
<a id="schema_ECRChecksJournalDataRowApiResponse"></a>
<a id="tocSecrchecksjournaldatarowapiresponse"></a>
<a id="tocsecrchecksjournaldatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "date": "2019-08-24",
      "documentNumber": "string",
      "ecrCheckNumber": "string",
      "type": 0,
      "typeName": "string",
      "currency": "string",
      "amount": 0.1,
      "cashAmount": 0.1,
      "nonCashAmount": 0.1,
      "prepaymentAmount": 0.1,
      "bonusAmount": 0.1,
      "creditAmount": 0.1,
      "state": 0,
      "stateName": "string",
      "storageCode": "string",
      "storageName": "string",
      "cashDeskCode": "string",
      "cashDeskName": "string",
      "cashierShiftNumber": "string",
      "posPartnerName": "string",
      "posPartnerContractName": "string",
      "paymentSystem": "string",
      "paymentNumber": "string",
      "paymentAccepted": true,
      "information": "string",
      "comment": "string",
      "partnerId": 0,
      "partnerCode": "string",
      "partnerName": "string",
      "partnerTaxCode": "string",
      "employeeCode": "string",
      "employeeName": "string",
      "lastUser": "string",
      "lastChange": "2019-08-24T14:15:22Z",
      "owner": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ECRChecksJournalDataRow](#schemaecrchecksjournaldatarow)]¦null|false|none|none|

<h2 id="tocS_ECRChecksJournalParam">ECRChecksJournalParam</h2>
<!-- backwards compatibility -->
<a id="schemaecrchecksjournalparam"></a>
<a id="schema_ECRChecksJournalParam"></a>
<a id="tocSecrchecksjournalparam"></a>
<a id="tocsecrchecksjournalparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "documentTypes": [
    "string"
  ],
  "partnerCode": "string",
  "itemCode": "string",
  "storageCode": "string",
  "cashDeskCode": "string",
  "employeeCode": "string",
  "showPayments": true,
  "showOutputAmountsAsNegatives": true,
  "documentState": "string",
  "owner": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|startDate|string(date)|true|none|none|
|endDate|string(date)|true|none|none|
|documentTypes|[string]¦null|false|none|none|
|partnerCode|string¦null|false|none|none|
|itemCode|string¦null|false|none|none|
|storageCode|string¦null|false|none|none|
|cashDeskCode|string¦null|false|none|none|
|employeeCode|string¦null|false|none|none|
|showPayments|boolean|false|none|none|
|showOutputAmountsAsNegatives|boolean|false|none|none|
|documentState|string¦null|false|none|none|
|owner|string¦null|false|none|none|

<h2 id="tocS_Invoice">Invoice</h2>
<!-- backwards compatibility -->
<a id="schemainvoice"></a>
<a id="schema_Invoice"></a>
<a id="tocSinvoice"></a>
<a id="tocsinvoice"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "customer": "string",
  "customerContract": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "seller": "string",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "dealType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "supplierAdditionalData": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "idDocumentType": "string",
  "passportNumber": "string",
  "customerAdditionalData": "string",
  "shippingMethod": "string",
  "additionalFullName": "string",
  "credentialNumber": "string",
  "credentialDate": "2019-08-24",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "environmentalFeePercent": 0.1,
      "environmentalFeeAmount": 0.1,
      "vat": true,
      "dealType": "string",
      "description": "string",
      "markingList": [
        "string"
      ],
      "cpaClassifier": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|baseDocumentISN|string(uuid)|false|none|none|
|customer|string¦null|false|none|none|
|customerContract|string¦null|false|none|none|
|bookNumber|string¦null|false|none|none|
|bookPage|integer(int32)|false|none|none|
|bookLine|integer(int32)|false|none|none|
|taxExportType|string¦null|false|none|none|
|taxInvoiceSeries|string¦null|false|none|none|
|taxInvoiceNumber|string¦null|false|none|none|
|submissionDate|string(date)¦null|false|none|none|
|seller|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|currencyExchangeRate|number(double)|false|none|none|
|currencyExchangeBase|number(double)|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|dealType|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|discountPercent|number(double)|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|supplierName|string¦null|false|none|none|
|supplierLegalAddress|string¦null|false|none|none|
|supplierBusinessAddress|string¦null|false|none|none|
|supplierSettlementAccount|string¦null|false|none|none|
|supplierTaxCode|string¦null|false|none|none|
|supplierManagerPosition|string¦null|false|none|none|
|supplierManagerName|string¦null|false|none|none|
|supplierAccountantPosition|string¦null|false|none|none|
|supplierAccountantName|string¦null|false|none|none|
|supplierAdditionalData|string¦null|false|none|none|
|customerName|string¦null|false|none|none|
|customerLegalAddress|string¦null|false|none|none|
|customerBusinessAddress|string¦null|false|none|none|
|customerSettlementAccount|string¦null|false|none|none|
|customerTaxCode|string¦null|false|none|none|
|customerManagerPosition|string¦null|false|none|none|
|customerManagerName|string¦null|false|none|none|
|customerAccountantPosition|string¦null|false|none|none|
|customerAccountantName|string¦null|false|none|none|
|stateRegisterNumber|string¦null|false|none|none|
|idDocumentType|string¦null|false|none|none|
|passportNumber|string¦null|false|none|none|
|customerAdditionalData|string¦null|false|none|none|
|shippingMethod|string¦null|false|none|none|
|additionalFullName|string¦null|false|none|none|
|credentialNumber|string¦null|false|none|none|
|credentialDate|string(date)¦null|false|none|none|
|itemList|[[InvoiceSpecificationRow](#schemainvoicespecificationrow)]¦null|false|none|none|

<h2 id="tocS_InvoiceSpecificationRow">InvoiceSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemainvoicespecificationrow"></a>
<a id="schema_InvoiceSpecificationRow"></a>
<a id="tocSinvoicespecificationrow"></a>
<a id="tocsinvoicespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "salePrice": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "discountedAmount": 0.1,
  "discountAmount": 0.1,
  "environmentalFeePercent": 0.1,
  "environmentalFeeAmount": 0.1,
  "vat": true,
  "dealType": "string",
  "description": "string",
  "markingList": [
    "string"
  ],
  "cpaClassifier": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|salePrice|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|discountedAmount|number(double)¦null|false|none|none|
|discountAmount|number(double)¦null|false|none|none|
|environmentalFeePercent|number(double)|false|none|none|
|environmentalFeeAmount|number(double)|false|none|none|
|vat|boolean¦null|false|none|none|
|dealType|string¦null|false|none|none|
|description|string¦null|false|none|none|
|markingList|[string]¦null|false|none|none|
|cpaClassifier|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|

<h2 id="tocS_MeasureUnitFilters">MeasureUnitFilters</h2>
<!-- backwards compatibility -->
<a id="schemameasureunitfilters"></a>
<a id="schema_MeasureUnitFilters"></a>
<a id="tocSmeasureunitfilters"></a>
<a id="tocsmeasureunitfilters"></a>

```json
{
  "pageSize": 0,
  "itemCodes": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|itemCodes|[string]¦null|false|none|none|

<h2 id="tocS_NextPageRequest">NextPageRequest</h2>
<!-- backwards compatibility -->
<a id="schemanextpagerequest"></a>
<a id="schema_NextPageRequest"></a>
<a id="tocSnextpagerequest"></a>
<a id="tocsnextpagerequest"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "close": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|close|boolean|false|none|none|

<h2 id="tocS_Partner">Partner</h2>
<!-- backwards compatibility -->
<a id="schemapartner"></a>
<a id="schema_Partner"></a>
<a id="tocSpartner"></a>
<a id="tocspartner"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "defaultContractCode": "string",
  "contracts": [
    {
      "code": "string",
      "name": "string",
      "currency": "string",
      "priceType": "string",
      "date": "2019-08-24",
      "description": "string",
      "discountPercent": 0.1,
      "cardCode": "string",
      "bonusCard": true,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "validationPeriodStart": "2019-08-24",
      "validationPeriodEnd": "2019-08-24",
      "canceled": true,
      "receivablesControl": true,
      "receivablesLimit": 0.1,
      "default": true
    }
  ],
  "settlementAccounts": [
    {
      "account": "string",
      "name": "string",
      "default": true
    }
  ],
  "additionalAddresses": [
    {
      "name": "string",
      "default": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|taxCode|string¦null|false|none|none|
|group|string¦null|false|none|none|
|supplier|boolean¦null|false|none|none|
|customer|boolean¦null|false|none|none|
|legalAddress|string¦null|false|none|none|
|businessAddress|string¦null|false|none|none|
|managerName|string¦null|false|none|none|
|managerPosition|string¦null|false|none|none|
|accountantName|string¦null|false|none|none|
|accountantPosition|string¦null|false|none|none|
|paymentMainAim|string¦null|false|none|none|
|phoneNumber|string¦null|false|none|none|
|email|string¦null|false|none|none|
|stateRegisterNumber|string¦null|false|none|none|
|passportNumber|string¦null|false|none|none|
|gender|string¦null|false|none|none|
|birthDate|string(date)¦null|false|none|none|
|idDocumentType|string¦null|false|none|none|
|status|string¦null|false|none|none|
|defaultContractCode|string¦null|false|none|none|
|contracts|[[PartnerContractRow](#schemapartnercontractrow)]¦null|false|none|none|
|settlementAccounts|[[PartnerSettlementAccountRow](#schemapartnersettlementaccountrow)]¦null|false|none|none|
|additionalAddresses|[[PartnerBusinessAddressRow](#schemapartnerbusinessaddressrow)]¦null|false|none|none|

<h2 id="tocS_PartnerBusinessAddressRow">PartnerBusinessAddressRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnerbusinessaddressrow"></a>
<a id="schema_PartnerBusinessAddressRow"></a>
<a id="tocSpartnerbusinessaddressrow"></a>
<a id="tocspartnerbusinessaddressrow"></a>

```json
{
  "name": "string",
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|name|string¦null|false|none|none|
|default|boolean|false|none|none|

<h2 id="tocS_PartnerContractRow">PartnerContractRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnercontractrow"></a>
<a id="schema_PartnerContractRow"></a>
<a id="tocSpartnercontractrow"></a>
<a id="tocspartnercontractrow"></a>

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "priceType": "string",
  "date": "2019-08-24",
  "description": "string",
  "discountPercent": 0.1,
  "cardCode": "string",
  "bonusCard": true,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "validationPeriodStart": "2019-08-24",
  "validationPeriodEnd": "2019-08-24",
  "canceled": true,
  "receivablesControl": true,
  "receivablesLimit": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|date|string(date)¦null|false|none|none|
|description|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|cardCode|string¦null|false|none|none|
|bonusCard|boolean¦null|false|none|none|
|bonusPercent|number(double)¦null|false|none|none|
|bonusPoint|number(double)¦null|false|none|none|
|validationPeriodStart|string(date)¦null|false|none|none|
|validationPeriodEnd|string(date)¦null|false|none|none|
|canceled|boolean¦null|false|none|none|
|receivablesControl|boolean¦null|false|none|none|
|receivablesLimit|number(double)¦null|false|none|none|
|default|boolean¦null|false|none|none|

<h2 id="tocS_PartnerFilters">PartnerFilters</h2>
<!-- backwards compatibility -->
<a id="schemapartnerfilters"></a>
<a id="schema_PartnerFilters"></a>
<a id="tocSpartnerfilters"></a>
<a id="tocspartnerfilters"></a>

```json
{
  "pageSize": 0,
  "codes": [
    "string"
  ],
  "group": "string",
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|codes|[string]¦null|false|none|none|
|group|string¦null|false|none|none|
|extended|boolean|false|none|none|
|lastModifiedDate|string(date-time)¦null|false|none|none|

<h2 id="tocS_PartnerRow">PartnerRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnerrow"></a>
<a id="schema_PartnerRow"></a>
<a id="tocSpartnerrow"></a>
<a id="tocspartnerrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "taxCode": "string",
  "group": "string",
  "groupName": "string",
  "supplier": true,
  "customer": true,
  "legalAddress": "string",
  "businessAddress": "string",
  "managerName": "string",
  "managerPosition": "string",
  "accountantName": "string",
  "accountantPosition": "string",
  "paymentMainAim": "string",
  "phoneNumber": "string",
  "email": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "gender": "string",
  "birthDate": "2019-08-24",
  "idDocumentType": "string",
  "status": "string",
  "settlementAccount": "string",
  "userName": "string",
  "creationDate": "2019-08-24T14:15:22Z",
  "lastChange": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|taxCode|string¦null|false|none|none|
|group|string¦null|false|none|none|
|groupName|string¦null|false|none|none|
|supplier|boolean¦null|false|none|none|
|customer|boolean¦null|false|none|none|
|legalAddress|string¦null|false|none|none|
|businessAddress|string¦null|false|none|none|
|managerName|string¦null|false|none|none|
|managerPosition|string¦null|false|none|none|
|accountantName|string¦null|false|none|none|
|accountantPosition|string¦null|false|none|none|
|paymentMainAim|string¦null|false|none|none|
|phoneNumber|string¦null|false|none|none|
|email|string¦null|false|none|none|
|stateRegisterNumber|string¦null|false|none|none|
|passportNumber|string¦null|false|none|none|
|gender|string¦null|false|none|none|
|birthDate|string(date)¦null|false|none|none|
|idDocumentType|string¦null|false|none|none|
|status|string¦null|false|none|none|
|settlementAccount|string¦null|false|none|none|
|userName|string¦null|false|none|none|
|creationDate|string(date-time)¦null|false|none|none|
|lastChange|string(date-time)¦null|false|none|none|

<h2 id="tocS_PartnerRowApiResponse">PartnerRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapartnerrowapiresponse"></a>
<a id="schema_PartnerRowApiResponse"></a>
<a id="tocSpartnerrowapiresponse"></a>
<a id="tocspartnerrowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "taxCode": "string",
      "group": "string",
      "groupName": "string",
      "supplier": true,
      "customer": true,
      "legalAddress": "string",
      "businessAddress": "string",
      "managerName": "string",
      "managerPosition": "string",
      "accountantName": "string",
      "accountantPosition": "string",
      "paymentMainAim": "string",
      "phoneNumber": "string",
      "email": "string",
      "stateRegisterNumber": "string",
      "passportNumber": "string",
      "gender": "string",
      "birthDate": "2019-08-24",
      "idDocumentType": "string",
      "status": "string",
      "settlementAccount": "string",
      "userName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "lastChange": "2019-08-24T14:15:22Z"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PartnerRow](#schemapartnerrow)]¦null|false|none|none|

<h2 id="tocS_PartnerSettlementAccountRow">PartnerSettlementAccountRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnersettlementaccountrow"></a>
<a id="schema_PartnerSettlementAccountRow"></a>
<a id="tocSpartnersettlementaccountrow"></a>
<a id="tocspartnersettlementaccountrow"></a>

```json
{
  "account": "string",
  "name": "string",
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|account|string¦null|false|none|none|
|name|string¦null|false|none|none|
|default|boolean|false|none|none|

<h2 id="tocS_PartnersBalancesDataRow">PartnersBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesdatarow"></a>
<a id="schema_PartnersBalancesDataRow"></a>
<a id="tocSpartnersbalancesdatarow"></a>
<a id="tocspartnersbalancesdatarow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "status": "string",
  "contractCode": "string",
  "contractName": "string",
  "contractDate": "2019-08-24",
  "currency": "string",
  "balance": 0.1,
  "balanceCurrency": 0.1
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|status|string¦null|false|none|none|
|contractCode|string¦null|false|none|none|
|contractName|string¦null|false|none|none|
|contractDate|string(date)¦null|false|none|none|
|currency|string¦null|false|none|none|
|balance|number(double)|false|none|none|
|balanceCurrency|number(double)|false|none|none|

<h2 id="tocS_PartnersBalancesDataRowApiResponse">PartnersBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesdatarowapiresponse"></a>
<a id="schema_PartnersBalancesDataRowApiResponse"></a>
<a id="tocSpartnersbalancesdatarowapiresponse"></a>
<a id="tocspartnersbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "status": "string",
      "contractCode": "string",
      "contractName": "string",
      "contractDate": "2019-08-24",
      "currency": "string",
      "balance": 0.1,
      "balanceCurrency": 0.1
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PartnersBalancesDataRow](#schemapartnersbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_PartnersBalancesParam">PartnersBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemapartnersbalancesparam"></a>
<a id="schema_PartnersBalancesParam"></a>
<a id="tocSpartnersbalancesparam"></a>
<a id="tocspartnersbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "partnerGroup": "string",
  "partner": "string",
  "contract": "string",
  "currency": "string",
  "reportCurrency": "string",
  "openedByContracts": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|date|string(date)|true|none|none|
|partnerGroup|string¦null|false|none|none|
|partner|string¦null|false|none|none|
|contract|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|reportCurrency|string|true|none|none|
|openedByContracts|boolean|false|none|none|

<h2 id="tocS_PartnersGroup">PartnersGroup</h2>
<!-- backwards compatibility -->
<a id="schemapartnersgroup"></a>
<a id="schema_PartnersGroup"></a>
<a id="tocSpartnersgroup"></a>
<a id="tocspartnersgroup"></a>

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|parent|string¦null|false|none|none|
|path|string¦null|false|none|none|

<h2 id="tocS_PriceListDataRow">PriceListDataRow</h2>
<!-- backwards compatibility -->
<a id="schemapricelistdatarow"></a>
<a id="schema_PriceListDataRow"></a>
<a id="tocSpricelistdatarow"></a>
<a id="tocspricelistdatarow"></a>

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "group": "string",
  "groupName": "string",
  "specification": "string",
  "prices": {
    "property1": 0.1,
    "property2": 0.1
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|itemId|integer(int32)|false|none|none|
|itemCode|string¦null|false|none|none|
|itemName|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|group|string¦null|false|none|none|
|groupName|string¦null|false|none|none|
|specification|string¦null|false|none|none|
|prices|object¦null|false|none|none|
|» **additionalProperties**|number(double)|false|none|none|

<h2 id="tocS_PriceListDataRowApiResponse">PriceListDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemapricelistdatarowapiresponse"></a>
<a id="schema_PriceListDataRowApiResponse"></a>
<a id="tocSpricelistdatarowapiresponse"></a>
<a id="tocspricelistdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "group": "string",
      "groupName": "string",
      "specification": "string",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[PriceListDataRow](#schemapricelistdatarow)]¦null|false|none|none|

<h2 id="tocS_PriceListParam">PriceListParam</h2>
<!-- backwards compatibility -->
<a id="schemapricelistparam"></a>
<a id="schema_PriceListParam"></a>
<a id="tocSpricelistparam"></a>
<a id="tocspricelistparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "priceListTypes": [
    "string"
  ],
  "itemType": "string",
  "group": "string",
  "itemCodes": [
    "string"
  ],
  "itemsShowMode": "string",
  "showAvailables": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|date|string(date)|true|none|none|
|priceListTypes|[string]|true|none|none|
|itemType|string¦null|false|none|none|
|group|string¦null|false|none|none|
|itemCodes|[string]¦null|false|none|none|
|itemsShowMode|string|true|none|none|
|showAvailables|boolean|false|none|none|

<h2 id="tocS_PriceListType">PriceListType</h2>
<!-- backwards compatibility -->
<a id="schemapricelisttype"></a>
<a id="schema_PriceListType"></a>
<a id="tocSpricelisttype"></a>
<a id="tocspricelisttype"></a>

```json
{
  "code": "string",
  "name": "string",
  "currency": "string",
  "roundingDegree": "string",
  "includingVAT": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|roundingDegree|string¦null|false|none|none|
|includingVAT|boolean¦null|false|none|none|

<h2 id="tocS_Product">Product</h2>
<!-- backwards compatibility -->
<a id="schemaproduct"></a>
<a id="schema_Product"></a>
<a id="tocSproduct"></a>
<a id="tocsproduct"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "cpaClassifier": "string",
  "group": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureName": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureName": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierCode": "string",
  "substituteItemsGroup": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "measureUnits": [
    {
      "code": "string",
      "abbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ],
  "barcodes": [
    {
      "unitMeasure": "string",
      "abbreviation": "string",
      "barcode": "string"
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|type|string¦null|false|none|none|
|cpaClassifier|string¦null|false|none|none|
|group|string¦null|false|none|none|
|baseUnitMeasure|string¦null|false|none|none|
|baseUnitMeasureName|string¦null|false|none|none|
|baseUnitMeasureAbbreviation|string¦null|false|none|none|
|alternativeUnitMeasure|string¦null|false|none|none|
|alternativeUnitMeasureName|string¦null|false|none|none|
|alternativeUnitMeasureAbbreviation|string¦null|false|none|none|
|barcode|string¦null|false|none|none|
|specification|string¦null|false|none|none|
|externalCode|string¦null|false|none|none|
|costingMethod|string¦null|false|none|none|
|vat|boolean¦null|false|none|none|
|checkMarking|boolean¦null|false|none|none|
|weight|boolean¦null|false|none|none|
|pluCode|integer(int32)¦null|false|none|none|
|showInPriceLists|boolean¦null|false|none|none|
|environmentalFeePercent|number(double)¦null|false|none|none|
|labelUnitMeasure|string¦null|false|none|none|
|labelUnitMeasureCoefficient|number(double)¦null|false|none|none|
|country|string¦null|false|none|none|
|producer|string¦null|false|none|none|
|property1|string¦null|false|none|none|
|property2|string¦null|false|none|none|
|minimumQuantity|number(double)¦null|false|none|none|
|maximumQuantity|number(double)¦null|false|none|none|
|addedValuePercent|number(double)¦null|false|none|none|
|aoeCoefficient|number(double)¦null|false|none|none|
|bonusPercent|number(double)¦null|false|none|none|
|bonusPoint|number(double)¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|mainSupplierId|integer(int32)¦null|false|none|none|
|mainSupplierCode|string¦null|false|none|none|
|substituteItemsGroup|string¦null|false|none|none|
|nameEN|string¦null|false|none|none|
|nameRU|string¦null|false|none|none|
|additionalSpecification1|string¦null|false|none|none|
|additionalSpecification2|string¦null|false|none|none|
|measureUnits|[[ProductMeasureUnitRow](#schemaproductmeasureunitrow)]¦null|false|none|none|
|barcodes|[[ProductBarcodeRow](#schemaproductbarcoderow)]¦null|false|none|none|

<h2 id="tocS_ProductBarcodeRow">ProductBarcodeRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductbarcoderow"></a>
<a id="schema_ProductBarcodeRow"></a>
<a id="tocSproductbarcoderow"></a>
<a id="tocsproductbarcoderow"></a>

```json
{
  "unitMeasure": "string",
  "abbreviation": "string",
  "barcode": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|unitMeasure|string¦null|false|none|none|
|abbreviation|string¦null|false|none|none|
|barcode|string¦null|false|none|none|

<h2 id="tocS_ProductFilters">ProductFilters</h2>
<!-- backwards compatibility -->
<a id="schemaproductfilters"></a>
<a id="schema_ProductFilters"></a>
<a id="tocSproductfilters"></a>
<a id="tocsproductfilters"></a>

```json
{
  "pageSize": 0,
  "group": "string",
  "type": "string",
  "codes": [
    "string"
  ],
  "showMode": "string",
  "priceListTypes": [
    "string"
  ],
  "extended": true,
  "lastModifiedDate": "2019-08-24T14:15:22Z"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|group|string¦null|false|none|none|
|type|string¦null|false|none|none|
|codes|[string]¦null|false|none|none|
|showMode|string|true|none|none|
|priceListTypes|[string]¦null|false|none|none|
|extended|boolean|false|none|none|
|lastModifiedDate|string(date-time)¦null|false|none|none|

<h2 id="tocS_ProductMeasureUnit">ProductMeasureUnit</h2>
<!-- backwards compatibility -->
<a id="schemaproductmeasureunit"></a>
<a id="schema_ProductMeasureUnit"></a>
<a id="tocSproductmeasureunit"></a>
<a id="tocsproductmeasureunit"></a>

```json
{
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureName": "string",
  "unitMeasureAbbreviation": "string",
  "coefficient": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|itemId|integer(int32)|false|none|none|
|itemCode|string¦null|false|none|none|
|itemName|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureName|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|coefficient|number(double)¦null|false|none|none|
|default|boolean¦null|false|none|none|

<h2 id="tocS_ProductMeasureUnitApiResponse">ProductMeasureUnitApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaproductmeasureunitapiresponse"></a>
<a id="schema_ProductMeasureUnitApiResponse"></a>
<a id="tocSproductmeasureunitapiresponse"></a>
<a id="tocsproductmeasureunitapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureName": "string",
      "unitMeasureAbbreviation": "string",
      "coefficient": 0.1,
      "default": true
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ProductMeasureUnit](#schemaproductmeasureunit)]¦null|false|none|none|

<h2 id="tocS_ProductMeasureUnitRow">ProductMeasureUnitRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductmeasureunitrow"></a>
<a id="schema_ProductMeasureUnitRow"></a>
<a id="tocSproductmeasureunitrow"></a>
<a id="tocsproductmeasureunitrow"></a>

```json
{
  "code": "string",
  "abbreviation": "string",
  "coefficient": 0.1,
  "default": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|abbreviation|string¦null|false|none|none|
|coefficient|number(double)¦null|false|none|none|
|default|boolean¦null|false|none|none|

<h2 id="tocS_ProductRow">ProductRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductrow"></a>
<a id="schema_ProductRow"></a>
<a id="tocSproductrow"></a>
<a id="tocsproductrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "type": "string",
  "typeName": "string",
  "cpaClassifier": "string",
  "group": "string",
  "groupName": "string",
  "groupPath": "string",
  "baseUnitMeasure": "string",
  "baseUnitMeasureAbbreviation": "string",
  "alternativeUnitMeasure": "string",
  "alternativeUnitMeasureAbbreviation": "string",
  "barcode": "string",
  "specification": "string",
  "externalCode": "string",
  "costingMethod": "string",
  "costingMethodName": "string",
  "vat": true,
  "checkMarking": true,
  "weight": true,
  "pluCode": 0,
  "showInPriceLists": true,
  "environmentalFeePercent": 0.1,
  "labelUnitMeasure": "string",
  "labelUnitMeasureAbbreviation": "string",
  "labelUnitMeasureCoefficient": 0.1,
  "country": "string",
  "countryName": "string",
  "producer": "string",
  "producerName": "string",
  "property1": "string",
  "property2": "string",
  "minimumQuantity": 0.1,
  "maximumQuantity": 0.1,
  "addedValuePercent": 0.1,
  "aoeCoefficient": 0.1,
  "bonusPercent": 0.1,
  "bonusPoint": 0.1,
  "discountPercent": 0.1,
  "mainSupplierId": 0,
  "mainSupplierName": "string",
  "substituteItemsGroup": "string",
  "substituteItemsGroupName": "string",
  "nameEN": "string",
  "nameRU": "string",
  "additionalSpecification1": "string",
  "additionalSpecification2": "string",
  "lastModifierName": "string",
  "lastModifyDate": "2019-08-24T14:15:22Z",
  "creatorName": "string",
  "creationDate": "2019-08-24T14:15:22Z",
  "prices": {
    "property1": 0.1,
    "property2": 0.1
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|type|string¦null|false|none|none|
|typeName|string¦null|false|none|none|
|cpaClassifier|string¦null|false|none|none|
|group|string¦null|false|none|none|
|groupName|string¦null|false|none|none|
|groupPath|string¦null|false|none|none|
|baseUnitMeasure|string¦null|false|none|none|
|baseUnitMeasureAbbreviation|string¦null|false|none|none|
|alternativeUnitMeasure|string¦null|false|none|none|
|alternativeUnitMeasureAbbreviation|string¦null|false|none|none|
|barcode|string¦null|false|none|none|
|specification|string¦null|false|none|none|
|externalCode|string¦null|false|none|none|
|costingMethod|string¦null|false|none|none|
|costingMethodName|string¦null|false|none|none|
|vat|boolean¦null|false|none|none|
|checkMarking|boolean¦null|false|none|none|
|weight|boolean¦null|false|none|none|
|pluCode|integer(int32)¦null|false|none|none|
|showInPriceLists|boolean¦null|false|none|none|
|environmentalFeePercent|number(double)¦null|false|none|none|
|labelUnitMeasure|string¦null|false|none|none|
|labelUnitMeasureAbbreviation|string¦null|false|none|none|
|labelUnitMeasureCoefficient|number(double)¦null|false|none|none|
|country|string¦null|false|none|none|
|countryName|string¦null|false|none|none|
|producer|string¦null|false|none|none|
|producerName|string¦null|false|none|none|
|property1|string¦null|false|none|none|
|property2|string¦null|false|none|none|
|minimumQuantity|number(double)¦null|false|none|none|
|maximumQuantity|number(double)¦null|false|none|none|
|addedValuePercent|number(double)¦null|false|none|none|
|aoeCoefficient|number(double)¦null|false|none|none|
|bonusPercent|number(double)¦null|false|none|none|
|bonusPoint|number(double)¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|mainSupplierId|integer(int32)¦null|false|none|none|
|mainSupplierName|string¦null|false|none|none|
|substituteItemsGroup|string¦null|false|none|none|
|substituteItemsGroupName|string¦null|false|none|none|
|nameEN|string¦null|false|none|none|
|nameRU|string¦null|false|none|none|
|additionalSpecification1|string¦null|false|none|none|
|additionalSpecification2|string¦null|false|none|none|
|lastModifierName|string¦null|false|none|none|
|lastModifyDate|string(date-time)¦null|false|none|none|
|creatorName|string¦null|false|none|none|
|creationDate|string(date-time)¦null|false|none|none|
|prices|object¦null|false|none|none|
|» **additionalProperties**|number(double)|false|none|none|

<h2 id="tocS_ProductRowApiResponse">ProductRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaproductrowapiresponse"></a>
<a id="schema_ProductRowApiResponse"></a>
<a id="tocSproductrowapiresponse"></a>
<a id="tocsproductrowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "type": "string",
      "typeName": "string",
      "cpaClassifier": "string",
      "group": "string",
      "groupName": "string",
      "groupPath": "string",
      "baseUnitMeasure": "string",
      "baseUnitMeasureAbbreviation": "string",
      "alternativeUnitMeasure": "string",
      "alternativeUnitMeasureAbbreviation": "string",
      "barcode": "string",
      "specification": "string",
      "externalCode": "string",
      "costingMethod": "string",
      "costingMethodName": "string",
      "vat": true,
      "checkMarking": true,
      "weight": true,
      "pluCode": 0,
      "showInPriceLists": true,
      "environmentalFeePercent": 0.1,
      "labelUnitMeasure": "string",
      "labelUnitMeasureAbbreviation": "string",
      "labelUnitMeasureCoefficient": 0.1,
      "country": "string",
      "countryName": "string",
      "producer": "string",
      "producerName": "string",
      "property1": "string",
      "property2": "string",
      "minimumQuantity": 0.1,
      "maximumQuantity": 0.1,
      "addedValuePercent": 0.1,
      "aoeCoefficient": 0.1,
      "bonusPercent": 0.1,
      "bonusPoint": 0.1,
      "discountPercent": 0.1,
      "mainSupplierId": 0,
      "mainSupplierName": "string",
      "substituteItemsGroup": "string",
      "substituteItemsGroupName": "string",
      "nameEN": "string",
      "nameRU": "string",
      "additionalSpecification1": "string",
      "additionalSpecification2": "string",
      "lastModifierName": "string",
      "lastModifyDate": "2019-08-24T14:15:22Z",
      "creatorName": "string",
      "creationDate": "2019-08-24T14:15:22Z",
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ProductRow](#schemaproductrow)]¦null|false|none|none|

<h2 id="tocS_ProductsBalancesDataRow">ProductsBalancesDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesdatarow"></a>
<a id="schema_ProductsBalancesDataRow"></a>
<a id="tocSproductsbalancesdatarow"></a>
<a id="tocsproductsbalancesdatarow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "specification": "string",
  "group": "string",
  "groupName": "string",
  "storage": "string",
  "storageName": "string",
  "quantity": 0.1,
  "costAmountWithoutVAT": 0.1,
  "costAmountWithVAT": 0.1,
  "costAmountCurrency": 0.1,
  "costPriceWithoutVAT": 0.1,
  "costPriceWithVAT": 0.1,
  "costPriceCurrency": 0.1,
  "minimumQuantity": 0.1,
  "variance": 0.1,
  "maximumQuantity": 0.1,
  "orderQuantity": 0.1,
  "orderComment": "string",
  "incomeDate": "2019-08-24",
  "partySupplierId": 0,
  "partySupplierName": "string",
  "partySupplierTaxCode": "string",
  "partyContractCode": "string",
  "partyContractName": "string",
  "partyDocumentNumber": "string",
  "partyDocumentType": "string",
  "partyExpirationDate": "2019-08-24",
  "partyCountryCode": "string",
  "partyCountryName": "string",
  "partyProducerCode": "string",
  "partyProducerName": "string",
  "partyPropertyType1Code": "string",
  "partyPropertyType1Name": "string",
  "partyPropertyValue1Code": "string",
  "partyPropertyValue1Name": "string",
  "partyPropertyType2Code": "string",
  "partyPropertyType2Name": "string",
  "partyPropertyValue2Code": "string",
  "partyPropertyValue2Name": "string",
  "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
  "partyRow": 0,
  "prices": {
    "property1": 0.1,
    "property2": 0.1
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|specification|string¦null|false|none|none|
|group|string¦null|false|none|none|
|groupName|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|storageName|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|costAmountWithoutVAT|number(double)|false|none|none|
|costAmountWithVAT|number(double)|false|none|none|
|costAmountCurrency|number(double)|false|none|none|
|costPriceWithoutVAT|number(double)¦null|false|none|none|
|costPriceWithVAT|number(double)¦null|false|none|none|
|costPriceCurrency|number(double)¦null|false|none|none|
|minimumQuantity|number(double)|false|none|none|
|variance|number(double)|false|none|none|
|maximumQuantity|number(double)|false|none|none|
|orderQuantity|number(double)|false|none|none|
|orderComment|string¦null|false|none|none|
|incomeDate|string(date)|false|none|none|
|partySupplierId|integer(int32)|false|none|none|
|partySupplierName|string¦null|false|none|none|
|partySupplierTaxCode|string¦null|false|none|none|
|partyContractCode|string¦null|false|none|none|
|partyContractName|string¦null|false|none|none|
|partyDocumentNumber|string¦null|false|none|none|
|partyDocumentType|string¦null|false|none|none|
|partyExpirationDate|string(date)¦null|false|none|none|
|partyCountryCode|string¦null|false|none|none|
|partyCountryName|string¦null|false|none|none|
|partyProducerCode|string¦null|false|none|none|
|partyProducerName|string¦null|false|none|none|
|partyPropertyType1Code|string¦null|false|none|none|
|partyPropertyType1Name|string¦null|false|none|none|
|partyPropertyValue1Code|string¦null|false|none|none|
|partyPropertyValue1Name|string¦null|false|none|none|
|partyPropertyType2Code|string¦null|false|none|none|
|partyPropertyType2Name|string¦null|false|none|none|
|partyPropertyValue2Code|string¦null|false|none|none|
|partyPropertyValue2Name|string¦null|false|none|none|
|partyBase|string(uuid)|false|none|none|
|partyRow|integer(int32)|false|none|none|
|prices|object¦null|false|none|none|
|» **additionalProperties**|number(double)|false|none|none|

<h2 id="tocS_ProductsBalancesDataRowApiResponse">ProductsBalancesDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesdatarowapiresponse"></a>
<a id="schema_ProductsBalancesDataRowApiResponse"></a>
<a id="tocSproductsbalancesdatarowapiresponse"></a>
<a id="tocsproductsbalancesdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "specification": "string",
      "group": "string",
      "groupName": "string",
      "storage": "string",
      "storageName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceWithoutVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "costPriceCurrency": 0.1,
      "minimumQuantity": 0.1,
      "variance": 0.1,
      "maximumQuantity": 0.1,
      "orderQuantity": 0.1,
      "orderComment": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractCode": "string",
      "partyContractName": "string",
      "partyDocumentNumber": "string",
      "partyDocumentType": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryCode": "string",
      "partyCountryName": "string",
      "partyProducerCode": "string",
      "partyProducerName": "string",
      "partyPropertyType1Code": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Code": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Code": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Code": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0,
      "prices": {
        "property1": 0.1,
        "property2": 0.1
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ProductsBalancesDataRow](#schemaproductsbalancesdatarow)]¦null|false|none|none|

<h2 id="tocS_ProductsBalancesParam">ProductsBalancesParam</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesparam"></a>
<a id="schema_ProductsBalancesParam"></a>
<a id="tocSproductsbalancesparam"></a>
<a id="tocsproductsbalancesparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showByDifferentParties": true,
  "openedByStorages": true,
  "minimumQuantities": "string",
  "subtotalType": "string",
  "priceListTypes": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|date|string(date)|true|none|none|
|storages|[string]¦null|false|none|none|
|group|string¦null|false|none|none|
|codes|[string]¦null|false|none|none|
|showQuantitiesWithAdditionalUnits|boolean|false|none|none|
|showSumsWithoutVAT|boolean|false|none|none|
|showSumsWithVAT|boolean|false|none|none|
|showCurrencySums|boolean|false|none|none|
|showByDifferentParties|boolean|false|none|none|
|openedByStorages|boolean|false|none|none|
|minimumQuantities|string¦null|false|none|none|
|subtotalType|string¦null|false|none|none|
|priceListTypes|[string]¦null|false|none|none|

<h2 id="tocS_ProductsBalancesShortDataRow">ProductsBalancesShortDataRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesshortdatarow"></a>
<a id="schema_ProductsBalancesShortDataRow"></a>
<a id="tocSproductsbalancesshortdatarow"></a>
<a id="tocsproductsbalancesshortdatarow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "specification": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "quantity": 0.1,
  "costAmountWithoutVAT": 0.1,
  "costAmountWithVAT": 0.1,
  "costAmountCurrency": 0.1,
  "salePrice": 0.1,
  "salePriceAmount": 0.1
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|specification|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|costAmountWithoutVAT|number(double)|false|none|none|
|costAmountWithVAT|number(double)|false|none|none|
|costAmountCurrency|number(double)|false|none|none|
|salePrice|number(double)|false|none|none|
|salePriceAmount|number(double)|false|none|none|

<h2 id="tocS_ProductsBalancesShortDataRowApiResponse">ProductsBalancesShortDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesshortdatarowapiresponse"></a>
<a id="schema_ProductsBalancesShortDataRowApiResponse"></a>
<a id="tocSproductsbalancesshortdatarowapiresponse"></a>
<a id="tocsproductsbalancesshortdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "specification": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costAmountCurrency": 0.1,
      "salePrice": 0.1,
      "salePriceAmount": 0.1
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[ProductsBalancesShortDataRow](#schemaproductsbalancesshortdatarow)]¦null|false|none|none|

<h2 id="tocS_ProductsBalancesShortParam">ProductsBalancesShortParam</h2>
<!-- backwards compatibility -->
<a id="schemaproductsbalancesshortparam"></a>
<a id="schema_ProductsBalancesShortParam"></a>
<a id="tocSproductsbalancesshortparam"></a>
<a id="tocsproductsbalancesshortparam"></a>

```json
{
  "pageSize": 0,
  "date": "2019-08-24",
  "storages": [
    "string"
  ],
  "group": "string",
  "codes": [
    "string"
  ],
  "showQuantitiesWithAdditionalUnits": true,
  "priceType": "string",
  "showZeroRows": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|date|string(date)|true|none|none|
|storages|[string]¦null|false|none|none|
|group|string¦null|false|none|none|
|codes|[string]¦null|false|none|none|
|showQuantitiesWithAdditionalUnits|boolean|false|none|none|
|priceType|string¦null|false|none|none|
|showZeroRows|boolean|false|none|none|

<h2 id="tocS_ProductsGroup">ProductsGroup</h2>
<!-- backwards compatibility -->
<a id="schemaproductsgroup"></a>
<a id="schema_ProductsGroup"></a>
<a id="tocSproductsgroup"></a>
<a id="tocsproductsgroup"></a>

```json
{
  "code": "string",
  "name": "string",
  "parent": "string",
  "path": "string",
  "nameEN": "string",
  "nameRU": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|parent|string¦null|false|none|none|
|path|string¦null|false|none|none|
|nameEN|string¦null|false|none|none|
|nameRU|string¦null|false|none|none|

<h2 id="tocS_ProductsMovement">ProductsMovement</h2>
<!-- backwards compatibility -->
<a id="schemaproductsmovement"></a>
<a id="schema_ProductsMovement"></a>
<a id="tocSproductsmovement"></a>
<a id="tocsproductsmovement"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storageOutput": "string",
  "storageInput": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "mediator": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "bookNumber": "string",
  "bookPage": 0,
  "bookLine": 0,
  "taxExportType": "string",
  "taxInvoiceSeries": "string",
  "taxInvoiceNumber": "string",
  "submissionDate": "2019-08-24",
  "transportationMethod": "string",
  "vehicle": true,
  "brand": "string",
  "licensePlate": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|storageOutput|string¦null|false|none|none|
|storageInput|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|mediator|string¦null|false|none|none|
|chiefAccount|string¦null|false|none|none|
|allowed|string¦null|false|none|none|
|bookNumber|string¦null|false|none|none|
|bookPage|integer(int32)|false|none|none|
|bookLine|integer(int32)|false|none|none|
|taxExportType|string¦null|false|none|none|
|taxInvoiceSeries|string¦null|false|none|none|
|taxInvoiceNumber|string¦null|false|none|none|
|submissionDate|string(date)¦null|false|none|none|
|transportationMethod|string¦null|false|none|none|
|vehicle|boolean|false|none|none|
|brand|string¦null|false|none|none|
|licensePlate|string¦null|false|none|none|
|baseDocumentISN|string(uuid)|false|none|none|
|productsList|[[ProductsMovementSpecificationRow](#schemaproductsmovementspecificationrow)]¦null|false|none|none|

<h2 id="tocS_ProductsMovementSpecificationRow">ProductsMovementSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemaproductsmovementspecificationrow"></a>
<a id="schema_ProductsMovementSpecificationRow"></a>
<a id="tocSproductsmovementspecificationrow"></a>
<a id="tocsproductsmovementspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "salePrice": 0.1,
  "saleAmount": 0.1,
  "description": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|salePrice|number(double)¦null|false|none|none|
|saleAmount|number(double)¦null|false|none|none|
|description|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|

<h2 id="tocS_Sale">Sale</h2>
<!-- backwards compatibility -->
<a id="schemasale"></a>
<a id="schema_Sale"></a>
<a id="tocSsale"></a>
<a id="tocssale"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "printExpenseConfirmingCheck": true,
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "changeAmount": 0.1,
  "bonusAmount": 0.1,
  "addedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "discountPriceType": "string",
  "comment": "string",
  "owner": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|storage|string¦null|false|none|none|
|cashDesk|string¦null|false|none|none|
|cashierShiftNumber|string¦null|false|none|none|
|ecrCheckNumber|string¦null|false|none|none|
|prepaymentECRCheckNumber|string¦null|false|none|none|
|customer|string¦null|false|none|none|
|customerContract|string¦null|false|none|none|
|seller|string¦null|false|none|none|
|printExpenseConfirmingCheck|boolean¦null|false|none|none|
|cashAmount|number(double)¦null|false|none|none|
|nonCashAmount|number(double)¦null|false|none|none|
|posBank|string¦null|false|none|none|
|posContract|string¦null|false|none|none|
|connectedDevice|string¦null|false|none|none|
|paymentSystem|integer(int32)|false|none|none|
|creditAmount|number(double)¦null|false|none|none|
|prepaymentAmount|number(double)¦null|false|none|none|
|prepaymentCustomer|string¦null|false|none|none|
|prepaymentContract|string¦null|false|none|none|
|changeAmount|number(double)¦null|false|none|none|
|bonusAmount|number(double)¦null|false|none|none|
|addedBonus|number(double)¦null|false|none|none|
|accumulatedBonus|number(double)¦null|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|discountPriceType|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|itemList|[[SaleSpecificationRow](#schemasalespecificationrow)]¦null|false|none|none|

<h2 id="tocS_SaleReturn">SaleReturn</h2>
<!-- backwards compatibility -->
<a id="schemasalereturn"></a>
<a id="schema_SaleReturn"></a>
<a id="tocSsalereturn"></a>
<a id="tocssalereturn"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "state": 0,
  "storage": "string",
  "cashDesk": "string",
  "cashierShiftNumber": "string",
  "ecrReturnCheckNumber": "string",
  "prepaymentECRCheckNumber": "string",
  "customer": "string",
  "customerContract": "string",
  "seller": "string",
  "cashAmount": 0.1,
  "nonCashAmount": 0.1,
  "posBank": "string",
  "posContract": "string",
  "connectedDevice": "string",
  "paymentSystem": 0,
  "creditAmount": 0.1,
  "prepaymentAmount": 0.1,
  "prepaymentCustomer": "string",
  "prepaymentContract": "string",
  "bonusAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "changeAmount": 0.1,
  "vatCalculationType": "string",
  "priceType": "string",
  "comment": "string",
  "owner": "string",
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "barcode": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "salePrice": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "discountedAmount": 0.1,
      "discountAmount": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "vat": true,
      "description": "string",
      "deleted": true,
      "gift": true,
      "rowNumber": 0,
      "rowId": 0,
      "baseRowId": 0,
      "cpaClassifier": "string",
      "markingList": [
        "string"
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|baseDocumentISN|string(uuid)|false|none|none|
|state|integer(int32)|false|none|none|
|storage|string¦null|false|none|none|
|cashDesk|string¦null|false|none|none|
|cashierShiftNumber|string¦null|false|none|none|
|ecrReturnCheckNumber|string¦null|false|none|none|
|prepaymentECRCheckNumber|string¦null|false|none|none|
|customer|string¦null|false|none|none|
|customerContract|string¦null|false|none|none|
|seller|string¦null|false|none|none|
|cashAmount|number(double)|false|none|none|
|nonCashAmount|number(double)|false|none|none|
|posBank|string¦null|false|none|none|
|posContract|string¦null|false|none|none|
|connectedDevice|string¦null|false|none|none|
|paymentSystem|integer(int32)|false|none|none|
|creditAmount|number(double)|false|none|none|
|prepaymentAmount|number(double)|false|none|none|
|prepaymentCustomer|string¦null|false|none|none|
|prepaymentContract|string¦null|false|none|none|
|bonusAmount|number(double)|false|none|none|
|usedBonus|number(double)|false|none|none|
|accumulatedBonus|number(double)|false|none|none|
|changeAmount|number(double)|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|itemList|[[SaleReturnSpecificationRow](#schemasalereturnspecificationrow)]¦null|false|none|none|

<h2 id="tocS_SaleReturnSpecificationRow">SaleReturnSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemasalereturnspecificationrow"></a>
<a id="schema_SaleReturnSpecificationRow"></a>
<a id="tocSsalereturnspecificationrow"></a>
<a id="tocssalereturnspecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "barcode": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "salePrice": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "discountedAmount": 0.1,
  "discountAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vat": true,
  "description": "string",
  "deleted": true,
  "gift": true,
  "rowNumber": 0,
  "rowId": 0,
  "baseRowId": 0,
  "cpaClassifier": "string",
  "markingList": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|barcode|string¦null|false|none|none|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|salePrice|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|discountedAmount|number(double)¦null|false|none|none|
|discountAmount|number(double)¦null|false|none|none|
|usedBonus|number(double)¦null|false|none|none|
|accumulatedBonus|number(double)|false|none|none|
|vat|boolean¦null|false|none|none|
|description|string¦null|false|none|none|
|deleted|boolean¦null|false|none|none|
|gift|boolean¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|
|baseRowId|integer(int32)|false|none|none|
|cpaClassifier|string¦null|false|none|none|
|markingList|[string]¦null|false|none|none|

<h2 id="tocS_SaleSpecificationRow">SaleSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemasalespecificationrow"></a>
<a id="schema_SaleSpecificationRow"></a>
<a id="tocSsalespecificationrow"></a>
<a id="tocssalespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "barcode": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "salePrice": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "discountedAmount": 0.1,
  "discountAmount": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "vat": true,
  "description": "string",
  "deleted": true,
  "gift": true,
  "rowNumber": 0,
  "rowId": 0,
  "cpaClassifier": "string",
  "markingList": [
    "string"
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|barcode|string¦null|false|none|none|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|salePrice|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|discountedAmount|number(double)¦null|false|none|none|
|discountAmount|number(double)¦null|false|none|none|
|usedBonus|number(double)¦null|false|none|none|
|accumulatedBonus|number(double)|false|none|none|
|vat|boolean¦null|false|none|none|
|description|string¦null|false|none|none|
|deleted|boolean¦null|false|none|none|
|gift|boolean¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|
|cpaClassifier|string¦null|false|none|none|
|markingList|[string]¦null|false|none|none|

<h2 id="tocS_SalesAnalysisDataRow">SalesAnalysisDataRow</h2>
<!-- backwards compatibility -->
<a id="schemasalesanalysisdatarow"></a>
<a id="schema_SalesAnalysisDataRow"></a>
<a id="tocSsalesanalysisdatarow"></a>
<a id="tocssalesanalysisdatarow"></a>

```json
{
  "documentNumber": "string",
  "date": "2019-08-24",
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "operationType": "string",
  "documentCurrency": "string",
  "documentVATType": "string",
  "documentVATTypeName": "string",
  "ecrCheckNumber": "string",
  "itemType": "string",
  "itemTypeName": "string",
  "itemId": 0,
  "itemCode": "string",
  "itemName": "string",
  "unitMeasure": "string",
  "unitMeasureAbbreviation": "string",
  "storage": "string",
  "storageName": "string",
  "cashDesk": "string",
  "cashDeskName": "string",
  "customer": "string",
  "customerName": "string",
  "customerContractName": "string",
  "quantity": 0.1,
  "costAmountWithoutVAT": 0.1,
  "costPriceWithoutVAT": 0.1,
  "salePriceWithoutVAT": 0.1,
  "saleAmountWithoutVAT": 0.1,
  "profitWithoutVAT": 0.1,
  "profitPercentBySaleWithoutVAT": 0.1,
  "profitPercentByCostWithoutVAT": 0.1,
  "initialPriceWithoutVAT": 0.1,
  "initialAmountWithoutVAT": 0.1,
  "discountPercentWithoutVAT": 0.1,
  "discountAmountWithoutVAT": 0.1,
  "costAmountWithVAT": 0.1,
  "costPriceWithVAT": 0.1,
  "salePriceWithVAT": 0.1,
  "saleAmountWithVAT": 0.1,
  "profitWithVAT": 0.1,
  "profitPercentBySaleWithVAT": 0.1,
  "profitPercentByCostWithVAT": 0.1,
  "initialPriceWithVAT": 0.1,
  "initialAmountWithVAT": 0.1,
  "discountPercentWithVAT": 0.1,
  "discountAmountWithVAT": 0.1,
  "costVATAmount": 0.1,
  "costVATPrice": 0.1,
  "saleVATAmount": 0.1,
  "discountVATAmount": 0.1,
  "costAmountCurrency": 0.1,
  "costPriceCurrency": 0.1,
  "salePriceCurrency": 0.1,
  "saleAmountCurrency": 0.1,
  "profitCurrency": 0.1,
  "profitPercentBySaleCurrency": 0.1,
  "profitPercentByCostCurrency": 0.1,
  "initialPriceCurrency": 0.1,
  "initialAmountCurrency": 0.1,
  "discountPercentCurrency": 0.1,
  "discountAmountCurrency": 0.1,
  "usedBonus": 0.1,
  "accumulatedBonus": 0.1,
  "description": "string",
  "seller": "string",
  "sellerName": "string",
  "comment": "string",
  "itemGroup": "string",
  "itemSpecification": "string",
  "businessAddress": "string",
  "incomeDate": "2019-08-24",
  "partySupplierId": 0,
  "partySupplierName": "string",
  "partySupplierTaxCode": "string",
  "partyContractName": "string",
  "partyDocumentTypeName": "string",
  "partyDocumentNumber": "string",
  "partyExpirationDate": "2019-08-24",
  "partyCountryName": "string",
  "partyProducerName": "string",
  "partyPropertyType1Name": "string",
  "partyPropertyValue1Name": "string",
  "partyPropertyType2Name": "string",
  "partyPropertyValue2Name": "string",
  "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
  "partyRow": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|documentNumber|string¦null|false|none|none|
|date|string(date)¦null|false|none|none|
|isn|string(uuid)|false|none|none|
|operationType|string¦null|false|none|none|
|documentCurrency|string¦null|false|none|none|
|documentVATType|string¦null|false|none|none|
|documentVATTypeName|string¦null|false|none|none|
|ecrCheckNumber|string¦null|false|none|none|
|itemType|string¦null|false|none|none|
|itemTypeName|string¦null|false|none|none|
|itemId|integer(int32)|false|none|none|
|itemCode|string¦null|false|none|none|
|itemName|string¦null|false|none|none|
|unitMeasure|string¦null|false|none|none|
|unitMeasureAbbreviation|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|storageName|string¦null|false|none|none|
|cashDesk|string¦null|false|none|none|
|cashDeskName|string¦null|false|none|none|
|customer|string¦null|false|none|none|
|customerName|string¦null|false|none|none|
|customerContractName|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|costAmountWithoutVAT|number(double)|false|none|none|
|costPriceWithoutVAT|number(double)|false|none|none|
|salePriceWithoutVAT|number(double)|false|none|none|
|saleAmountWithoutVAT|number(double)|false|none|none|
|profitWithoutVAT|number(double)|false|none|none|
|profitPercentBySaleWithoutVAT|number(double)|false|none|none|
|profitPercentByCostWithoutVAT|number(double)|false|none|none|
|initialPriceWithoutVAT|number(double)|false|none|none|
|initialAmountWithoutVAT|number(double)|false|none|none|
|discountPercentWithoutVAT|number(double)|false|none|none|
|discountAmountWithoutVAT|number(double)|false|none|none|
|costAmountWithVAT|number(double)|false|none|none|
|costPriceWithVAT|number(double)|false|none|none|
|salePriceWithVAT|number(double)|false|none|none|
|saleAmountWithVAT|number(double)|false|none|none|
|profitWithVAT|number(double)|false|none|none|
|profitPercentBySaleWithVAT|number(double)|false|none|none|
|profitPercentByCostWithVAT|number(double)|false|none|none|
|initialPriceWithVAT|number(double)|false|none|none|
|initialAmountWithVAT|number(double)|false|none|none|
|discountPercentWithVAT|number(double)|false|none|none|
|discountAmountWithVAT|number(double)|false|none|none|
|costVATAmount|number(double)|false|none|none|
|costVATPrice|number(double)|false|none|none|
|saleVATAmount|number(double)|false|none|none|
|discountVATAmount|number(double)|false|none|none|
|costAmountCurrency|number(double)|false|none|none|
|costPriceCurrency|number(double)|false|none|none|
|salePriceCurrency|number(double)|false|none|none|
|saleAmountCurrency|number(double)|false|none|none|
|profitCurrency|number(double)|false|none|none|
|profitPercentBySaleCurrency|number(double)|false|none|none|
|profitPercentByCostCurrency|number(double)|false|none|none|
|initialPriceCurrency|number(double)|false|none|none|
|initialAmountCurrency|number(double)|false|none|none|
|discountPercentCurrency|number(double)|false|none|none|
|discountAmountCurrency|number(double)|false|none|none|
|usedBonus|number(double)|false|none|none|
|accumulatedBonus|number(double)|false|none|none|
|description|string¦null|false|none|none|
|seller|string¦null|false|none|none|
|sellerName|string¦null|false|none|none|
|comment|string¦null|false|none|none|
|itemGroup|string¦null|false|none|none|
|itemSpecification|string¦null|false|none|none|
|businessAddress|string¦null|false|none|none|
|incomeDate|string(date)¦null|false|none|none|
|partySupplierId|integer(int32)|false|none|none|
|partySupplierName|string¦null|false|none|none|
|partySupplierTaxCode|string¦null|false|none|none|
|partyContractName|string¦null|false|none|none|
|partyDocumentTypeName|string¦null|false|none|none|
|partyDocumentNumber|string¦null|false|none|none|
|partyExpirationDate|string(date)¦null|false|none|none|
|partyCountryName|string¦null|false|none|none|
|partyProducerName|string¦null|false|none|none|
|partyPropertyType1Name|string¦null|false|none|none|
|partyPropertyValue1Name|string¦null|false|none|none|
|partyPropertyType2Name|string¦null|false|none|none|
|partyPropertyValue2Name|string¦null|false|none|none|
|partyBase|string(uuid)|false|none|none|
|partyRow|integer(int32)|false|none|none|

<h2 id="tocS_SalesAnalysisDataRowApiResponse">SalesAnalysisDataRowApiResponse</h2>
<!-- backwards compatibility -->
<a id="schemasalesanalysisdatarowapiresponse"></a>
<a id="schema_SalesAnalysisDataRowApiResponse"></a>
<a id="tocSsalesanalysisdatarowapiresponse"></a>
<a id="tocssalesanalysisdatarowapiresponse"></a>

```json
{
  "id": "497f6eca-6276-4993-bfeb-53cbbbba6f08",
  "hasMore": true,
  "data": [
    {
      "documentNumber": "string",
      "date": "2019-08-24",
      "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
      "operationType": "string",
      "documentCurrency": "string",
      "documentVATType": "string",
      "documentVATTypeName": "string",
      "ecrCheckNumber": "string",
      "itemType": "string",
      "itemTypeName": "string",
      "itemId": 0,
      "itemCode": "string",
      "itemName": "string",
      "unitMeasure": "string",
      "unitMeasureAbbreviation": "string",
      "storage": "string",
      "storageName": "string",
      "cashDesk": "string",
      "cashDeskName": "string",
      "customer": "string",
      "customerName": "string",
      "customerContractName": "string",
      "quantity": 0.1,
      "costAmountWithoutVAT": 0.1,
      "costPriceWithoutVAT": 0.1,
      "salePriceWithoutVAT": 0.1,
      "saleAmountWithoutVAT": 0.1,
      "profitWithoutVAT": 0.1,
      "profitPercentBySaleWithoutVAT": 0.1,
      "profitPercentByCostWithoutVAT": 0.1,
      "initialPriceWithoutVAT": 0.1,
      "initialAmountWithoutVAT": 0.1,
      "discountPercentWithoutVAT": 0.1,
      "discountAmountWithoutVAT": 0.1,
      "costAmountWithVAT": 0.1,
      "costPriceWithVAT": 0.1,
      "salePriceWithVAT": 0.1,
      "saleAmountWithVAT": 0.1,
      "profitWithVAT": 0.1,
      "profitPercentBySaleWithVAT": 0.1,
      "profitPercentByCostWithVAT": 0.1,
      "initialPriceWithVAT": 0.1,
      "initialAmountWithVAT": 0.1,
      "discountPercentWithVAT": 0.1,
      "discountAmountWithVAT": 0.1,
      "costVATAmount": 0.1,
      "costVATPrice": 0.1,
      "saleVATAmount": 0.1,
      "discountVATAmount": 0.1,
      "costAmountCurrency": 0.1,
      "costPriceCurrency": 0.1,
      "salePriceCurrency": 0.1,
      "saleAmountCurrency": 0.1,
      "profitCurrency": 0.1,
      "profitPercentBySaleCurrency": 0.1,
      "profitPercentByCostCurrency": 0.1,
      "initialPriceCurrency": 0.1,
      "initialAmountCurrency": 0.1,
      "discountPercentCurrency": 0.1,
      "discountAmountCurrency": 0.1,
      "usedBonus": 0.1,
      "accumulatedBonus": 0.1,
      "description": "string",
      "seller": "string",
      "sellerName": "string",
      "comment": "string",
      "itemGroup": "string",
      "itemSpecification": "string",
      "businessAddress": "string",
      "incomeDate": "2019-08-24",
      "partySupplierId": 0,
      "partySupplierName": "string",
      "partySupplierTaxCode": "string",
      "partyContractName": "string",
      "partyDocumentTypeName": "string",
      "partyDocumentNumber": "string",
      "partyExpirationDate": "2019-08-24",
      "partyCountryName": "string",
      "partyProducerName": "string",
      "partyPropertyType1Name": "string",
      "partyPropertyValue1Name": "string",
      "partyPropertyType2Name": "string",
      "partyPropertyValue2Name": "string",
      "partyBase": "c39df95f-1f9b-4de1-8155-0f24e1c3b455",
      "partyRow": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string(uuid)|false|none|none|
|hasMore|boolean|false|none|none|
|data|[[SalesAnalysisDataRow](#schemasalesanalysisdatarow)]¦null|false|none|none|

<h2 id="tocS_SalesAnalysisParam">SalesAnalysisParam</h2>
<!-- backwards compatibility -->
<a id="schemasalesanalysisparam"></a>
<a id="schema_SalesAnalysisParam"></a>
<a id="tocSsalesanalysisparam"></a>
<a id="tocssalesanalysisparam"></a>

```json
{
  "pageSize": 0,
  "startDate": "2019-08-24",
  "endDate": "2019-08-24",
  "storages": [
    "string"
  ],
  "itemType": "string",
  "itemsGroup": "string",
  "itemCode": "string",
  "partnersGroup": "string",
  "partnerCode": "string",
  "showQuantitiesWithAdditionalUnits": true,
  "showSumsWithoutVAT": true,
  "showSumsWithVAT": true,
  "showCurrencySums": true,
  "showParties": true,
  "showCostAndSalePrices": true,
  "showDiscounts": true,
  "showBonusPoints": true,
  "showVATAmounts": true,
  "groupBy": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|pageSize|integer(int32)¦null|false|none|none|
|startDate|string(date)|true|none|none|
|endDate|string(date)|true|none|none|
|storages|[string]¦null|false|none|none|
|itemType|string¦null|false|none|none|
|itemsGroup|string¦null|false|none|none|
|itemCode|string¦null|false|none|none|
|partnersGroup|string¦null|false|none|none|
|partnerCode|string¦null|false|none|none|
|showQuantitiesWithAdditionalUnits|boolean|false|none|none|
|showSumsWithoutVAT|boolean|false|none|none|
|showSumsWithVAT|boolean|false|none|none|
|showCurrencySums|boolean|false|none|none|
|showParties|boolean|false|none|none|
|showCostAndSalePrices|boolean|false|none|none|
|showDiscounts|boolean|false|none|none|
|showBonusPoints|boolean|false|none|none|
|showVATAmounts|boolean|false|none|none|
|groupBy|string¦null|false|none|none|

<h2 id="tocS_Storage">Storage</h2>
<!-- backwards compatibility -->
<a id="schemastorage"></a>
<a id="schema_Storage"></a>
<a id="tocSstorage"></a>
<a id="tocsstorage"></a>

```json
{
  "code": "string",
  "name": "string",
  "stockkeeper": "string",
  "address": "string",
  "retail": true
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|stockkeeper|string¦null|false|none|none|
|address|string¦null|false|none|none|
|retail|boolean¦null|false|none|none|

<h2 id="tocS_StorageInputOrder">StorageInputOrder</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorder"></a>
<a id="schema_StorageInputOrder"></a>
<a id="tocSstorageinputorder"></a>
<a id="tocsstorageinputorder"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|baseDocumentISN|string(uuid)|false|none|none|
|storage|string¦null|false|none|none|
|supplierCode|string¦null|false|none|none|
|supplierContract|string¦null|false|none|none|
|purchaseDocumentNumber|string¦null|false|none|none|
|purchaseDocumentDate|string(date)¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|currencyExchangeRate|number(double)¦null|false|none|none|
|currencyExchangeBase|number(double)¦null|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|includeVATInCost|boolean|false|none|none|
|priceType|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|letterOfAttorney|string¦null|false|none|none|
|mediator|string¦null|false|none|none|
|vehicle|string¦null|false|none|none|
|chiefAccount|string¦null|false|none|none|
|allowed|string¦null|false|none|none|
|accepted|string¦null|false|none|none|
|productsList|[[StorageInputOrderSpecificationRow](#schemastorageinputorderspecificationrow)]¦null|false|none|none|

<h2 id="tocS_StorageInputOrderRetail">StorageInputOrderRetail</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorderretail"></a>
<a id="schema_StorageInputOrderRetail"></a>
<a id="tocSstorageinputorderretail"></a>
<a id="tocsstorageinputorderretail"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "baseDocumentISN": "e3cf3357-51e7-469a-a6c4-77dfddcb9255",
  "storage": "string",
  "supplierCode": "string",
  "supplierContract": "string",
  "purchaseDocumentNumber": "string",
  "purchaseDocumentDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "vatCalculationType": "string",
  "includeVATInCost": true,
  "priceType": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "letterOfAttorney": "string",
  "mediator": "string",
  "vehicle": "string",
  "chiefAccount": "string",
  "allowed": "string",
  "accepted": "string",
  "productsList": [
    {
      "id": 0,
      "code": "string",
      "name": "string",
      "fullName": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "addedValuePercent": 0.1,
      "salePrice": 0.1,
      "saleAmount": 0.1,
      "description": "string",
      "vat": true,
      "expirationDate": "2019-08-24",
      "country": "string",
      "producer": "string",
      "property1": "string",
      "property2": "string",
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|baseDocumentISN|string(uuid)|false|none|none|
|storage|string¦null|false|none|none|
|supplierCode|string¦null|false|none|none|
|supplierContract|string¦null|false|none|none|
|purchaseDocumentNumber|string¦null|false|none|none|
|purchaseDocumentDate|string(date)¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|currencyExchangeRate|number(double)¦null|false|none|none|
|currencyExchangeBase|number(double)¦null|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|includeVATInCost|boolean|false|none|none|
|priceType|string¦null|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|letterOfAttorney|string¦null|false|none|none|
|mediator|string¦null|false|none|none|
|vehicle|string¦null|false|none|none|
|chiefAccount|string¦null|false|none|none|
|allowed|string¦null|false|none|none|
|accepted|string¦null|false|none|none|
|productsList|[[StorageInputOrderRetailSpecificationRow](#schemastorageinputorderretailspecificationrow)]¦null|false|none|none|

<h2 id="tocS_StorageInputOrderRetailSpecificationRow">StorageInputOrderRetailSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorderretailspecificationrow"></a>
<a id="schema_StorageInputOrderRetailSpecificationRow"></a>
<a id="tocSstorageinputorderretailspecificationrow"></a>
<a id="tocsstorageinputorderretailspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "addedValuePercent": 0.1,
  "salePrice": 0.1,
  "saleAmount": 0.1,
  "description": "string",
  "vat": true,
  "expirationDate": "2019-08-24",
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|price|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|amount|number(double)¦null|false|none|none|
|addedValuePercent|number(double)|false|none|none|
|salePrice|number(double)|false|none|none|
|saleAmount|number(double)|false|none|none|
|description|string¦null|false|none|none|
|vat|boolean¦null|false|none|none|
|expirationDate|string(date)¦null|false|none|none|
|country|string¦null|false|none|none|
|producer|string¦null|false|none|none|
|property1|string¦null|false|none|none|
|property2|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|

<h2 id="tocS_StorageInputOrderSpecificationRow">StorageInputOrderSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schemastorageinputorderspecificationrow"></a>
<a id="schema_StorageInputOrderSpecificationRow"></a>
<a id="tocSstorageinputorderspecificationrow"></a>
<a id="tocsstorageinputorderspecificationrow"></a>

```json
{
  "id": 0,
  "code": "string",
  "name": "string",
  "fullName": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "description": "string",
  "vat": true,
  "expirationDate": "2019-08-24",
  "country": "string",
  "producer": "string",
  "property1": "string",
  "property2": "string",
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|fullName|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|price|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|amount|number(double)¦null|false|none|none|
|description|string¦null|false|none|none|
|vat|boolean¦null|false|none|none|
|expirationDate|string(date)¦null|false|none|none|
|country|string¦null|false|none|none|
|producer|string¦null|false|none|none|
|property1|string¦null|false|none|none|
|property2|string¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|

<h2 id="tocS_TransferInvoice">TransferInvoice</h2>
<!-- backwards compatibility -->
<a id="schematransferinvoice"></a>
<a id="schema_TransferInvoice"></a>
<a id="tocStransferinvoice"></a>
<a id="tocstransferinvoice"></a>

```json
{
  "isn": "13a02e4e-9f55-416a-842c-b67b097485f4",
  "date": "2019-08-24",
  "documentNumber": "string",
  "state": 0,
  "customer": "string",
  "currency": "string",
  "currencyExchangeRate": 0.1,
  "currencyExchangeBase": 0.1,
  "contract": "string",
  "contractDate": "2019-08-24",
  "comment": "string",
  "owner": "string",
  "vatCalculationType": "string",
  "priceType": "string",
  "storage": "string",
  "discountPercent": 0.1,
  "vatAmount": 0.1,
  "totalAmount": 0.1,
  "supplierName": "string",
  "supplierLegalAddress": "string",
  "supplierBusinessAddress": "string",
  "supplierSettlementAccount": "string",
  "supplierTaxCode": "string",
  "supplierManagerPosition": "string",
  "supplierManagerName": "string",
  "supplierAccountantPosition": "string",
  "supplierAccountantName": "string",
  "customerName": "string",
  "customerLegalAddress": "string",
  "customerBusinessAddress": "string",
  "customerSettlementAccount": "string",
  "customerTaxCode": "string",
  "customerManagerPosition": "string",
  "customerManagerName": "string",
  "customerAccountantPosition": "string",
  "customerAccountantName": "string",
  "stateRegisterNumber": "string",
  "passportNumber": "string",
  "itemList": [
    {
      "type": "string",
      "storage": "string",
      "id": 0,
      "code": "string",
      "name": "string",
      "unit": "string",
      "unitAbbreviation": "string",
      "quantity": 0.1,
      "price": 0.1,
      "discountPercent": 0.1,
      "discountedPrice": 0.1,
      "amount": 0.1,
      "vat": true,
      "rowNumber": 0,
      "rowId": 0
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|isn|string(uuid)|false|none|none|
|date|string(date)¦null|false|none|none|
|documentNumber|string¦null|false|none|none|
|state|integer(int32)|false|none|none|
|customer|string¦null|false|none|none|
|currency|string¦null|false|none|none|
|currencyExchangeRate|number(double)|false|none|none|
|currencyExchangeBase|number(double)|false|none|none|
|contract|string¦null|false|none|none|
|contractDate|string(date)¦null|false|none|none|
|comment|string¦null|false|none|none|
|owner|string¦null|false|none|none|
|vatCalculationType|string¦null|false|none|none|
|priceType|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|discountPercent|number(double)|false|none|none|
|vatAmount|number(double)|false|none|none|
|totalAmount|number(double)|false|none|none|
|supplierName|string¦null|false|none|none|
|supplierLegalAddress|string¦null|false|none|none|
|supplierBusinessAddress|string¦null|false|none|none|
|supplierSettlementAccount|string¦null|false|none|none|
|supplierTaxCode|string¦null|false|none|none|
|supplierManagerPosition|string¦null|false|none|none|
|supplierManagerName|string¦null|false|none|none|
|supplierAccountantPosition|string¦null|false|none|none|
|supplierAccountantName|string¦null|false|none|none|
|customerName|string¦null|false|none|none|
|customerLegalAddress|string¦null|false|none|none|
|customerBusinessAddress|string¦null|false|none|none|
|customerSettlementAccount|string¦null|false|none|none|
|customerTaxCode|string¦null|false|none|none|
|customerManagerPosition|string¦null|false|none|none|
|customerManagerName|string¦null|false|none|none|
|customerAccountantPosition|string¦null|false|none|none|
|customerAccountantName|string¦null|false|none|none|
|stateRegisterNumber|string¦null|false|none|none|
|passportNumber|string¦null|false|none|none|
|itemList|[[TransferInvoiceSpecificationRow](#schematransferinvoicespecificationrow)]¦null|false|none|none|

<h2 id="tocS_TransferInvoiceSpecificationRow">TransferInvoiceSpecificationRow</h2>
<!-- backwards compatibility -->
<a id="schematransferinvoicespecificationrow"></a>
<a id="schema_TransferInvoiceSpecificationRow"></a>
<a id="tocStransferinvoicespecificationrow"></a>
<a id="tocstransferinvoicespecificationrow"></a>

```json
{
  "type": "string",
  "storage": "string",
  "id": 0,
  "code": "string",
  "name": "string",
  "unit": "string",
  "unitAbbreviation": "string",
  "quantity": 0.1,
  "price": 0.1,
  "discountPercent": 0.1,
  "discountedPrice": 0.1,
  "amount": 0.1,
  "vat": true,
  "rowNumber": 0,
  "rowId": 0
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|type|string¦null|false|none|none|
|storage|string¦null|false|none|none|
|id|integer(int32)|false|none|none|
|code|string¦null|false|none|none|
|name|string¦null|false|none|none|
|unit|string¦null|false|none|none|
|unitAbbreviation|string¦null|false|none|none|
|quantity|number(double)|false|none|none|
|price|number(double)|false|none|none|
|discountPercent|number(double)¦null|false|none|none|
|discountedPrice|number(double)¦null|false|none|none|
|amount|number(double)¦null|false|none|none|
|vat|boolean¦null|false|none|none|
|rowNumber|integer(int32)|false|none|none|
|rowId|integer(int32)|false|none|none|

