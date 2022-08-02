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
    public class Certifications
    {
        public IWebDriver driver;
        Certifications Certificationsobj;

        public Certifications(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NavigateToCertificationsTab()
        {
            string CertificationsTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]";
            WaitHelpers.WaitTobeClickable(driver, "XPath", CertificationsTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }
       
        public void AddCertification(string Certificate, string From, string Year)
        {
            //Click AddNew Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

            //Identify Certificate TextBox and enter Certificate
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Certificate");

            //Identify CertifiedFrom TextBox and enter Institutename
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("From");


            //Click and choose Year from Dropdown
            IWebElement addcertyear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            SelectElement selectcertyear = new SelectElement(addcertyear);
            selectcertyear.SelectByValue(Year);

            //Click Add Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

        }

        public string newCertificate()
        {
            IWebElement newCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newCertificate.Text;

        }

        public string newCertificateFrom()
        {
            IWebElement newCertificateFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return newCertificateFrom.Text;
        }

        public string newCertificateYear()
        {
            IWebElement newCertificateYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return newCertificateYear.Text;
        }

        public void EditCertification(string Certificate, string From, string Year)
        {
            string editCertificationsymbol = "//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i";
            WaitHelpers.WaitToBeVisible(driver, "XPath", editCertificationsymbol, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));


            //Edit Certificate
            IWebElement editcertificate = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input"));
            editcertificate.Clear();
            editcertificate.SendKeys(Certificate);


            //Edit CertificateFrom
            IWebElement editcertificatefrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input"));
            editcertificatefrom.Clear();
            editcertificatefrom.SendKeys(From);

            //Edit CertificationYear
            IWebElement editCertificateYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
            SelectElement selectEditYear = new SelectElement(editCertificateYear);
            selectEditYear.SelectByValue(Year);

            //Click on Update Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        public string editedCertificate()
        {
            IWebElement editedCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedCertificate.Text;
        }

        public string editedCertificateFrom()
        {
            IWebElement editedCertificateFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return editedCertificateFrom.Text;
        }

        public string editedCertificateYear()
        {
            IWebElement editedCertificateYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return editedCertificateYear.Text;
        }

        public void DeleteCertificate(string Certificate)
        {
            //Click DeleteButton
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i")).Click();
        }

        public string deletedCertificate()
        {
            IWebElement deletedCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return deletedCertificate.Text;
        }
        
    }

}