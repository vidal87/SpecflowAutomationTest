Feature: RestAPIUnsuccessReg

@mytag
Scenario: Fail POST API
	Given creating client connect
	And creating json post 
	Then the result should be BadRequest
