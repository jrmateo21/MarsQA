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
    public class SkillsTab
    {
        private static IWebElement navToSkillsTab => Driver.driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']"));
        private static IWebElement skillsTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']"));
        private static IWebElement addNewButtonSkills => Driver.driver.FindElement(By.XPath("//*[@class='ui teal button'][text()='Add New']"));
        private static IWebElement addSkillTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private static IWebElement selectSkillLevel => Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']/option[2]"));
        private static IWebElement addButtonSkills => Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
        private static IWebElement actualSkills => Driver.driver.FindElement(By.XPath("//*[@data-tab='second']//tr/td[1]"));


        public void SelectSkillsTab()
        {                
            navToSkillsTab.Click();
        }
        public void AddSkills()
        {           
            skillsTab.Click();
                        
            addNewButtonSkills.Click();
            
            addSkillTextbox.SendKeys("Automation Testing");
            
            selectSkillLevel.Click();
           
            addButtonSkills.Click();
        }

        public string GetAddedSkills()
        {           
            return actualSkills.Text;
        }

    } 
}
