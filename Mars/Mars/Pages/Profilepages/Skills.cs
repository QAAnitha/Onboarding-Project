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
    public class Skills  
    {
        public IWebDriver driver;
        Skills Skillsobj;

        public Skills(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void NavigateToSkillsTab()
        {
            string SkiilsTab = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]";
            WaitHelpers.WaitTobeClickable(driver, "XPath", SkiilsTab, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        }

        public void AddSkills(string Skill,string Skilllevel)
        {
            //Click on AddNew Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Identify AddSkill Textbox and enter Skill
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(Skill);

            //Click Skilllevel
            IWebElement skilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement Selectskill = new SelectElement(skilllevel);
            Selectskill.SelectByValue(Skilllevel);

            //Click on Add Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

         public string newSkill()
        {
            string skillvisible = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]";
            WaitHelpers.WaitToBeVisible(driver, "XPath", skillvisible, 5);
            IWebElement newSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        } 

            public string newSkilllevel()
        {
            string newskilllevelvisible = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]";
            WaitHelpers.WaitToBeVisible(driver, "XPath", newskilllevelvisible, 5);
            IWebElement newSkilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return newSkilllevel.Text;
        }
           
        public void EditSkill(string Skill, string Skilllevel)
        {
            string EditSkillsymbol = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i";
            WaitHelpers.WaitToBeVisible(driver, "XPath", EditSkillsymbol, 5);
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Edit Skill
            IWebElement Skillname = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            Skillname.Clear();
            Skillname.SendKeys(Skill);

            //Edit skilllevel
            IWebElement editskilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            SelectElement Selectnewskill = new SelectElement (editskilllevel);
            Selectnewskill.SelectByValue(Skilllevel);

            //Click on Update Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

;        }
            
        public string editedSkill()
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }

        public string editedSkilllevel()
        {
            IWebElement editedSkilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return editedSkilllevel.Text;
        }


        public void DeleteSkill(string Skill)
        {
            //Click Delete Button
            driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();

        }


        public string deletedSkill()
        {
            IWebElement deletedSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return deletedSkill.Text;
        }
            }


}
