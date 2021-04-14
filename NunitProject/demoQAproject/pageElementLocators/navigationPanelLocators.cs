using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class navigationPanelLocators
    {
        IWebDriver driver = null;
        public navigationPanelLocators(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement practiceFromPageLink => driver.FindElement(By.XPath("//span[@class='text'][contains(text(),'Practice Form')]"));
        public IWebElement getPracticeFromPageLink(){ return practiceFromPageLink; }
    }
}
