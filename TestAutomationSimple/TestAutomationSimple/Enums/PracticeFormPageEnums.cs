using OpenQA.Selenium;

namespace TestAutomationSimple.Enums
{
    public class PracticeFormPageEnums
    {
        public By FirstNameInput = By.Id("firstName");
        public By LastNameInput = By.Id("lastName");
        public By UserEmailInput = By.Id("userEmail");
        public By GenderOtherRadioButton = By.Id("gender-radio-3");
        public By TelephoneNumberInput = By.Id("userNumber");
        public By PopUpCalendar = By.ClassName("react-datepicker");
        public By MonthDropDown = By.ClassName("react-datepicker__month-select");
        public By YearDropDown = By.ClassName("react-datepicker__year-select");
        public By CalendarInput = By.Id("dateOfBirthInput");
    }
}
