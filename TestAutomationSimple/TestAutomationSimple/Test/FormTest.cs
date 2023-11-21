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
            HomePage.VerifyTotalOfTables();
            HomePage.GoToFormPage();
            PracticeFormPage.FillForm(validData);
        }
        /*[Test]
        public void Test()
        {
            var vehicleType = Enum.GetValues(typeof(FileName)).Cast<FileName>().ToList();
            foreach(var vehicle in vehicleType)
            {

            }
        }*/
    }
}
