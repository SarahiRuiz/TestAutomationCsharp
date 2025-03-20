using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationSimple.Model;
using static TestAutomationSimple.Model.ButtonsType;

namespace TestAutomationSimple.Data
{
    public class ButtonData
    {
        public static IEnumerable ButtonExample()
        {
            var testType = new Dictionary<ButtonType, string>
            {
                {ButtonType.DoubleClick, "Test1"}
            };
            foreach(var (buttonTypeActual, TestId) in testType)
            {
                yield return new TestCaseData(buttonTypeActual)
                .SetName($"ButtonExample_({buttonTypeActual})")
                .SetProperty("TestId", TestId);
            }
        }
    }
}
