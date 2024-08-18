# swagger_client.GroupOrderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**group_order_get**](GroupOrderApi.md#group_order_get) | **GET** /group-order | 
[**group_order_id_delete**](GroupOrderApi.md#group_order_id_delete) | **DELETE** /group-order/{id} | 
[**group_order_id_get**](GroupOrderApi.md#group_order_id_get) | **GET** /group-order/{id} | 
[**group_order_put**](GroupOrderApi.md#group_order_put) | **PUT** /group-order | 

# **group_order_get**
> group_order_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GroupOrderApi()

try:
    api_instance.group_order_get()
except ApiException as e:
    print("Exception when calling GroupOrderApi->group_order_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **group_order_id_delete**
> group_order_id_delete(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GroupOrderApi()
id = 'id_example' # str | 

try:
    api_instance.group_order_id_delete(id)
except ApiException as e:
    print("Exception when calling GroupOrderApi->group_order_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **group_order_id_get**
> group_order_id_get(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GroupOrderApi()
id = 'id_example' # str | 

try:
    api_instance.group_order_id_get(id)
except ApiException as e:
    print("Exception when calling GroupOrderApi->group_order_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **group_order_put**
> group_order_put(body=body)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GroupOrderApi()
body = NULL # dict(str, JToken) |  (optional)

try:
    api_instance.group_order_put(body=body)
except ApiException as e:
    print("Exception when calling GroupOrderApi->group_order_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**dict(str, JToken)**](dict.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

