using PhpTravels01.Locators;
using PhpTravels01.SaveToExcel;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PhpTravels01
{
    [Binding]
    public class TravelSiteSteps
    {
        PXpaths xp = new PXpaths();
        ExcelData usrdata = new ExcelData();

        [Given(@"Userid and Password I have to fetch userid and password and store it in excel")]
        public void GivenUseridAndPasswordIHaveToFetchUseridAndPasswordAndStoreItInExcel()
        {

          // usrdata.ReadCredentials();
            usrdata.ExcelCode();
        }


        [When(@"Launch the customer Front-End phptravels site")]
        public void WhenLaunchTheCustomerFront_EndPhptravelsSite()
        {

            xp.CustomerFrontEnd();

        }


        [When(@"Click on login url need to Switch next window")]
        public void WhenClickOnLoginUrlNeedToSwitchNextWindow()
        {

            xp.SwitchWindow();

        }


        [Then(@"Enter valid userid(.*) and password(.*)")]
        public void ThenEnterValidUseridAndPassword(string UserId, string Password)
        {

            xp.GetIdPass(UserId, Password);

        }

        
        [Then(@"Click on Login button")]
        public void ThenClickOnLoginButton()
        {

            xp.MakeLogin();

        }

        
        [Then(@"Click on Flight option")]
        public void ThenClickOnFlightOption()
        {


            xp.ClickFlight();
            
        }


        [Then(@"Choose round Trip")]
        public void ThenChooseRoundTrip()
        {

            xp.ClickRoundButton();

        }


        [Then(@"Select Flyingfrom(.*) and Destination(.*)")]
        public void ThenSelectFlyingfromAndDestination(string FlyingFrom, string Destination)
        {

            xp.SelectPlaces(FlyingFrom,Destination);

        }


        [Then(@"Select Departuredate(.*) and Returndate(.*)")]
        public void ThenSelectDeparturedateAndReturndate(string DepartureDate, string ReturnDate)
        {

            xp.SelectDates(DepartureDate,ReturnDate);

        }


        [Then(@"Select numbers of passengers")]
        public void ThenSelectNumbersOfPassengers()
        {

            xp.SelectPassengers();

        }


        [Then(@"Click on Search Button and hit Direct button")]
        public void ThenClickOnSearchButtonAndHitDirectButton()
        {

            xp.SearchAndHitDirect();

        }


        [Then(@"Take ScreenShot of the Flights lists")]
        public void ThenTakeScreenShotOfTheFlightsLists()
        {

            xp.Screenshot();

        }

       





    }
}
