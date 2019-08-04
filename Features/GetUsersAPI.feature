Feature: GetUsersAPI

@mytag
Scenario: Get Users
	Given creating an API connection
	And send a GET method
	Then the result should get the list of users
