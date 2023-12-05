using NUnit.Framework;
using System.Collections;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.Data
{
    public class RadioButtonTestDataSource
    {
        public static IEnumerable RadioButtonTest()
        {
            List<RadioButtonOption> radioButtonOptionsList = Enum.GetValues(typeof(RadioButtonOption)).Cast<RadioButtonOption>().ToList();
            foreach (var radioButtonOption in radioButtonOptionsList)
            {
                yield return new TestCaseData(radioButtonOption).SetName($"RadioButtonExample_({radioButtonOption})");
            }
        }
    }
}
