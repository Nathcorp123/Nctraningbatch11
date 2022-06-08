using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class Applynowwithexcel
    {
        [When(@"I clickk on Working AT Nathcorp pagee\.")]
        public void WhenIClickkOnWorkingATNathcorpPagee_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Working_AT_Nathcorp2)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Careers page inn samee window\.")]
        public void ThenUserShouldBeRedirectedToCareersPageInnSameeWindow_()
        {
            Console.WriteLine("User Should be redirected to Careers page in same window");
        }
        
        [Then(@"I click onn Apply Now page\.")]
        public void ThenIClickOnnApplyNowPage_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Apply_Now)).Click();
            Thread.Sleep(9000); 
        }
        
        [Then(@"Nathcorpp Apply Now page should open\.")]
        public void ThenNathcorppApplyNowPageShouldOpen_()
        {
            Console.WriteLine("Nathcorp Apply Now page should open");
        }
        
        [Then(@"user should enter the First Name (.*),Last Name (.*),Email (.*),Home Phone (.*),Mobile Phone (.*),Address (.*),City (.*),State(.*),Zip(.*),Country(.*)")]
        public void ThenUserShouldEnterTheFirstNameLastNameEmailHomePhoneMobilePhoneAddressCityStateZipCountry(string FirstName, string LastName, string Email, string HomePhone, string MobilePhone, string Address, string City, string State, string Zip, string Country)
        {
            IWebElement First_Name = Hooks.driver.FindElement(By.XPath(xpath.First_Name1));
            First_Name.SendKeys(FirstName);
            Thread.Sleep(3000);

            IWebElement Last_Name = Hooks.driver.FindElement(By.XPath(xpath.Last_Name1));
            Last_Name.SendKeys(LastName);
            Thread.Sleep(3000);
            IWebElement Email1 = Hooks.driver.FindElement(By.XPath(xpath.Email1));
            Email1.SendKeys(Email);
            Thread.Sleep(3000);

            IWebElement Homephone1 = Hooks.driver.FindElement(By.XPath(xpath.Homephone2));
            Homephone1.SendKeys(HomePhone);
            Thread.Sleep(3000);

            IWebElement Mobilephone1 = Hooks.driver.FindElement(By.XPath(xpath.Mobilephone2));
            Mobilephone1.SendKeys(MobilePhone);
            Thread.Sleep(3000);


            IWebElement Address1 = Hooks.driver.FindElement(By.XPath(xpath.Address2));
            Address1.SendKeys(Address);
            Thread.Sleep(3000);

            IWebElement City1 = Hooks.driver.FindElement(By.XPath(xpath.City2));
            City1.SendKeys(City);
            Thread.Sleep(3000);

            IWebElement state1 = Hooks.driver.FindElement(By.XPath(xpath.State2));
            state1.SendKeys(State);
            Thread.Sleep(3000);

            IWebElement zip1 = Hooks.driver.FindElement(By.XPath(xpath.Zip2));
            zip1.SendKeys(Zip);
            Thread.Sleep(3000);

            IWebElement Country1 = Hooks.driver.FindElement(By.XPath(xpath.Country2));
            Country1.SendKeys(Country);
            Thread.Sleep(3000);
        }
        
        [Then(@"select the Employment Desired\.")]
        public void ThenSelectTheEmploymentDesired_()
        {
            IWebElement Employment_Desired_FullTime = Hooks.driver.FindElement(By.XPath(xpath.Employment_Desired_FullTime1));
            Employment_Desired_FullTime.Click();
            Thread.Sleep(3000);
        }
        
        [Then(@"Select the resume in proper format\.")]
        public void ThenSelectTheResumeInProperFormat_()
        {
            IWebElement upload_resume = Hooks.driver.FindElement(By.XPath(xpath.upload_resume1));
            upload_resume.SendKeys("<C:\\Users\\RiteshOneDrive - NATHCORP\\Desktop>/<Ritesh Ranjan Gupta resume.pdf>");
            Thread.Sleep(3000);
        }
        
        [Then(@"Click on Submit button\.")]
        public void ThenClickOnSubmitButton_()
        {
            IWebElement Submit = Hooks.driver.FindElement(By.XPath(xpath.Submit1));
            Submit.Click();
            Thread.Sleep(3000);
        }
    }
}
