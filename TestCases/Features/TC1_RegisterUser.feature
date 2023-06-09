﻿Feature: TC1_RegisterUser

A short summary of the feature

@tag1
Scenario: Register User Testing
	Given Launch browser
	When Navigate to url 'http://automationexercise.com'
	Then Verify that home page is visible successfully
	When Click on *Signup / Login* button
	Then Verify *New User Signup!* is visible
	When Enter name and email address
	When Click *Signup* button
	Then Verify that *ENTER ACCOUNT INFORMATION* is visible
	When Fill details: Title, Name, Email, Password, Date of birth
	When Select checkbox *Sign up for our newsletter!*
	When Select checkbox *Receive special offers from our partners!*
	When Fill details: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
	When Click *Create Account button*
	Then Verify that *ACCOUNT CREATED!* is visible
	When Click *Continue* button
	Then Verify that *Logged in as username* is visible
	When Click *Delete Account* button
	Then Verify that *ACCOUNT DELETED!* is visible and click *Continue* button
	

