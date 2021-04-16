using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;

namespace SeleniumTest.demoQAProject.pageElementActions
{
    class navigationPanelActions
    {
        IWebDriver driver;
        navigationPanelLocators navigationPL = null;
        public navigationPanelActions(IWebDriver driver)
        {
            this.driver = driver;
            navigationPL = new navigationPanelLocators(this.driver);
        }

        public void M_navigateToPracticeForm()
        {
            buttonActions.M_clickOnbutton(driver,navigationPL.getPracticeFromPageLink());
        }
    }
}
