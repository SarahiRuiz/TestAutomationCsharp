using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.Model;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    public class FormTest : SetUp
    {
        public HomePage HomePage = new HomePage();
        public PracticeFormPage PracticeFormPage = new PracticeFormPage();
        FormData validData = FormDataInstances.ValidaData;
        [Test]
        public void FillForm() 
        {
            HomePage.VerifyHomePage();
            HomePage.GoToFormPage();
            PracticeFormPage.FillForm(validData);
        }
    }
}
