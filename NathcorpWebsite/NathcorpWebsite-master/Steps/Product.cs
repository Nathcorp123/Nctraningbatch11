using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Product
    {
        [When(@"I click on Product link\.")]
        public void WhenIClickOnProductLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Product)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Modern deployment page\.")]
        public void ThenUserShouldBeRedirectedToModernDeploymentPage_()
        {
            Console.WriteLine("User Should be redirected to Modern deployment page");
        }
    }
}
