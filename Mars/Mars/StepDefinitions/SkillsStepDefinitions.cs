using Mars.Pages;
using Mars.Pages.Profilepages;
using Mars.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        Skills Skillsobj;
        LoginPage loginpageobj;

        public SkillsStepDefinitions()
        {
            Skillsobj = new Skills(driver);
            loginpageobj = new LoginPage(driver);

        }
        [Given(@"I logged in to the portal")]
        public void GivenILoggedInToThePortal()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //Initialize a Object

            Skillsobj = new Skills(driver);
            loginpageobj = new LoginPage(driver);

            //Login
            loginpageobj.LoginActions();

        }

        [When(@"I Click Skills Tab")]
        public void WhenIClickSkillsTab()
        {
            Skillsobj.NavigateToSkillsTab();
        }

        [When(@"I want to add '([^']*)' and '([^']*)'")]
        public void WhenIWantToAddAnd(string p0, string p1)
        {

            Skillsobj.AddSkills(p0, p1);


        }

        [Then(@"The  '([^']*)' and '([^']*)' should be added Successfully")]
        public void ThenTheAndShouldBeAddedSuccessfully(string p0, string p1)
        {
            //Check Skill and skill levels are added successfully
            string newSkill = Skillsobj.newSkill();
            string newSkilllevel = Skillsobj.newSkilllevel();
            Assert.That(newSkill == p0, "New Skill doednot added successfully");
            Assert.That(newSkilllevel == p1, "New Skilllvel doesnot added successfully");
        }

        [When(@"I edit '([^']*)' and '([^']*)'")]
        public void WhenIEditAnd(string p0, string p1)
        {
            Skillsobj.EditSkill(p0, p1);
        }

        [Then(@"The  '([^']*)' and '([^']*)' should be edited Successfully")]
        public void ThenTheAndShouldBeEditedSuccessfully(string p0, string p1)
        {
            //Check Skill and skilllevel Edited successfully
            string editedSkill = Skillsobj.editedSkill();
            string editedSkilllevel = Skillsobj.editedSkilllevel();
            Assert.That(editedSkill == p0, "The Skill doesnot Edited Successfully");
            Assert.That(editedSkilllevel == p1, "The Skilllevel doesnot Edited Successfully");

        }

        [When(@"I delete'([^']*)'")]
        public void WhenIDelete(string p0)
        {
            Skillsobj.DeleteSkill(p0);
        }

        [Then(@"The  '([^']*)'  should be deleted Successfully")]
        public void ThenTheShouldBeDeletedSuccessfully(string p0)
        {
            string deletedSkill = Skillsobj.deletedSkill();
            Assert.That(deletedSkill == p0, "The Skill does not deleted sucessfully");
            driver.Close();
        }
    }
}
