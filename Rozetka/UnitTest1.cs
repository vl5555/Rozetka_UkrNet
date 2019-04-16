using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

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
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Quit();
        }

        [Test]
        public void MoveToAsusPage()
        {
            string expectedResult = $"https://rozetka.com.ua/notebooks/c80004/filter/producer=asus/";

            MainPage element = new MainPage();

            //IWebElement laptopsAndComputers = driver.FindElement(By.XPath("//ul[@class='menu-categories menu-categories_type_main']/li[1]/a"));
            //IWebElement asus = driver.FindElement(By.XPath("//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']"));

            Actions actions = new Actions(driver);
            //actions.MoveToElement(laptopsAndComputers).MoveToElement(asus).Click().Perform();
            actions.MoveToElement(element.LaptopsAndComputers).MoveToElement(element.Asus).Click().Perform();

            Assert.AreEqual(driver.Url , expectedResult,"Url of open page does not match to expected result");
        }

        [Test]
        public void BasketPopUpText()
        {
            string expectedElementText = "Ваша корзина пуста\r\nДобавляйте понравившиеся товары в корзину";
            MainPage element = new MainPage();

            //IWebElement shopingCart = driver.FindElement(By.XPath("//a[@href='https://rozetka.com.ua/cart/']"));
            //IWebElement shopingCartPopUp = driver.FindElement(By.XPath("//div[@class='header-actions__dummy-content header-actions__dummy-content_type_cart']"));
            
            Actions actions = new Actions(driver);
            //actions.MoveToElement(shopingCart).MoveToElement(shopingCartPopUp).Perform();
            actions.MoveToElement(element.ShopingCart).Perform();
                        
            string text = element.ShopingCartPupUp.Text;
            Console.WriteLine(text);

            Assert.AreEqual(text, expectedElementText, "Text doesn't match expected text");
        
          
        }
    }
}