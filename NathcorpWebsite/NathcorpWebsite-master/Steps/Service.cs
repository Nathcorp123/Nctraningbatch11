using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Service
    {
        [When(@"I click on Service link\.")]
        public void WhenIClickOnServiceLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.service0)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to What we Do  page\.")]
        public void ThenUserShouldBeRedirectedToWhatWeDoPage_()
        {
            Console.WriteLine("User Should be redirected to What we Do  page");
        }
    }
}
