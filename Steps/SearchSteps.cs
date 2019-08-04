using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SpecFlowDemo
{
    [Binding] 
    public class SearchSteps
    {
        public IWebDriver driver;
        [Given(@"Launch FireFox")]
        public void GivenLaunchFireFox()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\salik016\Desktop\My Projects\Automation Test", "geckodriver.exe");
            driver = new FirefoxDriver(service);

            //Navigate to URL www.codeproject.com
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            
        }

        [Given(@"Navigate to Code Project")]
        public void GivenNavigateToCodeProject()
        {
            driver.Navigate().GoToUrl("https://codeproject.com");
        }

        [When(@"Click on Search our Articles")]
        public void WhenClickOnSearchOurArticles()
        {
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click(); ;
        }
        
        [When(@"Enter Testing")]
        public void WhenEnterTesting()
        {
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");
        }
        
        [When(@"Click on Search Button")]
        public void WhenClickOnSearchButton()
        {
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
        }
        
        [Then(@"Results should be visible and Browser should close")]
        public void ThenResultsShouldBeVisibleAndBrowserShouldClose()
        {
            driver.Quit();
        }
    }
}
