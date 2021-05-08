using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        private IWebElement about;

        [FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        private IWebElement searchIcon;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://testinstance.ayudalabs.com/Juice/#DigitalAvails");
        }

        public void goToLogInPage()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__top-bar > header > div:nth-child(5) > button._3f37264be67c8f40fa9f76449afdb4bd-scss._1f2f8feb807c94d2a0a7737b433e19a8-scss")).Click();
        }
    }
}
