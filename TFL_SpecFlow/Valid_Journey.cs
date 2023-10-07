using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFL_SpecFlow
{
    class Valid_Journey
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            //Navigate to the TFL website

            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")).Click();

            driver.FindElement(By.ClassName("cb-button")).Click();

            IWebElement InputFrom = driver.FindElement(By.Name("InputFrom"));
            InputFrom.SendKeys("Harlesden");

            IWebElement InputTo = driver.FindElement(By.Name("InputTo"));
            InputTo.SendKeys("Royal Victoria");

            IWebElement PlanJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            PlanJourneyButton.Click();

            driver.Quit();
        }
    }
}