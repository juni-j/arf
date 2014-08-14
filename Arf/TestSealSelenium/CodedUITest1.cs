using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace TestSealSelenium
{
    [TestClass]
    public class POAPostTest
    {
        [TestMethod]
        public void SearchForCuteSealsBing()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://www.bing.com");
            driver.Manage().Window.Maximize();

            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
            searchInput.SendKeys("cute seals");
            searchInput.SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.Close();

        }

        [TestMethod]
        public void SearchForCuteSealsGoogle()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();

            IWebElement searchInput = driver.FindElement(By.Id("gbqfq"));
            searchInput.SendKeys("cute seals");
            searchInput.SendKeys(OpenQA.Selenium.Keys.Enter);
            driver.Close();

        }
    }
}
