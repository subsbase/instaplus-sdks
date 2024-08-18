---
title: InstaPlus.Api v1.0
language_tabs:
  - shell: Shell
  - http: HTTP
  - javascript: JavaScript
  - ruby: Ruby
  - python: Python
  - php: PHP
  - java: Java
  - go: Go
toc_footers: []
includes: []
search: true
highlight_theme: darkula
headingLevel: 2

---

<!-- Generator: Widdershins v4.0.1 -->

<h1 id="instaplus-api">InstaPlus.Api v1.0</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

<h1 id="instaplus-api-grouporder">GroupOrder</h1>

## put__group-order

> Code samples

```shell
# You can also use wget
curl -X PUT /group-order \
  -H 'Content-Type: application/json' \
  -H 'Accept: application/json'

```

```http
PUT /group-order HTTP/1.1

Content-Type: application/json
Accept: application/json

```

```javascript
const inputBody = '{
  "from": [
    {
      "externalId": "string",
      "amount": 0
    }
  ],
  "notes": "string",
  "receivingAccountId": "string",
  "validityInHours": 0
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'application/json'
};

fetch('/group-order',
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
  'Accept' => 'application/json'
}

result = RestClient.put '/group-order',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'application/json'
}

r = requests.put('/group-order', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'application/json',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/group-order', array(
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
URL obj = new URL("/group-order");
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
        "Accept": []string{"application/json"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/group-order", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /group-order`

> Body parameter

```json
{
  "from": [
    {
      "externalId": "string",
      "amount": 0
    }
  ],
  "notes": "string",
  "receivingAccountId": "string",
  "validityInHours": 0
}
```

<h3 id="put__group-order-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» from|body|[any]|false|none|
|»» externalId|body|string|false|none|
|»» amount|body|number|false|none|
|» notes|body|string|false|none|
|» receivingAccountId|body|string|false|Receiving Account Id can be retrieved from Instaplus Dashboard|
|» validityInHours|body|number|false|none|

> Example responses

> 200 Response

```json
"string"
```

<h3 id="put__group-order-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|string|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unallowed|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__group-order_{id}

> Code samples

```shell
# You can also use wget
curl -X GET /group-order/{id} \
  -H 'Accept: application/json'

```

```http
GET /group-order/{id} HTTP/1.1

Accept: application/json

```

```javascript

const headers = {
  'Accept':'application/json'
};

fetch('/group-order/{id}',
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
  'Accept' => 'application/json'
}

result = RestClient.get '/group-order/{id}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'application/json'
}

r = requests.get('/group-order/{id}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'application/json',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/group-order/{id}', array(
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
URL obj = new URL("/group-order/{id}");
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
        "Accept": []string{"application/json"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/group-order/{id}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /group-order/{id}`

<h3 id="get__group-order_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|string|true|none|

> Example responses

> 200 Response

```json
{
  "id": "string",
  "totalAmount": 0,
  "collectedAmount": 0,
  "createdAt": "string",
  "expiresAt": "string",
  "to": {
    "number": "string"
  },
  "receivingAccountType": "IPA",
  "notes": "string",
  "orders": [
    {
      "id": "string",
      "externalId": "string",
      "createdAt": "string",
      "amount": 0,
      "collectedAmount": 0,
      "to": {
        "number": "string"
      },
      "receivingAccountType": "IPA",
      "expiresAt": "string",
      "notes": "string",
      "userAccountId": "string",
      "transactionReceipts": [
        {
          "instapayReference": "string",
          "timestamp": "string",
          "amount": 0,
          "from": {
            "ipa": "string"
          }
        }
      ]
    }
  ]
}
```

<h3 id="get__group-order_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[groupOrder](#schemagrouporder)|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="instaplus-api-order">Order</h1>

## put__order

> Code samples

```shell
# You can also use wget
curl -X PUT /order \
  -H 'Content-Type: application/json' \
  -H 'Accept: application/json'

```

```http
PUT /order HTTP/1.1

Content-Type: application/json
Accept: application/json

```

```javascript
const inputBody = '{
  "externalId": "string",
  "amount": 0,
  "receivingAccountId": "string",
  "validityInHours": 0,
  "notes": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'application/json'
};

fetch('/order',
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
  'Accept' => 'application/json'
}

result = RestClient.put '/order',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json',
  'Accept': 'application/json'
}

r = requests.put('/order', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
    'Accept' => 'application/json',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('PUT','/order', array(
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
URL obj = new URL("/order");
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
        "Accept": []string{"application/json"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("PUT", "/order", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`PUT /order`

> Body parameter

```json
{
  "externalId": "string",
  "amount": 0,
  "receivingAccountId": "string",
  "validityInHours": 0,
  "notes": "string"
}
```

<h3 id="put__order-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|object|false|none|
|» externalId|body|string|false|none|
|» amount|body|number|false|none|
|» receivingAccountId|body|string|false|Receiving Account Id can be retrieved from Instaplus Dashboard|
|» validityInHours|body|number|false|none|
|» notes|body|string|false|none|

> Example responses

> 200 Response

```json
"string"
```

<h3 id="put__order-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|string|
|401|[Unauthorized](https://tools.ietf.org/html/rfc7235#section-3.1)|Unallowed|None|

<aside class="success">
This operation does not require authentication
</aside>

## get__order_{id}

> Code samples

```shell
# You can also use wget
curl -X GET /order/{id} \
  -H 'Accept: application/json'

