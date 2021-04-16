using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumTest.demoQAProject.pageElementLocators
{
    class practiceFormLocators
    {
        IWebDriver driver;
        public practiceFormLocators(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement firstNameTextBox => driver.FindElement(By.XPath("//input[@id='firstName']"));
        public IWebElement getFirstNameTextbox() { return firstNameTextBox; }

        private IWebElement lastNameTextBox => driver.FindElement(By.XPath("//input[@id='lastName']"));
        public IWebElement getLastNameTextBox() { return lastNameTextBox; }

        private IWebElement maleGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
        public IWebElement getMaleGenderRadioButton() { return maleGenderRadioButton; }

        private IWebElement femaleGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        public IWebElement getFemaleGenderRadioButton() { return femaleGenderRadioButton; }

        private IWebElement otherGenderRadioButton => driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        public IWebElement getOtherGenderRadioButton() { return otherGenderRadioButton; }

        private IWebElement submitButton => driver.FindElement(By.XPath("//button[@id='submit'][@type='submit']"));
        public IWebElement getSubmitButton() { return submitButton; }

        private IWebElement successDialogue=>driver.FindElement(By.XPath("//div[@role='dialog']"));
        public IWebElement getSuccessDialogue() { return successDialogue; }

        private IWebElement closeSuccessModal => driver.FindElement(By.XPath("closeLargeModal"));
        public IWebElement getCloseSuccessModal() { return closeSuccessModal; }

        private IWebElement userNumber => driver.FindElement(By.XPath("//input[@id='userNumber']"));
        public IWebElement getUserNumber(){ return userNumber; }

        private List<IWebElement> allInputElements => driver.FindElements(By.TagName("input")).ToList();
        public List<IWebElement> getAllInputElements()
        {
            return allInputElements;
        }
    }
}
