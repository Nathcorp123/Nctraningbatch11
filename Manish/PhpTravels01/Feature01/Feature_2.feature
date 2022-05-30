Feature: Feature_2
	Automation for PhpTravel Site

@mytag
Scenario: open php demo url and save userid and password to excel
	Given demo url and have to fetch it
	And   save userid and passsword to excel


@login 
Scenario Outline: launch customerr front end site and make login
    Given launch the Customer Frontt End site 
	And  Need to switch Windoww
	Then Enter correctt Userid<EmailId> and password<Password>
	And Click on Loginn button

@Source:Fdata1.xlsx:Sheet1
	Examples: 
	| EmailId | Password |


 @To Check Flights
 Scenario Outline: Check for Flight button and Book flight 
 Given click on the Flight button on the filght booking page
 And click on the radio button of round trip
 Then select the departure<FlyingFrom> and destination <Destination> place
 And select the departure <DepartureDate> and returning <ReturnDate> date
 And search the passanger and click on search button
 Then click on the direct button
 Then take screenshot of flight price

@Source:Fdata1.xlsx:Sheet1
    Examples:
	| FlyingFrom | Destination | DepartureDate | ReturnDate |







	