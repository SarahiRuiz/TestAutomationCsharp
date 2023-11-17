using NUnit.Framework;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    public class FormTest : SetUp
    {
        public static HomePage HomePage = new HomePage();
        [Test]
        public void FillForm() 
        {
            HomePage.VerifyHomePage();
            HomePage.GoToFormPage();
        }
    }
}
