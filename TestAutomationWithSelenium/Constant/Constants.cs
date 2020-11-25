using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationWithSelenium.Constant
{
    public class Constants
    {
        #region WebDriver
        public static IWebDriver driver;
        public static WebDriverWait wait;
        #endregion


        #region Login Logout
        public static By txtEmail = By.CssSelector("input[id = 'EmailLogin']");
        public static By txtPassword = By.CssSelector("input[id='Password']");
        public static By btnLogin = By.XPath("//*[@class='btn btn-primary btn-lg pull-right login__btn js-login-button']");
        public static By txtModelBody = By.XPath("//div[@class='modal-body']");
        public static By txtEmailError = By.Id("EmailLogin-error");
        public static By txtPasswordError = By.Id("Password-error");
        public static By btnLogout = By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/nav/ul/li[4]/a/span");
        public static By btnCloseIcon = By.XPath("//span[@class='icon-close']");
        public static By btnForgotPassword = By.XPath("//*[contains(text(),'Forgot Password')]");
        public static By txtForgotMail = By.XPath("//*[@id='Mail']");
        public static By btnSend = By.XPath("//*[@class='btn btn-lg btn-primary form-password-recovery__btn js-password-recovery-button']");
        public static By txtPasswordRecoveryResult = By.XPath("//div[contains(@class,'password-recovery-result js-password-recovery-result')]");
        public static By txtValidationResultMail = By.XPath("//*[@id='Mail-error']");
        #endregion




    }
}
