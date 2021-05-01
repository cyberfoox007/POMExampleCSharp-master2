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
        public void SearchTextFromAboutPage()
        {
            //To the person reading this code: Hello my name is Nicolas Vicenzo and I am 
            //writing this code for my application to the QA position at Octave Group.
            //Alert have coded a test of the Spotify Web Player in this code and I have done
            //all the tests I cam capable of doing in testing the functions of the web player.
            //I have tested as much of the functions as I could as well as putting in
            //as much of the verifications as I could think of. I am well aware that some are missing
            //or not very refined. All NUnit and Selenium WebDriver packages are installed in this project
            //and have run well on my system at the rime of this code (That is May 1st, 2021)
            //I hope this code is satisfactory to you
            //If you have questions or with to contact me please contact me at n.vicenzo@gmail.com
            //or at 514-572-8307 (Montreal, quebec, Canada area code)
            //Thank you and have a great day


            //IMPPORTANT: Please use the breakpoint to run this application step by step

            //Go to Spotify WebPlayer
            HomePage home = new HomePage(driver);
            MainPage main = new MainPage(driver);
            home.goToPage();

            //Wait for page to load
            WaitForPageLoad();

            //Go to log in page
            home.goToLogInPage();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Enter username
            IWebElement userName = driver.FindElement(By.CssSelector("#login-username"));
            userName.Click();
            userName.SendKeys("???");

            //Enter password
            IWebElement password = driver.FindElement(By.CssSelector("#login-password"));
            password.Click();
            password.SendKeys("???");

            //Click login
            driver.FindElement(By.CssSelector("#login-button")).Click();
            //I would put a function here to verify if login functions is working but not sure on how to do it

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Remove Cookie Notice
            main.clickCookieNoticeX();

            //Select playlist
            main.selectPlaylist();

            //Wait for page to load
            WaitForPageLoad();
            Thread.Sleep(5000);

            //Click on play button - music should play
            main.clickPlayButton();
            //I would put a function here to verify if play functions is working but not sure on how to do it

            //Play song for 5 seconds
            Thread.Sleep(5000);
            
            //Click on Pause Button to pause - music should stop
            main.clickPauseButton();
            //I would put a function here to verify if pause functions is working but not sure on how to do it

            //wait for 5 seconds
            Thread.Sleep(5000);

            //Click on play button - music should play
            main.clickPlayButton();
            //I would put a function here to verify if play functions is working but not sure on how to do it

            //Click on next button 5 times
            for(int i = 0; i <= 4; i++)
            {
                main.clickNextButton();
                Thread.Sleep(5000);
                //I would put a function here to verify if next functions is working but not sure on how to do it
            }

            //Click on back button 3 times to go back 2 songs back
            for (int i = 0; i <= 2; i++)
            {
                main.clickBackButton();
                Thread.Sleep(500);
                //I would put a function here to verify if back functions is working but not sure on how to do it
            }

            //Click shuffle button - Shuffle button should be enabled
            main.clickShuffleButton();
            //I would put a function here to verify if  functions is working but not sure on how to do it

            //Click on next button 5 times - Next few songs should be random
            for (int i = 0; i <= 4; i++)
            {
                main.clickNextButton();
                Thread.Sleep(5000);
                //I would put a function here to verify if next functions is working but not sure on how to do it
            }

            //Click shuffle button - Shuffle button should be disabled
            main.clickShuffleButton();
            //I would put a function here to verify if shuffle functions is working but not sure on how to do it

            //Click loop button - Loop button is enabled
            main.clickLoopButton();
            //I would put a function here to verify if loop functions is working but not sure on how to do it

            //wait for 5 seconds
            Thread.Sleep(5000);

            //Click loop button - Loop song infinitely is enabled
            main.clickLoopButton2();
            //I would put a function here to verify if loop functions is working but not sure on how to do it

            //wait for 5 seconds
            Thread.Sleep(5000);

            //Click loop button - Loop song infinitely is enabled
            main.clickLoopButton2();
            //I would put a function here to verify if loop functions is working but not sure on how to do it

            //wait for 5 seconds
            Thread.Sleep(5000);
        }

        protected void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }
}
