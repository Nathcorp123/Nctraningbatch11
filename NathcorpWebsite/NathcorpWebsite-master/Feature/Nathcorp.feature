Feature: Nathcorp

Background: Manage Verification
Given : I Launch the Application
         | URL1                      |
         | https://www.nathcorp.com/ |


Scenario: Verify Who we are 
  When I click on Who we are 
  Then User should be redirected to who we are page in same window


  Scenario:  Verify Who we Do it for
  When I click on Who we Do it for
  Then User Should be redirected to Who we Do it for page in same window

  Scenario: Verify that User is able to hover the Services link and able to click on Active Directory link.
  When  I Hover on Services link.
  Then The List of service menu should appear
  And  I Click on Active Directory link.
  Then Active Directory page should appear.

  Scenario: Verify that user is able to hover the Services link and able to click on App Modernization link.
  When I Hover on Services1 link.
  Then The list of service1 menu should appear.
  And I click on App Modernization link.
  Then Application Modernization page should appear.

  Scenario: Verify that user is able to hover the Services link and able to click on Cloud Enablement link.
  When I Hover on Service link.
  Then The list of servic menu should appear.
  And I click on Cloud Enablement link.
  Then Cloud Enablement page should appear.

  Scenario: Verify that user is able to hover the Services link and able to click on Managed Services link.
  When I Hover on Service linkk.
  Then The list of servic menu shouldd appear.
  And I click on Managed Services linkk.
  Then Managed Services page should apppear.

   Scenario: Verify that user is able to hover the Services link and able to click on Modern Deployment link.
  When I Hoverr on Service linkk.
  Then The listt of servic menu shouldd appear.
  And I clickk on Modern Deployment linkk.
  Then Modern Deployment page should apppear.

    Scenario: Verify that user is able to hover the Services link and able to click on Security link.
  When I Hoverr on Servicee linkk.
  Then The listt of servic menu shouldd appearr.
  And I clickk on Security linkk.
  Then Security page should apppear.

   Scenario: Verify that user is able to hover the Services link and able to click on Teams and Collaboration link.
  When I Hoverr onn Servicee linkk.
  Then The listt off servic menu shouldd appearr.
  And I clickk on Teams and Collaboration linkk.
  Then Teams and Collaboration page should apppear.

   Scenario: Verify that user is able to hover the Services link and able to click on Emerging Technologies link.
  When I Hoverr onn Servicee linkkk.
  Then The listt off service menu shouldd appearr.
  And I clickk on Teams and Emerging Technologies.
  Then Emerging Technologies page should apppear.

   Scenario:  Verify that User is able to click on Service link.
  When I click on Service link.
  Then User Should be redirected to What we Do  page.

   Scenario:  Verify that User is able to click on Product link.
  When I click on Product link.
  Then User Should be redirected to Modern deployment page.

    Scenario: Verify that user is able to hover the Product link and able to click on Docsync link.
  When I Hover on Product link.
  Then The list of Product menu should appear.
  And I click on  Docsync link.
  Then  Docsync page should apppear.

   Scenario: Verify that user is able to hover the Product link and able to click on Teams Tempo link.
  When I Hover on Product linkk.
  Then The list of Product menu shouldd appear.
  And I click on  Teams Tempo link.
  Then  Teams Tempo page should apppear.

   Scenario: Verify that user is able to hover the Product link and able to click on M365 Governance Manager link.
  When I Hover on Productt linkk.
  Then The listt of Product menu shouldd appear.
  And I click on  M365 Governance Manager.
  Then  M365 Governance Manager page should apppear.

  @Verify Why People Use Uss page.
 Scenario:Verify Why People Use Us page.
  When I click on Why People Use Us page
  Then User Should be redirected to  Why People Use Us page in same window

   Scenario:  Verify Working AT Nathcorp page.
  When I click on Working AT Nathcorp page
   Then User Should be redirected to Careers page in same window

   
   Scenario:  Verify Contact Us page.
  When I click on Contact Us page
   Then User Should be redirected to Contact Us page in same window

   Scenario: Verify Apply Now page inside Working AT Nathcorp page.
   When I clickk on Working AT Nathcorp page.
    Then User Should be redirected to Careers page inn same window.
    And I click on Apply Now page.
    Then Nathcorp Apply Now page should open.

@ApplyNow
Scenario Outline: Verify Apply Now page inside Workingg AT Nathcorp page.
     When I clickk on Working AT Nathcorp pagee.
     Then User Should be redirected to Careers page inn samee window.
     And I click onn Apply Now page.
     Then Nathcorpp Apply Now page should open.
     And user should enter the First Name <First Name>,Last Name <Last Name>,Email <Email>,Home Phone <HomePhone>,Mobile Phone <MobilePhone >,Address <Address>,City <City>,State<State>,Zip<Zip>,Country<Country>
     Then select the Employment Desired.
     And  Select the resume in proper format.
     Then Click on Submit button.
         @source:Applynowsheet.xlsx:sheet1
         Examples:
             |First Name|Last Name|Email|HomePhone|MobilePhone|Address|City|State|Zip|Country|

@ContactUs 
Scenario Outline: Verify Contact Us page at Nathcorp page.
       When I click on Contact Us page.
       Then We are here to help page should open.
       And User should enter the Name<Name>,Email<Email>,Company<Company>,Phone<Phone>,Message<Message>.
       Then Click on Send Message.
          @source:ContactUs.xlsx:sheet1
          Examples: 
              |Name|Email|Company|Phone|Message|
             
            
            
            
            
            
            
            








































































































































































































































































