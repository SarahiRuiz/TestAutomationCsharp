using NUnit.Framework;
using OpenQA.Selenium;
using TestAutomationSimple.Enums;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.PageObject
{
    public class WebTablesPage : SetUp
    {
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public WebTablesEnums WebTablesEnums = new WebTablesEnums();
        public void Actions(WebTableOptions webTableOptions, WebTableData webTableData)
        {
            switch (webTableOptions)
            {
                case WebTableOptions.Add:
                    AddUser(webTableData);
                    break;
                case WebTableOptions.Edit:
                    EditUser();
                    break;
                case WebTableOptions.Delete:
                    DeleteUser();
                    break;
            }
        }
        public void AddUser(WebTableData webTableData)
        {
            IWebElement AddButton = driver.FindElement(WebTablesEnums.AddButton);
            Assert.IsTrue(AddButton.Displayed, "Verify Add Button was displayed");
            bool clickAddButton = GlobalMethods.ClickOn(AddButton);
            Assert.IsTrue(clickAddButton, "Verify Add Button was clicked");
            Thread.Sleep(2000);
            IWebElement AddUserPopUp = driver.FindElement(WebTablesEnums.AddUserPopUp);
            Assert.IsTrue(AddUserPopUp.Displayed, "Verify Add User Pop Up was displayed");
            FillUserPopUp(webTableData);
            int totalOfColums = GlobalMethods.GetTotalOfElements(WebTablesEnums.TableRows);
            VerifyTableDataAdded(webTableData, totalOfColums);
        }
        public void EditUser()
        {

        }   
        public void DeleteUser()
        {

        }
        public void FillUserPopUp(WebTableData webTableData)
        {
            IWebElement FirstNamePopUpInput = driver.FindElement(WebTablesEnums.FirstNamePopUpInput);
            Assert.IsTrue(FirstNamePopUpInput.Displayed, "Verify First Name Pop Up Input was displayed");
            bool enterFirstName = GlobalMethods.EnterText(FirstNamePopUpInput, webTableData.FirstName);
            Assert.IsTrue(enterFirstName, $"Verify First Name Pop Up Input {webTableData.FirstName} was entered");
            IWebElement LastNamePopUpInput = driver.FindElement(WebTablesEnums.LastNamePopUpInput);
            bool enterLastName = GlobalMethods.EnterText(LastNamePopUpInput, webTableData.LastName);
            Assert.IsTrue(enterLastName, $"Verify Last Name Pop Up Input {webTableData.LastName} was entered");
            IWebElement EmailPopUpInput = driver.FindElement(WebTablesEnums.EmailPopUpInput);
            bool enterEmail = GlobalMethods.EnterText(EmailPopUpInput, webTableData.Email);
            Assert.IsTrue(enterEmail, $"Verify Email Pop Up Input {webTableData.Email} was entered");
            IWebElement AgePopUpInput = driver.FindElement(WebTablesEnums.AgePopUpInput);
            bool enterAge = GlobalMethods.EnterText(AgePopUpInput, webTableData.Age);
            Assert.IsTrue(enterAge, $"Verify Age Pop Up Input {webTableData.Age} was entered");
            IWebElement SalaryPopUpInput = driver.FindElement(WebTablesEnums.SalaryPopUpInput);
            bool enterSalary = GlobalMethods.EnterText(SalaryPopUpInput, webTableData.Salary);
            Assert.IsTrue(enterSalary, $"Verify Salary Pop Up Input {webTableData.Salary} was entered");
            IWebElement DepartmentPopUpInput = driver.FindElement(WebTablesEnums.DepartmentPopUpInput);
            bool enterDepartment = GlobalMethods.EnterText(DepartmentPopUpInput, webTableData.Department);
            Assert.IsTrue(enterDepartment, $"Verify Department Pop Up Input {webTableData.Department} was entered");
            IWebElement SubmitPopUpButton = driver.FindElement(WebTablesEnums.SubmitPopUpButton);
            bool clickSubmitPopUpButton = GlobalMethods.ClickOn(SubmitPopUpButton);
            Assert.IsTrue(clickSubmitPopUpButton, "Verify Submit Pop Up Button was clicked");
        }
        public void VerifyTableDataAdded(WebTableData webTableData, int totalOfColums)
        {
            int colomnValue=0;
            String rowValue = "//div[@class='rt-tr-group'][1]//div[text()='2']";
            for(int i = 1; i <= totalOfColums; i ++)
            {
                String valueRow = rowValue.Replace("1", i.ToString()).Replace("2", webTableData.FirstName);                
                try
                {
                    IWebElement firstNameRow = driver.FindElement(By.XPath(valueRow));
                    Assert.IsTrue(firstNameRow.Displayed, $"Verify first name {webTableData.FirstName} is in the table.");
                    colomnValue = i;
                    break;
                }
                catch(Exception ex)
                {

                }                
            }
            By rowValueActual = By.XPath($"//div[@class='rt-tr-group'][{colomnValue}]//div[text()='?']");
            IWebElement lastNameRow = GlobalMethods.DynamicToIWebElement(rowValueActual, webTableData.LastName);
            Assert.IsTrue(lastNameRow.Displayed, $"Verify last name {webTableData.LastName} is in the table.");
            IWebElement ageRow = GlobalMethods.DynamicToIWebElement(rowValueActual, webTableData.Age);
            Assert.IsTrue(ageRow.Displayed, $"Verify age {webTableData.Age} is in the table.");
            IWebElement emailRow = GlobalMethods.DynamicToIWebElement(rowValueActual, webTableData.Email);
            Assert.IsTrue(emailRow.Displayed, $"Verify email {webTableData.Email} is in the table.");
            IWebElement salaryRow = GlobalMethods.DynamicToIWebElement(rowValueActual, webTableData.Salary);
            Assert.IsTrue(salaryRow.Displayed, $"Verify salary {webTableData.Salary} is in the table.");
            IWebElement departmentRow = GlobalMethods.DynamicToIWebElement(rowValueActual, webTableData.Department);
            Assert.IsTrue(departmentRow.Displayed, $"Verify department{webTableData.Department} is in the table.");
        }   
    }
}
