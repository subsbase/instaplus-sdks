# swagger_client.ReceivingAccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**receiving_account_get**](ReceivingAccountApi.md#receiving_account_get) | **GET** /receiving-account | 
[**receiving_account_id_delete**](ReceivingAccountApi.md#receiving_account_id_delete) | **DELETE** /receiving-account/{id} | 
[**receiving_account_id_get**](ReceivingAccountApi.md#receiving_account_id_get) | **GET** /receiving-account/{id} | 
[**receiving_account_put**](ReceivingAccountApi.md#receiving_account_put) | **PUT** /receiving-account | 
[**receiving_account_receiving_account_id_link_to_post**](ReceivingAccountApi.md#receiving_account_receiving_account_id_link_to_post) | **POST** /receiving-account/{receivingAccountId}/link-to | 
[**receiving_account_types_get**](ReceivingAccountApi.md#receiving_account_types_get) | **GET** /receiving-account/types | 

# **receiving_account_get**
> receiving_account_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()

try:
    api_instance.receiving_account_get()
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_get: %s\n" % e)
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

# **receiving_account_id_delete**
> receiving_account_id_delete(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()
id = 'id_example' # str | 

try:
    api_instance.receiving_account_id_delete(id)
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_id_delete: %s\n" % e)
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

# **receiving_account_id_get**
> receiving_account_id_get(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()
id = 'id_example' # str | 

try:
    api_instance.receiving_account_id_get(id)
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_id_get: %s\n" % e)
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

# **receiving_account_put**
> receiving_account_put(body=body)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()
body = NULL # dict(str, JToken) |  (optional)

try:
    api_instance.receiving_account_put(body=body)
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_put: %s\n" % e)
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

# **receiving_account_receiving_account_id_link_to_post**
> receiving_account_receiving_account_id_link_to_post(receiving_account_id, code=code)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()
receiving_account_id = 'receiving_account_id_example' # str | 
code = 'code_example' # str |  (optional)

try:
    api_instance.receiving_account_receiving_account_id_link_to_post(receiving_account_id, code=code)
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_receiving_account_id_link_to_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receiving_account_id** | **str**|  | 
 **code** | **str**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **receiving_account_types_get**
> receiving_account_types_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReceivingAccountApi()

try:
    api_instance.receiving_account_types_get()
except ApiException as e:
    print("Exception when calling ReceivingAccountApi->receiving_account_types_get: %s\n" % e)
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

