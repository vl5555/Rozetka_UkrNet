using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace Rozetka
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
        }

        [Test]
        public void Test1()
        {
            string expectedResult = $"https://rozetka.com.ua/notebooks/asus/c80004/v004/";

            MainPage element = new MainPage();

            Actions actions = new Actions(driver);
            actions.MoveToElement(element.LaptopsAndComputers).MoveToElement(element.Asus).Click().Perform();

            Assert.AreEqual(driver.Url , expectedResult,"Url of open page does not match to expected result");
        }

        [Test]
        public void Test2()
        {
            MainPage element = new MainPage();
            
            Actions actions = new Actions(driver);
            actions.MoveToElement(element.ShopingCart).MoveToElement(element.ShopingCartPupUp). Perform();
          
        }
    }
}