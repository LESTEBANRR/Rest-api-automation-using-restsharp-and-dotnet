Feature: APIApplication
	
@mytag
Scenario: Set API Response using given endpoint
	Given I have a endpoint /endpoint/
	When I call get method of api
	Then I get a API response in json format

Scenario Outline: Get user information using userid
	Given I have a endpoint /userInformation/
	When I call get method to get user information using <userid>
	Then I will get user information
	
Examples: User Info
| userid   |
| user1001 |