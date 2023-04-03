Feature: TC6_POSTToSearchProductWithoutSearch_ProductParameter

A short summary of the feature

Scenario Outline: Post to search products without search_product parameter
	Given API URL is "https://automationexercise.com/api/searchProduct"
	When POST empty to Search Product
	Then Response Code is 400
	And Response Message is "Bad request, search_product parameter is missing in POST request."
