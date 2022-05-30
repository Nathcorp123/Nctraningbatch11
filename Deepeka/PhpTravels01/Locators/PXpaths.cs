using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhpTravels01.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhpTravels01.Locators
{
    class PXpaths
    {
       
        By Customer = By.XPath("//small");
        By Usrid = By.XPath("//div[@class='form-group']/input[@name='email']");
        By Pass = By.XPath("//input[@type='password']");
        By Log = By.XPath("//span[normalize-space()='Login']");
        By Flight = By.XPath("//a[normalize-space()='flights']");
        By Round = By.XPath("//input[@id='round-trip']");
        By Fplace = By.XPath("//input[@id='autocomplete']");
        By Dplace = By.XPath("//input[@id='autocomplete2']");
        By Ddate = By.XPath("//input[@id='departure']"); //*[@id="departure"]
        By Rdate = By.XPath("//input[@id='return']");
        By Pasngr = By.XPath("//span[@class='guest_flights d-block text-center']");
        By Adult = By.XPath("//div[@class='dropdown-item adult_qty']//i[@class='la la-plus']");
        By Child= By.XPath("//div[@class='dropdown-item child_qty']//i[@class='la la-plus']");
        By Infant = By.XPath("//div[@class='dropdown-item infant_qty']//i[@class='la la-plus']");
        By Srch = By.XPath("//button[@id='flights-search']");
        By Direct = By.XPath("//input[@id='direct']");



        public void CustomerFrontEnd()
        {
           IList<IWebElement> urlxpath = Hooks1.driver.FindElements(Customer);
           int count = urlxpath.Count;
           urlxpath[1].Click();
           // Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[1]);

            Thread.Sleep(11000);

        }

        public void SwitchWindow()
        {
            Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[1]);
            Thread.Sleep(7000);

        }

        public void GetIdPass(string UserId,string Password)
        {
            
            Hooks1.driver.FindElement(Usrid).SendKeys(UserId);
            Thread.Sleep(2000);
            Hooks1.driver.FindElement(Pass).SendKeys(Password);
            Thread.Sleep(2000);
        }

        public void MakeLogin()
        {
            Hooks1.driver.FindElement(Log).Click();
            Thread.Sleep(3000);
        }

        public void ClickFlight()
        {
            Hooks1.driver.FindElement(Flight).Click();
            Thread.Sleep(2000);
        }

        public void ClickRoundButton()
        {
            Hooks1.driver.FindElement(Round).Click();
            Thread.Sleep(2000);
        }

        public void SelectPlaces(string FlyingFrom,string Destination)
        {
            Hooks1.driver.FindElement(Fplace).SendKeys(FlyingFrom);
            Thread.Sleep(3000);
            Hooks1.driver.FindElement(Dplace).SendKeys(Destination);
            Thread.Sleep(3000);


        }

        public void SelectDates(string DepartureDate, string ReturnDate)
        {
          //  Hooks1.driver.FindElement(By.XPath("//div[@class='row g-0']//input[@id='departure']")).Clear();
            Hooks1.driver.FindElement(Ddate).Clear();
            Thread.Sleep(10000);
            Hooks1.driver.FindElement(Ddate).SendKeys(DepartureDate);
            Thread.Sleep(000);
            // Hooks1.driver.FindElement(By.XPath("//input[@id='return']")).Clear();
            Hooks1.driver.FindElement(Rdate).Clear();
            Thread.Sleep(3000);
            Hooks1.driver.FindElement(Rdate).SendKeys(ReturnDate);
            Thread.Sleep(3000);
        }


        public void SelectPassengers()
        {
            Hooks1.driver.FindElement(Pasngr).Click();
            Thread.Sleep(3000);
         
            Hooks1.driver.FindElement(Adult).Click();
            Thread.Sleep(3000);

            Hooks1.driver.FindElement(Child).Click();
            Thread.Sleep(3000);
            Hooks1.driver.FindElement(Child).Click();
            Thread.Sleep(3000);

            Hooks1.driver.FindElement(Infant).Click();
            Thread.Sleep(3000);

        }

        public void SearchAndHitDirect()
        {

            Hooks1.driver.FindElement(Srch).Click();
            Thread.Sleep(3000);
            Hooks1.driver.FindElement(Direct).Click();
            Thread.Sleep(3000);

        }

        public void Screenshot()
        {

            ITakesScreenshot screenshotDriverS = Hooks1.driver as ITakesScreenshot;
            Screenshot screenshot5 = screenshotDriverS.GetScreenshot();
            screenshot5.SaveAsFile("C:\\Users\\Deepika\\source\\repos\\PhpTravels01\\PhpTravels01\\Ss\\BookingScreenshot1.jpeg", ScreenshotImageFormat.Jpeg);

        }


    }
}
