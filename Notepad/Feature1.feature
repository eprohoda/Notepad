Feature: Feature1
	As an windows user,
	I would like to see some elements in the Notepad
	
@mytag
Scenario: See buttons in the Notepad
 Given Notepad window is opened
 Then I see button New
 And I see button Open
 And I see button Save
 When I close browser