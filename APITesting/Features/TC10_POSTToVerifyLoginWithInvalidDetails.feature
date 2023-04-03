Feature: TC10_POSTToVerifyLoginWithInvalidDetails

A short summary of the feature

Scenario Outline: POST To Verify Login with invalid details
	Given API URL is "https://automationexercise.com/api/verifyLogin"
	When POST "email" "<email>" and "password" "<password>"
	Then Response Code is 404
	And Response Message is "User not found!"


Examples: 
| email                            |  password			 |
| chucknorris@exampleIncorrect.com |  chuckIncorrect1234 |
