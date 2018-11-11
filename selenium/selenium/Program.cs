using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com/ncr");
            Console.WriteLine(driver.Title);

            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("DevOps");
            query.Submit();
            Console.WriteLine(driver.Title);

            driver.Quit();

        }
    }
}
