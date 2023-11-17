using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;

namespace TestAutomationSimple.PageObject
{
    public class HomePage : SetUp
    {
        public static HomePageEnums HomePageEnums = new HomePageEnums();        
        public void GoToFormPage()
        {
            //Verify element is there
            IWebElement FormOption = driver.FindElement(HomePageEnums.FormOption);
            FormOption.Click();
            Thread.Sleep(2000);
        }
        public void VerifyHomePage()
        {
            Thread.Sleep(5000);
            IWebElement LogoPage = driver.FindElement(HomePageEnums.LogoPage);
            Assert.True(LogoPage.Displayed, "Verify logo was diplayed.");
        }
    }
}
