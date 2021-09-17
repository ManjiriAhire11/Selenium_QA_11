using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class Check_Box
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Check Box");

            //Launch Chrome browser
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");
            //Maximize the browser
            driver.Manage().Window.Maximize();
            //Launch Url(Open Google
            driver.Url = "https://accounts.google.com/signup/v2/webcreateaccount?hl=en&flowName=GlifWebSignIn&flowEntry=SignUp";
            IWebElement check_box = driver.FindElement(By.XPath("//input[@id='i3']"));
            Thread.Sleep(3000);
            check_box.Click();
        }

            
    }
}
