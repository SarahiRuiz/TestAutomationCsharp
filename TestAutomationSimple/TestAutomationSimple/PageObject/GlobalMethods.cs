
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace TestAutomationSimple.PageObject
{
    public class GlobalMethods : SetUp
    {
        public bool EnterText(IWebElement element, string value, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitElementEnter(element, value));
        }

        private bool WaitElementEnter(IWebElement element, string Value)
        {
            try
            {
                element.SendKeys(Value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ClickOn(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitElementClicked(element));
        }

        private bool WaitElementClicked(IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ScrollToElement(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitToScrollToElement(element));
        }
        public bool WaitToScrollToElement(IWebElement element)
        {
            try
            {
                var scrollOrigin = new WheelInputDevice.ScrollOrigin
                {
                    Element = element,
                    XOffset = 0,
                    YOffset = -50
                };
                new Actions(driver)
                    .ScrollFromOrigin(scrollOrigin, 0, 200)
                    .Perform();
                Thread.Sleep(1000);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }            
        }
        public IWebElement DynamicToIWebElement(By element, String value)
        {
            return driver.FindElement(By.XPath(element.Criteria.Replace("?", value)));
        }
        public bool ClickRadioButtonOrCheckBox(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitToClickRadioButtonOrCheckBox(element));
        }
        public bool WaitToClickRadioButtonOrCheckBox(IWebElement element)
        {
            try
            {                 
                action.Click(element).Perform();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int GetTotalOfElements(By element)
        {
            return driver.FindElements(element).Count;
        }
    }
}
