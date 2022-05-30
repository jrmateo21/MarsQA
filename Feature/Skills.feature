Feature: Skills

A As a Seller
I want the feature to add Skills to my Profile Details
So that
The people seeking for some details can look into it.

@AddSkillsDetails
Scenario: Seller is able to  add entry in Skills tab with valid details
	Given I login to the website
	When I navigate to Skills
	And  I add a new Skills
	Then The Skills should be added successfully
