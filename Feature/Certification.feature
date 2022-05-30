Feature: Certification

As a Seller
I want the feature to add,edit and delete Certifications to my Profile Details
So that
The people seeking for some details can look into it.

@AddCertficationDetails
Scenario Outline: Seller is able to  add entry in Certfications tab with valid details
	Given I login to the website
	When I navigate to Certifications Tab
	And  I add a new Certifications, '<Certificate>' , '<From>', '<Year>'
	Then The Certifications should be added successfully, '<Certificate>' , '<From>', '<Year>'
		Examples: 
		| Certificate                                            | From  | Year |
		| CERTIFIED TESTER FOUNDATION LEVEL (CTFL)               | ISTQB | 2018 |
		| Certified Tester Advanced Level Test Analyst (CTAL-TA) | ISTQB | 2019 |
		| Certified Tester Test Automation Engineer (CT-TAE)     | ISQTB | 2022 |

@UpdateCertificationsTab
Scenario Outline: Seller is able to  edit entry in Certifications tab with valid details
	Given I login to the website
	When I navigate to Certifications Tab
	And  I update  Certifications, '<Certificate>' , '<From>', '<Year>'
	Then The Certifications should have the updated  '<Certificate>' , '<From>', '<Year>'
		Examples: 
		| Certificate                                                     | From  | Year |
		| Edited_CERTIFIED TESTER FOUNDATION LEVEL (CTFL)                 | ISTQB | 2015 |
		| Modified_Certified Tester Advanced Level Test Analyst (CTAL-TA) | ISTQB | 2017 |
		| Updated_Certified Tester Test Automation Engineer (CT-TAE)      | ISQTB | 2021 |

@DeleteCertification

Scenario: Seller is able to  delete entry in Certifications tab with valid details
	Given I login to the website
	When I navigate to Certifications Tab
	And  I delete  a Certification
	Then The Certification should have been deleted
