# Swagger\Client\TransactionReceiptApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transactionReceiptGet**](TransactionReceiptApi.md#transactionreceiptget) | **GET** /transaction-receipt | 
[**transactionReceiptLiveGet**](TransactionReceiptApi.md#transactionreceiptliveget) | **GET** /transaction-receipt/live | 
[**transactionReceiptPut**](TransactionReceiptApi.md#transactionreceiptput) | **PUT** /transaction-receipt | 
[**transactionReceiptReferenceGet**](TransactionReceiptApi.md#transactionreceiptreferenceget) | **GET** /transaction-receipt/{reference} | 

# **transactionReceiptGet**
> transactionReceiptGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TransactionReceiptApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->transactionReceiptGet();
} catch (Exception $e) {
    echo 'Exception when calling TransactionReceiptApi->transactionReceiptGet: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transactionReceiptLiveGet**
> transactionReceiptLiveGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TransactionReceiptApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->transactionReceiptLiveGet();
} catch (Exception $e) {
    echo 'Exception when calling TransactionReceiptApi->transactionReceiptLiveGet: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transactionReceiptPut**
> transactionReceiptPut()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TransactionReceiptApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->transactionReceiptPut();
} catch (Exception $e) {
    echo 'Exception when calling TransactionReceiptApi->transactionReceiptPut: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transactionReceiptReferenceGet**
> transactionReceiptReferenceGet($reference)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TransactionReceiptApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$reference = "reference_example"; // string | 

try {
    $apiInstance->transactionReceiptReferenceGet($reference);
} catch (Exception $e) {
    echo 'Exception when calling TransactionReceiptApi->transactionReceiptReferenceGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reference** | **string**|  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

