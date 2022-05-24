using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Login : Driver
    {

        ProfileDetailsPage profileDetailsPageObj = new ProfileDetailsPage();


        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
           
            SignIn.SigninStep();
           
           
        }


        [When(@"I create a new Profile Details")]
        public void WhenICreateANewProfileDetails()
        {
           
           profileDetailsPageObj.AddProfileDetails();
          

            


        }

        [Then(@"The Profile Details should be created successfully")]
        public void ThenTheProfileDetailsShouldBeCreatedSuccessfully()
        {
        
         //Assertion for Languages Tab

            string newLanguage = profileDetailsPageObj.GetAddedLanguages();
            Console.WriteLine("Added Language:  " + newLanguage);
            Assert.That(newLanguage== "Filipino", "Actual language and expected language do not match");


         //Assertion for Skills Tab
            string newSkills = profileDetailsPageObj.GetAddedSkills();
            Console.WriteLine("Added Skill:  " +  newSkills);
            Assert.That(newSkills == "Automation Testing", "Actual skills and expected skills do not match");
           

         // Assertion for Education Tab

            string newEdu = profileDetailsPageObj.GetAddedEducation();
            Console.WriteLine("Added Education:  " + newEdu);
            Assert.That(newEdu =="Auckland University", "Actual Uuniversity and expected university do not match");


         // Assertion for Certifications Tab

            string newCerts = profileDetailsPageObj.GetAddedCerts();
            Console.WriteLine("Added Certifications:  " + newCerts);
            Assert.That(newCerts == "CERTIFIED TESTER FOUNDATION LEVEL (CTFL)", "Actual certification and expected certification do not match");

         // Assertions for Description Textbox
            
            string newDesc = profileDetailsPageObj.GetAddedDesc();
            Console.WriteLine("Added Descriptions:  " + newDesc);
            Assert.That(newDesc == "I love to play basketball", "Actual descriptions and expected descriptions do not match");

         // Assertions for  User's Avaialability
         
            string newAvail = profileDetailsPageObj.GetAddedAvail();
            Console.WriteLine("Availability:  " + newAvail);
            Assert.That(newAvail == "Full Time", "Actual availability  and expected availability do not match");

         // Assertions for  User's  hours Avaialability
            
            string newHours = profileDetailsPageObj.GetAddedHours();
            Console.WriteLine("Hours:  " + newHours);
            Assert.That(newHours== "Less than 30hours a week", "Actual hours  and expected availability do not match");

         // Assertions for  User's Earn Target

            string newEarnTarget = profileDetailsPageObj.GetAddedEarnTarget();
            Console.WriteLine("Hours:  " + newEarnTarget);
            Assert.That(newEarnTarget == "More than $1000 per month", "Actual earn target  and expected earn target  do not match");




























        }

    }


}
