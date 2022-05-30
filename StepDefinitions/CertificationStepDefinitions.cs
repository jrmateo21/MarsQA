using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions
    {

        CertificationsTab certsTabPageObj = new CertificationsTab();

        [When(@"I navigate to Certifications Tab")]
        public void WhenINavigateToCertificationsTab()
        {
            certsTabPageObj.SelectCersTab();
        }

        [When(@"I add a new Certifications, '([^']*)' , '([^']*)', '([^']*)'")]
        public void WhenIAddANewCertifications(string p0, string p1, string p2)
        {
            certsTabPageObj.AddCerts(p0, p1, p2);
        }



        [Then(@"The Certifications should be added successfully, '([^']*)' , '([^']*)', '([^']*)'")]
        public void ThenTheCertificationsShouldBeAddedSuccessfully(string p0, string p1, string p2)
        {
            
            string newCerts = certsTabPageObj.GetAddedCerts();
            string newCertsFrom = certsTabPageObj.GetAddedCertsFrom();
            string newCertsYear = certsTabPageObj.GetAddedCertsYear();
            Console.WriteLine("PASSED! Added Certification:  " + newCerts + "   "+ p0);
            Console.WriteLine("PASSED! Added Certification:  " + newCertsFrom + "   " + p1);
            Console.WriteLine("PASSED! Added Certification:  " + newCertsYear + "   " + p2);


            Assert.That(newCerts == p0, "Actual certification and expected certification do not match");
            Assert.That(newCertsFrom == p1, "Actual certification and expected certification do not match");
            Assert.That(newCertsYear == p2, "Actual certification and expected certification do not match");


        }




        [When(@"I update  Certifications, '([^']*)' , '([^']*)', '([^']*)'")]
        public void WhenIUpdateCertifications(string p0, string p1, string p2)
        {
            certsTabPageObj.EditCerts(p0, p1, p2);

        }

        [Then(@"The Certifications should have the updated  '([^']*)' , '([^']*)', '([^']*)'")]
        public void ThenTheCertificationsShouldHaveTheUpdated(string p0, string p1, string p2)
        {

            string editedCerts = certsTabPageObj.GetEditedCerts();
            string editedCertsFrom = certsTabPageObj.GetEditedCertsFrom();
            string editedCertsYear = certsTabPageObj.GetEditedCertsYear();
            Console.WriteLine("PASSED! Added Certification:  " + editedCerts + "   " + p0);
            Console.WriteLine("PASSED! Added Certification:  " + editedCertsFrom + "   " + p1);
            Console.WriteLine("PASSED! Added Certification:  " + editedCertsYear + "   " + p2);


            Assert.That(editedCerts == p0, "Actual certificat and expected certification do not match");

            

        }


    }



}
