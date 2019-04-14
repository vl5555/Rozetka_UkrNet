using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Net.Mail;

namespace UkrNet
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            //driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ukr.net/");
        }

        [TearDown]
        public void CloseDriver()
        {
            //driver.Quit();
        }

        [Test]
        public void Test1()
        {
            IWebElement iframe = driver.FindElement(By.XPath("//iframe[@name='mail widget']"));
            driver.SwitchTo().Frame(iframe);

            IWebElement login = driver.FindElement(By.Id("id-input-login"));
            login.SendKeys("test@test.ua");
            IWebElement password = driver.FindElement(By.Id("id-input-password"));
            password.SendKeys("123456");
            IWebElement submit = driver.FindElement(By.XPath("//button[@class='form__submit']"));
            submit.Click();

            IWebElement errorMessage = driver.FindElement(By.XPath("//p[@class='form__error form__error_internal form__error_visible']"));

            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {

        }

        public void SetImplicitWait(IWebDriver driver, int timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        public bool IsElementPresent(IWebElement element)
        {
            SetImplicitWait(driver, 2);
            try
            {
                var result = element.Displayed;
                SetImplicitWait(driver, 10);
                return true;
            }
            catch (NoSuchElementException)
            {
                SetImplicitWait(driver, 10);
                return false;
            }
            throw new Exception("Unexpected exception.");
        }
    }
}