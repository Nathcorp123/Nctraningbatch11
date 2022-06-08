using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Emerging_Technologies
    {
        [When(@"I Hoverr onn Servicee linkkk\.")]
        public void WhenIHoverrOnnServiceeLinkkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service9));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The listt off service menu shouldd appearr\.")]
        public void ThenTheListtOffServiceMenuShoulddAppearr_()
        {
            Console.WriteLine("The listt off service menu shouldd appearr");
        }
        
        [Then(@"I clickk on Teams and Emerging Technologies\.")]
        public void ThenIClickkOnTeamsAndEmergingTechnologies_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Emerging_Technologies)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Emerging Technologies page should apppear\.")]
        public void ThenEmergingTechnologiesPageShouldApppear_()
        {
            Console.WriteLine("Emerging Technologies page should apppear");
        }
    }
}
