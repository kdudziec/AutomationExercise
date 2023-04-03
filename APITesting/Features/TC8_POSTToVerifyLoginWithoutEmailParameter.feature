Feature: TC8_POSTToVerifyLoginWithoutEmailParameter

A short summary of the feature

Scenario: POST To Verify Login without email parameter
	Given API URL is "https://automationexercise.com/api/verifyLogin"
	When POST "password" "<password>"
	Then Response Code is 400
	And Response Message is "Bad request, email or password parameter is missing in POST request."


Examples: 
| password|
| chuck1234  |
