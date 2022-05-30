Feature: Education

As a Seller
I want the feature to add Education to my Profile Details
So that
The people seeking for some details can look into it.


@AddEducation
Scenario: Seller is able to  add entry in Education tab with valid details
	Given I login to the website
	When I navigate to Education
	And  I add a new Education
	Then The Education should be added successfully
