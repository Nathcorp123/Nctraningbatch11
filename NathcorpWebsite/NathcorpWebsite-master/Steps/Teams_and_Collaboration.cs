using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Teams_and_Collaboration
    {
        [When(@"I Hoverr onn Servicee linkk\.")]
        public void WhenIHoverrOnnServiceeLinkk_()
        {

            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The listt off servic menu shouldd appearr\.")]
        public void ThenTheListtOffServicMenuShoulddAppearr_()
        {
            Console.WriteLine("The listt off servic menu shouldd appearr");
        }
        
        [Then(@"I clickk on Teams and Collaboration linkk\.")]
        public void ThenIClickkOnTeamsAndCollaborationLinkk_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Active_Directory)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Teams and Collaboration page should apppear\.")]
        public void ThenTeamsAndCollaborationPageShouldApppear_()
        {
            Console.WriteLine("Teams and Collaboration page should apppear");
        }
    }
}
