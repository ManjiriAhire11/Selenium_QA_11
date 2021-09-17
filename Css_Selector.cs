using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

                //Assignment-04

namespace Selenium_QA_11
{
    class Css_Selector
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Css_Selector");
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //manage window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.google.co.in/";
               
            //By Selector xpath
            driver.FindElement(By.CssSelector("input.gLFyf")).SendKeys("Selenium");

            //By attribute
            driver.FindElement(By.CssSelector("input[role=''combobox']")).SendKeys("Selenium");

            //stars with
            driver.FindElement(By.CssSelector("input[role^='combo']")).SendKeys("Selenium");

            //contains
            driver.FindElement(By.CssSelector("input[role*='combobox']")).SendKeys("Selenium");

            //Ends with
            driver.FindElement(By.CssSelector("input[role$='box']")).SendKeys("Selenium");


            Thread.Sleep(3000);
            //close
            driver.Close();
        }
    }
}
