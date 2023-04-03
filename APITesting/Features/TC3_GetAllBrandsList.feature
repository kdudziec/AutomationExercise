Feature: TC3_GetAllBrandssList

Scenario: Get All Brands
	Given API URL is "https://automationexercise.com/api/brandsList"
	When Get All Brands List
	Then Response Code is 200
	And Response JSON is All Brand list
