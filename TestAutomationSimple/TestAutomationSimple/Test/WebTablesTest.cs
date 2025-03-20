using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.Model;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{    
    public class WebTablesTest : SetUp
    {
        public HomePage HomePage = new HomePage();
        public WebTablesPage WebTablesPage = new WebTablesPage();
        [Test, Category("Regression Testing")]
        [TestCaseSource(typeof(WebTableDataSource), nameof(WebTableDataSource.WebTableTest))]
        public void WebTableTest_(WebTableOptions webTableOptions, WebTableData validData)
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToWebTablesPage();
            WebTablesPage.PerformActions(webTableOptions, validData);
        }   
    }
}
