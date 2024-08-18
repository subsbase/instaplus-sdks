# InstaPlusapi.UserApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userLoginPost**](UserApi.md#userLoginPost) | **POST** /user/login | 
[**userPasswordPut**](UserApi.md#userPasswordPut) | **PUT** /user/password | 
[**userSignupPost**](UserApi.md#userSignupPost) | **POST** /user/signup | 

<a name="userLoginPost"></a>
# **userLoginPost**
> userLoginPost(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.UserApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.userLoginPost(opts, (error, data, response) => {
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
 **body** | [**{String: JToken}**](Object.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="userPasswordPut"></a>
# **userPasswordPut**
> userPasswordPut(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.UserApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.userPasswordPut(opts, (error, data, response) => {
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
 **body** | [**{String: JToken}**](Object.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

<a name="userSignupPost"></a>
# **userSignupPost**
> userSignupPost(opts)



### Example
```javascript
import {InstaPlusapi} from 'insta_plusapi';

let apiInstance = new InstaPlusapi.UserApi();
let opts = { 
  'body': null // {String: JToken} | 
};
apiInstance.userSignupPost(opts, (error, data, response) => {
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
 **body** | [**{String: JToken}**](Object.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

