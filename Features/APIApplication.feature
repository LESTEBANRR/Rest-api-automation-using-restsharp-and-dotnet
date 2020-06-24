﻿Feature: APIApplication
	
@mytag
Scenario: Set API Response using given endpoint
	Given I have a endpoint api/
	When I call get method of api
	Then I get a API response in json format

#https://jsonplaceholder.typicode.com/posts/1/
Scenario Outline: Get user information using userid
	Given I have a endpoint posts/
	When I call get method to get user information using <userid>
	Then I will get user information
	
Examples: User Info
| userid   |
| 1 |

#http://mydomain.com/userinformation/userid/AccountInformation?account={accountNumber}
Scenario Outline: Get user account information using userid and accountnumber
	Given I have a endpoint v2/pokemon/
	When I call get method to get user account information using <userid> and <accountNumber>
	Then I will get user account information
	
Examples: User Info
| userid   | accountNumber |
| ditto | 123456789     |

#https://jsonplaceholder.typicode.com/posts/
Scenario Outline: User registration for given endpoint
	Given I have a endpoint posts/
	When I call a post method to register a user
	Then I will regitered succesfully

