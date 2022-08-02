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
    public class profileStepDefinitions : CommonDriver
    {
        
        profile profileobj;
        LoginPage loginpageobj;

        public profileStepDefinitions()
        {
            profileobj = new profile(driver);
            loginpageobj = new LoginPage(driver);
        }

        [Given(@"I logged in to the Portal successfully")]
        public void GivenILoggedInToThePortalSuccessfully()
        {
            //Open Browser
            driver = new ChromeDriver();


            //Initialize  objects
            profileobj = new profile(driver);
            loginpageobj = new LoginPage(driver);

            //Login
            loginpageobj.LoginActions();
        }

        [Then(@"i can able to see my profile")]
        public void ThenICanAbleToSeeMyProfile()
        {
            String WelcomeText = profileobj.getWelcomeText(driver);
            Assert.That(WelcomeText == "Hi Anitha" | WelcomeText == "Hi", "Actual and Expected result not match");
            driver.Close();
        }
    }
}
