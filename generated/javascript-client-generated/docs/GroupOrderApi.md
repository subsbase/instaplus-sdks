# InstaPlusapi.GroupOrderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**groupOrderGet**](GroupOrderApi.md#groupOrderGet) | **GET** /group-order | 
[**groupOrderIdDelete**](GroupOrderApi.md#groupOrderIdDelete) | **DELETE** /group-order/{id} | 
[**groupOrderIdGet**](GroupOrderApi.md#groupOrderIdGet) | **GET** /group-order/{id} | 
[**groupOrderPut**](GroupOrderApi.md#groupOrderPut) | **PUT** /group-order | 

<a name="groupOrderGet"></a>
# **groupOrderGet**
> groupOrderGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.GroupOrderApi();
apiInstance.groupOrderGet((error, data, response) => {
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

<a name="groupOrderIdDelete"></a>
# **groupOrderIdDelete**
> groupOrderIdDelete(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.GroupOrderApi();
let id = "id_example"; // String | 

apiInstance.groupOrderIdDelete(id, (error, data, response) => {
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

<a name="groupOrderIdGet"></a>
# **groupOrderIdGet**
> groupOrderIdGet(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.GroupOrderApi();
let id = "id_example"; // String | 

apiInstance.groupOrderIdGet(id, (error, data, response) => {
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

<a name="groupOrderPut"></a>
# **groupOrderPut**
> groupOrderPut(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.GroupOrderApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.groupOrderPut(opts, (error, data, response) => {
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

