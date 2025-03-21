using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class ButtonsPageEnums
    {
        public By ButtonPageTitle = By.XPath("//h1[text()='Buttons']");
        public By DoubleClickButton = By.Id("doubleClickBtn");
    }
}
