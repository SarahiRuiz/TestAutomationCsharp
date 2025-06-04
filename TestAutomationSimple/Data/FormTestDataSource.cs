using NUnit.Framework;
using System.Collections;
using TestAutomationSimple.Instances;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.Data
{
    public class FormTestDataSource
    {
        public static IEnumerable FillForm()
        {
            List<Users> userList = Enum.GetValues(typeof(Users)).Cast<Users>().ToList();
            foreach (var user in userList)
            {
                FormData formData = user switch
                {
                    Users.Miguel => FormDataInstances.Miguel,
                    Users.Juan => FormDataInstances.Juan,
                    Users.Billy => FormDataInstances.Billy
                };
                yield return new TestCaseData(user, formData).SetName($"FillForm_By_({user})");
            }
        }
    }
}