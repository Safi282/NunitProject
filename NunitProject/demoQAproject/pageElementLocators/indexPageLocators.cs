using OpenQA.Selenium;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class indexPageLocators
    {
        IWebDriver driver;
        public indexPageLocators(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        private IWebElement FormButtons => driver.FindElement(By.CssSelector("#app div.card:nth-child(2)"));
        public IWebElement getFormButton() { return FormButtons; }
    }
}
