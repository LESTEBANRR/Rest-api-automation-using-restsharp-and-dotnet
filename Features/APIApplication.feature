Feature: APIApplication
	
@mytag
Scenario: Set API Response using given endpoint
	Given I have a endpoint /api/
	When I call get method of api
	Then I get a API response in json format

#https://reqres.in/api/users/
Scenario Outline: Get user information using userid
	Given I have a endpoint /api/v2/pokemon/
	When I call get method to get user information using <userid>
	Then I will get user information
	
Examples: User Info
| userid   |
| ditto |

#http://mydomain.com/userinformation/userid/AccountInformation?account={accountNumber}
Scenario Outline: Get user account information using userid and accountnumber
	Given I have a endpoint /api/v2/pokemon/
	When I call get method to get user account information using <userid> and <accountNumber>
	Then I will get user account information
	
Examples: User Info
| userid   | accountNumber |
| ditto | 123456789     |

Scenario Outline: User registration for given endpoint
	Given I have a endpoint /api/
	When I call a post method to register a user
	Then I will regitered succesfully

