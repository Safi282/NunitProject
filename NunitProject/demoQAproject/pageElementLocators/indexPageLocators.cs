using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class indexPageLocators
    {
        private IWebDriver driver;
        public indexPageLocators(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        IWebElement FormButtons => driver.FindElement(By.XPath("//div[@class='card-body']/h5[contains(text(),'Forms')]"));
        public IWebElement getFormButton() { return FormButtons; }
    }
}
