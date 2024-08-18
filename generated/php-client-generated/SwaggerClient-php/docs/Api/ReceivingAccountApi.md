# Swagger\Client\ReceivingAccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**receivingAccountGet**](ReceivingAccountApi.md#receivingaccountget) | **GET** /receiving-account | 
[**receivingAccountIdDelete**](ReceivingAccountApi.md#receivingaccountiddelete) | **DELETE** /receiving-account/{id} | 
[**receivingAccountIdGet**](ReceivingAccountApi.md#receivingaccountidget) | **GET** /receiving-account/{id} | 
[**receivingAccountPut**](ReceivingAccountApi.md#receivingaccountput) | **PUT** /receiving-account | 
[**receivingAccountReceivingAccountIdLinkToPost**](ReceivingAccountApi.md#receivingaccountreceivingaccountidlinktopost) | **POST** /receiving-account/{receivingAccountId}/link-to | 
[**receivingAccountTypesGet**](ReceivingAccountApi.md#receivingaccounttypesget) | **GET** /receiving-account/types | 

# **receivingAccountGet**
> receivingAccountGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->receivingAccountGet();
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountGet: ', $e->getMessage(), PHP_EOL;
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

# **receivingAccountIdDelete**
> receivingAccountIdDelete($id)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->receivingAccountIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **receivingAccountIdGet**
> receivingAccountIdGet($id)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->receivingAccountIdGet($id);
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **receivingAccountPut**
> receivingAccountPut($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\map(); // map[string,\Swagger\Client\Model\JToken] | 

try {
    $apiInstance->receivingAccountPut($body);
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**map[string,\Swagger\Client\Model\JToken]**](../Model/map.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **receivingAccountReceivingAccountIdLinkToPost**
> receivingAccountReceivingAccountIdLinkToPost($receiving_account_id, $code)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$receiving_account_id = "receiving_account_id_example"; // string | 
$code = "code_example"; // string | 

try {
    $apiInstance->receivingAccountReceivingAccountIdLinkToPost($receiving_account_id, $code);
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountReceivingAccountIdLinkToPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receiving_account_id** | **string**|  |
 **code** | **string**|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **receivingAccountTypesGet**
> receivingAccountTypesGet()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ReceivingAccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->receivingAccountTypesGet();
} catch (Exception $e) {
    echo 'Exception when calling ReceivingAccountApi->receivingAccountTypesGet: ', $e->getMessage(), PHP_EOL;
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

