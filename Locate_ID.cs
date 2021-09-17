using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                //Assignment-04

namespace Selenium_QA_11
{
    class Locate_ID
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello Launch_By_ID");

            //Launch chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //Launch Url google
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F%26ogbl%2F&ltmpl=default&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";
            // driver.FindElement(By.Id("gs_taif50")).SendKeys("Manjiri");

            //Maximize window
            driver.Manage().Window.Maximize();

            //first Name
            driver.FindElement(By.CssSelector("#firstName")).SendKeys("Manjiri");

            //Last Name
            driver.FindElement(By.CssSelector("#lastName")).SendKeys("Ahire");
        
            //close
            driver.Close();
        }
    }
}
