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
    public static class ProfileDetailsPage 
    {

        public static IWebElement addNewButton => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][text()='Add New']"));
        public static IWebElement signOutButton => Driver.driver.FindElement(By.XPath("//A[@class='item']//Button[@class='ui green basic button']"));

       

       //Profile Tab Menu
        
        public static IWebElement languagesTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Languages']"));
        public static IWebElement skillsTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Skills']"));
        public static IWebElement educationTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Education']"));
        public static IWebElement certificationsTab => Driver.driver.FindElement(By.XPath("//A[@class='item active'][text()='Certifications']"));


        //Drop down icon

        public static IWebElement dropDownIcon1 => Driver.driver.FindElement(By.XPath("//div[@class='title']//i[@class='dropdown icon']"));

        public static void AddProfileDetails()
        {

            dropDownIcon1.Click();

            //skillsTab.Click();



            //Driver.TurnOnWait();

            // addNewButton.Click();
            //certificationsTab.Click();
            



        }
    }
}
