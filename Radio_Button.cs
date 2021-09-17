using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class Radio_Button
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Handle Radiobutton");
            //1.Launch chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //open Url
            driver.Url = "https://www.seleniumeasy.com/test/basic-radiobutton-demo.html";

            //maximize window
            driver.Manage().Window.Maximize();

            //select the gender:male/female
            ReadOnlyCollection<IWebElement> radio_button1 = driver.FindElements(By.Name("gender"));
            radio_button1[0].Click();
            
            //select age group:0-5/5-15/15-50
            ReadOnlyCollection<IWebElement> radio_button2 = driver.FindElements(By.Name("ageGroup"));
            radio_button2[2].Click();

            Thread.Sleep(3000);

            //close
            driver.Close();

        }
    }
}
