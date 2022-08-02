Feature: Certifications

As a Seller in my Profile page i want to manage my Certification details.
so i can able to add,edit,delete details.

@Certifications
Scenario Outline: 1-Add a Certification
	Given I logged in to the Portal
	When  I click Certifications tab
	And   I add a '<Certificate>','<From>','<Year>'
	Then  The '<Certificate>','<From>','<Year>' shoud be added successfully

	Examples: 
	| Certificate  | From | Year |
	| ISTQB        | CTFL | 2021 |
	| Test Analyst | IC   | 2021 |




@Certifications
Scenario Outline: 2-Edit Certification
	Given I logged in to the Portal
	When  I click Certifications tab
	And   I edit a last'<Certificate>','<From>','<Year>'
	Then  The '<Certificate>','<From>','<Year>' shoud be edited successfully

	Examples: 
	| Certificate               | From       | Year  |
	| AutomationTest Analyst    | MVP        |  2022 |
	



@Certifications
Scenario Outline: 3-Delete Certification
	Given I logged in to the Portal
	When  I click Certifications tab
	And   I delete a last'<Certificate>'
	Then  The '<Certificate>' shoud be deleted successfully

	Examples: 
	|    Certificate               | 
	|   AutomationTest Analyst     | 
