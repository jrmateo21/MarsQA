using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public  class ProfileDetailsPage
    { 

        



        public  void AddProfileDetails()
        {


            //Add  Entryy in Languages Tab


            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);

            //Click the Add New Button
            IWebElement addNewButton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            // Click the Language Textboc and input a language
            IWebElement addLanguageTextbox = Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguageTextbox.SendKeys("Filipino");

            // Select language Level
            IWebElement selectLanguageLevel = Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown']/option[3]"));
            selectLanguageLevel.Click();

            // Click the Add button
            IWebElement addButtonLanguage = Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
            addButtonLanguage.Click();



            //Add  entry to Skills Tab

            IWebElement skillsTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']"));
            skillsTab.Click();

            IWebElement addNewButtonSkills = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButtonSkills.Click();

            IWebElement addSkillTextbox = Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            addSkillTextbox.SendKeys("Automation Testing");

            IWebElement selectSkillLevel = Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']/option[2]"));
            selectSkillLevel.Click();

            IWebElement addButtonSkills = Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
            addButtonSkills.Click();



            //Add Entry in  Education  Tab

            IWebElement educationTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']"));
            educationTab.Click();

            Thread.Sleep(4000);
            IWebElement addNewButtonEdu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButtonEdu.Click();

            IWebElement addUniTextbox = Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            addUniTextbox.SendKeys("Auckland University");
                                   
            IWebElement selectCountryUni = Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='country']"));
            selectCountryUni.SendKeys("New Zealand");

            IWebElement selectEducationTitle= Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='title']"));
            selectEducationTitle.SendKeys("B.Sc");

            IWebElement addDegreeTextbox = Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            addDegreeTextbox.SendKeys("Information Technology");

            IWebElement selectYearOfGrad= Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='yearOfGraduation']"));
            selectYearOfGrad.SendKeys("2010");

            IWebElement addButtonEdu= Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
            addButtonEdu.Click();



            //Add  entry to Certifications  Tab

            
            IWebElement certificationsTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Certifications']"));
            certificationsTab.Click();

            Thread.Sleep(4000);
            IWebElement addNewButtonCert = Driver.driver.FindElement(By.XPath("//html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButtonCert.Click();

            IWebElement addCertTextbox= Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            addCertTextbox.SendKeys("CERTIFIED TESTER FOUNDATION LEVEL (CTFL)");

            IWebElement addCertFromTextbox = Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            addCertFromTextbox.SendKeys("ISTQB");

            IWebElement selectCertYear = Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown'][@name='certificationYear']"));
            selectCertYear.SendKeys("2022");

            IWebElement addButtonCert = Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
            addButtonCert.Click();



            // Add Entry to Description Textbox


            IWebElement descButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descButton.Click();

            IWebElement descTextBox = Driver.driver.FindElement(By.XPath("//textarea[@name = 'value']"));
            Thread.Sleep(3000);
            descTextBox.Clear();           
            descTextBox.SendKeys("I love to play  basketball");
            //descTextBox.SendKeys("abc");

            IWebElement descSaveButton = Driver.driver.FindElement(By.XPath("//*[@class='ui twelve wide column']//*[@class= 'ui teal button'][text()='Save']"));
            descSaveButton.Click();
            Thread.Sleep(3000);




            // Add User's Avaialabilty option

            IWebElement addAvailabilty = Driver.driver.FindElement(By.XPath("//*[@class='ui list']/div[2]/div/span/i"));
            addAvailabilty.Click();

            IWebElement selectAvailDropDown = Driver.driver.FindElement(By.XPath("//select[@class = 'ui right labeled dropdown'][@name='availabiltyType']/option[3]"));
            selectAvailDropDown.Click();

            // Add User's Hours option

            IWebElement addHours = Driver.driver.FindElement(By.XPath("//*[@class='ui list']/div[3]/div/span/i"));
            addHours.Click();

            IWebElement selectHoursDropDown = Driver.driver.FindElement(By.XPath("//select[@class = 'ui right labeled dropdown'][@name='availabiltyHour']/option[2]"));
            selectHoursDropDown.Click();


            // Add User's Earn Target option

            IWebElement addEarnTarget = Driver.driver.FindElement(By.XPath("//*[@class='ui list']/div[4]/div/span/i"));
            addEarnTarget.Click();

            IWebElement selectEarnTargetDropDown = Driver.driver.FindElement(By.XPath("//select[@class = 'ui right labeled dropdown'][@name='availabiltyTarget']/option[4]"));
            selectEarnTargetDropDown.Click();





























        }



        public  string GetAddedLanguages()
        {
            
             // Go back to Languages Tab
            //Thread.Sleep(3000);
            IWebElement goBackToLanguageTab =Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Languages']"));
            goBackToLanguageTab.Click();
           
            

            // Select the last entry on the table
            Thread.Sleep(3000);
            IWebElement actualLanguage = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualLanguage.Text;



        }


        public string GetAddedSkills()
        {

            // Go back to Skills Tab
            IWebElement goBackToSkillsTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']"));
            goBackToSkillsTab.Click();

            // Select the last entry on the table
            IWebElement actualSkills = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualSkills.Text;



        }


        public string GetAddedEducation()
        {

            // Go back to Education Tab
            IWebElement goBackToEduTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']"));
            goBackToEduTab.Click();

            // Select the last entry on the table
            IWebElement actualEdu = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return actualEdu.Text;





        }


        public string GetAddedCerts()
        {

            // Go back to Certification Tab
            IWebElement goBackToCertsTab = Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Certifications']"));
            goBackToCertsTab.Click();


            // Select the last entry on the table
            IWebElement actualCerts = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualCerts.Text;



        }

        public string GetAddedDesc()
        {
            

            // Select the  description Textbox
            IWebElement actualDesc = Driver.driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            return actualDesc.Text;




        }

        public string GetAddedAvail()
        {

            // Select the Availabilty Label

            IWebElement actualAvail = Driver.driver.FindElement(By.XPath("//*[@class= 'ui list']/div[2]/div/span"));
            return actualAvail.Text;


        }


        public string GetAddedHours()
        {

            // Select the availabilty Hours Label

            IWebElement actualHours = Driver.driver.FindElement(By.XPath("//*[@class= 'ui list']/div[3]/div/span"));
            return actualHours.Text;

        }


        public string GetAddedEarnTarget()
        {

            // Select the Earn Target Label

            IWebElement actualEarnTarget = Driver.driver.FindElement(By.XPath("//*[@class= 'ui list']/div[4]/div/span"));
            return actualEarnTarget.Text;

        }










































    }

   
}
