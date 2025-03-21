using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;
using static TestAutomationSimple.Model.ButtonsType;

namespace TestAutomationSimple.PageObject
{
    public class ButtonsPage : SetUp
    {
        public ButtonsPageEnums ButtonsPageEnums = new ButtonsPageEnums();
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public void ClickButtonsByButtonType(ButtonType buttonType)
        {
            VerifyButtoPageDisplayed();
            switch(buttonType)
            {
                case ButtonType.DoubleClick:
                    IWebElement DoubleClickButton = driver.FindElement(ButtonsPageEnums.DoubleClickButton);
                    GlobalMethods.ScrollToElement(DoubleClickButton);
                    Assert.IsTrue(DoubleClickButton.Displayed, "Verify Double Click Button was displayed.");

                    break;
                case ButtonType.Click:
                    break;
                case ButtonType.RightClick:
                    break;
            }
        }
        public void VerifyButtoPageDisplayed()
        {
            IWebElement ButtonPageTitle = driver.FindElement(ButtonsPageEnums.ButtonPageTitle);
            Assert.IsTrue(ButtonPageTitle.Displayed, "Verify Button Page Title was displayed.");
        }
    }
}
