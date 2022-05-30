using System;
using TechTalk.SpecFlow;

namespace PhpTravels01.steps
{
    [Binding]
    public class BookFlight
    {
        [Given(@"click on the Flight button on the filght booking page")]
        public void GivenClickOnTheFlightButtonOnTheFilghtBookingPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on the radio button of round trip")]
        public void GivenClickOnTheRadioButtonOfRoundTrip()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"select the departure(.*) and destination (.*) place")]
        public void ThenSelectTheDepartureAndDestinationPlace(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"select the departure (.*) and returning (.*) date")]
        public void ThenSelectTheDepartureAndReturningDate(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"search the passanger and click on search button")]
        public void ThenSearchThePassangerAndClickOnSearchButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on the direct button")]
        public void ThenClickOnTheDirectButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"take screenshot of flight price")]
        public void ThenTakeScreenshotOfFlightPrice()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
