using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class HomePageEnums
    {
        public By LogoPage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        public By FormOption = By.XPath("//div[@class='card mt-4 top-card'][2]");
        public By PracticeFormOption = By.XPath("//li[@id='item-0']//span[text()='Practice Form']");
        public By PracticeFormTitle = By.XPath("//div[text()='Practice Form']");
    }
}
