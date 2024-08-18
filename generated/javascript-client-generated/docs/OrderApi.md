# InstaPlusapi.OrderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderGet**](OrderApi.md#orderGet) | **GET** /order | 
[**orderIdDelete**](OrderApi.md#orderIdDelete) | **DELETE** /order/{id} | 
[**orderIdGet**](OrderApi.md#orderIdGet) | **GET** /order/{id} | 
[**orderOrderIdLinkToPost**](OrderApi.md#orderOrderIdLinkToPost) | **POST** /order/{orderId}/link-to | 
[**orderPut**](OrderApi.md#orderPut) | **PUT** /order | 

<a name="orderGet"></a>
# **orderGet**
> orderGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.OrderApi();
apiInstance.orderGet((error, data, response) => {
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

<a name="orderIdDelete"></a>
# **orderIdDelete**
> orderIdDelete(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.OrderApi();
let id = "id_example"; // String | 

apiInstance.orderIdDelete(id, (error, data, response) => {
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

<a name="orderIdGet"></a>
# **orderIdGet**
> orderIdGet(id)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.OrderApi();
let id = "id_example"; // String | 

apiInstance.orderIdGet(id, (error, data, response) => {
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

<a name="orderOrderIdLinkToPost"></a>
# **orderOrderIdLinkToPost**
> orderOrderIdLinkToPost(orderId, opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.OrderApi();
let orderId = "orderId_example"; // String | 
let opts = { 
  'code': "code_example" // String | 
};
apiInstance.orderOrderIdLinkToPost(orderId, opts, (error, data, response) => {
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
 **orderId** | **String**|  | 
 **code** | **String**|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="orderPut"></a>
# **orderPut**
> orderPut(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.OrderApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.orderPut(opts, (error, data, response) => {
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

