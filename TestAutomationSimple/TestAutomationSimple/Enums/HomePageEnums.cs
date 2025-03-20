using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class HomePageEnums
    {
        public By LogoPage = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        public By FormOption = By.XPath("//div[@class='card mt-4 top-card'][2]");
        public By ElementOption = By.XPath("//div[@class='card mt-4 top-card'][1]");
        public By PracticeFormOption = By.XPath("//li[@id='item-0']//span[text()='Practice Form']");
        public By RadioButtonOption = By.XPath("//span[text()='Radio Button']");
        public By ButtonOption = By.XPath("//span[text()='Buttons']");
        public By PracticeFormTitle = By.XPath("//span[text()='Practice Form']");
        public By RadioButtonTitle = By.XPath("//span[text()='Radio Button']");
        public By WebTablesOption = By.XPath("//span[text()='Web Tables']");
        public By WebTablesTitle = By.XPath("//span[text()='Web Tables']");
        public By TableOptions = By.XPath("//div[@class='card mt-4 top-card']");        
    }
}
