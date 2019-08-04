using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SpecFlowDemo
{
    public class Class1
    {
        [Test]
        public void Search_Test()
        {
            //Launch Browser
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\salik016\Desktop\My Projects\Automation Test", "geckodriver.exe");
            IWebDriver driver = new FirefoxDriver(service);

            //Navigate to URL www.codeproject.com
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Navigate().GoToUrl("https://codeproject.com");
            

            //Click on Search Our Articles
            //For the XPath, inspect on the 'Search our Articles' and copy the XPath
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();

            //Enter Testing
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");

            //Click on Search Button
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();

            driver.Quit();
        }
    }
}


