Feature: TC11_VerifySubscriptionInCartPage

A short summary of the feature

@tag1
Scenario: Verify Subscription in Cart
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click *Cart* button
	When Scroll down to footer in Cart Page
	Then Verify text *SUBSCRIPTION* in Cart Page
	When Enter email address in input and click arrow button in Cart Page
	Then Verify success message *You have been successfully subscribed!* is visible Cart Page
