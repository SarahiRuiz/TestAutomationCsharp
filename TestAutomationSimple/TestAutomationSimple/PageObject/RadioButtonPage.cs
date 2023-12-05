using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.PageObject
{
    public class RadioButtonPage : SetUp
    {
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public RadioButtonPageEnums RadioButtonPageEnums = new RadioButtonPageEnums();
        public void VerifyAndClickRadioButtonOption(RadioButtonOption radioButtonOption)
        {
            IWebElement RadioButton = GlobalMethods.DynamicToIWebElement(RadioButtonPageEnums.RadioButtonOption, radioButtonOption.ToString());
            bool clickRadioButton = GlobalMethods.ClickRadioButtonOrCheckBox(RadioButton);
            Assert.IsTrue(clickRadioButton, $"Verify if Radio Button {radioButtonOption.ToString()} was clicked.");
            if(radioButtonOption!=RadioButtonOption.No)
            {
                IWebElement RadioButtonTitle = GlobalMethods.DynamicToIWebElement(RadioButtonPageEnums.RadioButtonTitle, radioButtonOption.ToString());
                Assert.IsTrue(RadioButtonTitle.Displayed, $"Verify if Radio Button Title {radioButtonOption.ToString()} was clicked.");
            }            
        }
    }
}
