Feature: Search
	
@mytag
Scenario: Search with Testing
	Given Launch FireFox
	And Navigate to Code Project
	When Click on Search our Articles
	When Enter Testing 
	And Click on Search Button
	Then Results should be visible and Browser should close