using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                    //Assignmanet-4

namespace Selenium_QA_11
{
    class Locate_Name
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Locate_By_Name");
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //google Url
            driver.Url = "https://www.google.co.in/";


            //Maximize
            driver.Manage().Window.Maximize();

            //locate-Name
            driver.FindElement(By.Name("q")).SendKeys("Selenium");

            //close
           // driver.Close();
        }
    }
}
