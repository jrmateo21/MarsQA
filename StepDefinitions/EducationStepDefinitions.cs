using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions
    {
        EducationTab educationTabPageObj = new EducationTab();

        
        [When(@"I navigate to Education")]
        public void WhenINavigateToEducation()
        {
            educationTabPageObj.SelectEducTab();

        }

        [When(@"I add a new Education")]
        public void WhenIAddANewEducation()
        {

             educationTabPageObj.AddEducation();

        }

        [Then(@"The Education should be added successfully")]
        public void ThenTheEducationShouldBeAddedSuccessfully()
        {

            // Assertion for Education Tab

            string newEdu = educationTabPageObj.GetAddedEducation();
            Console.WriteLine("PASSED! Added Education:  " + newEdu);
            Assert.That(newEdu == "Auckland University", "Actual Uuniversity and expected university do not match");


        }
    }
}
