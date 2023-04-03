Feature: TC9_DELETEToVerifyLogin

A short summary of the feature

@tag1
Scenario: DELETE To Verify Login
	Given API URL is "https://automationexercise.com/api/verifyLogin"
	When DELETE
	Then Response Code is 405
	And Response Message is "This request method is not supported."

