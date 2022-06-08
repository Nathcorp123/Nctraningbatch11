using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Managed_Services
    {
        [When(@"I Hover on Service linkk\.")]
        public void WhenIHoverOnServiceLinkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The list of servic menu shouldd appear\.")]
        public void ThenTheListOfServicMenuShoulddAppear_()
        {
            Console.WriteLine("The list of servic menu shouldd appear");
        }
        
        [Then(@"I click on Managed Services linkk\.")]
        public void ThenIClickOnManagedServicesLinkk_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Managed_Services)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Managed Services page should apppear\.")]
        public void ThenManagedServicesPageShouldApppear_()
        {
            Console.WriteLine("Managed Services page should apppear");
        }
    }
}
