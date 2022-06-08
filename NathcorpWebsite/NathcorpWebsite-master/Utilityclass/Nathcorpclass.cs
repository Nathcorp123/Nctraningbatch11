using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing;
using NathcorpWebsite.TestHooks;
using NathcorpWebsite.wait;
using NathcorpWebsite.Xpaths;
using OpenQA.Selenium;

namespace NathcorpWebsite.Utilityclass
{
    class Nathcorpclass
    {
       public void launchurl(string url)
        {

            //string URLSplit = url;
           
            //string newUrl = URLSplit.Replace(@"\", "");
            Hooks.driver.Manage().Window.Maximize();
            Hooks.driver.Navigate().GoToUrl(url);
        }

        public void servicedropdown()
        {
            IWebElement ele = Hooks.driver.FindElement(By.XPath(xpath.service2));
            var actions = new OpenQA.Selenium.Interactions.Actions(Hooks.driver);
            actions.MoveToElement(ele).Perform();
            ExplicitWaiting.waitForTime(2000); 
        }
    }
}
