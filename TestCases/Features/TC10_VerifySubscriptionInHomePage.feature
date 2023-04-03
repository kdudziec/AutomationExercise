Feature: TC10_VerifySubscriptionInHomePage

A short summary of the feature

@tag1
Scenario: Test Subscription
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Scroll down to footer
	Then Verify text *SUBSCRIPTION*
	When Enter email address in input and click arrow button
	Then Verify success message *You have been successfully subscribed!* is visible