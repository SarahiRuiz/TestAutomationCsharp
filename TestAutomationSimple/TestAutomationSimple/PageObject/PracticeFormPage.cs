using AngleSharp.Dom;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using System.Xml.Linq;
using TestAutomationSimple.Enums;
using TestAutomationSimple.Model;

namespace TestAutomationSimple.PageObject
{
    public class PracticeFormPage : SetUp
    {
        public PracticeFormPageEnums PracticeFormPageEnums = new PracticeFormPageEnums();
        public GlobalMethods GlobalMethods = new GlobalMethods();
        public void FillForm(FormData formData)
        {            
            IWebElement FirstNameInput = driver.FindElement(PracticeFormPageEnums.FirstNameInput);
            Assert.True(FirstNameInput.Displayed, "Verify if First Name input was displayed.");
            bool enterFirstNameInput = GlobalMethods.EnterText(FirstNameInput, formData.FirstName);
            Assert.True(enterFirstNameInput, $"Verify if First Name {formData.FirstName} was added.");
            IWebElement LastNameInput = driver.FindElement(PracticeFormPageEnums.LastNameInput);
            bool enterLastNameInput = GlobalMethods.EnterText(LastNameInput, formData.LastName);
            Assert.True(enterLastNameInput, $"Verify if Last Name {formData.LastName} was added.");
            IWebElement UserEmailInput = driver.FindElement(PracticeFormPageEnums.UserEmailInput);
            bool enterUserEmailInput = GlobalMethods.EnterText(UserEmailInput, formData.UserEmail);
            Assert.True(enterUserEmailInput, $"Verify if Emial {formData.UserEmail} was added.");
            IWebElement GenderOtherRadioButton = 
                GlobalMethods.DynamicToIWebElement(PracticeFormPageEnums.GenderRadioButtonDynamic, formData.Gender);
            bool clickGenderOtherRadioButton = GlobalMethods.ClickRadioButtonOrCheckBox(GenderOtherRadioButton);
            Assert.IsTrue(clickGenderOtherRadioButton, $"Verify if gender {formData.Gender} was clicked");
            IWebElement TelephoneNumberInput = driver.FindElement(PracticeFormPageEnums.TelephoneNumberInput);
            bool enterTelephoneNumberInput = GlobalMethods.EnterText(TelephoneNumberInput, formData.TelephoneNumber);
            Assert.True(enterTelephoneNumberInput, $"Verify if Telephone Number {formData.TelephoneNumber} was added.");
            IWebElement CalendarInput = driver.FindElement(PracticeFormPageEnums.CalendarInput);
            SelectDateCalendar(CalendarInput, formData.DateBirth);
            IWebElement SubjectInput = driver.FindElement(PracticeFormPageEnums.SubjectInput);
            GlobalMethods.ScrollToElement(SubjectInput);
            Assert.True(SubjectInput.Displayed, "Verify if Subject input was displayed.");
            bool enterSubjectInput = GlobalMethods.EnterText(SubjectInput, formData.Subject);
            Assert.True(enterSubjectInput, $"Verify if Subject {formData.Subject} was added.");
            Thread.Sleep(2000);
            IWebElement SubjectInputOption = driver.FindElement(PracticeFormPageEnums.SubjectInputOption);            
            Assert.True(SubjectInputOption.Displayed, "Verify if Subject Option was displayed.");
            bool clickSubjectInputOption = GlobalMethods.ClickOn(SubjectInputOption);
            Assert.True(clickSubjectInputOption, $"Verify if Subject Option {formData.Subject} was clicked.");
            IWebElement HobbiesCheckBox = 
                GlobalMethods.DynamicToIWebElement(PracticeFormPageEnums.HobbiesCheckBoxDynamic, formData.Hobbie);
            bool clickHobbiesCheckBox = GlobalMethods.ClickRadioButtonOrCheckBox(HobbiesCheckBox);
            Assert.True(clickHobbiesCheckBox, $"Verify if Hobbies CheckBox {formData.Hobbie} was clicked.");
        }
        public void SelectDateCalendar(IWebElement calendarInput, String date)
        {            
            bool clickCalendarInput = GlobalMethods.ClickOn(calendarInput);
            Assert.True(clickCalendarInput, "Verify if Calendar Input was clicked.");
            IWebElement popUpCalendar = driver.FindElement(PracticeFormPageEnums.PopUpCalendar);
            Assert.True(popUpCalendar.Displayed, "Verify if Pop Up Calendar was displayed.");
            String[] dateArray = date.Split('/');
            IWebElement MonthDropDown = driver.FindElement(PracticeFormPageEnums.MonthDropDown);
            String monthName = NumberToMonth(dateArray[1]).Replace("/", "");
            SelectValueFromDropDown(MonthDropDown, monthName);
            IWebElement YearDropDown = driver.FindElement(PracticeFormPageEnums.MonthDropDown);
            String year = dateArray[2].Replace("/", "");
            SelectValueFromDropDown(YearDropDown, year);
            String day = NotValidNumberToValidNumber(dateArray[0].Replace("/", ""));
            String dayXpath = $"//div[text()='{day}']";
            IWebElement DayOption = driver.FindElement(By.XPath(dayXpath));
            bool clickDayOption = GlobalMethods.ClickOn(DayOption);
            Assert.True(clickDayOption, $"Verify if Day Option {day}  was clicked.");
        }
        public void SelectValueFromDropDown(IWebElement DropDown, String value)
        {
            bool clickDropDown = GlobalMethods.ClickOn(DropDown);
            Assert.True(clickDropDown, "Verify if DropDown was clicked.");
            String monthDropDownOptionXpath = $"//option[contains(text(),'{value}')]";
            IWebElement DropDownOption = driver.FindElement(By.XPath(monthDropDownOptionXpath));
            Assert.True(DropDownOption.Displayed, "Verify if Drop Down Option was displayed.");
            bool clickDropDownOption = GlobalMethods.ClickOn(DropDownOption);
            Assert.True(clickDropDownOption, $"Verify if Drop Down Option {value} was clicked.");
        }
        public string NotValidNumberToValidNumber(String number)
        {
            switch (number)
            {
                case "01":
                    return "1";
                case "02":
                    return "2";
                case "03":
                    return "3";
                case "04":
                    return "4";
                case "05":
                    return "5";
                case "06":
                    return "6";
                case "07":
                    return "7";
                case "08":
                    return "8";
                case "09":
                    return "9";
                default:
                    return number;
            }
        }
        public String NumberToMonth(String monthNumber)
        {
            switch (monthNumber)
            {
                case "01":
                    return "January";
                case "02":
                    return "February";
                case "03":
                    return "March";
                case "04":
                    return "April";
                case "05":
                    return "May";
                case "06":
                    return "June";
                case "07":
                    return "July";
                case "08":
                    return "August";
                case "09":
                    return "September";
                case "10":
                    return "October";
                case "11":
                    return "November";
                case "12":
                    return "December";
                default:
                    return "Invalid month";
            }
        }
    }
}
