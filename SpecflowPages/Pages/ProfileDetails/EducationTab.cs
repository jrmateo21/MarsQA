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
    public class EducationTab
    {
       
       private static IWebElement navToEduTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']"));

      // private static IWebElement addNewButtonEdu => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
       private static IWebElement addNewButtonEdu => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//div[@class='ui teal button ']"));
       private static IWebElement addUniTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
       private static IWebElement selectCountryUni => Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='country']"));
       private static IWebElement selectEducationTitle => Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='title']"));
       private static IWebElement addDegreeTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
       private static IWebElement selectYearOfGrad => Driver.driver.FindElement(By.XPath("//*[@class='ui dropdown'][@name='yearOfGraduation']"));
       private static IWebElement addButtonEdu => Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
       private static IWebElement actualEdu => Driver.driver.FindElement(By.XPath("//*[@data-tab='third']//tr/td[2] "));

        public void SelectEducTab()
       {
          
            navToEduTab.Click();

       }

       public void AddEducation()
       {
            //Add Entry in  Education  Tab

           
            addNewButtonEdu.Click();

            
            addUniTextbox.SendKeys("Auckland University");

            
            selectCountryUni.SendKeys("New Zealand");

           
            selectEducationTitle.SendKeys("B.Sc");

            
            addDegreeTextbox.SendKeys("Information Technology");

            
            selectYearOfGrad.SendKeys("2010");

            
            addButtonEdu.Click();
       }


        public string GetAddedEducation()
        {
               
         
            return actualEdu.Text;

        }








    }
}
