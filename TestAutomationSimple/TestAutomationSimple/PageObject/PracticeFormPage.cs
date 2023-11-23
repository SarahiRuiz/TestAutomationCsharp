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
            IWebElement LastNameInput = driver.FindElement(PracticeFormPageEnums.LastNameInput);
            bool enterLastNameInput = GlobalMethods.EnterText(LastNameInput, formData.LastName);
            Assert.True(enterLastNameInput, $"Verify if Last Name {formData.LastName} was added.");
            IWebElement UserEmailInput = driver.FindElement(PracticeFormPageEnums.UserEmailInput);
            bool enterUserEmailInput = GlobalMethods.EnterText(UserEmailInput, formData.UserEmail);
            Assert.True(enterUserEmailInput, $"Verify if Emial {formData.UserEmail} was added.");
            IWebElement GenderOtherRadioButton = driver.FindElement(PracticeFormPageEnums.GenderOtherRadioButton);
            bool clickGenderOtherRadioButton = GlobalMethods.ClickOn(GenderOtherRadioButton);
            Assert.IsTrue(clickGenderOtherRadioButton, "Verify if Gender Other Radio Button was clicked.");
        }
    }
}
