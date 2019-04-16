using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using SeleniumExtras.PageObjects;
using System.Text;

namespace UkrNet
{
    public class MainPage
    {
        IWebDriver driver;

        private const string laptopsAndComputers = "//ul[@class='menu-categories menu-categories_type_main']/li[1]/a";
        private const string asus = "//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']";
        private const string shopingCart = "//a[@href='https://rozetka.com.ua/cart/']";
        private const string shopingCartPopUp = "//div[@class='header-actions__dummy-content header-actions__dummy-content_type_cart']";

        public IWebElement LaptopsAndComputers => driver.FindElement(By.XPath(laptopsAndComputers));
        public IWebElement Asus => driver.FindElement(By.XPath(asus));
        public IWebElement ShopingCart => driver.FindElement(By.XPath(shopingCart));
        public IWebElement ShopingCartPupUp => driver.FindElement(By.XPath(shopingCartPopUp));
    }
}
