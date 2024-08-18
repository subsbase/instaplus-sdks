# swagger_client.OrderApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**order_get**](OrderApi.md#order_get) | **GET** /order | 
[**order_id_delete**](OrderApi.md#order_id_delete) | **DELETE** /order/{id} | 
[**order_id_get**](OrderApi.md#order_id_get) | **GET** /order/{id} | 
[**order_order_id_link_to_post**](OrderApi.md#order_order_id_link_to_post) | **POST** /order/{orderId}/link-to | 
[**order_put**](OrderApi.md#order_put) | **PUT** /order | 

# **order_get**
> order_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OrderApi()

try:
    api_instance.order_get()
except ApiException as e:
    print("Exception when calling OrderApi->order_get: %s\n" % e)
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

# **order_id_delete**
> order_id_delete(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OrderApi()
id = 'id_example' # str | 

try:
    api_instance.order_id_delete(id)
except ApiException as e:
    print("Exception when calling OrderApi->order_id_delete: %s\n" % e)
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

# **order_id_get**
> order_id_get(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OrderApi()
id = 'id_example' # str | 

try:
    api_instance.order_id_get(id)
except ApiException as e:
    print("Exception when calling OrderApi->order_id_get: %s\n" % e)
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

# **order_order_id_link_to_post**
> order_order_id_link_to_post(order_id, code=code)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OrderApi()
order_id = 'order_id_example' # str | 
code = 'code_example' # str |  (optional)

try:
    api_instance.order_order_id_link_to_post(order_id, code=code)
except ApiException as e:
    print("Exception when calling OrderApi->order_order_id_link_to_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order_id** | **str**|  | 
 **code** | **str**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **order_put**
> order_put(body=body)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OrderApi()
body = NULL # dict(str, JToken) |  (optional)

try:
    api_instance.order_put(body=body)
except ApiException as e:
    print("Exception when calling OrderApi->order_put: %s\n" % e)
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

