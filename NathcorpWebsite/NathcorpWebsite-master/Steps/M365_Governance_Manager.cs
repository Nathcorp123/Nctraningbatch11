using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class M365_Governance_Manager
    {
        [When(@"I Hover on Productt linkk\.")]
        public void WhenIHoverOnProducttLinkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.Product2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The listt of Product menu shouldd appear\.")]
        public void ThenTheListtOfProductMenuShoulddAppear_()
        {
            Console.WriteLine("The listt of Product menu shouldd appear");
        }
        
        [Then(@"I click on  M(.*) Governance Manager\.")]
        public void ThenIClickOnMGovernanceManager_(int p0)
        {
            Hooks.driver.FindElement(By.XPath(xpath.M365_Governance_Manager)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"M(.*) Governance Manager page should apppear\.")]
        public void ThenMGovernanceManagerPageShouldApppear_(int p0)
        {
            Console.WriteLine("M(.*) Governance Manager page should apppear");
        }
    }
}
