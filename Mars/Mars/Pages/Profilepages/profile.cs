using Mars.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages.Profilepages
{
    public class profile
    {
        public IWebDriver driver;
        profile profileobj;
        

        public profile(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string getWelcomeText(IWebDriver driver)
        {
            WaitHelpers.WaitToBeVisible(driver, "Xpath", "//body/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]", 5);
            IWebElement WelcomeText = driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]"));
            return WelcomeText.Text;



        }
    }
}