Feature: TC2_POSTToAllProductsList

A short summary of the feature


Scenario: Post empty to All Products Lis
	Given API URL is "https://automationexercise.com/api/productsList"
	When Post empty to All Products List
	Then Response Code is 405
	And Response Message is "This request method is not supported."