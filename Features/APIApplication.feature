Feature: APIApplication
	
@mytag
Scenario: Set API Response using given endpoint
	Given I have a endpoint /endpoint/
	When I call get method of api
	Then I get a API response in json format

#http://mydomain.com/userinformation/userid
Scenario Outline: Get user information using userid
	Given I have a endpoint /userInformation/
	When I call get method to get user information using <userid>
	Then I will get user information
	
Examples: User Info
| userid   |
| user1001 |

#http://mydomain.com/userinformation/userid/AccountInformation?account={accountNumber}
Scenario Outline: Get user account information using userid and accountnumber
	Given I have a endpoint /userInformation/
	When I call get method to get user account information using <userid> and <accountNumber>
	Then I will get user account information
	
Examples: User Info
| userid   | accountNumber |
| user1001 | 123456789     |