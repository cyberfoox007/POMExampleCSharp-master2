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

        public void clickCookieNoticeX()
        {
            driver.FindElement(By.CssSelector("#onetrust-close-btn-container > button")).Click();
        }

        public void selectPlaylist()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__main-view > main > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > section > div > div > section:nth-child(1) > div._5aac821edb25f0e281f50522021abbe4-scss._6424f268be3505ebab663700d60ebaa6-scss > div > div > div._0f1a8f7fdd1d622cbfe4c283f4f5cd72-scss")).Click();
        }

        public void clickPlayFirstSong()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__main-view > main > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > section > div._235729a60d5e265806e8509d8633b779-scss > div:nth-child(3) > div > div.c27f49a483c85a5b88b3f37fb918e497-scss > div:nth-child(2) > div:nth-child(1) > div > div._7c993111016a33a158645119f8a6fb12-scss > div > span")).Click();
        }

        public void clickPlayLastSong()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__main-view > main > div.os-host.os-host-foreign.os-theme-spotify.os-host-resize-disabled.os-host-scrollbar-horizontal-hidden.main-view-container__scroll-node.os-host-transition.os-host-overflow.os-host-overflow-y > div.os-padding > div > div > div.main-view-container__scroll-node-child > section > div._235729a60d5e265806e8509d8633b779-scss > div:nth-child(3) > div > div.c27f49a483c85a5b88b3f37fb918e497-scss > div:nth-child(2) > div:nth-child(47) > div > div._7c993111016a33a158645119f8a6fb12-scss > div > span")).Click();
        }

        public void clickPlayButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button._82ba3fb528bb730b297a91f46acd37a3-scss > svg > path")).Click();
        }

        public void clickPauseButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button._82ba3fb528bb730b297a91f46acd37a3-scss > svg")).Click();
        }

        public void clickNextButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button.bf01b0d913b6bfffea0d4ffd7393c4af-scss")).Click();
        }

        public void clickBackButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button.bc13c597ccee51a09ec60253c3c51c75-scss > svg")).Click();
        }

        public void clickShuffleButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button._39234eb5c173f8b6de80ed73820b1be8-scss > svg")).Click();
        }

        public void clickLoopButton()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button.ebfd411a126f1e7bea6133f21b4ef88e-scss > svg")).Click();
        }
        public void clickLoopButton2()
        {
            driver.FindElement(By.CssSelector("#main > div > div.Root__top-container > div.Root__now-playing-bar > footer > div > div._985ee24884f107a290cef7577b8a8909-scss > div > div.player-controls__buttons > button.ebfd411a126f1e7bea6133f21b4ef88e-scss._46e671f2323a45b17a6f4a3d15c2961f-scss > svg")).Click();
        }

    }
}
