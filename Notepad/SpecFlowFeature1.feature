Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: ClickingNewButton
	Given Notepad window is opened
	When I enter text in Notepad
	And I click Undo button
	And I wait some time
	And I click Redo button
	And I close browser
	And I click "Undo" button
