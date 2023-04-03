Feature: TC6_ContactUsForm

A short summary of the feature

@tag1
Scenario: Test Contact Us Form
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	When Click on *Contact Us* button
	Then Verify *GET IN TOUCH* is visible
	When Enter name, email, subject and message
	When Upload file
	When Click *Submit* button
	When Click OK button
	Then Verify success message *Success! Your details have been submitted successfully.* is visible
	When Click *Home* button
	Then Verify that landed to home page successfully