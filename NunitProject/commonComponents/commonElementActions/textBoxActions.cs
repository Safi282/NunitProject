using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class textBoxActions
    {
        public static void sendInput(IWebElement textBox, String value)
        {
            if (elementAvailability.isClickableOnScreen(textBox))
            {
                textBox.SendKeys(value);
            }
        }
        public static void emptyTextBox(IWebElement textbox)
        {
            if (elementAvailability.isClickableOnScreen(textbox))
            {
                textbox.SendKeys("");
            }
        }

        public static bool TextBoxRequiredValidation(IWebElement requiredTextBox)
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
