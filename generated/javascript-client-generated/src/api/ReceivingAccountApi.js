/*
 * InstaPlus.Api
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 3.0.61
 *
 * Do not edit the class manually.
 *
 */
import ApiClient from "../ApiClient";
import JToken from '../model/JToken';

/**
* ReceivingAccount service.
* @module api/ReceivingAccountApi
* @version 1.0
*/
export default class ReceivingAccountApi {

    /**
    * Constructs a new ReceivingAccountApi. 
    * @alias module:api/ReceivingAccountApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instanc
    e} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }

    /**
     * Callback function to receive the result of the receivingAccountGet operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountGetCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {module:api/ReceivingAccountApi~receivingAccountGetCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountGet(callback) {
      
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the receivingAccountIdDelete operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountIdDeleteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {String} id 
     * @param {module:api/ReceivingAccountApi~receivingAccountIdDeleteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountIdDelete(id, callback) {
      
      let postBody = null;
      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling receivingAccountIdDelete");
      }

      let pathParams = {
        'id': id
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account/{id}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the receivingAccountIdGet operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountIdGetCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {String} id 
     * @param {module:api/ReceivingAccountApi~receivingAccountIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountIdGet(id, callback) {
      
      let postBody = null;
      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling receivingAccountIdGet");
      }

      let pathParams = {
        'id': id
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account/{id}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the receivingAccountPut operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountPutCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {Object} opts Optional parameters
     * @param {{String: JToken}} opts.body 
     * @param {module:api/ReceivingAccountApi~receivingAccountPutCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountPut(opts, callback) {
      opts = opts || {};
      let postBody = opts['body'];

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = ['application/json-patch+json', 'application/json', 'text/json', 'application/_*+json'];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the receivingAccountReceivingAccountIdLinkToPost operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountReceivingAccountIdLinkToPostCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {String} receivingAccountId 
     * @param {Object} opts Optional parameters
     * @param {String} opts.code 
     * @param {module:api/ReceivingAccountApi~receivingAccountReceivingAccountIdLinkToPostCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountReceivingAccountIdLinkToPost(receivingAccountId, opts, callback) {
      opts = opts || {};
      let postBody = null;
      // verify the required parameter 'receivingAccountId' is set
      if (receivingAccountId === undefined || receivingAccountId === null) {
        throw new Error("Missing the required parameter 'receivingAccountId' when calling receivingAccountReceivingAccountIdLinkToPost");
      }

      let pathParams = {
        'receivingAccountId': receivingAccountId
      };
      let queryParams = {
        'code': opts['code']
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account/{receivingAccountId}/link-to', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
    /**
     * Callback function to receive the result of the receivingAccountTypesGet operation.
     * @callback moduleapi/ReceivingAccountApi~receivingAccountTypesGetCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * @param {module:api/ReceivingAccountApi~receivingAccountTypesGetCallback} callback The callback function, accepting three arguments: error, data, response
     */
    receivingAccountTypesGet(callback) {
      
      let postBody = null;

      let pathParams = {
        
      };
      let queryParams = {
        
      };
      let headerParams = {
        
      };
      let formParams = {
        
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;

      return this.apiClient.callApi(
        '/receiving-account/types', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

}