using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
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

        
        LanguagesTab  languagesTabPageObj = new LanguagesTab();


        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
           
            SignIn.SigninStep();
           
           
        }



        [Given(@"I login to the website using  '([^']*)' and '([^']*)'")]
        public void GivenILoginToTheWebsiteUsingAnd(string p0, string p1)
        {
            SignIn.Login(p0,p1);
        }
    

    }


}
