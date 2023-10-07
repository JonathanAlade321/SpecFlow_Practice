using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFL_SpecFlow
{
    class Recents
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("");
            Thread.Sleep(3000);

            IWebElement RecentsTab = driver.FindElement(By.XPath("//*[@id=\"jp-recent-tab-home-small\"]/a"));
            RecentsTab.Click();

            //Recents Tab is displayed

            IWebElement RecentsList1 = driver.FindElement(By.XPath(""));
            RecentsList1.Click();

            driver.Quit();



        }
    }
}
