# swagger_client.WebhookApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**webhook_events_get**](WebhookApi.md#webhook_events_get) | **GET** /webhook/events | 
[**webhook_get**](WebhookApi.md#webhook_get) | **GET** /webhook | 
[**webhook_id_delete**](WebhookApi.md#webhook_id_delete) | **DELETE** /webhook/{id} | 
[**webhook_id_get**](WebhookApi.md#webhook_id_get) | **GET** /webhook/{id} | 
[**webhook_id_logs_get**](WebhookApi.md#webhook_id_logs_get) | **GET** /webhook/{id}/logs | 
[**webhook_put**](WebhookApi.md#webhook_put) | **PUT** /webhook | 

# **webhook_events_get**
> webhook_events_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()

try:
    api_instance.webhook_events_get()
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_events_get: %s\n" % e)
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

# **webhook_get**
> webhook_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()

try:
    api_instance.webhook_get()
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_get: %s\n" % e)
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

# **webhook_id_delete**
> webhook_id_delete(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()
id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | 

try:
    api_instance.webhook_id_delete(id)
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **webhook_id_get**
> webhook_id_get(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()
id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | 

try:
    api_instance.webhook_id_get(id)
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **webhook_id_logs_get**
> webhook_id_logs_get(id)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()
id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | 

try:
    api_instance.webhook_id_logs_get(id)
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_id_logs_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **webhook_put**
> webhook_put(body=body)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WebhookApi()
body = NULL # dict(str, JToken) |  (optional)

try:
    api_instance.webhook_put(body=body)
except ApiException as e:
    print("Exception when calling WebhookApi->webhook_put: %s\n" % e)
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

