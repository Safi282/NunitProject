using OpenQA.Selenium;
using SeleniumTest.commonComponents.commonElementActions;
using SeleniumTest.demoQAProject.pageElementLocators;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void navigateToPracticeForm()
        {
            buttonActions.clickOnbutton(navigationPL.getPracticeFromPageLink());
        }
    }
}
