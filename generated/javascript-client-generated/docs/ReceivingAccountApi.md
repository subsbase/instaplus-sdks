# InstaPlusapi.ReceivingAccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**receivingAccountGet**](ReceivingAccountApi.md#receivingAccountGet) | **GET** /receiving-account | 
[**receivingAccountIdDelete**](ReceivingAccountApi.md#receivingAccountIdDelete) | **DELETE** /receiving-account/{id} | 
[**receivingAccountIdGet**](ReceivingAccountApi.md#receivingAccountIdGet) | **GET** /receiving-account/{id} | 
[**receivingAccountPut**](ReceivingAccountApi.md#receivingAccountPut) | **PUT** /receiving-account | 
[**receivingAccountReceivingAccountIdLinkToPost**](ReceivingAccountApi.md#receivingAccountReceivingAccountIdLinkToPost) | **POST** /receiving-account/{receivingAccountId}/link-to | 
[**receivingAccountTypesGet**](ReceivingAccountApi.md#receivingAccountTypesGet) | **GET** /receiving-account/types | 

<a name="receivingAccountGet"></a>
# **receivingAccountGet**
> receivingAccountGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
apiInstance.receivingAccountGet((error, data, response) => {
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

<a name="receivingAccountIdDelete"></a>
# **receivingAccountIdDelete**
> receivingAccountIdDelete(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
let id = "id_example"; // String | 

apiInstance.receivingAccountIdDelete(id, (error, data, response) => {
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
 **id** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="receivingAccountIdGet"></a>
# **receivingAccountIdGet**
> receivingAccountIdGet(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
let id = "id_example"; // String | 

apiInstance.receivingAccountIdGet(id, (error, data, response) => {
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
 **id** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="receivingAccountPut"></a>
# **receivingAccountPut**
> receivingAccountPut(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.receivingAccountPut(opts, (error, data, response) => {
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

<a name="receivingAccountReceivingAccountIdLinkToPost"></a>
# **receivingAccountReceivingAccountIdLinkToPost**
> receivingAccountReceivingAccountIdLinkToPost(receivingAccountId, opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
let receivingAccountId = "receivingAccountId_example"; // String | 
let opts = { 
  'code': "code_example" // String | 
};
apiInstance.receivingAccountReceivingAccountIdLinkToPost(receivingAccountId, opts, (error, data, response) => {
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
 **receivingAccountId** | **String**|  | 
 **code** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="receivingAccountTypesGet"></a>
# **receivingAccountTypesGet**
> receivingAccountTypesGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.ReceivingAccountApi();
apiInstance.receivingAccountTypesGet((error, data, response) => {
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

