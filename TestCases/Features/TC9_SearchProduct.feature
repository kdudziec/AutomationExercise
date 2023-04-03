Feature: TC9_SearchProduct

A short summary of the feature

@tag1
Scenario: Search Product Test
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Products* button
	Then Verify user is navigated to ALL PRODUCTS page successfully
	When Enter product name in search input and click search button
	Then Verify *SEARCHED PRODUCTS* is visible
	Then Verify all the products related to search are visible
