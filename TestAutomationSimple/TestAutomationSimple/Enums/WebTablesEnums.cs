using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class WebTablesEnums
    {
        public By AddButton = By.Id("addNewRecordButton");
        public By AddUserPopUp = By.ClassName("modal-content");
        public By FirstNamePopUpInput = By.XPath("//div[@id='firstName-wrapper']//input");
        public By LastNamePopUpInput = By.XPath("//div[@id='lastName-wrapper']//input");
        public By EmailPopUpInput = By.Id("userEmail");
        public By AgePopUpInput = By.Id("age");
        public By SalaryPopUpInput = By.Id("salary");
        public By DepartmentPopUpInput = By.Id("department");
        public By SubmitPopUpButton = By.Id("submit");
        public By TableDataDynamic = By.XPath("//div[@class='rt-tr-group']//div[text()='?']");
        public By TableRows = By.XPath("//div[@class='rt-tr-group']");
    }
}
