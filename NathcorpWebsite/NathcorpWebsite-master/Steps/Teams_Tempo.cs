using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Teams_Tempo
    {
        [When(@"I Hover on Product linkk\.")]
        public void WhenIHoverOnProductLinkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.Product2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The list of Product menu shouldd appear\.")]
        public void ThenTheListOfProductMenuShoulddAppear_()
        {
            Console.WriteLine("The list of Product menu shouldd appear");
        }
        
        [Then(@"I click on  Teams Tempo link\.")]
        public void ThenIClickOnTeamsTempoLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Teams_Tempo)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Teams Tempo page should apppear\.")]
        public void ThenTeamsTempoPageShouldApppear_()
        {
            Console.WriteLine("Teams Tempo page should apppear");
        }
    }
}
