Feature: MarsQA
As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@LogIntoWebsite
Scenario: Login to website
	Given I login to the website


@AddProfileDetails
Scenario: Seller is able to add the Profile Details
	Given I login to the website
	When  I create a new Profile Details
	Then  The Profile Details should be created successfully
