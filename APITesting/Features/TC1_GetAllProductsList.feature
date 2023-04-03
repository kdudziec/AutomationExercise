Feature: TC1_GetAllProductsList

Scenario: Get All Products
	Given API URL is "https://automationexercise.com/api/productsList"
	When Get All Products List
	Then Response Code is 200
	And Response JSON is All products list
