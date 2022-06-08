using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Working_AT_Nathcorp
    {
        [When(@"I click on Working AT Nathcorp page")]
        public void WhenIClickOnWorkingATNathcorpPage()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Working_AT_Nathcorp)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Careers page in same window")]
        public void ThenUserShouldBeRedirectedToCareersPageInSameWindow()
        {

            Console.WriteLine("User Should be redirected to Careers page in same window");
        }
    }
}
