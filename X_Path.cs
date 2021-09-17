using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                    //Assignment-04
                    //Relative XPath

namespace Selenium_QA_11
{
    class X_Path
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
        
            //By Realative XPath-relative starts with //
            driver.FindElement(By.XPath("//input[@role='combobox']")).SendKeys("Selenium");

            //close browser
            driver.Close();
        }
    }
}

