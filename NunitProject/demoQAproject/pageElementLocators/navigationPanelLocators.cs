using OpenQA.Selenium;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class navigationPanelLocators
    {
        IWebDriver driver = null;
        public navigationPanelLocators(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement practiceFromPageLink => driver.FindElement(By.XPath("//span[@class='text'][contains(text(),'Practice Form')]"));
        public IWebElement getPracticeFromPageLink(){ return practiceFromPageLink; }
    }
}
