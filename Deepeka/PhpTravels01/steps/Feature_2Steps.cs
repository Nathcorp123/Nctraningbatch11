using PhpTravels01.Locators;
using PhpTravels01.SaveToExcel;
using System;
using TechTalk.SpecFlow;

namespace PhpTravels01.steps
{
    [Binding]
    public class Feature_2Steps
    {

        ExcelData Data = new ExcelData();
        PXpaths path = new PXpaths();

        [Given(@"the userid and passsword")]
        public void GivenTheUseridAndPasssword()
        {
            Data.ReadCredentials();
        }

        [Then(@"fetch the userid and passsword and save to excel")]
        public void ThenFetchTheUseridAndPassswordAndSaveToExcel()
        {
            Data.ExcelCode();
        }

     
        
            //2nd scenario


        [Given(@"launch the Customer Front End site")]
        public void GivenLaunchTheCustomerFrontEndSite()
        {
            path.CustomerFrontEnd();
        }


        [When(@"Click on given url, it switch to next Window")]
        public void WhenClickOnGivenUrlItSwitchToNextWindow()
        {
            path.SwitchWindow();
        }


        [When(@"Enter the Userid(.*) and password(.*)")]
        public void WhenEnterTheUseridAndPassword(string UserId, string Password)
        {
            path.GetIdPass(UserId,Password);
        }

        [Then(@"validate the Userid and Password")]
        public void ThenValidateTheUseridAndPassword()
        {
            //validation1

            path.ValidateCredentials();
        }

        [Then(@"Click on Loginn button")]
        public void ThenClickOnLoginnButton()
        {
            path.MakeLogin();
            path.Logout();
            path.CloseWindow();
        }


               //3rd scenario



        [Given(@"the userid (.*) and password (.*) to login the Customer front end site")]
        public void GivenTheUseridAndPasswordToLoginTheCustomerFrontEndSite(string UserId, string Password)
        {

            path.uptologin(UserId, Password);

        }

        [Then(@"it redirect to flight dashboard and validate it")]
        public void ThenItRedirectToFlightDashboardAndValidateIt()
        {

            //validation2


            path.ValidateFlightdashboard();

            // Console.WriteLine("Successfully logged in");
            //path.Logout();
            //path.CloseWindow();
        }



        [Then(@"click on the Flight button on the flight booking page")]
        public void ThenClickOnTheFlightButtonOnTheFlightBookingPage()
        {
            path.ClickFlight();
        }

        [Then(@"click on the radio button of round trip")]
        public void ThenClickOnTheRadioButtonOfRoundTrip()
        {
            path.ClickRoundButton();
        }


        [Then(@"select the departure(.*) and destination (.*) place")]
        public void ThenSelectTheDepartureAndDestinationPlace(string FlyingFrom, string Destination)
        {
            path.SelectPlaces(FlyingFrom,Destination);
        }

        [Then(@"select the departure (.*) and returning (.*) date")]
        public void ThenSelectTheDepartureAndReturningDate(string DepartureDate, string ReturnDate)
        {
            path.SelectDates( DepartureDate, ReturnDate);
        }

        [Then(@"select the passanger")]
        public void ThenSelectThePassanger()
        {
            path.SelectPassengers();
        }

        [Then(@"click on search button and hit on the direct button")]
        public void ThenClickOnSearchButtonAndHitOnTheDirectButton()
        {
            path.SearchAndHitDirect();
        }


        [Then(@"take screenshot of flight price")]
        public void ThenTakeScreenshotOfFlightPrice()
        {
            path.Screenshot();
        }


    }
}
