Feature: TravelSite
	Automation for PhpTravel Site

@mytag
Scenario Outline: Open PhpTavel site and take correct credentials for login
	Given Userid and Password I have to fetch userid and password and store it in excel
	When  Launch the customer Front-End phptravels site
	And  Click on login url need to Switch next window
	Then  Enter valid userid<UserId> and password<Password>
	And Click on Login button
	Then Click on Flight option
	And  Choose round Trip
	Then Select Flyingfrom<FlyingFrom> and Destination<Destination>
	And  Select Departuredate<DepartureDate> and Returndate<ReturnDate> 
	Then Select numbers of passengers
	And  Click on Search Button and hit Direct button
	And  Take ScreenShot of the Flights lists
	

	@Source:Fdata1.xlsx:Sheet1
	Examples: 
	| UserId | Password | FlyingFrom | Destination | DepartureDate | ReturnDate |