```

```http
GET /order/{id} HTTP/1.1

Accept: application/json

```

```javascript

const headers = {
  'Accept':'application/json'
};

fetch('/order/{id}',
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
  'Accept' => 'application/json'
}

result = RestClient.get '/order/{id}',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Accept': 'application/json'
}

r = requests.get('/order/{id}', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Accept' => 'application/json',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('GET','/order/{id}', array(
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
URL obj = new URL("/order/{id}");
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
        "Accept": []string{"application/json"},
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("GET", "/order/{id}", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`GET /order/{id}`

<h3 id="get__order_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|string|true|none|

> Example responses

> 200 Response

```json
{
  "id": "string",
  "externalId": "string",
  "createdAt": "string",
  "amount": 0,
  "collectedAmount": 0,
  "to": {
    "number": "string"
  },
  "receivingAccountType": "IPA",
  "expiresAt": "string",
  "notes": "string",
  "userAccountId": "string",
  "transactionReceipts": [
    {
      "instapayReference": "string",
      "timestamp": "string",
      "amount": 0,
      "from": {
        "ipa": "string"
      }
    }
  ]
}
```

<h3 id="get__order_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[order](#schemaorder)|

<aside class="success">
This operation does not require authentication
</aside>

<h1 id="instaplus-api-user">User</h1>

## post__user_login

> Code samples

```shell
# You can also use wget
curl -X POST /user/login \
  -H 'Content-Type: application/json'

```

```http
POST /user/login HTTP/1.1

Content-Type: application/json

```

```javascript
const inputBody = '{
  "userId": "string",
  "password": "string"
}';
const headers = {
  'Content-Type':'application/json'
};

fetch('/user/login',
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
  'Content-Type' => 'application/json'
}

result = RestClient.post '/user/login',
  params: {
  }, headers: headers

p JSON.parse(result)

```

```python
import requests
headers = {
  'Content-Type': 'application/json'
}

r = requests.post('/user/login', headers = headers)

print(r.json())

```

```php
<?php

require 'vendor/autoload.php';

$headers = array(
    'Content-Type' => 'application/json',
);

$client = new \GuzzleHttp\Client();

// Define array of request body.
$request_body = array();

try {
    $response = $client->request('POST','/user/login', array(
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
URL obj = new URL("/user/login");
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
    }

    data := bytes.NewBuffer([]byte{jsonReq})
    req, err := http.NewRequest("POST", "/user/login", data)
    req.Header = headers

    client := &http.Client{}
    resp, err := client.Do(req)
    // ...
}

```

`POST /user/login`

> Body parameter

```json
{
  "userId": "string",
  "password": "string"
}
```

<h3 id="post__user_login-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[userLogin](#schemauserlogin)|false|none|

<h3 id="post__user_login-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|None|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_userLogin">userLogin</h2>
<!-- backwards compatibility -->
<a id="schemauserlogin"></a>
<a id="schema_userLogin"></a>
<a id="tocSuserlogin"></a>
<a id="tocsuserlogin"></a>

```json
{
  "userId": "string",
  "password": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|userId|string|false|none|none|
|password|string|false|none|none|

<h2 id="tocS_groupOrder">groupOrder</h2>
<!-- backwards compatibility -->
<a id="schemagrouporder"></a>
<a id="schema_groupOrder"></a>
<a id="tocSgrouporder"></a>
<a id="tocsgrouporder"></a>

```json
{
  "id": "string",
  "totalAmount": 0,
  "collectedAmount": 0,
  "createdAt": "string",
  "expiresAt": "string",
  "to": {
    "number": "string"
  },
  "receivingAccountType": "IPA",
  "notes": "string",
  "orders": [
    {
      "id": "string",
      "externalId": "string",
      "createdAt": "string",
      "amount": 0,
      "collectedAmount": 0,
      "to": {
        "number": "string"
      },
      "receivingAccountType": "IPA",
      "expiresAt": "string",
      "notes": "string",
      "userAccountId": "string",
      "transactionReceipts": [
        {
          "instapayReference": "string",
          "timestamp": "string",
          "amount": 0,
          "from": {
            "ipa": "string"
          }
        }
      ]
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string|false|none|none|
|totalAmount|number|false|none|none|
|collectedAmount|number|false|none|none|
|createdAt|string|false|none|ISO Datetime|
|expiresAt|string|false|none|ISO Datetime|
|to|[receivingAccount](#schemareceivingaccount)|false|none|none|
|receivingAccountType|[receivingAccountType](#schemareceivingaccounttype)|false|none|none|
|notes|string|false|none|none|
|orders|[[order](#schemaorder)]|false|none|none|

<h2 id="tocS_order">order</h2>
<!-- backwards compatibility -->
<a id="schemaorder"></a>
<a id="schema_order"></a>
<a id="tocSorder"></a>
<a id="tocsorder"></a>

```json
{
  "id": "string",
  "externalId": "string",
  "createdAt": "string",
  "amount": 0,
  "collectedAmount": 0,
  "to": {
    "number": "string"
  },
  "receivingAccountType": "IPA",
  "expiresAt": "string",
  "notes": "string",
  "userAccountId": "string",
  "transactionReceipts": [
    {
      "instapayReference": "string",
      "timestamp": "string",
      "amount": 0,
      "from": {
        "ipa": "string"
      }
    }
  ]
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|id|string|false|none|none|
|externalId|string|false|none|none|
|createdAt|string|false|none|ISO Datetime|
|amount|number|false|none|none|
|collectedAmount|number|false|none|none|
|to|[receivingAccount](#schemareceivingaccount)|false|none|none|
|receivingAccountType|[receivingAccountType](#schemareceivingaccounttype)|false|none|none|
|expiresAt|string|false|none|ISO Datetime|
|notes|string|false|none|none|
|userAccountId|string|false|none|none|
|transactionReceipts|[[transactionReceipt](#schematransactionreceipt)]|false|none|none|

<h2 id="tocS_receivingAccount">receivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemareceivingaccount"></a>
<a id="schema_receivingAccount"></a>
<a id="tocSreceivingaccount"></a>
<a id="tocsreceivingaccount"></a>

```json
{
  "number": "string"
}

```

### Properties

anyOf

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[accountReceivingAccount](#schemaaccountreceivingaccount)|false|none|none|

or

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[walletReceivingAccount](#schemawalletreceivingaccount)|false|none|none|

or

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[ipaReceivingAccount](#schemaipareceivingaccount)|false|none|none|

or

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[bankReceivingAccount](#schemabankreceivingaccount)|false|none|none|

or

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[ibanReceivingAccount](#schemaibanreceivingaccount)|false|none|none|

<h2 id="tocS_receivingAccountType">receivingAccountType</h2>
<!-- backwards compatibility -->
<a id="schemareceivingaccounttype"></a>
<a id="schema_receivingAccountType"></a>
<a id="tocSreceivingaccounttype"></a>
<a id="tocsreceivingaccounttype"></a>

```json
"IPA"

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|string|false|none|none|

#### Enumerated Values

|Property|Value|
|---|---|
|*anonymous*|IPA|
|*anonymous*|WalletNumber|
|*anonymous*|AccountNumber|
|*anonymous*|BankAccount|
|*anonymous*|BankIban|

<h2 id="tocS_transactionReceipt">transactionReceipt</h2>
<!-- backwards compatibility -->
<a id="schematransactionreceipt"></a>
<a id="schema_transactionReceipt"></a>
<a id="tocStransactionreceipt"></a>
<a id="tocstransactionreceipt"></a>

```json
{
  "instapayReference": "string",
  "timestamp": "string",
  "amount": 0,
  "from": {
    "ipa": "string"
  }
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|instapayReference|string|false|none|none|
|timestamp|string|false|none|ISO Datetime|
|amount|number|false|none|none|
|from|object|false|none|none|
|» ipa|string|false|none|none|

<h2 id="tocS_accountReceivingAccount">accountReceivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemaaccountreceivingaccount"></a>
<a id="schema_accountReceivingAccount"></a>
<a id="tocSaccountreceivingaccount"></a>
<a id="tocsaccountreceivingaccount"></a>

```json
{
  "number": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|number|string|false|none|none|

<h2 id="tocS_walletReceivingAccount">walletReceivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemawalletreceivingaccount"></a>
<a id="schema_walletReceivingAccount"></a>
<a id="tocSwalletreceivingaccount"></a>
<a id="tocswalletreceivingaccount"></a>

```json
{
  "number": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|number|string|false|none|none|

<h2 id="tocS_ipaReceivingAccount">ipaReceivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemaipareceivingaccount"></a>
<a id="schema_ipaReceivingAccount"></a>
<a id="tocSipareceivingaccount"></a>
<a id="tocsipareceivingaccount"></a>

```json
{
  "ipa": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|ipa|string|false|none|none|

<h2 id="tocS_bankReceivingAccount">bankReceivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemabankreceivingaccount"></a>
<a id="schema_bankReceivingAccount"></a>
<a id="tocSbankreceivingaccount"></a>
<a id="tocsbankreceivingaccount"></a>

```json
{
  "bankCode": "string",
  "accountNumber": "string",
  "receiverName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|bankCode|string|false|none|none|
|accountNumber|string|false|none|none|
|receiverName|string|false|none|none|

<h2 id="tocS_ibanReceivingAccount">ibanReceivingAccount</h2>
<!-- backwards compatibility -->
<a id="schemaibanreceivingaccount"></a>
<a id="schema_ibanReceivingAccount"></a>
<a id="tocSibanreceivingaccount"></a>
<a id="tocsibanreceivingaccount"></a>

```json
{
  "iban": "string",
  "receiverName": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|iban|string|false|none|none|
|receiverName|string|false|none|none|

