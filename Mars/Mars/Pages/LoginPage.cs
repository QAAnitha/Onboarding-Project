

using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        LoginPage loginpageobj;
        public LoginPage(IWebDriver driver)
        {
            //Initialize Driver Object 
            this.driver = driver;
        }
        public void LoginActions()
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            try
            {
                // Click SignIn 
                IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                SignInButton.Click();

                //Identify Emailaddress Textbox and enter valid Email Address
                IWebElement Emailaddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                Emailaddress.SendKeys("anithainfo9@gmail.com");

                //Identify Password TextBox and Enter valid Password
                IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                Password.SendKeys("567890");

                //Identify Login Button and click
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();

            }
            catch(Exception ex)
            {
                Assert.Fail("Portal Doesnot launch", ex.Message);
            }


           

        }

        }
    }

