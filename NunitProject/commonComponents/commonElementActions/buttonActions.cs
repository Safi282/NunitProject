using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest.commonComponents.commonElementActions
{
    class buttonActions
    {
        public static void clickOnbutton(IWebElement button)
        {
            if (elementAvailability.isClickableOnScreen(button)){
                button.Click();
            }
        }
    }
}
