using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomationWithSelenium.Base;
using TestAutomationWithSelenium.Constant;

namespace TestAutomationWithSelenium
{
    [Binding,Scope(Feature = "Lolaflora")]
    public sealed class LolafloraTestSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;
        public static IWebDriver WebDriver { get; set; }
        Util.Browser browser = new Util.Browser();
        BasePage bsp;


        public LolafloraTestSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            browser.SetUp();
            bsp = new BasePage(WebDriver);
        }

        [StepDefinition("'(.*)' adresine gidilir")]
        public void GoToUrl(string url)
        {
            bsp.GoToUrl(url);
        }

        [StepDefinition("Email alanına '(.*)' yazılır")]
        public void SetEmailAreaByValue(string value)
        {
            bsp.SendKeys(Constants.txtEmail, value);
        }

        [StepDefinition("Password alanına  '(.*)' yazılır")]
        public void SetPasswordByValue(string value)
        {
            bsp.SendKeys(Constants.txtPassword, value);
        }

        [StepDefinition("Sign In elementine tıklanır")]
        public void ClickTheElement()
        {
            bsp.ClickElement(Constants.btnLogin);
        }

        [StepDefinition("Çıkan popup kapatılır")]
        public void CloseThePopup()
        {
            bsp.ClickElement(Constants.btnCloseIcon);
        }

        [StepDefinition("Logout butonuna tıklanır")]
        public void ClickTheLogout()
        {
            bsp.ClickElement(Constants.btnLogout);
        }

        [StepDefinition("'(.*)' uyarısı alınır")]
        public void GetResultText(string expectedValue)
        {
            string actualValue = bsp.GetText(Constants.txtModelBody);
            Assert.IsTrue(actualValue.Contains(expectedValue));
        }            
        

        [StepDefinition("Geçersiz email adresi için '(.*)' uyarısı alınır")]
        public void GetEmailError(string expected)
        {
            string actual = bsp.GetText(Constants.txtEmailError);
            Assert.IsTrue(expected == actual);
        }

        [StepDefinition("Geçersiz password için '(.*)' uyarısı alınır")]
        public void GetPasswordError(string expected)
        {
            string actual = bsp.GetText(Constants.txtPasswordError);
            bsp.AssertEqual(expected, actual);
        }        

        [StepDefinition("Url '(.*)' ana sayfa olduğu kontrol edilir")]
        public void CheckTheUrl(string expected)
        {
            string actual = bsp.GetCurrentUrl();
            bsp.AssertEqual(expected, actual);
        }

        [StepDefinition("Şifremi unuttum elementine tıklanır")]
        public void ClickTheForgotPassword()
        {
            bsp.ClickElement(Constants.btnForgotPassword);
        }

        [StepDefinition("Mail adresi '(.*)' girilir")]
        public void SetTheMailAddress(string mail)
        {
            bsp.SendKeys(Constants.txtForgotMail, mail);
        }

        [StepDefinition("Send butonuna tıklanır")]
        public void ClickToSend()
        {
            bsp.ClickElement(Constants.btnSend);
        }

        [StepDefinition("Unutulan şifre için '(.*)' uyarısı alınır")]
        public void GetWarningForForgotPassword(string expected)
        {
            string actual = bsp.GetText(Constants.txtPasswordRecoveryResult);
            bsp.AssertEqual(expected, actual);
        }

        [StepDefinition("Email doğrumanadı '(.*)' uyarısı alınır")]
        public void GetWarningForInvalidMail(string expected)
        {
            string actual = bsp.GetText(Constants.txtValidationResultMail);
            bsp.AssertEqual(expected, actual.Trim());
        }

        [AfterScenario]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
