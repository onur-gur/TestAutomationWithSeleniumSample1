using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationWithSelenium.Base
{
    class BasePage
    {
        IWebDriver webDriver;
        WebDriverWait wait;
        IWebElement webElement;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            this.wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
        }

        /// <summary>
        /// Dynamic Wait
        /// </summary>
        /// <param name="by"></param>
        public void WaitElement(By by)
        {

            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        /// <summary>
        /// Find Element
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IWebElement FindElement(By by)
        {
            WaitElement(by);
            return webDriver.FindElement(by);
        }

        /// <summary>
        /// Hover Element
        /// </summary>
        /// <param name="by"></param>
        public void HoverElement(By by)
        {
            WaitElement(by);

            Actions actions = new Actions(webDriver);
            actions.MoveToElement(webElement).Build().Perform();

        }

        /// <summary>
        /// Click Element
        /// </summary>
        /// <param name="by"></param>
        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        /// <summary>
        /// Send Text
        /// </summary>
        /// <param name="by"></param>
        /// <param name="text"></param>
        public void SendKeys(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }

        /// <summary>
        /// Get Text Element
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public string GetText(By by)
        {
            return FindElement(by).Text;
        }

        /// <summary>
        /// Assertion 
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public void AssertEqual(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Go to Url
        /// </summary>
        /// <param name="url"></param>
        public void GoToUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Get Url
        /// </summary>
        /// <returns></returns>
        public string GetCurrentUrl()
        {
            return webDriver.Url;
        }

        /// <summary>
        /// Back Page(previous page)
        /// </summary>
        public void BackPage()
        {
            webDriver.Navigate().Back();
        }
    }
}
