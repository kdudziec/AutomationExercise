Feature: TC2_LoginUserWithCorrectEmailAndPassword

A short summary of the feature

@tag1
Scenario: Valid User Login Testing
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Signup / Login* button
	Then Verify *Login to your account* is visible
	When Enter correct email address and password
	When Click *login* button
	Then Verify that *Logged in as username* is visible
	When Click *Delete Account* button
	Then Verify that *ACCOUNT DELETED!* is visible and click *Continue* button
