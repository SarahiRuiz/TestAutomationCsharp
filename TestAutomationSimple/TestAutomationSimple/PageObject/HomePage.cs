using NUnit.Framework;
using OpenQA.Selenium;
using System.Drawing;
using TestAutomationSimple.Enums;

namespace TestAutomationSimple.PageObject
{
    public class HomePage : SetUp
    {
        public static HomePageEnums HomePageEnums = new HomePageEnums();
        public GlobalMethods GlobalMethods = new GlobalMethods();        
        public void GoToFormPage()
        {
            IWebElement formOption = driver.FindElement(HomePageEnums.FormOption);
            bool clickFormOption = GlobalMethods.ClickOn(formOption);
            Assert.IsTrue(clickFormOption, "Verify if form option was clicked.");
            IWebElement PracticeFormOption = driver.FindElement(HomePageEnums.PracticeFormOption);
            bool clickOnPracticeFormOption = GlobalMethods.ClickOn(PracticeFormOption);
            Assert.IsTrue(clickOnPracticeFormOption, "Verify if Practice Form Option was clicked.");
            IWebElement PracticeFormTitle = driver.FindElement(HomePageEnums.PracticeFormTitle);
            bool PracticeFormTitleDisplayed = GlobalMethods.ClickOn(PracticeFormTitle);
            Assert.IsTrue(PracticeFormTitleDisplayed, "Verify if Practice Form Title was displayed.");
            Thread.Sleep(2000);
        }
        public void GoToRadioButtonPage()
        {            
            IWebElement ElementOption = driver.FindElement(HomePageEnums.ElementOption);
            bool clickOnElementOption = GlobalMethods.ClickOn(ElementOption);
            Assert.IsTrue(clickOnElementOption, "Verify if Element Option was clicked.");
            Thread.Sleep(2000);
            IWebElement RadioButtonOption = driver.FindElement(HomePageEnums.RadioButtonOption);
            bool clickRadioButtonOption = GlobalMethods.ClickOn(RadioButtonOption);
            Assert.IsTrue(clickRadioButtonOption, "Verify if Radio Button Option clicked.");
            IWebElement RadioButtonTitle = driver.FindElement(HomePageEnums.RadioButtonTitle);
            bool radioButtonTitleDisplayed = GlobalMethods.ClickOn(RadioButtonTitle);
            Assert.IsTrue(radioButtonTitleDisplayed, "Verify if Radio Button Option was displayed.");
            Thread.Sleep(2000);
        }
        public void VerifyTotalOfTables()
        {
            var tableOptions = driver.FindElements(HomePageEnums.TableOptions);
            Assert.IsTrue(tableOptions.Count == 6, "Verify if all table options were displayed.");
        }
        public void VerifyHomePage()
        {
            Thread.Sleep(5000);
            IWebElement LogoPage = driver.FindElement(HomePageEnums.LogoPage);
            Assert.True(LogoPage.Displayed, "Verify logo was diplayed.");
        }
    }
}
