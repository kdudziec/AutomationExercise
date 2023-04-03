Feature: TC8_VerifyAllProductsAndProductDetailPage

A short summary of the feature

@tag1
Scenario: Verify Products and Product Detail Page
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Products* button
	Then Verify user is navigated to ALL PRODUCTS page successfully
	Then The products list is visible
	When Click on *View Product* of first product
	Then User is landed to product detail page
	Then Verify that detail detail is visible: product name, category, price, availability, condition, brand