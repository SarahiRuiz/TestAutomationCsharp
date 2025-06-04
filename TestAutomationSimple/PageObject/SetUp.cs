using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
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
            // Configura el driver con WebDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();
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
