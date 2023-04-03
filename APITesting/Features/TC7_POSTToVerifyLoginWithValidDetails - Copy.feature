Feature: TC7_POSTToVerifyLoginWithValidDetails

A short summary of the feature

Scenario Outline: Post to Verify Login with valid details
	Given API URL is "https://automationexercise.com/api/verifyLogin"
	When POST "email" "<email>" and "password" "<password>"
	Then Response Code is 200
	And Response Message is "User exists!"


Examples: 
| email                           |  password  |
| chucknorris@exampleExisting.com |  chuck1234 |
