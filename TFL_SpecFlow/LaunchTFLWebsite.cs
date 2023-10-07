using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


public class LaunchTFLWebsite
{
    static void Main()
    {
            //Scenario
            //Given a user navigates to the TFL website
            //When the user enters the URL correctly
            //Then the website is generated successfully

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")).Click();
            driver.FindElement(By.ClassName("cb-button")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
}
