using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.Model;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    public class RadioButtonTest : SetUp
    {
        public HomePage HomePage = new HomePage();
        public RadioButtonPage RadioButtonPage = new RadioButtonPage();
        [Test, Category("Functional Testing")]
        [TestCaseSource(typeof(RadioButtonTestDataSource), nameof(RadioButtonTestDataSource.RadioButtonTest))]
        public void RadioButtonExample_(RadioButtonOption radioButtonOption)
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToRadioButtonPage();
            RadioButtonPage.VerifyAndClickRadioButtonOption(radioButtonOption);
        }
    }
}
