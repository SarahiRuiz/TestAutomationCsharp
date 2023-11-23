using NUnit.Framework;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    public class RadioButtonTest : SetUp
    {
        public HomePage HomePage = new HomePage();
        public RadioButtonPage RadioButtonPage = new RadioButtonPage();
        [Test]
        public void RadioButtonExample()
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToRadioButtonPage();
            RadioButtonPage.VerifyAndClickYesRadioButton();
        }
    }
}
