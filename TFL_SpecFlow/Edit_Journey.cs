using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFL_SpecFlow
{
    class Edit_Journey
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            IWebElement InputFrom = driver.FindElement(By.Name("InputFrom"));
            InputFrom.SendKeys("");

            IWebElement InputTo = driver.FindElement(By.Name("InputTo"));
            InputTo.SendKeys("InvalidJourneyLocationEntered");

            IWebElement PlanJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            PlanJourneyButton.Click();

            driver.Navigate().GoToUrl("");
            Thread.Sleep(3000);

            //Edit the Journey & Click button

            IWebElement EditJourneyButton = driver.FindElement(By.XPath(""));
            EditJourneyButton.Click();

            IWebElement NewDestination = driver.FindElement(By.XPath(""));
            NewDestination.SendKeys("Oxford Circus Underground Station");

            IWebElement PlanaJourneyButtonAgain = driver.FindElement(By.XPath(""));
            PlanaJourneyButtonAgain.Click();

            driver.Quit();
        }
    }
}
