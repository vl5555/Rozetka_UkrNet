using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rozetka
{
    public class MainPage
    {
        IWebDriver driver;

        private readonly string laptopsAndComputers = "//ul[@class='menu-categories menu-categories_type_main']/li[1]/a";
        private readonly string asus = "//a[@href='https://rozetka.com.ua/notebooks/asus/c80004/v004/']";
        private readonly string shopingCart = "//a[@href='https://rozetka.com.ua/cart/']";
        private readonly string shopingCartPopUp = "//div[@class='header-actions__dummy-content header-actions__dummy-content_type_cart']";

        public IWebElement LaptopsAndComputers
        {
            get
            {
                return driver.FindElement(By.XPath(laptopsAndComputers));
            }
        }

        public IWebElement Asus
        {
            get
            {
                return driver.FindElement(By.XPath(asus));
            }
        }

        public IWebElement ShopingCart
        {
            get
            {
                return driver.FindElement(By.XPath(shopingCart));
            }
        }

        public IWebElement ShopingCartPupUp
        {
            get
            {
                return driver.FindElement(By.XPath(shopingCartPopUp));
            }
        }
    }
}
