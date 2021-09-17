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
    class Link_Text
    {
        static void Main(String[] args)
        {
            Console.WriteLine("LinkText Demo");
            Console.WriteLine("Css_Selector");
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //minimize window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.google.co.in/";

            //Get innertext web element
            Console.WriteLine(driver.FindElements(By.LinkText("Gmail")).Text;

            //close browser
            driver.Close();
        }
    }
}
