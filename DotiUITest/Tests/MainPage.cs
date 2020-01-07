using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Diagnostics;
using System.Threading;


namespace DotiUITest.Test
{
    [TestFixture]
    class MainPage
    {
        public ChromeDriver driver;
        PageObject.MainPage mainPage;
        static int passedTests = 0;
        static int failedTests = 0;
        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver(@"C:\Visual Studio Projects\DotiUiTest\DotiUITest\Driver\");
            driver.Navigate().GoToUrl("https://www.doti.pl/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this.mainPage = new PageObject.MainPage(driver);
        }

        [Test]
        public void goToMainWebsiteByClickedOnDotiLogo()
        {
            mainPage.findAndClickMainLogoDoti();
            try
            {
                Assert.AreEqual("https://www.doti.pl/", driver.Url);
                Debug.WriteLine($"goToMainWebsiteByClickedOnDotiLogo Test Passed, Successful tests : {++passedTests}");
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"goToMainWebsiteByClickedOnDotiLogo test failed, {ex.Message} \n Unsuccessful tests : {++failedTests}");
            }

        }
        [Test]
        public void goToCatalogsbsiteByClickedOnDotiLogo()
        {
            mainPage.findAndClickMainLogoDoti();
            try
            {
                Assert.AreEqual("https://www.doti.pl/en/catalogs", driver.Url);
                Debug.WriteLine($"goToMainWebsiteByClickedOnDotiLogo Test Passed, Successful tests : {++passedTests}");
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"goToMainWebsiteByClickedOnDotiLogo test failed, {ex.Message} \n Unsuccessful tests : {++failedTests}");
            }

        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
