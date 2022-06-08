using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Cloud_Enablement
    {
        [When(@"I Hover on Service link\.")]
        public void WhenIHoverOnServiceLink_()
        {

            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The list of servic menu should appear\.")]
        public void ThenTheListOfServicMenuShouldAppear_()
        {
            Console.WriteLine("The list of servic menu should appear");
        }
        
        [Then(@"I click on Cloud Enablement link\.")]
        public void ThenIClickOnCloudEnablementLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Cloud_Enablement)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Cloud Enablement page should appear\.")]
        public void ThenCloudEnablementPageShouldAppear_()
        {
            Console.WriteLine("Cloud Enablement page should appear");
        }
    }
}
