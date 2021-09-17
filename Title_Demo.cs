using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class Title_Demo
    {

        static void Main(String[] args)

        {
            Console.WriteLine("Title Demo");
           
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //minimize window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.google.co.in/";
            String title = driver.Title;

            //Bylinktext
            driver.FindElement(By.LinkText("Gmail")).Click();
            title = driver.Title;
            Console.WriteLine(title);

            //cose browser
            driver.Close();
        }
    }
}
