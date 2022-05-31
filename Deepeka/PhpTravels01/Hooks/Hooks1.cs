using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace PhpTravels01.Hooks
{
    [Binding]
    public static class Hooks1
    {
        public static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            ExplicitWaiting.waitForTime(5000);

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

        }

        [BeforeScenario]
        public static void BeforeScenario()
        {

            driver.Navigate().GoToUrl("https://phptravels.com/demo/");

        }

        [AfterFeature]
        public static void AfterFeature()
        {

           driver.Quit();

        }


    }
}
