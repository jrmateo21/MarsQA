using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions
    {
        SkillsTab skillsTabPageObj = new SkillsTab();  
        
        [When(@"I navigate to Skills")]
        public void WhenINavigateToSkills()
        {

            skillsTabPageObj.SelectSkillsTab();


        }

        [When(@"I add a new Skills")]
        public void WhenIAddANewSkills()
        {
            skillsTabPageObj.AddSkills();

            
        }

        [Then(@"The Skills should be added successfully")]
        public void ThenTheSkillsShouldBeAddedSuccessfully()
        {

            //Assertion for Skills Tab
            string newSkills = skillsTabPageObj.GetAddedSkills();
            Console.WriteLine("PASSED! Added Skill:  " + newSkills);
            Assert.That(newSkills == "Automation Testing", "Actual skills and expected skills do not match");

        }
    }
}
