using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class MultiselectDemo
    {
        

        static void Main(String[] args)
        {

            Console.WriteLine("MultiSelect Demo");

            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //minimize window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
            IWebElement select_box = driver.FindElement(By.Name("States"));
            SelectElement select = new SelectElement(select_box);
            Boolean status_Multiple = select.IsMultiple;
            Console.WriteLine(status_multiple);
            select.SelectByIndex(4);
            select.SelectByValue("California");
            select.SelectByValue("New York");
            select.SelectByText("New Jersey");
            select.DeselectByIndex(0);

            //close browser
            driver.Close();



        }
    }   
}
