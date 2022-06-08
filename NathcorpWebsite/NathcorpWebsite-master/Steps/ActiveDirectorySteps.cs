using OpenQA.Selenium.Interactions;
using Microsoft.Office.Interop.Excel;
using NathcorpWebsite.TestHooks;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using NathcorpWebsite.wait;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NathcorpWebsite.Steps
{
    [Binding]
    public class ActiveDirectorySteps
    {
        public static string _path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
        [When(@"I Hover on Services link\.")]
        public void WhenIHoverOnServicesLink_()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            ExplicitWaiting.waitForTime(2000); ;


        }
        
        [Then(@"The List of service menu should appear")]
        public void ThenTheListOfServiceMenuShouldAppear()
        {
             

            string List_of_service_menu =  Hooks.driver.FindElement(By.XPath("//ul[@id='top-menu']//a[normalize-space()='Active Directory']")).Text;

            ExplicitWaiting.waitForTime(2000);
            Console.WriteLine("Data on File for List_of_service_menu = " + List_of_service_menu);
            var FileData = File.ReadAllText(_path + @"\Data Validation\List_of_Service_menu.txt");
            ExplicitWaiting.waitForTime(2000);
            Console.WriteLine("Data on File for FileData= " + FileData);
            
            Assert.AreEqual(List_of_service_menu, FileData);
           
            Console.WriteLine(" The data results are matched sucessfully for List_of_service_menu");
            Thread.Sleep(2000);

        }

        [Then(@"I Click on Active Directory link\.")]
        public void ThenIClickOnActiveDirectoryLink_()
        {
            Hooks.driver.FindElement(By.XPath(xpath.Active_Directory)).Click();
            ExplicitWaiting.waitForTime(2000); 
            
        }
        
        [Then(@"Active Directory page should appear\.")]
        public void ThenActiveDirectoryPageShouldAppear_()
        {
            string Active_Directory_Page = Hooks.driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/article[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[1]")).Text;

            //ExplicitWaiting.waitForTime(2000);
            Console.WriteLine("Data on File for Active_Directory_Page = " + Active_Directory_Page);
        }
    }
}
