using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Contact_Us
    {
        [When(@"I click on Contact Us page")]
        public void WhenIClickOnContactUsPage()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Contact_Us)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Contact Us page in same window")]
        public void ThenUserShouldBeRedirectedToContactUsPageInSameWindow()
        {
            Console.WriteLine("User Should be redirected to Contact Us page in same window");
        }
    }
}
