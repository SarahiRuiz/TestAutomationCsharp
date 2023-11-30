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
            DateBirth = "01/01/2000",
            Subject = "Maths",
            Gender = "Male",
            Hobbie = "Sports"
        };
        public static FormData Juan = new FormData
        {
            FirstName = "Juan",
            LastName = "Estrada",
            UserEmail = "Juan@test.com",
            TelephoneNumber = "0987654321",
            DateBirth = "15/10/2020",
            Subject = "Arts",
            Gender = "Male",
            Hobbie = "Reading"
        };
        public static FormData Billy = new FormData
        {
            FirstName = "Billy",
            LastName = "Lasti",
            UserEmail = "Billy@test.com",
            TelephoneNumber = "2468101214",
            DateBirth = "31/12/2020",
            Subject = "English",
            Gender = "Other",
            Hobbie = "Music"
        };
    }
}
