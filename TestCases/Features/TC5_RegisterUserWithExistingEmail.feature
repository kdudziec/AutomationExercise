Feature: TC5_RegisterUserWithExistingEmail

A short summary of the feature

@tag1
Scenario: Register Existing User Testing
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Signup / Login* button
	Then Verify *Login to your account* is visible
	When Enter name and already registered email address
	When Click *Signup* button
	Then Verify error *Email Address already exist!* is visible
