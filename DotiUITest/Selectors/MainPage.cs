using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace DotiUITest.Selectors
{
    internal static class MainPage
    {
        internal static By mainLogoDoti = By.XPath("/html/body/div[3]/div[1]/nav/a");
        internal static By Catalogues = By.XPath("/html/body/div[3]/div[1]/nav/div[2]/div/ul[2]/li[1]");
    }
}
