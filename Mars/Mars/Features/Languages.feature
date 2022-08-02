Feature: Languages
As a seller in my profile page I want to Manage my Language Details.
So i can able to add,edit,delete my Language.



@Languages
Scenario Outline: 1-Add a Language
	Given I login to the Website
	When  I click on Languages Tab
	And   I Want to add my '<language>' and '<language level>'
	Then  The '<Language>' and '<Language level>' should be added in the Portal successfully

Examples:
|  language  |  languagelevel   |
|  French    |  Conversational   |
|  Spanish   |  Fluent           |


@Languages
Scenario Outline: 2-Edit a Language
	Given I login to the Website
	When  I click on Languages Tab
	And   I Want to edit my '<language>' and '<language level>'
	Then  The '<Language>' and '<Language level>' should be edited in the Portal successfully

	Examples:
| language | languagelevel   |
| Spanish  | Native/Bilingual |  


@Languages
Scenario Outline: 3-Delete a Language
	Given I login to the Website
	When  I click on Languages Tab
	And   I Want to Delete my '<language>'
	Then  The '<Language>' should be deleted in the Portal successfully

Examples:
| language | 
| Spanish  |