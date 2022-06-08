using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Docsync
    {
        [When(@"I Hover on Product link\.")]
        public void WhenIHoverOnProductLink_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.Product1));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The list of Product menu should appear\.")]
        public void ThenTheListOfProductMenuShouldAppear_()
        {
            Console.WriteLine("The list of Product menu should appear");
        }
        
        [Then(@"I click on  Docsync link\.")]
        public void ThenIClickOnDocsyncLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Docsync)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Docsync page should apppear\.")]
        public void ThenDocsyncPageShouldApppear_()
        {
            Console.WriteLine("Docsync page should apppear");

        }
    }
}
