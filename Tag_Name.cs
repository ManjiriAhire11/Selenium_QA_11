using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_QA_11
{
    class Tag_Name
    {
        static void Main(String[]args)
        {
            
            Console.WriteLine("TagName Demo");
            IWebDriver driver = new ChromeDriver("C:\\Users\\manji\\Manjiri_Selenium\\chromedriver_win32");

            //minimize window
            driver.Manage().Window.Maximize();

            //google Url
            driver.Url = "https://www.google.co.in/";

            IReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("q"));
            Console.WriteLine(links.Count);
            foreach (IWebElement item in links)
            {
                Console.WriteLine(item.Text);
            }
            Thread.Sleep(3000);
            driver.Close();
            
        }
    }
}
