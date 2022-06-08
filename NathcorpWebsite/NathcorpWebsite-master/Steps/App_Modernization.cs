using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class App_Modernization
    {
        [When(@"I Hover on Services(.*) link\.")]
        public void WhenIHoverOnServicesLink_(int p0)
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service3));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The list of service(.*) menu should appear\.")]
        public void ThenTheListOfServiceMenuShouldAppear_(int p0)
        {
            Console.WriteLine("The list of service(.*) menu should appear");
        }
        
        [Then(@"I click on App Modernization link\.")]
        public void ThenIClickOnAppModernizationLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.App_Modernization)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Application Modernization page should appear\.")]
        public void ThenApplicationModernizationPageShouldAppear_()
        {
            Console.WriteLine("Application Modernization page should appear");
        }
    }
}
