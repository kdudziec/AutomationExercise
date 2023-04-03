Feature: TC4_PUTToAllBrandsList

A short summary of the feature


Scenario: Put to all Brands List
	Given API URL is "https://automationexercise.com/api/brandsList"
	When Put empty to All Brands List
	Then Response Code is 405
	And Response Message is "This request method is not supported."