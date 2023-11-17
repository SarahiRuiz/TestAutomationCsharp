using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestAutomationSimple.PageObject
{
    public class SetUp
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void SetUpInitial()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
