using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
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
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
           
            SignIn.SigninStep();
           
           
        }


        [When(@"I create a new Profile Details")]
        public void WhenICreateANewProfileDetails()
        {
           
            ProfileDetailsPage.AddProfileDetails();

        }

        [Then(@"The Profile Details should be created successfully")]
        public void ThenTheProfileDetailsShouldBeCreatedSuccessfully()
        {
            Console.WriteLine("Profile Details Should be added");
        }

    }


}
