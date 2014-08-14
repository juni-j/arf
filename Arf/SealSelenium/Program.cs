using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


namespace SealSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("http://www.bing.com");
            driver.Manage().Window.Maximize();

            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
            searchInput.SendKeys("cute seals");
            searchInput.SendKeys(Keys.Enter);
            driver.Close();
        }
    }
}


//namespace Test {

//    [TestFixture()]
//    public class testEtt {

//        //[SetUp]
//        //public void Init (){
//        //IWebDriver driver = new FirefoxDriver();
//        //}

//        [Test]
//        public void searchForSeals(){
//            IWebDriver driver = new FirefoxDriver();
//            driver.Navigate().GoToUrl("http://www.bing.com");
//            driver.Manage().Window.Maximize();

//            IWebElement searchInput = driver.FindElement(By.Id("sb_form_q"));
//            searchInput.SendKeys("cute seals");
//            searchInput.SendKeys(Keys.Enter);
//            driver.Close();
//        }

//        //[TearDown]
    
//    }


//}