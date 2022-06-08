Feature: Nathcorpwebsite
	
Background: Launch Nathcorp Application.
Given : the url https://www.nathcorp.com/ of an application
         


Scenario: Verify Who we are 
  When I click on Who we aree 
  Then User should be redirected to who we are page in same windowe

  
  Scenario:  Verify Who we Do it for
  When I click on Who we Do itt for
  Then User Should be redirectedd to Who we Do it for page in same window

  Scenario: Verify that User is able to hover the Services link and able to click on Active Directory link.
  When  I Hover on Services linkk.
  Then The List of service menu should appearr
  And  I Click on Active Directoryy link.
  Then Active Directory page shouldd appear.

  Scenario: Verify that user is able to hover the Services link and able to click on App Modernization link.
  When  I Hover on Services linkk.
  Then The List of service menu should appearr
  And I click on App Modernization linkk.
  Then Application Modernization page should appearr.