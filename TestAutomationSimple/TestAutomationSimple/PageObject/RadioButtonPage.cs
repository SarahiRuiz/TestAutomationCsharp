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
            String option = "Impressive";
            IWebElement RadioButton = GlobalMethods.DynamicToIWebElement(RadioButtonPageEnums.RadioButtonOption, option);
            bool clickRadioButton = GlobalMethods.ClickRadioButtonOrCheckBox(RadioButton);
            Assert.IsTrue(clickRadioButton, $"Verify if Yes Radio Button {option} was clicked.");
        }
    }
}
