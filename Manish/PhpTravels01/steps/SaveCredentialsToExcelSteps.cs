using System;
using TechTalk.SpecFlow;

namespace PhpTravels01.steps
{
    [Binding]
    public class Feature_2Steps
    {
        [Given(@"demo url and have to fetch it")]
        public void GivenDemoUrlAndHaveToFetchIt()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"save userid and passsword to excel")]
        public void GivenSaveUseridAndPassswordToExcel()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
