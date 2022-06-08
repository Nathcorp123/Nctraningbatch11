using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class ApplyNow
    {
        [When(@"I clickk on Working AT Nathcorp page\.")]
        public void WhenIClickkOnWorkingATNathcorpPage_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Working_AT_Nathcorp1)).Click();
            Thread.Sleep(7000);
        }
        
        [Then(@"User Should be redirected to Careers page inn same window\.")]
        public void ThenUserShouldBeRedirectedToCareersPageInnSameWindow_()
        {
            Console.WriteLine("User Should be redirected to Careers page in same window");
        }
        
        [Then(@"I click on Apply Now page\.")]
        public void ThenIClickOnApplyNowPage_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Apply_Now)).Click();
            Thread.Sleep(9000);
            IWebElement First_Name = Hooks.driver.FindElement(By.XPath("//input[@id='field_x1dzdf2']"));
            First_Name.SendKeys("Ritesh");
            Thread.Sleep(3000);

            IWebElement Last_Name = Hooks.driver.FindElement(By.XPath("//input[@id='field_57mz9h2']"));
            Last_Name.SendKeys("Ranjan");
            Thread.Sleep(3000);

            IWebElement Email = Hooks.driver.FindElement(By.XPath("//input[@id='field_7df6al2']"));
            Email.SendKeys("riteshranjan8200@gmail.com");
            Thread.Sleep(3000);

            IWebElement Homephone = Hooks.driver.FindElement(By.XPath("//input[@id='field_4hh35l2']"));
            Homephone.SendKeys("1234567890");
            Thread.Sleep(3000);

            IWebElement Mobilephone = Hooks.driver.FindElement(By.XPath("//input[@id='field_24gocg2']"));
            Mobilephone.SendKeys("0123456789");
            Thread.Sleep(3000);


            IWebElement Address = Hooks.driver.FindElement(By.XPath("//input[@id='field_vnv7we2_line1']"));
            Address.SendKeys("Garhwa");
            Thread.Sleep(3000);

            IWebElement City = Hooks.driver.FindElement(By.XPath("//input[@id='field_vnv7we2_city']"));
            City.SendKeys("Garhwa");
            Thread.Sleep(3000);

            IWebElement state = Hooks.driver.FindElement(By.XPath("//input[@id='field_vnv7we2_state']"));
            state.SendKeys("Jharkhand");
            Thread.Sleep(3000);

            IWebElement zip = Hooks.driver.FindElement(By.XPath("//input[@id='field_vnv7we2_zip']"));
            zip.SendKeys("822128");
            Thread.Sleep(3000);

            IWebElement Country = Hooks.driver.FindElement(By.XPath("//select[@id='field_vnv7we2_country']"));
            Country.SendKeys("India");
            Thread.Sleep(3000);

            IWebElement Employment_Desired_FullTime = Hooks.driver.FindElement(By.XPath("//input[@id='field_8l3som2-0']"));
            Employment_Desired_FullTime.Click();
            Thread.Sleep(3000);


            IWebElement upload_resume = Hooks.driver.FindElement(By.XPath("//button[contains(text(),'Drop a file here or click to upload (PDF, JPEG, DO')]"));
            upload_resume.SendKeys("<C:\\Users\\RiteshOneDrive - NATHCORP\\Desktop>/<Ritesh Ranjan Gupta resume.pdf>");
            Thread.Sleep(3000);

            IWebElement Submit = Hooks.driver.FindElement(By.XPath("//button[normalize-space()='Submit']"));
            Submit.Click();
            Thread.Sleep(3000);
        }

        [Then(@"Nathcorp Apply Now page should open\.")]
        public void ThenNathcorpApplyNowPageShouldOpen_()
        {
            Console.WriteLine("Nathcorp Apply Now page should open");
        }
    }
}
