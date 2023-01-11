using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TCS_ISTQB_JAN2023
{
    /// <summary>
    /// This is the Main Program that will launch my automation for the HerokuApp Page
    /// </summary>
    internal class TCSAutomationProgram
    {
        /// <summary>
        /// The Main Program Takes in a argument and launches the automation.
        /// </summary>
        /// <param name="args">This is the value passed by the Invocation environment </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISTQB Automation");
            ChromeDriver myBrowser = new ChromeDriver();
            myBrowser.Url = "https://the-internet.herokuapp.com/";
            int noIfLinks = myBrowser.FindElements(By.TagName("a")).Count;
            Console.WriteLine($" The Heroku Page has {noIfLinks} Links");

        }

        private static void testcasePetStoreHomePage_CheckForDisplayedPets() {
        // Navigate to Home Page
        // Check the Number of Links 
        // Assert that it is cotrrectly as per the spec
        // No of links - 46
        // AAA
        } 

        
        
    }
}
