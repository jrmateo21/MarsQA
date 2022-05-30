Feature: Login
As a Seller
I want to log in so that I can see  my profiles


@LogIntoWebsite
Scenario: Login to website
	Given I login to the website


@LogIntoWebsiteDataDriven
Scenario Outline: Login to website-DD
	Given  I login to the website using  '<Email>' and '<Password>'
	
		Examples: 
		| Email                 | Password   |
		| jewhy27@gmail.com     | Windows_27 |
		| lakaka9900@dufeed.com | Test123    |






