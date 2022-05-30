using System;
using TechTalk.SpecFlow;

namespace PhpTravels01.steps
{
    [Binding]
    public class loginn
    {
        [Given(@"launch the Customer Frontt End site")]
        public void GivenLaunchTheCustomerFronttEndSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Need to switch Windoww")]
        public void GivenNeedToSwitchWindoww()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter correctt Userid(.*) and password(.*)")]
        public void ThenEnterCorrecttUseridAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on Loginn button")]
        public void ThenClickOnLoginnButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
