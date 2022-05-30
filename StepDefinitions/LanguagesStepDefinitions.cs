using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class LanguagesStepDefinitions
    {
        LanguagesTab languagesTabPageObj = new LanguagesTab();



        [When(@"I navigate to Languages")]
        public void WhenINavigateToLanguages()
        {
            languagesTabPageObj.SelectLanguagesTab();

        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {
            languagesTabPageObj.AddLanguages();

        }


        [Then(@"The language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {


            // Assertion for Languages Tab
 

            string newLanguage = languagesTabPageObj.GetAddedLanguages();
            Console.WriteLine("PASSED! Added Language:  " + newLanguage);
            Assert.That(newLanguage == "Filipino", "Actual language and expected language do not match");

        }
    }
}
