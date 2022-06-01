Feature: Search The Flights
	Automation script for searching the flight and ticket booking

@mytag
Scenario: Homepage Verification
		Given Browser should open
		When Enter the url
		Then Homepage should open

Scenario: Loginpage & Dashboard Verification 
		When click on Customer Front-End  
		Then Login page should open
		When Enter email
		And  Enter password 
		And click on login button 
		Then Dashboard should open

Scenario: Searchpage Verification
		When Choose flight from top menu
		Then SEARCH FOR BEST FLIGHTS page sholud open

Scenario: Search The Flights
		When Choose Round Trip
		Then Return Date field should come
		When Enter  Ranchi in Flying From field
		When Enter Mumbai in To Destination field
		When Select Depart Date
		And  select return date 
		And Select  Adults, Childs, Infants
		And  click on Search
		Then Flight details should come
		When Choose the option Direct from the left panel
		And Select Economic class from top drop down list
		And Read the price of first five search result
		And save the result to excel sheet
		And Save the screenshot of the search result page
		And close the browser
	