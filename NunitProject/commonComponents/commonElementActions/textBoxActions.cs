using OpenQA.Selenium;
using System;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class textBoxActions
    {
        public static void M_sendInput(IWebDriver driver, IWebElement textBox, String value)
        {
            if (elementAvailability.M_isClickableOnScreen(driver, textBox))
            {
                textBox.SendKeys(value);
            }
        }
        public static void M_emptyTextBox(IWebDriver driver ,IWebElement textbox)
        {
            if (elementAvailability.M_isClickableOnScreen(driver,textbox))
            {
                textbox.SendKeys("");
            }
        }

        public static bool M_textBoxRequiredValidation(IWebElement requiredTextBox)
        {
            String attribute = "required";
            bool isRequired = false;
            if (requiredTextBox.GetAttribute(attribute)!=null)
            {
                isRequired = true;
            }
            return isRequired;
        }
    }
}
