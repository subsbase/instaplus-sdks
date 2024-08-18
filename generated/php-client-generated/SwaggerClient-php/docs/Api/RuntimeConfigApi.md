# Swagger\Client\RuntimeConfigApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**runtimeConfigPost**](RuntimeConfigApi.md#runtimeconfigpost) | **POST** /runtime-config | 

# **runtimeConfigPost**
> runtimeConfigPost()



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\RuntimeConfigApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);

try {
    $apiInstance->runtimeConfigPost();
} catch (Exception $e) {
    echo 'Exception when calling RuntimeConfigApi->runtimeConfigPost: ', $e->getMessage(), PHP_EOL;
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

