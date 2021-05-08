using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using POMExample.Data;

namespace POMExample
{
    public class TestClass
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
   
        [Test]
        public void BroadsignTest()
        {
            //START OF PRECONDITION SECTION

            //Open browser and got to Ayuda website
            HomePage home = new HomePage(driver);
            MainPage main = new MainPage(driver);
            home.goToPage();

            //setting up wait parameter
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            //Wait for page to load
            WaitForPageLoad();

            //Enter username
            IWebElement userName = driver.FindElement(By.CssSelector("#UserName"));
            userName.Click();
            userName.SendKeys(DataInput.userName);

            //Enter password
            IWebElement password = driver.FindElement(By.CssSelector("#Password"));
            password.Click();
            password.SendKeys(DataInput.password);

            //Click login
            driver.FindElement(By.CssSelector("#login_button > span.action_icon.icon_right")).Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

           //Cick on "Sales"
            main.clickSalesSection();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Click on "Digital Avails" subsection
            main.clickDigitalAvailsSubSection();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Click on search
            main.clickSearch();

            //Wait for list to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Select first 3 Avails
            main.clickSelectAvials();

            //Select "Add To Cart"
            main.clickAddToCart();

            //Select "Avilable Actions"
            main.clickAvilableActions();

            //Select "New Campaign"
            main.clickNewCampaign();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //END OF PRECONDITION SECTION

            //New Campign windos appear - Input name
            IWebElement clickElement;
            
            //Input name
            clickElement = driver.FindElement(By.CssSelector("#Name"));
            clickElement.Click();
            clickElement.SendKeys(DataInput.name + "_" + DateTime.Now.ToString("MM/dd/yyyy_HH:mm:ss"));

            //open advertizer window
            clickElement = driver.FindElement(By.CssSelector("#field_AdvertiserID > div.field.even.value > div.autocomplete_holder > div"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Search advertizer
            clickElement = driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/div[4]/div[1]/div[2]"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);
            
            //select advertizer
            clickElement = driver.FindElement(By.CssSelector("#link_advertisers_datatable > tbody > tr:nth-child(5)"));
            clickElement.Click();

            //Open agency window
            clickElement = driver.FindElement(By.CssSelector("#field_AgencyID > div.field.even.value > div.autocomplete_holder > div"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Search agency
            clickElement = driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/div[4]/div[1]/div[2]"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(1000);

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#link_agencies_datatable > tbody > tr:nth-child(9) > td.Name.sorting_1")));

            //select advertizer
            clickElement = driver.FindElement(By.CssSelector("#link_agencies_datatable > tbody > tr:nth-child(9) > td.Name.sorting_1"));
            clickElement.Click();

            //Input billing amount
            clickElement = driver.FindElement(By.CssSelector("#BillingAmount"));
            clickElement.Click();
            clickElement.SendKeys(DataInput.billingAmout);

            //Input Recognition Date
            clickElement = driver.FindElement(By.CssSelector("#RecognitionDateUtc_date"));
            clickElement.Click();
            clickElement.SendKeys(DataInput.recognitionDate);

            //Open Specialist Agency window
            clickElement = driver.FindElement(By.CssSelector("#field_SpecialistAgencyID > div.field.even.value > div.autocomplete_holder > div"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Search Specialist Agency
            clickElement = driver.FindElement(By.XPath("/html/body/div[6]/div/div[2]/div[4]/div[1]/div[2]"));
            clickElement.Click();

            //Wait for page to load
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#link_agencies_datatable > tbody > tr:nth-child(9) > td.Name.sorting_1")));

            //select Specialist Agency
            clickElement = driver.FindElement(By.CssSelector("#link_agencies_datatable > tbody > tr:nth-child(9) > td.Name.sorting_1"));
            clickElement.Click();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Input Product Date
            clickElement = driver.FindElement(By.CssSelector("#CampaignProductID_autocomplete"));
            clickElement.Click();
            clickElement.SendKeys(DataInput.product);

            //Input Ref. number - Number is randomly generated
            clickElement = driver.FindElement(By.CssSelector("#SalesContract_ReferenceNumber"));
            clickElement.Click();
            clickElement.SendKeys(randomRefNo());

            //Input receved date
            clickElement = driver.FindElement(By.CssSelector("#ReceivedDateUtc_date"));
            clickElement.Click();
            clickElement.SendKeys(DateTime.Now.ToString("MM/dd/yyyy"));
            
            //click save button
            clickElement = driver.FindElement(By.CssSelector("#new_campaign_dialog_confirm"));
            clickElement.Click();

            WaitForPageLoad();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#confirmation_modal > div.modal-footer > div.btn.btn-primary.btn_confirmation")));

            //confirm changes
            clickElement = driver.FindElement(By.CssSelector("#confirmation_modal > div.modal-footer > div.btn.btn-primary.btn_confirmation"));
            clickElement.Click();

            //Wait for page to load - Wait for proposals page to load and verify it has loaded
            WaitForPageLoad();
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#field_display_StartDate > div.field.even.value")));

            //Verify that start date is on the screen
            string bodyText = driver.FindElement(By.CssSelector("#field_display_StartDate > div.field.even.value")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.startDate);

            //Verify that end date is on the screen
            bodyText = driver.FindElement(By.CssSelector("#field_display_EndDate > div.field.even.value")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.endDate);

            //Click on Segements tab on side bar
            clickElement = driver.FindElement(By.CssSelector("#tab_segments > div"));
            clickElement.Click();

            //wait till Segments page loads
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#sales_contract_items_datatable_wrapper > div.table_wrapper_header > div > span")));

            //Click on side arrow on first element
            clickElement = driver.FindElement(By.CssSelector("#sales_contract_items_datatable > tbody > tr.odd > td:nth-child(1) > div"));
            clickElement.Click();

            //wait till Segments page loads
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#sales_contract_items_datatable > tbody > tr.odd > td.StartDate")));

            //Verify that start date on Segments section
            bodyText = driver.FindElement(By.CssSelector("#sales_contract_items_datatable > tbody > tr.odd > td.StartDate")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.startDate_v2);

            //Verify that end date on Segments section
            bodyText = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[27]/div/div[3]/div[1]/div/div[9]/div[2]/table/tbody/tr[1]/td[7]")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.endDate_v2);

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div/div[2]/div[27]/div/div[3]/div[1]/div/div[9]/div[2]/table/tbody/tr[2]/td/div/div/div[5]/div[2]/table/tbody/tr/td[5]")));

            //Verify that start date on Digital Booking lines
            bodyText = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[27]/div/div[3]/div[1]/div/div[9]/div[2]/table/tbody/tr[2]/td/div/div/div[5]/div[2]/table/tbody/tr/td[5]")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.startLongDate);

            //Verify that end date on Digital Booking lines
            bodyText = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[27]/div/div[3]/div[1]/div/div[9]/div[2]/table/tbody/tr[2]/td/div/div/div[5]/div[2]/table/tbody/tr/td[6]")).Text;
            bodyText = bodyText.Replace('"', ' ').Trim();
            Assert.AreEqual(bodyText, DataInput.endLongDate);

            //END OF MAIN SECTION
        }


        protected void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }



    public string randomRefNo()
        {
            var chars = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }
}
