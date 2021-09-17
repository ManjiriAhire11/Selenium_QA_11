using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class MouseActioncs
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Mouse action demo");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch Url(Open Google
            driver.Url = "https://www.google.co.in/";

            IWebElement gmail = driver.FindElement(By.LinkText("Gmail"));
            Actions action = new Actions(driver);
            //Click using Mouse
            //action.MoveToElement(gmail).Click().Perform();

            //Hover on the Element
            //action.MoveToElement(gmail).Build().Perform();

            //Right Click the Element
            //action.MoveToElement(gmail).ContextClick().Perform();

            //double Click
            action.MoveToElement(gmail).DoubleClick().Perform();

            //Close the Browser
            driver.Close();
        }
    }
}
