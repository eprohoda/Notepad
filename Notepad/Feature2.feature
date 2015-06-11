Feature: Notepad1
	As an windows user,
	I would like to type some text in Notepad
	I see text in Notepad

@mytag
Scenario: Write text in Notepad
 Given Notepad window is opened
 When I enter text in Notepad
 And I click Save button
 Then I see Filename field 
 When I enter File Name
 And I click Save button to save File
 And I wait some time
 And I close browser
 #Then I see entered text Notepad