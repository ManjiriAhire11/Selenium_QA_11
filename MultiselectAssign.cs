using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
            //Assignment of miltiselect

namespace Selenium_QA_11
{
    class MultiselectAssign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple select assignment");
            //Launch Chrome
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch Url
            driver.Url = "https://www.seleniumeasy.com/test/jquery-dual-list-box-demo.html";

            IWebElement select_box = driver.FindElement(By.XPath("//*[@id='pickList']/div/div[1]/select"));
            SelectElement select = new SelectElement(select_box);
            select.SelectByIndex(0);
            select.SelectByIndex(1);
            select.SelectByIndex(2);
            select.SelectByIndex(3);
            select.SelectByIndex(4);

            driver.FindElement(By.CssSelector("button.pAdd")).Click();
            IList<IWebElement> options = select.Options;
            Console.WriteLine(options.Count);
            Console.WriteLine("All Selected Options:");

            foreach (IWebElement option in options)
            {
                Console.WriteLine(option.Text);
            }
            select_box = driver.FindElement(By.XPath("//*[@id='pickList']/div/div[3]/select"));
            select = new SelectElement(select_box);
            options = select.Options;
            Console.WriteLine(options.Count);
            Console.WriteLine("All Selected Options:");
            foreach (IWebElement option in options)
            {
                Console.WriteLine(option.Text);
            }
            driver.Close();

        }


    }
}
    

