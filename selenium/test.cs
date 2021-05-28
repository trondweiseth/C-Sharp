using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras;


namespace SILAutomatisering
{
    public class Run
    {
        private FirefoxDriver driver;
        //private EdgeDriver driver;

        [OneTimeSetUp]
        public void SetupClass()
        {
            _driver = new InternetExplorerDriver();
        }

        [OneTimeTearDown]
        public void TeardownClass()
        {
            driver.Close(); // Lukker IE
            driver.Quit(); // Lukker kommandolinje for å kjøre IE
        }

        [Test]
        public void RunTest()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");
            driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
            driver.FindElement(By.CssSelector("ul:nth-child(3) > .tree-branch:nth-child(1) > a")).Click();
            driver.FindElement(By.LinkText("Simple Form Demo")).Click();
            driver.FindElement(By.Id("user-message")).Click();
            driver.FindElement(By.Id("user-message")).SendKeys("Test");
            driver.FindElement(By.CssSelector(".btn:nth-child(2)")).Click();
            driver.FindElement(By.Id("sum1")).Click();
            driver.FindElement(By.Id("sum1")).SendKeys("a");
            driver.FindElement(By.Id("sum2")).Click();
            driver.FindElement(By.Id("sum2")).SendKeys("b");
            driver.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector("ul:nth-child(3) > .tree-branch:nth-child(1) > a")).Click();
            driver.FindElement(By.LinkText("Checkbox Demo")).Click();
            driver.FindElement(By.Id("isAgeSelected")).Click();
            driver.FindElement(By.CssSelector(".checkbox:nth-child(5) .cb1-element")).Click();
            driver.FindElement(By.Id("check1")).Click();
            driver.FindElement(By.CssSelector(".tree-branch:nth-child(3) > a")).Click();
            driver.FindElement(By.LinkText("Table Data Download")).Click();
            driver.FindElement(By.LinkText("Progress Bars & Sliders")).Click();
            driver.FindElement(By.LinkText("Drag & Drop Sliders")).Click();
            {
                var element = driver.FindElement(By.Name("range"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.Name("range"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.Name("range"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.Name("range")).SendKeys("85");
            driver.FindElement(By.Name("range")).Click();
            driver.FindElement(By.CssSelector(".tree-branch:nth-child(4) > .tree-indicator")).Click();
            driver.FindElement(By.CssSelector(".tree-branch:nth-child(2) > a")).Click();
            driver.FindElement(By.LinkText("JQuery Date Picker")).Click();
            driver.FindElement(By.Id("from")).Click();
            driver.FindElement(By.LinkText("1")).Click();
            driver.FindElement(By.Id("to")).Click();
            driver.FindElement(By.LinkText("9")).Click();
        }
    }
}
