using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class practiceFormLocators
    {
        IWebDriver driver;
        public practiceFormLocators(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement firstNameTextBox => driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement getFirstNameTextbox() { return firstNameTextBox; }

        IWebElement lastNameTextBox => driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement getLastNameTextBox() { return lastNameTextBox; }

        IWebElement maleGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
        public IWebElement getMaleGenderRadioButton() { return maleGenderRadioButton; }

        IWebElement femaleGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        public IWebElement getFemaleGenderRadioButton() { return femaleGenderRadioButton; }

        IWebElement otherGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        public IWebElement getOtherGenderRadioButton() { return otherGenderRadioButton; }

        IWebElement submitButton => driver.FindElement(By.XPath("//button[@id='submit'][@type='submit']"));
        public IWebElement getSubmitButton() { return submitButton; }

        IWebElement successDialogue=>driver.FindElement(By.XPath("//div[@role='dialog']"));
        public IWebElement getSuccessDialogue() { return successDialogue; }

        IWebElement closeSuccessModal => driver.FindElement(By.XPath("closeLargeModal"));
        public IWebElement getCloseSuccessModal() { return closeSuccessModal; }

        IWebElement userNumber => driver.FindElement(By.XPath("//input[@id='userNumber']"));
        public IWebElement getUserNumber(){ return userNumber; }

        List<IWebElement> allInputElements => driver.FindElements(By.TagName("input")).ToList();
        public List<IWebElement> getAllInputElements()
        {
            return allInputElements;
        }
    }
}
