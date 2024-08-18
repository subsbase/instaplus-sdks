# swagger_client.BanksApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**banks_get**](BanksApi.md#banks_get) | **GET** /banks | 

# **banks_get**
> banks_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BanksApi()

try:
    api_instance.banks_get()
except ApiException as e:
    print("Exception when calling BanksApi->banks_get: %s\n" % e)
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

