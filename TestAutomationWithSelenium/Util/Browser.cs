using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationWithSelenium.Util
{
    class Browser
    {
        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--disable-notifications");
            options.AddArguments("enable-automation");
            LolafloraTestSteps.WebDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
            LolafloraTestSteps.WebDriver.Navigate().GoToUrl("https://www.google.com/");
        }
    }
}
