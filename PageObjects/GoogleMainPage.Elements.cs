using OpenQA.Selenium;

namespace Pompoc.PageObjects
{
    public class GoogleMainPageElements
    {
        private readonly IWebDriver _driver;
        public GoogleMainPageElements(IWebDriver driver) => _driver = driver;
        
        public IWebElement AgreeButton => _driver.FindElement(By.XPath("//div[contains(text(), 'I agree')]"));
        public IWebElement SearchBox => _driver.FindElement(By.Name("q"));
        public IWebElement GoButton => _driver.FindElement(By.Name("btnK"));
        public IWebElement ResultsCountDiv => _driver.FindElement(By.Id("result-stats"));
    }
}