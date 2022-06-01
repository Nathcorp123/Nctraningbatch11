using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.Events;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Ticket_Booking_Assignment
{
    [Binding]
    public class SearchTheFlightsSteps
    {
        public static IWebDriver driver;

        [Given(@"Browser should open")]
        public void GivenBrowserShouldOpen()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [When(@"Enter the url")]
        public void WhenEnterTheUrl()
        {
            driver.Navigate().GoToUrl(Datafile.url);
            driver.Manage().Window.Maximize();
           

        }

        [When(@"click on Customer Front-End")]
        public void WhenClickOnCustomerFront_End()
        {

            driver.FindElement(By.XPath(Pathfile.CustomerFront_End)).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);
             
            
        }
        
        [When(@"Enter email")]
        public void WhenEnterEmail()
        {
            driver.FindElement(By.XPath(Pathfile.email)).SendKeys(Datafile.user_email);
        }

        [When(@"Enter password")]
        public void WhenEnterPassword()
        {
            driver.FindElement(By.XPath(Pathfile.password)).SendKeys(Datafile.user_pass);
            try
            {
                driver.FindElement(By.XPath(Pathfile.cookie_stop)).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.XPath(Pathfile.login_btn)).Click();

        }

        [When(@"Choose flight from top menu")]
        public void WhenChooseFlightFromTopMenu()
        {
            
            driver.FindElement(By.XPath(Pathfile.flight)).Click();
        }

        [When(@"Choose Round Trip")]
        public void WhenChooseRoundTrip()
        {
           
            driver.FindElement(By.XPath(Pathfile.round)).Click();

        }

        [When(@"Enter  Ranchi in Flying From field")]
        public void WhenEnterRanchiInFlyingFromField()
        {
           
            driver.FindElement(By.XPath(Pathfile.flyingfield)).SendKeys(Datafile.flyingfrom_value);
           
            driver.FindElement(By.XPath(Pathfile.selectflyingfield)).Click();


        }

        [When(@"Enter Mumbai in To Destination field")]
        public void WhenEnterMumbaiInToDestinationField()
        {

            driver.FindElement(By.XPath(Pathfile.destinationField)).SendKeys(Datafile.todestination_value);

            driver.FindElement(By.XPath(Pathfile.selectDestination)).Click();

        }

        [When(@"Select Depart Date")]
        public void WhenSelectDepartDate()
        {
           
            driver.FindElement(By.XPath(Pathfile.SelectDepartDate)).Clear();
            driver.FindElement(By.XPath(Pathfile.SelectDepartDate)).SendKeys(Datafile.departdate_value);

        }

        [When(@"select return date")]
        public void WhenSelectReturnDate()
        {
           
            driver.FindElement(By.XPath(Pathfile.SelectReturnDate)).Clear();
            driver.FindElement(By.XPath(Pathfile.SelectReturnDate)).SendKeys(Datafile.returndate_value);
        }

        [When(@"Select  Adults, Childs, Infants")]
        public void WhenSelectAdultsChildsInfants()
        {
               
                driver.FindElement(By.XPath(Pathfile.passengerbox)).Click();
                
                driver.FindElement(By.XPath(Pathfile.selectadults)).Click();

               
                driver.FindElement(By.XPath(Pathfile.selectchilds)).Click();

                driver.FindElement(By.XPath(Pathfile.selectchilds)).Click();


               
                driver.FindElement(By.XPath(Pathfile.selectinfants)).Click();
                driver.FindElement(By.XPath(Pathfile.selectinfants)).Click();

            
        }

        [When(@"click on Search")]
        public void WhenClickOnSearch()
        {
            
            driver.FindElement(By.XPath(Pathfile.search_btn)).Click();
        }

        [When(@"Choose the option Direct from the left panel")]
        public void WhenChooseTheOptionDirectFromTheLeftPanel()
        {
            
            driver.FindElement(By.XPath(Pathfile.direct)).Click();
        }

        [When(@"Select Economic class from top drop down list")]
        public void WhenSelectEconomicClassFromTopDropDownList()
        {
            driver.FindElement(By.XPath(Pathfile.select_class)).Click();

        }

        [When(@"Read the price of first five search result")]
        public void WhenReadThePriceOfFirstFiveSearchResult()
        {
            Console.WriteLine("First Flight price is: "+driver.FindElement(By.XPath(Pathfile.Fprice1)).Text);
            Console.WriteLine("Second Flight price is: " + driver.FindElement(By.XPath(Pathfile.Fprice2)).Text);
            Console.WriteLine("Third Flight price is: " + driver.FindElement(By.XPath(Pathfile.Fprice3)).Text);
            Console.WriteLine("Fourth Flight price is: " + driver.FindElement(By.XPath(Pathfile.Fprice4)).Text);
            Console.WriteLine("Fifth Flight price is: " + driver.FindElement(By.XPath(Pathfile.Fprice5)).Text);

        }

        [When(@"save the result to excel sheet")]
        public void WhenSaveTheResultToExcelSheet()
        {
            //save result to excel
        }

        [When(@"Save the screenshot of the search result page")]
        public void WhenSaveTheScreenshotOfTheSearchResultPage()
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(TakeSs.Flights_Result, ScreenshotImageFormat.Png);
        
        }

        [Then(@"Homepage should open")]
        public void ThenHomepageShouldOpen()
        {
            try
            {
                Screenshot s1 = ((ITakesScreenshot)driver).GetScreenshot();
                s1.SaveAsFile(TakeSs.Homepage_Result, ScreenshotImageFormat.Png);

                IWebElement homepageElement = driver.FindElement(By.XPath(Pathfile.vhomepage));
                if (homepageElement.Displayed)
                {
                    Console.WriteLine(homepageElement.Displayed);
                    Console.WriteLine("Test case Passed");

                }
                else
                {
                    Console.WriteLine("Test case Failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Screenshot s11 = ((ITakesScreenshot)driver).GetScreenshot();
                s11.SaveAsFile(TakeSs.HomepageError, ScreenshotImageFormat.Png);
                driver.Quit();
            }

        }

        [Then(@"Login page should open")]
        public void ThenLoginPageShouldOpen()
        {
            try
            {
                Screenshot s2 = ((ITakesScreenshot)driver).GetScreenshot();
                s2.SaveAsFile(TakeSs.Loginpage_Result, ScreenshotImageFormat.Png);

                IWebElement loginpageElement = driver.FindElement(By.XPath(Pathfile.vloginpage));
                if (loginpageElement.Displayed)
                {
                    Console.WriteLine(loginpageElement.Displayed);
                    Console.WriteLine("Test case Passed");
                }
                else
                {
                    Console.WriteLine("Test case Failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Screenshot s22 = ((ITakesScreenshot)driver).GetScreenshot();
                s22.SaveAsFile(TakeSs.LoginpageError, ScreenshotImageFormat.Png);
                driver.Quit();
            }

        }

        [Then(@"Dashboard should open")]
        public void ThenDashboardShouldOpen()
        {
            try
            {
                Screenshot s3 = ((ITakesScreenshot)driver).GetScreenshot();
                s3.SaveAsFile(TakeSs.Dashboard_Result, ScreenshotImageFormat.Png);

                IWebElement dashboardElement = driver.FindElement(By.XPath(Pathfile.vdashboard));
                if (dashboardElement.Displayed)
                {
                    Console.WriteLine(dashboardElement.Displayed);
                    Console.WriteLine("Test case Passed");
                }
                else
                {
                    Console.WriteLine("Test case Failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Screenshot s33 = ((ITakesScreenshot)driver).GetScreenshot();
                s33.SaveAsFile(TakeSs.DashboardpageError, ScreenshotImageFormat.Png);
                driver.Quit();
            }

        }

        [Then(@"SEARCH FOR BEST FLIGHTS page sholud open")]
        public void ThenSEARCHFORBESTFLIGHTSPageSholudOpen()
        {
            try
            {
                Screenshot s4 = ((ITakesScreenshot)driver).GetScreenshot();
                s4.SaveAsFile(TakeSs.Searchpage_Result, ScreenshotImageFormat.Png);

                IWebElement searchpageElement = driver.FindElement(By.XPath(Pathfile.vsearchpage));
                if (searchpageElement.Displayed)
                {
                    Console.WriteLine(searchpageElement.Displayed);
                    Console.WriteLine("Test case Passed");
                }
                else
                {
                    Console.WriteLine("Test case Failed");
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex);
                Screenshot s44 = ((ITakesScreenshot)driver).GetScreenshot();
                s44.SaveAsFile(TakeSs.SearchpageError, ScreenshotImageFormat.Png);
                driver.Quit();
            }

        }

        [Then(@"Return Date field should come")]
        public void ThenReturnDateFieldShouldCome()
        {
            IWebElement returnfieldElement = driver.FindElement(By.XPath(Pathfile.vreturn));
            if (returnfieldElement.Displayed)
            {
                Console.WriteLine(returnfieldElement.Displayed);
                Console.WriteLine("Test case Passed");
            }
            else
            {
                Console.WriteLine("Test case Failed");
            }
        }



        [Then(@"Flight details should come")]
        public void ThenFlightDetailsShouldCome()
        {
            try
            {
                IWebElement felement = driver.FindElement(By.Id(Pathfile.vflightresult));
                if (felement.Displayed)
                {
                    Console.WriteLine(felement.Displayed);
                    Console.WriteLine("Test case Passed");
                }
                else
                {
                    Console.WriteLine("Test case Failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Screenshot s66 = ((ITakesScreenshot)driver).GetScreenshot();
                s66.SaveAsFile(TakeSs.FlightpageError, ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [When(@"close the browser")]
        public void WhenCloseTheBrowser()
        {
            driver.Quit();
        }

    }
}
