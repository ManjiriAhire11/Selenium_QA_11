using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   //Assihnment-3

namespace Selenium_QA_11
{
    class Launch_Chrome
    {
        static void Main(String[]args)
        { 
            Console.WriteLine("Hello google Launch");

            //1.Launch chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //2.Launch Url google
            driver.Url = "https://www.google.co.in/";

            //3.Maximize window
            driver.Manage().Window.Maximize();


            //4.close
            driver.Close();

        }
    }
}
