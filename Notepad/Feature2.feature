Feature: Notepad1
	As an windows user,
	I would like to type some text in Notepad
	I see text in Notepad

@mytag
Scenario: Feature2_Write text in Notepad
 Given Notepad window is opened
 When I enter "test text" text
 And I click "Save" button
 And I enter File Name
 And I wait "3000" msec
 And I close browser
 #Then I see entered text Notepad