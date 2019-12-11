using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/index.php?route=common/home");
            driver.FindElement(By.LinkText("Laptops & Notebooks")).Click();
            driver.FindElement(By.LinkText("Show All Laptops & Notebooks")).Click();
            driver.FindElement(By.XPath("//img[@alt='HP LP3065']")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[4]/a/i")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Continue Shopping'])[1]/following::a[1]")).Click();
            driver.FindElement(By.Id("button-account")).Click();
            driver.FindElement(By.Id("input-payment-firstname")).Click();
            driver.FindElement(By.Id("input-payment-firstname")).Clear();
            driver.FindElement(By.Id("input-payment-firstname")).SendKeys("asd");
            driver.FindElement(By.Id("input-payment-lastname")).Click();
            driver.FindElement(By.Id("input-payment-lastname")).Clear();
            driver.FindElement(By.Id("input-payment-lastname")).SendKeys("asd");
            driver.FindElement(By.Id("input-payment-email")).Click();
            driver.FindElement(By.Id("input-payment-email")).Clear();
            driver.FindElement(By.Id("input-payment-email")).SendKeys("asd@asd.com");
            driver.FindElement(By.Id("input-payment-telephone")).Click();
            driver.FindElement(By.Id("input-payment-telephone")).Clear();
            driver.FindElement(By.Id("input-payment-telephone")).SendKeys("123");
            driver.FindElement(By.Id("button-guest")).Click();
            driver.FindElement(By.Id("button-shipping-method")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.Id("button-payment-method")).Click();
            driver.FindElement(By.Id("button-confirm")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
        }
        [Test]
        public void TheUntitledTestCaseTest1()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/index.php?route=common/home");
            driver.FindElement(By.LinkText("Show All Laptops & Notebooks")).Click();
            driver.FindElement(By.XPath("//img[@alt='HP LP3065']")).Click();
            driver.FindElement(By.Id("button-cart")).Click();
            driver.FindElement(By.Id("cart-total")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$122.00'])[2]/following::strong[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Continue Shopping'])[1]/following::a[1]")).Click();
            driver.FindElement(By.Id("button-account")).Click();
            driver.FindElement(By.Id("input-payment-firstname")).Click();
            driver.FindElement(By.Id("input-payment-firstname")).Clear();
            driver.FindElement(By.Id("input-payment-firstname")).SendKeys("asd");
            driver.FindElement(By.Id("input-payment-lastname")).Click();
            driver.FindElement(By.Id("input-payment-lastname")).Clear();
            driver.FindElement(By.Id("input-payment-lastname")).SendKeys("asd");
            driver.FindElement(By.Id("input-payment-email")).Click();
            driver.FindElement(By.Id("input-payment-email")).Clear();
            driver.FindElement(By.Id("input-payment-email")).SendKeys("asd@asd.com");
            driver.FindElement(By.Id("input-payment-telephone")).Click();
            driver.FindElement(By.Id("input-payment-telephone")).Clear();
            driver.FindElement(By.Id("input-payment-telephone")).SendKeys("123");
            driver.FindElement(By.Id("input-payment-zone")).Click();
            new SelectElement(driver.FindElement(By.Id("input-payment-zone"))).SelectByText("Caerphilly");
            driver.FindElement(By.Id("input-payment-zone")).Click();
            driver.FindElement(By.Id("button-guest")).Click();
            driver.FindElement(By.Id("button-shipping-method")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.Id("button-payment-method")).Click();
            driver.FindElement(By.Id("button-confirm")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
        }
        [Test]
        public void TheUntitledTestCaseTest2()
        {
            driver.Navigate().GoToUrl("https://demo.opencart.com/index.php?route=common/home");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Your Store'])[2]/following::button[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='$122.00'])[2]/following::strong[1]")).Click();
            driver.FindElement(By.XPath("//div[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[2]/i")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

}