Feature: TC3_LoginUserWithIncorrectEmailAndPassword

A short summary of the feature

@tag1
Scenario: Invalid User Login Testing
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Signup / Login* button
	Then Verify *Login to your account* is visible
	When Enter incorrect email address and password
	When Click *login* button
	Then Verify error *Your email or password is incorrect!* is visible
