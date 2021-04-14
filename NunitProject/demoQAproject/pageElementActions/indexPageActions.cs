using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void navigateToFormsPage()
        {
            buttonActions.clickOnbutton(indexPL.getFormButton());
        }
    }
}
