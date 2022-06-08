using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NathcorpWebsite.Data;
using NathcorpWebsite.TestHooks;
using OpenQA.Selenium;
using NathcorpWebsite.Xpaths;
using NathcorpWebsite.Utilityclass;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class whowearepage
    {
        Nathcorpclass nc = new Nathcorpclass();
        [Given(@": I Launch the Application")]
        public void GivenILaunchTheApplication(String url)
        {
           
            nc.launchurl(url);
        }
        
        [When(@"I click on Who we are")]
        public void WhenIClickOnWhoWeAre()
        {
            Hooks.driver.FindElement(By.XPath(xpath.who)).Click();
        }
        
        [Then(@"User should be redirected to who we are page in same window")]
        public void ThenUserShouldBeRedirectedToWhoWeArePageInSameWindow()
        {
            Console.WriteLine("Done");
        }
    }
}
