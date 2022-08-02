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
    public class CertificationsStepDefinitions : CommonDriver
    {
        Certifications Certificationsobj;
        LoginPage loginpageobj;


        public CertificationsStepDefinitions()
        {
            Certificationsobj = new Certifications(driver);
            loginpageobj = new LoginPage(driver);

        }

        [Given(@"I logged in to the Portal")]
        public void GivenILoggedInToThePortal()
        {
            //Open ChromeBrowser
            driver = new ChromeDriver();

            //initiaize the object
            Certificationsobj = new Certifications(driver);
            loginpageobj = new LoginPage(driver);


            //Login
            loginpageobj.LoginActions();
        }

        [When(@"I click Certifications tab")]
        public void WhenIClickCertificationsTab()
        {
            Certificationsobj.NavigateToCertificationsTab();

        }

        [When(@"I add a '([^']*)','([^']*)','([^']*)'")]
        public void WhenIAddA(string p0, string p1, string p2)
        {
            Certificationsobj.AddCertification(p0, p1, p2);
        }

        [Then(@"The '([^']*)','([^']*)','([^']*)' shoud be added successfully")]
        public void ThenTheShoudBeAddedSuccessfully(string p0, string p1, string p2)
        {
            // check Certifications are added successfully
            string newCertificate = Certificationsobj.newCertificate();
            string newCertificateFrom = Certificationsobj.newCertificateFrom();
            string newCertificateYear = Certificationsobj.newCertificateYear();

            Assert.That(newCertificate == p0, "The NewCertificate doesnot added successfully");
            Assert.That(newCertificateFrom == p1, "The NewCertificate Institute not added Successfully");
            Assert.That(newCertificateYear == p2, "The NewCertificateYear not added successfully");
        }

        [When(@"I edit a last'([^']*)','([^']*)','([^']*)'")]
        public void WhenIEditALast(string p0, string p1, string p2)
        {
            Certificationsobj.EditCertification(p0, p1, p2);
        }

        [Then(@"The '([^']*)','([^']*)','([^']*)' shoud be edited successfully")]
        public void ThenTheShoudBeEditedSuccessfully(string p0, string p1, string p2)
        {
            //Check Certificates are updated successfully

            string editedCertificate = Certificationsobj.editedCertificate();
            string editedCertificateFrom = Certificationsobj.editedCertificateFrom();
            string editedCertificateYear = Certificationsobj.editedCertificateYear();

            Assert.That(editedCertificate == p0, "The Certificate doesnot edited successfully");
            Assert.That(editedCertificateFrom == p1, "The Certificate Institute doesnot edited successfully");
            Assert.That(editedCertificateYear == p2, "The Certificate Year doesnot edited successfully");

        }

        [When(@"I delete a last'([^']*)'")]
        public void WhenIDeleteALast(string p0)
        {
            Certificationsobj.DeleteCertificate(p0);
        }

        [Then(@"The '([^']*)' shoud be deleted successfully")]
        public void ThenTheShoudBeDeletedSuccessfully(string p0)
        {
            //Check Certificate is delete successfully
            string deletedCertificate = Certificationsobj.deletedCertificate();
            Assert.That(deletedCertificate == p0, "The Certificate is deleted successfully");

            driver.Close();
        }
    }
}
