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
    public class LanguagesStepDefinitions : CommonDriver
    {
        Languages Languagesobj;
        LoginPage loginpageobj;

        public LanguagesStepDefinitions()
        {
            Languagesobj = new Languages(driver);
            loginpageobj = new LoginPage(driver);


        }

        [Given(@"I login to the Website")]
        public void GivenILoginToTheWebsite()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //Initialize the object
            Languagesobj = new Languages(driver);
            loginpageobj = new LoginPage(driver);

            //Login
            loginpageobj.LoginActions();

        }

        [When(@"I click on Languages Tab")]
        public void WhenIClickOnLanguagesTab()
        {
            Languagesobj.NavigateToLanguageTab();
        }

        [When(@"I Want to add my '([^']*)' and '([^']*)'")]
        public void WhenIWantToAddMyAnd(string p0, string p1)
        {
            Languagesobj.AddLanguages(p0, p1);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added in the Portal successfully")]
        public void ThenTheAndShouldBeAddedInThePortalSuccessfully(string p0, string p1)
        {
            //Check Language and LanguageLevel are added successfully
            string newLanguage = Languagesobj.newLanguage();
            string newLanguageLevel = Languagesobj.newLanguageLevel();
            Assert.That(newLanguage == p0, "New Language does not added successfully");
            Assert.That(newLanguageLevel == p1, "New LanguageLevel  does not added successfully");
        }

        [When(@"I Want to edit my '([^']*)' and '([^']*)'")]
        public void WhenIWantToEditMyAnd(string p0, string p1)
        {
            Languagesobj.EditLanguage(p0, p1);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be edited in the Portal successfully")]
        public void ThenTheAndShouldBeEditedInThePortalSuccessfully(string p0, string p1)
        {
            //check Language and Languagelevel are edited successfully
            string editedLanguage = Languagesobj.editedLanguage();
            string editedLanguageLevel = Languagesobj.editedLanguageLevel();
            Assert.That(editedLanguage == p0, "The Language does not Edited Successfully");
            Assert.That(editedLanguageLevel == p1, "The Language does not edited successfully");
        }

        [When(@"I Want to Delete my '([^']*)'")]
        public void WhenIWantToDeleteMy(string p0)
        {
            Languagesobj.DeleteLanguage(p0);
        }

        [Then(@"The '([^']*)' should be deleted in the Portal successfully")]
        public void ThenTheShouldBeDeletedInThePortalSuccessfully(string p0)
        {
            //Check Language is deleted successfully

            string deletedLanguage = Languagesobj.deletedLanguage();
            Assert.That(deletedLanguage == p0, "The Language deleted successfully");
            driver.Close();
        }
    }
}
