Feature: TC7_VerifyTestCasesPage

A short summary of the feature

@tag1
Scenario: Verify Test Cases Page
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Test Cases* button
	Then Verify user is navigated to test cases page successfully
