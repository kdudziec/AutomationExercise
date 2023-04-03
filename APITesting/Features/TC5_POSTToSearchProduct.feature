Feature: TC5_POSTToSearchProduct

A short summary of the feature

Scenario Outline: Post to search products
	Given API URL is "https://automationexercise.com/api/searchProduct"
	When POST "search_product" "<Product>"
	Then Response Code is 200
	And Response JSON is Searched products list


Examples: 
| Product |
| dress   |
| shirt   |
