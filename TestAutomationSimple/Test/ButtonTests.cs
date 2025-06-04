using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.PageObject;
using static TestAutomationSimple.Model.ButtonsType;

namespace TestAutomationSimple.Test
{
    public class ButtonTests : SetUp
    {
        public HomePage HomePage = new HomePage();
        public ButtonsPage ButtonsPage = new ButtonsPage();
        [Test, Category("Functional Testing")]
        [TestCaseSource(typeof(ButtonData), nameof(ButtonData.ButtonExample))]
        //[assembly: LevelOfParallelism(3)]
        //[Parallelizable(scope: ParallelScope.All)]
        public void ButtonExample_(ButtonType buttonType)
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToButtonsPage();
            ButtonsPage.ClickButtonsByButtonType(buttonType);
        }
    }
}
