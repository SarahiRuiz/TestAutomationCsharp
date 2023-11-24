using TestAutomationSimple.Model;

namespace TestAutomationSimple.Data
{
    public class FormDataInstances
    {
        public static FormData Miguel = new FormData
        {
            FirstName = "Miguel",
            LastName = "Barajas",
            UserEmail = "Miguel@test.com",
            TelephoneNumber = "1234567890",
            DateBirth = "01/01/2000"
        };
        public static FormData Juan = new FormData
        {
            FirstName = "Juan",
            LastName = "Estrada",
            UserEmail = "Juan@test.com",
            TelephoneNumber = "0987654321",
            DateBirth = "15/10/2020"
        };
        public static FormData Billy = new FormData
        {
            FirstName = "Billy",
            LastName = "Lasti",
            UserEmail = "Billy@test.com",
            TelephoneNumber = "2468101214",
            DateBirth = "31/12/2020"
        };
    }
}
