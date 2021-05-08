using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pompoc.Helpers.Actions;
using Pompoc.PageObjects;

namespace Pompoc
{
    [TestFixture]
    public class GoogleTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void SearchTextBox()
        {
            var googleMainPage = new GoogleMainPage(_driver);

            googleMainPage.Navigate();
            googleMainPage.Elements.AgreeButton.Click();
            googleMainPage.Elements.SearchBox.SendKeys("Sage UK");
            // Could Be Anything
            Assert.That(googleMainPage.Elements.ResultsCountDiv.Text, Does.Contain("About 332,000,000 results"));
        }
    }
}