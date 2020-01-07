using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;


namespace DotiUITest.BasePage
{
    public class BasePage
    {
        ChromeDriver driver;
        public BasePage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public void findAndClickElement(By selector)
        {
            driver.FindElement(selector).Click();
        }
        public void findAndSetValue(By selector, string value)
        {
            driver.FindElement(selector).SendKeys(value);
        }
        public void findElement(By selector)
        {
            driver.FindElement(selector);
        }
        public bool elementIsDisplayed(By selector)
        {
            if (driver.FindElement(selector).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
