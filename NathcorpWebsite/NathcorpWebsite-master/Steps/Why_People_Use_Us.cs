using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Why_People_Use_Us
    {
        [When(@"I click on Why People Use Us page")]
        public void WhenIClickOnWhyPeopleUseUsPage()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Why_People_Use_Us)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to  Why People Use Us page in same window")]
        public void ThenUserShouldBeRedirectedToWhyPeopleUseUsPageInSameWindow()
        {
            Console.WriteLine("User Should be redirected to  Why People Use Us page in same window");
        }
    }
}
