using NUnit.Framework;
using System.Collections;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.Data
{
    public class WebTableDataSource
    {
        public static IEnumerable WebTableTest()
        {
            List<WebTableOptions> webTableOptionsList = Enum.GetValues(typeof(WebTableOptions)).Cast<WebTableOptions>().ToList();
            WebTableData validData = WebTableDataInstances.ValidUserToAdd;
            foreach (var webTableOption in webTableOptionsList)
            {
                yield return new TestCaseData(webTableOption, validData).SetName($"WebTableTest_({webTableOption})");
            }
        }
    }
}
