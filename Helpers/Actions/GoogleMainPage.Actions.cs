using OpenQA.Selenium;
using Pompoc.PageObjects;

namespace Pompoc.Helpers.Actions
{
    public partial class GoogleMainPage
    {
        private readonly IWebDriver _driver;
        private readonly string _url = @"http://www.google.com";

        public GoogleMainPage(IWebDriver driver)
        {
            _driver = driver;
            Elements = new GoogleMainPageElements(_driver);
        }

        public void Navigate() => _driver.Navigate().GoToUrl(_url);

        public void Search(string textToType)
        {
            Elements.SearchBox.Clear();
            Elements.SearchBox.SendKeys(textToType);
            Elements.GoButton.Click();
        }

        public GoogleMainPageElements Elements { get; set; }
    }
}