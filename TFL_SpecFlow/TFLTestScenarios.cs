using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFL_SpecFlow
{
    [TestClass]
    public class ValidJourney
    {
        //Scenario - Given I navigate to the TFL Website
        //When I click on the Plan a Journey widget
        //and I select a valid station in both the Input From/Input To fields
        //Then the valid journey is displayed

        [TestMethod]
        public void Test_ValidJourney()
        { 
            IWebDriver driver = new EdgeDriver();
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
        [TestMethod]
        public void Test_InvalidJourney()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            IWebElement InputFrom = driver.FindElement(By.Name("InputFrom"));
            InputFrom.SendKeys("Knightsbridge");

            IWebElement InputTo = driver.FindElement(By.Name("InputTo"));
            InputTo.SendKeys("InvalidJourneyLocationEntered");

            IWebElement PlanJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            PlanJourneyButton.Click();

            driver.Quit();
        }
        [TestMethod]
        public void Test_EditJourney()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            IWebElement InputFrom = driver.FindElement(By.Name("InputFrom"));
            InputFrom.SendKeys("Harlesden");

            IWebElement InputTo = driver.FindElement(By.Name("InputTo"));
            InputTo.SendKeys("InvalidJourneyLocationEntered");

            IWebElement PlanJourneyButton = driver.FindElement(By.Id("plan-journey-button"));
            PlanJourneyButton.Click();

            driver.Navigate().GoToUrl("");
            Thread.Sleep(3000);

            //Edit the Journey & Click button

            IWebElement EditJourneyButton = driver.FindElement(By.XPath("Wembley Park"));
            EditJourneyButton.Click();

            IWebElement NewDestination = driver.FindElement(By.XPath(""));
            NewDestination.SendKeys("Oxford Circus Underground Station");

            IWebElement PlanaJourneyButtonAgain = driver.FindElement(By.XPath(""));
            PlanaJourneyButtonAgain.Click();

            driver.Quit();
        }
        [TestMethod]
        public void Test_Recents()
        {
            IWebDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://tfl.gov.uk");
            Thread.Sleep(3000);

            IWebElement RecentsTab = driver.FindElement(By.XPath("//*[@id=\"jp-recent-tab-home-small\"]/a"));
            RecentsTab.Click();

            //Recents Tab is displayed

            IWebElement RecentsList1 = driver.FindElement(By.XPath(""));
            RecentsList1.Click();

            driver.Quit();
        }
        [TestMethod]
        public void Test_NoLocations()
        {
            IWebDriver driver = new EdgeDriver();

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

    internal class TestClassAttribute : Attribute
    {
    }
}