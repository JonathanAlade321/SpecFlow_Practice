using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFL_SpecFlow
{
    class NoLocations
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            IWebElement PlanJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            PlanJourneyButton.Click();

            //Widget can't plan journey as no destinations are entered in the InputFrom/InputTo

            IWebElement InputFromError = driver.FindElement(By.Id(""));

            IWebElement InputToError = driver.FindElement(By.Id(""));

            driver.Quit();
        }
    }
}
