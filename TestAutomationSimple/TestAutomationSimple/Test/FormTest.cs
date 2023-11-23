using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.Model;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    [TestFixture]
    public class FormTest : SetUp
    {
        public HomePage HomePage = new HomePage();
        public PracticeFormPage PracticeFormPage = new PracticeFormPage();        
        [Test,Category("Regression Testing")]
        [TestCaseSource(typeof(FormTestDataSource), nameof(FormTestDataSource.FillForm))]
        public void FillForm_By_(Users user, FormData formData) 
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToFormPage();
            PracticeFormPage.FillForm(formData);
        }
    }
}
