using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Whowedoittfor
    {
        [When(@"I click on Who we Do it for")]
        public void WhenIClickOnWhoWeDoItFor()
        {
            Hooks.driver.FindElement(By.XPath(xpath.whowe)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Who we Do it for page in same window")]
        public void ThenUserShouldBeRedirectedToWhoWeDoItForPageInSameWindow()
        {
            Console.WriteLine("Done");
        }
    }
}
