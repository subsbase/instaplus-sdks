# swagger_client.TransactionReceiptApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transaction_receipt_get**](TransactionReceiptApi.md#transaction_receipt_get) | **GET** /transaction-receipt | 
[**transaction_receipt_live_get**](TransactionReceiptApi.md#transaction_receipt_live_get) | **GET** /transaction-receipt/live | 
[**transaction_receipt_put**](TransactionReceiptApi.md#transaction_receipt_put) | **PUT** /transaction-receipt | 
[**transaction_receipt_reference_get**](TransactionReceiptApi.md#transaction_receipt_reference_get) | **GET** /transaction-receipt/{reference} | 

# **transaction_receipt_get**
> transaction_receipt_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransactionReceiptApi()

try:
    api_instance.transaction_receipt_get()
except ApiException as e:
    print("Exception when calling TransactionReceiptApi->transaction_receipt_get: %s\n" % e)
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

# **transaction_receipt_live_get**
> transaction_receipt_live_get()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransactionReceiptApi()

try:
    api_instance.transaction_receipt_live_get()
except ApiException as e:
    print("Exception when calling TransactionReceiptApi->transaction_receipt_live_get: %s\n" % e)
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

# **transaction_receipt_put**
> transaction_receipt_put()



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransactionReceiptApi()

try:
    api_instance.transaction_receipt_put()
except ApiException as e:
    print("Exception when calling TransactionReceiptApi->transaction_receipt_put: %s\n" % e)
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

# **transaction_receipt_reference_get**
> transaction_receipt_reference_get(reference)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransactionReceiptApi()
reference = 'reference_example' # str | 

try:
    api_instance.transaction_receipt_reference_get(reference)
except ApiException as e:
    print("Exception when calling TransactionReceiptApi->transaction_receipt_reference_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **str**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

