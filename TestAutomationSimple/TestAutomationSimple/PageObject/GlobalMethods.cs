
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
            return wait.Until(d => WaitElementEnter(wait, element, value));
        }

        private bool WaitElementEnter(WebDriverWait wait, IWebElement element, string Value)
        {
            try
            {
                return wait.Until(d =>
                {
                    element.SendKeys(Value);
                    return true;
                });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ClickOn(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitElementClicked(wait, element));
        }

        private bool WaitElementClicked(WebDriverWait wait, IWebElement element)
        {
            try
            {
                return wait.Until(d =>
                {
                    element.Click();
                    return true;
                });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ScrollToElement(IWebElement element, int timeOut = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
            return wait.Until(d => WaitToScrollToElement(wait, element));
        }
        public bool WaitToScrollToElement(WebDriverWait wait, IWebElement element)
        {
            try
            {
                return wait.Until(d =>
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
                });
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
            return wait.Until(d => WaitToClickRadioButtonOrCheckBox(wait, element));
        }
        public bool WaitToClickRadioButtonOrCheckBox(WebDriverWait wait, IWebElement element)
        {
            try
            {
                return wait.Until(d =>
                {                    
                    action.Click(element).Build().Perform();
                    return true;
                });
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
