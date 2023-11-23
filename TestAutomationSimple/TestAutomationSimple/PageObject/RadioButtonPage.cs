using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;

namespace TestAutomationSimple.PageObject
{
    public class RadioButtonPage : SetUp
    {
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public RadioButtonPageEnums RadioButtonPageEnums = new RadioButtonPageEnums();
        public void VerifyAndClickYesRadioButton()
        {
            IWebElement yesRadioButton = driver.FindElement(RadioButtonPageEnums.YesRadioButton);
            bool clickYesRadioButton = GlobalMethods.ClickOn(yesRadioButton);
            Assert.IsTrue(clickYesRadioButton, "Verify if Yes Radio Button was clicked.");
        }
    }
}
