using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Modern_Deployment
    {
        [When(@"I Hoverr on Service linkk\.")]
        public void WhenIHoverrOnServiceLinkk_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service6));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            Thread.Sleep(7000);
        }
        
        [Then(@"The listt of servic menu shouldd appear\.")]
        public void ThenTheListtOfServicMenuShoulddAppear_()
        {
            Console.WriteLine("The listt of servic menu shouldd appear");
        }
        
        [Then(@"I clickk on Modern Deployment linkk\.")]
        public void ThenIClickkOnModernDeploymentLinkk_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Modern_Deployment)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"Modern Deployment page should apppear\.")]
        public void ThenModernDeploymentPageShouldApppear_()
        {
            Console.WriteLine("Modern Deployment page should apppear");
        }
    }
}
