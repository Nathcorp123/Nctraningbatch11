using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PhpTravels01.Hooks;
using PhpTravels01.SaveToExcel;
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
        By logout = By.XPath("//ul[@class='sidebar-menu list-items']//a[contains(@class,'waves-effect')][normalize-space()='Logout']");

        //validate flight dashboard
        By WlcmMsg1 = By.XPath("//div[@class='breadcrumb-content']//*[text()='Hi, ']");

       // By WlcmMsg2 = By.XPath("//div[@class='breadcrumb-content']//*[text()='Demo']");



        public static string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\Ss");



        public void CustomerFrontEnd()
        {
           IList<IWebElement> urlxpath = Hooks1.driver.FindElements(Customer);
           int count = urlxpath.Count;
           urlxpath[1].Click();
            // Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[1]);

            //Thread.Sleep(7000);
            ExplicitWaiting.waitForTime(7000);

        }

        public void SwitchWindow()
        {
            string Mainwindow = Hooks1.driver.CurrentWindowHandle;
            Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[1]);
            ExplicitWaiting.waitForTime(7000);

        }

        public void GetIdPass(string UserId,string Password)
        {
            
            Hooks1.driver.FindElement(Usrid).SendKeys(UserId);
            ExplicitWaiting.waitForTime(2000);
            Hooks1.driver.FindElement(Pass).SendKeys(Password);
            ExplicitWaiting.waitForTime(2000);
        }

        public void MakeLogin()
        {
            Hooks1.driver.FindElement(Log).Click();
            ExplicitWaiting.waitForTime(3000);
        }

        public void ClickFlight()
        {
            Hooks1.driver.FindElement(Flight).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        public void ClickRoundButton()
        {
            Hooks1.driver.FindElement(Round).Click();
            ExplicitWaiting.waitForTime(2000);
        }

        public void SelectPlaces(string FlyingFrom,string Destination)
        {
            Hooks1.driver.FindElement(Fplace).SendKeys(FlyingFrom);
            ExplicitWaiting.waitForTime(3000);
            Hooks1.driver.FindElement(Dplace).SendKeys(Destination);
            ExplicitWaiting.waitForTime(3000);


        }

        public void SelectDates(string DepartureDate, string ReturnDate)
        {
          //  Hooks1.driver.FindElement(By.XPath("//div[@class='row g-0']//input[@id='departure']")).Clear();
            Hooks1.driver.FindElement(Ddate).Clear();
            ExplicitWaiting.waitForTime(6000);
            Hooks1.driver.FindElement(Ddate).SendKeys(DepartureDate);
            ExplicitWaiting.waitForTime(2000);
            // Hooks1.driver.FindElement(By.XPath("//input[@id='return']")).Clear();
            Hooks1.driver.FindElement(Rdate).Clear();
            ExplicitWaiting.waitForTime(3000);
            Hooks1.driver.FindElement(Rdate).SendKeys(ReturnDate);
            ExplicitWaiting.waitForTime(3000);
        }


        public void SelectPassengers()
        {
            Hooks1.driver.FindElement(Pasngr).Click();
            ExplicitWaiting.waitForTime(3000);

            Hooks1.driver.FindElement(Adult).Click();
            ExplicitWaiting.waitForTime(3000);

            Hooks1.driver.FindElement(Child).Click();
            ExplicitWaiting.waitForTime(3000);

            Hooks1.driver.FindElement(Child).Click();
            ExplicitWaiting.waitForTime(3000);

            Hooks1.driver.FindElement(Infant).Click();
            ExplicitWaiting.waitForTime(3000);

        }

        public void SearchAndHitDirect()
        {

            Hooks1.driver.FindElement(Srch).Click();
            ExplicitWaiting.waitForTime(3000);
            Hooks1.driver.FindElement(Direct).Click();
            ExplicitWaiting.waitForTime(3000);

        }

        public void Screenshot()
        {

            ITakesScreenshot screenshotDriverS = Hooks1.driver as ITakesScreenshot;
            Screenshot scrnshot1 = screenshotDriverS.GetScreenshot();
            //scrnshot1.SaveAsFile("C:\\Users\\Deepika\\source\\repos\\PhpTravels01\\PhpTravels01\\Ss\\BookingScreenshot1.jpeg", ScreenshotImageFormat.Jpeg);
            scrnshot1.SaveAsFile(path +@"BookingScreenshot1.jpeg", ScreenshotImageFormat.Jpeg);

        }

        public void uptologin(string UserId,string Password)
        {

            //ExcelData xldata = new ExcelData();

           // xldata.ReadCredentials();
           // xldata.ExcelCode();
            CustomerFrontEnd();
            SwitchWindow();
            GetIdPass(UserId, Password);
            MakeLogin();

        }

        public void Logout()
        {

            Hooks1.driver.FindElement(logout).Click();
        }


        public void CloseWindow()
        {

           // Hooks1.driver.Close();
            Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[1]).Close();
            Hooks1.driver.SwitchTo().Window(Hooks1.driver.WindowHandles[0]);

        }



        //validation functions

        public void ValidateFlightdashboard()
        {

            //xpath for validation
           

            IWebElement Msg = Hooks1.driver.FindElement(WlcmMsg1);
            string TextMsg1 = Msg.Text;

            ////concatination
            //string str = string.Concat(TextMsg1, TextMsg2);

            // char[] spearator = { ' ',};

            // string[] strMsglist = str.Split(spearator);
            // string DashboardText1 = strMsglist[];

            // //string ab1 = driver.FindElement(By.XPath("//input[@id='User_Name']")).GetAttribute("value").ToString();

            string ab1 = TextMsg1;
            // string ab1 = DashboardText1;

            Console.WriteLine("welcome message on flight dashboard = " + ab1);
            ExplicitWaiting.waitForTime(1000);


            string original = "Hi, Demo Welcome Back";
            Assert.AreEqual(ab1, original);
            ExplicitWaiting.waitForTime(3000);
            Console.WriteLine(" The welcome message is matching sucessfully");
            ExplicitWaiting.waitForTime(1000);


        }

        public void ValidateCredentials()
        {

            string cred1 = Hooks1.driver.FindElement(Usrid).GetAttribute("value").ToString();
            string cred2 = Hooks1.driver.FindElement(Pass).GetAttribute("value").ToString();

            //Thread.Sleep(1000);
            Console.WriteLine("User name provided on website =" + cred1);
            ExplicitWaiting.waitForTime(1000);

            Console.WriteLine("User name provided on website =" + cred2);
            ExplicitWaiting.waitForTime(1000);

            string original1 = "user@phptravels.com";
            Assert.AreEqual(cred1, original1);
            ExplicitWaiting.waitForTime(2000);

            string original2 = "demouser";
            Assert.AreEqual(cred2, original2);
            ExplicitWaiting.waitForTime(2000);

            Console.WriteLine(" The username  and Password are matching sucessfully");
            ExplicitWaiting.waitForTime(1000);

        }






    }
}
