using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class MainPage
    {

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);      
        }

        public void clickSalesSection()
        {
            driver.FindElement(By.CssSelector("#sales_menu_item > a > span:nth-child(2)")).Click();
        }

        public void clickDigitalAvailsSubSection()
        {
            driver.FindElement(By.CssSelector("#ko_binding_layer > div.menu_tile_panel > div:nth-child(5) > a > div > div")).Click();
        }

        public void clickSearch()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div[4]/div[1]/div[2]/span[2]")).Click();
        }

        public void clickSelectAvials()
        {
            driver.FindElement(By.CssSelector("#digital_avails_datatable > tbody > tr:nth-child(1) > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("#digital_avails_datatable > tbody > tr:nth-child(2) > td:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector("#digital_avails_datatable > tbody > tr:nth-child(3) > td:nth-child(2)")).Click();
        }

        public void clickAddToCart()
        {
            driver.FindElement(By.CssSelector("#avails_cart_add > div > span")).Click();
        }

        public void clickAvilableActions()
        {
            driver.FindElement(By.CssSelector("#avails_actions > div > span")).Click();
        }

        public void clickNewCampaign()
        {
            driver.FindElement(By.CssSelector("#new_avails_campaign")).Click();
        }
    }
}
