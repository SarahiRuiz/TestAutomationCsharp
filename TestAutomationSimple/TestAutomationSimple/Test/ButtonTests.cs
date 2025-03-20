using NUnit.Framework;
using TestAutomationSimple.Data;
using TestAutomationSimple.PageObject;

namespace TestAutomationSimple.Test
{
    public class ButtonTests : SetUp
    {
        public HomePage HomePage = new HomePage();
        [Test, Category("Functional Testing")]
        [TestCaseSource(typeof(ButtonData), nameof(ButtonData.ButtonExample))]
        //[assembly: LevelOfParallelism(3)]
        //[Parallelizable(scope: ParallelScope.All)]
        public void ButtonExample_()
        {
            HomePage.VerifyHomePage();
            HomePage.VerifyTotalOfTables();
            HomePage.GoToButtonsPage();
        }
    }
}
