# InstaPlusapi.TransactionReceiptApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transactionReceiptGet**](TransactionReceiptApi.md#transactionReceiptGet) | **GET** /transaction-receipt | 
[**transactionReceiptLiveGet**](TransactionReceiptApi.md#transactionReceiptLiveGet) | **GET** /transaction-receipt/live | 
[**transactionReceiptPut**](TransactionReceiptApi.md#transactionReceiptPut) | **PUT** /transaction-receipt | 
[**transactionReceiptReferenceGet**](TransactionReceiptApi.md#transactionReceiptReferenceGet) | **GET** /transaction-receipt/{reference} | 

<a name="transactionReceiptGet"></a>
# **transactionReceiptGet**
> transactionReceiptGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.TransactionReceiptApi();
apiInstance.transactionReceiptGet((error, data, response) => {
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

<a name="transactionReceiptLiveGet"></a>
# **transactionReceiptLiveGet**
> transactionReceiptLiveGet()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.TransactionReceiptApi();
apiInstance.transactionReceiptLiveGet((error, data, response) => {
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

<a name="transactionReceiptPut"></a>
# **transactionReceiptPut**
> transactionReceiptPut()



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.TransactionReceiptApi();
apiInstance.transactionReceiptPut((error, data, response) => {
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

<a name="transactionReceiptReferenceGet"></a>
# **transactionReceiptReferenceGet**
> transactionReceiptReferenceGet(reference)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.TransactionReceiptApi();
let reference = "reference_example"; // String | 

apiInstance.transactionReceiptReferenceGet(reference, (error, data, response) => {
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
 **reference** | **String**|  | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

