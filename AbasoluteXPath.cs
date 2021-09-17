using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class AbasoluteXPath
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Relative XPath");
            Console.WriteLine("Css_Selector");
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //minimize window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.google.co.in/";

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Selenium");

        }
    }
}

