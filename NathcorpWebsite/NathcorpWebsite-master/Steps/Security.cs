using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Security
    {
        [When(@"I Hoverr on Servicee linkk\.")]
        public void WhenIHoverrOnServiceeLinkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service7));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The listt of servic menu shouldd appearr\.")]
        public void ThenTheListtOfServicMenuShoulddAppearr_()
        {
            Console.WriteLine("The listt of servic menu shouldd appearr");
        }
        
        [Then(@"I clickk on Security linkk\.")]
        public void ThenIClickkOnSecurityLinkk_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Security)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Security page should apppear\.")]
        public void ThenSecurityPageShouldApppear_()
        {
            Console.WriteLine("Security page should apppear");
        }
    }
}
