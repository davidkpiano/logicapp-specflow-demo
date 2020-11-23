Feature: GreetingFlow
	As a developer
	I want to get greeted via email

Scenario: GreetingFlow noon test
	When I send a POST request to 'TestLogicApp' with the body
	| greeting |
	| howdy |
	And I wait '5' seconds for execution to complete
	Then I can verify the following logic app events for 'TestLogicApp'
	| StepName                       | Status    |
	| manual                         | Succeeded |
	| Send_email_(V2)                | Succeeded |

