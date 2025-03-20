using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.Data
{
    public class ButtonData
    {
        public static IEnumerable ButtonExample()
        {
            yield return new TestCaseData()
                .SetName("ButtonExample_");
        }
    }
}
