# swagger_client.RuntimeConfigApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**runtime_config_post**](RuntimeConfigApi.md#runtime_config_post) | **POST** /runtime-config | 

# **runtime_config_post**
> runtime_config_post()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RuntimeConfigApi()

try:
    api_instance.runtime_config_post()
except ApiException as e:
    print("Exception when calling RuntimeConfigApi->runtime_config_post: %s\n" % e)
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

