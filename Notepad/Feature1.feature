Feature: Feature1
	As an windows user,
	I would like to see some elements in the Notepad
	
@mytag
Scenario: Feature1_See buttons in the Notepad
 Given Notepad window is opened
 Then I see "New" button
 And I see "Open" button
 And I see "Save" button
 When I close browser