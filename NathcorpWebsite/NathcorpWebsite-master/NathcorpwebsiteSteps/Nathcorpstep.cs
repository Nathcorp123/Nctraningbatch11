using Microsoft.VisualStudio.TestTools.UnitTesting;
using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Utilityclass;
using NathcorpWebsite.wait;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.NathcorpSteps
{
    [Binding]
    public sealed class Nathcorpstep
    {
        
        public static string _path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        Nathcorpclass nc = new Nathcorpclass();
        [Given(@": the url (.*)of an application")]
        public void GivenTheUrlOfAnApplication(string URL)
        {
            nc.launchurl(URL);
        }

        
        //[Given(@": I launch the application\.")]
        //public void GivenILaunchTheApplication_(string URL)
        //{
        //  nc.launchurl(URL) ;
        ////}

        [When(@"I click on Who we aree")]
        public void WhenIClickOnWhoWeAree()
        {
            Hooks.driver.FindElement(By.XPath(xpath.who)).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        [Then(@"User should be redirected to who we are page in same windowe")]
        public void ThenUserShouldBeRedirectedToWhoWeArePageInSameWindowe()
        {
            string ExpectedValue = Hooks.driver.FindElement(By.XPath("//h1[normalize-space()='WHO WE ARE']")).Text;
            Console.WriteLine("Data on File for ExpectedValue = " + ExpectedValue);
            var FileData = File.ReadAllText(_path + @"\Data validation\List_of_Data.txt");
            Console.WriteLine("Data on File for ActualValue = " + FileData);
            Assert.AreEqual(ExpectedValue, FileData);
            ExplicitWaiting.waitForTime(2000);
            Console.WriteLine(" The data results are matched sucessfully for Who are We");
            ExplicitWaiting.waitForTime(2000);
        }

        [When(@"I click on Who we Do itt for")]
        public void WhenIClickOnWhoWeDoIttFor()
        {
            Hooks.driver.FindElement(By.XPath(xpath.whowe)).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        [Then(@"User Should be redirectedd to Who we Do it for page in same window")]
        public void ThenUserShouldBeRedirecteddToWhoWeDoItForPageInSameWindow()
        {
            string ExpectedValue = Hooks.driver.FindElement(By.XPath("//p[normalize-space()='WHO WE DO IT FOR']")).Text;
            Console.WriteLine("Data on File for ExpectedValue = " + ExpectedValue);
        }

        [When(@"I Hover on Services linkk\.")]
        public void WhenIHoverOnServicesLinkk_()
        {
            nc.servicedropdown();
        }

        [Then(@"The List of service menu should appearr")]
        public void ThenTheListOfServiceMenuShouldAppearr()
        {
            Console.WriteLine("Done");
        }

        [Then(@"I Click on Active Directoryy link\.")]
        public void ThenIClickOnActiveDirectoryyLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Active_Directory)).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        [Then(@"Active Directory page shouldd appear\.")]
        public void ThenActiveDirectoryPageShoulddAppear_()
        {
            Console.WriteLine("Done");
        }

        [Then(@"I click on App Modernization linkk\.")]
        public void ThenIClickOnAppModernizationLinkk_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.App_Modernization)).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        [Then(@"Application Modernization page should appearr\.")]
        public void ThenApplicationModernizationPageShouldAppearr_()
        {
            Console.WriteLine("Done");
        }





    }
}
