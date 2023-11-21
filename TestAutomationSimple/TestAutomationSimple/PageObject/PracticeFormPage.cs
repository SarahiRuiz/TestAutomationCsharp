using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.PageObject
{
    public class PracticeFormPage : SetUp
    {
        public PracticeFormPageEnums PracticeFormPageEnums = new PracticeFormPageEnums();
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public void FillForm(FormData formData)
        {
            IWebElement FirstNameInput = driver.FindElement(PracticeFormPageEnums.FirstNameInput);
            Assert.True(FirstNameInput.Displayed, "Verify if First Name input was displayed.");
            bool enterFirstNameInput = GlobalMethods.EnterText(FirstNameInput, formData.FirstName);
            Assert.True(enterFirstNameInput, $"Verify if First Name {formData.FirstName} was added.");
        }
    }
}
