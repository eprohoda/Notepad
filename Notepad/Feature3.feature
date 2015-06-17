Feature: tmp
	

Scenario: Feature3_tmp
	Given Notepad window is opened
	When I enter "balba" text
	And I wait "1000" msec
	And I click "New" button
	And I wait "1000" msec
	And I click "Save" button
	And I close browser