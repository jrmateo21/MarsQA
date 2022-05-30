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
    public class CertificationsTab
    {   

        private static IWebElement navToCertsTab => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Certifications']"));
        private static IWebElement addNewButtonCert => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//div[@class='ui teal button ']"));
        private static IWebElement CertTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertFromTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement selectCertYear => Driver.driver.FindElement(By.XPath("//*[@class='ui fluid dropdown'][@name='certificationYear']"));
        private static IWebElement addButtonCert => Driver.driver.FindElement(By.XPath("//INPUT[@type='button'][1]"));
        private static IWebElement editButtonCert => Driver.driver.FindElement(By.XPath("//*[@class = 'ui fixed table']/tbody[1]/tr/td[4]/span[1]"));
        private static IWebElement updateButtonCert => Driver.driver.FindElement(By.XPath("//*[@colspan='4']//input[@value='Update']"));
        
        public static IWebElement actualCerts => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]/tr/td[1]"));
        public static IWebElement actualCertsFrom => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]/tr/td[2]"));
        public static IWebElement actualCertsYear => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[last()]/tr/td[3]"));
        public static IWebElement editedCerts => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[(1)]/tr/td[1]"));
        public static IWebElement editedCertsFrom => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody[(1)]/tr/td[2]"));
        public static IWebElement editedCertsYear => Driver.driver.FindElement(By.XPath("//*[@data-tab='fourth']//tbody/tr/td[3]"));



        public void SelectCersTab()
        {
            
            navToCertsTab.Click();

        }


        public void AddCerts(string certificate,string from, string year )
        {

            //Add  entry to Certifications  Tab

            addNewButtonCert.Click();

            // addCertTextbox.SendKeys("CERTIFIED TESTER FOUNDATION LEVEL (CTFL)");
            CertTextbox.SendKeys(certificate);

            //  addCertFromTextbox.SendKeys("ISTQB");
            CertFromTextbox.SendKeys(from);

            // selectCertYear.SendKeys("2022");
            selectCertYear.SendKeys(year);

            addButtonCert.Click();


        }

        public void EditCerts(string certificate,string from,string year)
        {

            editButtonCert.Click();

            //Clear  the textbox value
            CertTextbox.Clear();
            CertFromTextbox.Clear();
            
            //Add the textbox new value
            CertTextbox.SendKeys(certificate);            
            CertFromTextbox.SendKeys(from);           
            selectCertYear.SendKeys(year);
            updateButtonCert.Click();



        }
       

        public string GetAddedCerts()
        {

            // Select the last entry on the table
            Thread.Sleep(500);
            return actualCerts.Text;

        }

        public string GetAddedCertsFrom()
        {
            Thread.Sleep(500);
            return actualCertsFrom.Text;
        }

        public string GetAddedCertsYear()
        {
            Thread.Sleep(500);
            return actualCertsYear.Text;
        }

        public string GetEditedCerts()
        {
            Thread.Sleep(300);
            return editedCerts.Text;


        }
        public string GetEditedCertsFrom()
        {
            Thread.Sleep(100);
            return editedCertsFrom.Text;
        }

        public string GetEditedCertsYear()
        {
            Thread.Sleep(100);
            return editedCertsYear.Text;
        }


    }
}
