using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class RadioButtonPageEnums
    {
        public By RadioButtonOption = By.XPath("//label[text()='?']/../input");
        public By RadioButtonTitle = By.XPath("//p[text()='You have selected ']//span[text()='?']");
    }
}
