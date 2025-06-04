using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace TestAutomationSimple.PageObject
{
    public class SetUp
    {
        public static IWebDriver driver;
        public static Actions action;

        [SetUp]
        public void SetUpInitial()
        {
            var options = new ChromeOptions();
            var driverPath = @"C:\Users\Ana.Ruiz\source\MyTraning\TestAutomation2\TestAutomationSimple\TestAutomationSimple\bin\Debug\net6.0\Chrome\134.0.6998.90\X64"; 
            driver = new ChromeDriver(driverPath, options);


            /*new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), "134.0.6998.90");
            driver = new ChromeDriver();*/
            driver.Url = "https://demoqa.com/";
            action = new Actions(driver);
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
