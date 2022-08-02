using Mars.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages.Profilepages
{
    public class Languages
    {
        public IWebDriver driver;
        Languages Languagesobj;
        public Languages(IWebDriver driver)
        {
           
            this.driver = driver;
        }
        public void NavigateToLanguageTab()

        {
            string Languagetab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
            WaitHelpers.WaitTobeClickable(driver, "Xpath", Languagetab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
        }

        public void AddLanguages(string language,string languagelevel)
        {
            //Click on AddNew Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();



            //Identify AddLanguageTextBox and enter Language
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(language);
           


            //Select ChooseLanguageLevel Dropdown

            //driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")).Click();

            IWebElement dropdownlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement selectlevel = new SelectElement(dropdownlanguage);
            selectlevel.SelectByValue(languagelevel);

            //Click Add Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
       

        }

        public string newLanguage()
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;
        }

        public string newLanguageLevel()
        {
            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
            return newLanguageLevel.Text;


        }

        public void EditLanguage(string Language,string languagelevel)
        {
            string editsymbol = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i";
            WaitHelpers.WaitToBeVisible(driver,"XPath", editsymbol,5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Edit Language
            IWebElement language = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            language.Clear();
            language.SendKeys(Language);

            //Edit Level
            IWebElement editlevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            SelectElement updatelevel = new SelectElement(editlevel);
            updatelevel.SelectByValue(languagelevel);


            //Click on Update button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

        }
        

        public string editedLanguage()
        {
            IWebElement editedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedLanguage.Text;
        }

        public string editedLanguageLevel()
        {
            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editedLanguageLevel.Text;
        }
        

        public void DeleteLanguage(string language)
        {
            //Click Delete Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();

        }

        public string deletedLanguage()
        {
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedLanguage.Text;
        }


    }



}

