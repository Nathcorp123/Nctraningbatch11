using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class ContactUs1
    {
        [When(@"I click on Contact Us page\.")]
        public void WhenIClickOnContactUsPage_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Contact_Us_Form)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"We are here to help page should open\.")]
        public void ThenWeAreHereToHelpPageShouldOpen_()
        {
            Console.WriteLine("Done");
            Thread.Sleep(7000);

        }
        
        [Then(@"User should enter the Name(.*),Email(.*),Company(.*),Phone(.*),Message(.*)\.")]
        public void ThenUserShouldEnterTheNameEmailCompanyPhoneMessage_(string Name, string Email, string Company, string Phone, string Message)
        {
            IWebElement First_Name = Hooks.driver.FindElement(By.XPath(xpath.Name1));
            First_Name.SendKeys(Name);
            Thread.Sleep(3000);

            IWebElement Email_Address = Hooks.driver.FindElement(By.XPath(xpath.Email2));
            Email_Address.SendKeys(Email);
            Thread.Sleep(3000);

            IWebElement Company2 = Hooks.driver.FindElement(By.XPath(xpath.Company1));
            Company2.SendKeys(Company);
            Thread.Sleep(3000);

            IWebElement Phone2 = Hooks.driver.FindElement(By.XPath(xpath.Phone1));
            Phone2.SendKeys(Phone);
            Thread.Sleep(3000);

            IWebElement Message2 = Hooks.driver.FindElement(By.XPath(xpath.Message1));
            Message2.SendKeys(Message);
            Thread.Sleep(3000);



        }

        [Then(@"Click on Send Message\.")]
        public void ThenClickOnSendMessage_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Sendmessage1)).Click();
            Thread.Sleep(3000);
        }
    }
}
