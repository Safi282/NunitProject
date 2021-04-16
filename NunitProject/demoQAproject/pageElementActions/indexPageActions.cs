using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;

namespace SeleniumTest.demoQAProject.pageElementActions
{
    class indexPageActions
    {
        IWebDriver driver;
        indexPageLocators indexPL = null;
        public indexPageActions(IWebDriver driver)
        {
            this.driver = driver;
            indexPL = new indexPageLocators(driver);
        }

        public void M_navigateToFormsPage()
        {
            buttonActions.M_clickOnbutton(driver,indexPL.getFormButton());
        }
    }
}
