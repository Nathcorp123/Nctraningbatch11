Feature: Feature_2
	Automation for PhpTravel Site

@mytag
Scenario:1. open php demo url and save userid and password to excel
	Given  the userid and passsword
	Then   fetch the userid and passsword and save to excel


@login 
Scenario Outline:2. launch customerr front end site and make login
    Given launch the Customer Front End site 
	When  Click on given url, it switch to next Window
	When Enter the Userid<UserId> and password<Password>
	Then validate the Userid and Password
	And Click on Loginn button
	

@Source:Fdata1.xlsx:Sheet1
	Examples: 
	| UserId | Password |


 @To Check Flights
 Scenario Outline:3. Check for Flight button and Book flight 
 Given the userid <UserId> and password <Password> to login the Customer front end site
 Then it redirect to flight dashboard and validate it
 And click on the Flight button on the flight booking page
 And click on the radio button of round trip
 Then select the departure<FlyingFrom> and destination <Destination> place
 And select the departure <DepartureDate> and returning <ReturnDate> date
 And select the passanger 
 Then click on search button and hit on the direct button
 Then take screenshot of flight price

@Source:Fdata1.xlsx:Sheet1
    Examples:
	| UserId | Password | FlyingFrom | Destination | DepartureDate | ReturnDate |







	