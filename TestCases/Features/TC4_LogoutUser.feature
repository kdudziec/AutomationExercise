Feature: TC4_LogoutUser

A short summary of the feature

@tag1
Scenario: User Logout Testing
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Signup / Login* button
	Then Verify *Login to your account* is visible
	When Enter correct existing email address and password
	When Click *login* button
	Then Verify that *Logged in as username* is visible
	When Click *Logout* button
	Then Verify that user is navigated to login page
