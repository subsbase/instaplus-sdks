# coding: utf-8

"""
    InstaPlus.Api

    No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)  # noqa: E501

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.user_api import UserApi  # noqa: E501
from swagger_client.rest import ApiException


class TestUserApi(unittest.TestCase):
    """UserApi unit test stubs"""

    def setUp(self):
        self.api = UserApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_user_login_post(self):
        """Test case for user_login_post

        """
        pass

    def test_user_password_put(self):
        """Test case for user_password_put

        """
        pass

    def test_user_signup_post(self):
        """Test case for user_signup_post

        """
        pass


if __name__ == '__main__':
    unittest.main()
