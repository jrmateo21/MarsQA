using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfileDetails
{
    public class LanguagesTab 

    {
        
     
        private static IWebElement addNewButton => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//div[@class='ui teal button ']"));        
        private static IWebElement addLanguageTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement selectLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown']"));
        private static IWebElement addButtonLanguage => Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
        private static IWebElement navToLangTab => Driver.driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']"));
        private static IWebElement actualLanguage => Driver.driver.FindElement(By.XPath("//*[@data-tab='first']//tr/td[1]"));

        public void SelectLanguagesTab()
        {
         
            navToLangTab.Click();   

        }
        
        
        
        public void AddLanguages()
        {

          

            //Click the Add New Button
            addNewButton.Click();


            // Click the Language Textboc and input a language
            addLanguageTextbox.SendKeys("Filipino");

            // Select language Level
            

            selectLanguageLevel.SendKeys("Basic");

            // Click the Add button
            
            addButtonLanguage.Click();

        }


        public string GetAddedLanguages()
        {

            
            return actualLanguage.Text;



        }

    }
}
