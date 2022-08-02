Feature: Skills

As a seller in my Profile page I want to manage my skill details.
so i can able to add,edit,delete my skills.


@Skills
Scenario Outline:1-Add a Skill
	Given I logged in to the portal
	When I Click Skills Tab
	And I want to add '<Skill>' and '<Skilllevel>'
	Then The  '<Skill>' and '<Skilllevel>' should be added Successfully


	Examples: 
	| Skill   | Skilllevel |
	| Java    | Beginner   |
	| Python  | Beginner   |



@Skills
Scenario Outline:2-Edit a Skill
	Given I logged in to the portal
	When I Click Skills Tab
	And I edit '<Skill>' and '<Skilllevel>'
	Then The  '<Skill>' and '<Skilllevel>' should be edited Successfully


	Examples: 
	| Skill       | Skilllevel     |
	| JavaScript  | Intermediate   |




	@Skills
Scenario Outline:3-Delete a Skill
	Given I logged in to the portal
	When I Click Skills Tab
	And I delete'<Skill>'
	Then The  '<Skill>'  should be deleted Successfully


	Examples: 
	| Skill       | 
	| JavaScript  | 


