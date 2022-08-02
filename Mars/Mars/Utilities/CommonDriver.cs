using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Utilities
{
    [TestFixture]
    public class CommonDriver
    {

        public  IWebDriver driver;
        LoginPage loginpageobj;

        public CommonDriver()
        {
            loginpageobj = new LoginPage(driver);
        }

        [OneTimeSetUp]
        public void Login()
        {
            //Open Chromedriver
            driver = new ChromeDriver();
            loginpageobj.LoginActions();

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}

