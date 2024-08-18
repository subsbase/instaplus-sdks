# InstaPlusapi.WebhookApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**webhookEventsGet**](WebhookApi.md#webhookEventsGet) | **GET** /webhook/events | 
[**webhookGet**](WebhookApi.md#webhookGet) | **GET** /webhook | 
[**webhookIdDelete**](WebhookApi.md#webhookIdDelete) | **DELETE** /webhook/{id} | 
[**webhookIdGet**](WebhookApi.md#webhookIdGet) | **GET** /webhook/{id} | 
[**webhookIdLogsGet**](WebhookApi.md#webhookIdLogsGet) | **GET** /webhook/{id}/logs | 
[**webhookPut**](WebhookApi.md#webhookPut) | **PUT** /webhook | 

<a name="webhookEventsGet"></a>
# **webhookEventsGet**
> webhookEventsGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
apiInstance.webhookEventsGet((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="webhookGet"></a>
# **webhookGet**
> webhookGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
apiInstance.webhookGet((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="webhookIdDelete"></a>
# **webhookIdDelete**
> webhookIdDelete(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
let id = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // String | 

apiInstance.webhookIdDelete(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="webhookIdGet"></a>
# **webhookIdGet**
> webhookIdGet(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
let id = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // String | 

apiInstance.webhookIdGet(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="webhookIdLogsGet"></a>
# **webhookIdLogsGet**
> webhookIdLogsGet(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
let id = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // String | 

apiInstance.webhookIdLogsGet(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="webhookPut"></a>
# **webhookPut**
> webhookPut(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.WebhookApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.webhookPut(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**{String: JToken}**](Object.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

