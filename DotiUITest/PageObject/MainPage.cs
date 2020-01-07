using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using DotiUITest.Selectors;

namespace DotiUITest.PageObject
{
    class MainPage : BasePage.BasePage
    {
        ChromeDriver driver;
        public MainPage(ChromeDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void findAndClickMainLogoDoti()
        {
            driver.FindElement(Selectors.MainPage.mainLogoDoti).Click();
        }

        public void findAndClickCatalogsButton()
        {
            
        }
    }
}
